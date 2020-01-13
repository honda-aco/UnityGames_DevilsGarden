using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class Charactor : MyMonoBehaviour
    {
        // 一時停止管理
        public class PauseManager
        {
            private static string changePauseTime = "00000000000000000";
            private static bool pause = false;
            // イベント終了後の一定時間の硬直実装
            public static bool Status
            {
                get
                {
                    if (pause == false)
                    {
                        string nowTime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                        if (decimal.Parse(nowTime) - decimal.Parse(changePauseTime) <= 2000)
                        {
                            return true;
                        }
                    }
                    return pause;
                }
                set
                {
                    changePauseTime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    pause = value;
                }
            }
        }

        // 追跡管理
        public class ChaseManager
        {
            private static string lastTime = "00000000000000000";
            private static bool chaseStatus = false;
            
            public static void playChaseBgm()
            {
                if (chaseStatus == false)
                {
                    chaseStatus = true;
                    BgmController.GetInstance().playChaseBgm(true);
                }
                lastTime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            }

            public static void StopChaseBgm()
            {
                string nowTime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                if (decimal.Parse(nowTime) - decimal.Parse(lastTime) > 1500)
                {
                    if (chaseStatus)
                    {
                        chaseStatus = false;
                        BgmController.GetInstance().playDefaultBgm();
                    }
                }
            }
        }

        [SerializeField]
        protected Transform player;

        [SerializeField]
        protected float speed = 0.0f;

        [SerializeField]
        protected float accelSpeed = 0.0f;

        [SerializeField]
        protected float walkRange = 0.0f;

        [SerializeField]
        protected float reactDistance = 0.0f;

        [SerializeField]
        protected int runMilliSeconds = 0;

        [SerializeField]
        protected int restMilliSeconds = 0;

        private string startTime = "00000000000000000";

        private int speakCount = 0;

        public static void Restart()
        {
            PauseManager.Status = false;
        }

        public static void Pause()
        {
            PauseManager.Status = true;
        }

        public void Start()
        {
            base.backupDefaultValue();
        }

        public void restorDefaultValue()
        {
            base.restorDefaultValue();
            PauseManager.Status = false;
        }

        public void FixedUpdate()
        {
            // 倒れさせない
            transform.rotation = new Quaternion(0.0f, transform.rotation.y, 0.0f, transform.rotation.w);

            if (PauseManager.Status == true)
            {
                return;
            }

            if (this.GetComponent<Collider>() != null && this.GetComponent<Collider>().enabled == false)
            {
                return;
            }

            // 加速しないよう設定
            if (GetComponent<Rigidbody>() != null)
            {
                GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            
            float distance = Vector3.Distance(transform.position, player.position);
            if (distance < walkRange)
            {
                ChaseManager.playChaseBgm();   // BGMの設定

                Vector3 direction = (player.position - transform.position).normalized;

                string nowTime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                if ((decimal.Parse(nowTime) - decimal.Parse(startTime)) <= runMilliSeconds)
                {
                    MotionRun();    // 走る
                    direction.x *= accelSpeed;
                    direction.z *= accelSpeed;
                }
                else if ((decimal.Parse(nowTime) - decimal.Parse(startTime)) <= runMilliSeconds + restMilliSeconds)
                {
                    MotionWalk();   // 歩く
                    direction.x *= speed;
                    direction.z *= speed;
                }
                else
                {
                    MotionRun();    // 走る
                    direction.x *= accelSpeed;
                    direction.z *= accelSpeed;
                    startTime = nowTime;
                }
                // 本オブジェクトの座標を取得
                Vector3 workVector3 = transform.position + direction;
                // 進行方向を変更した後にキャラクタを動かす
                transform.LookAt(workVector3);
                transform.position = workVector3;
            }else
            {
                ChaseManager.StopChaseBgm();   // BGMの設定

                MotionWait();
            }
        }

        /// <summary>
        /// オブジェクトと接触した時に呼ばれるコールバック
        /// </summary>
        /// <param name="hit"></param>
        public void OnCollisionEnter(Collision hit)
        {
            OnCollisionEnterBase(hit);
        }

        /// <summary>
        /// オブジェクトと接触した時に呼ばれるコールバック（Enemyクラス共通）
        /// </summary>
        /// <param name="hit"></param>
        public void OnCollisionEnterBase(Collision hit)
        {
            // 接触したオブジェクトのタグが"Player"の場合
            if (hit.gameObject.CompareTag("Player"))
            {
                Vector3 direction = (player.position - transform.position).normalized;
                // Playerと衝突した場合は反動をイメージして反対方向へ移動させる
                direction.x *= -reactDistance;
                direction.z *= -reactDistance;
                transform.position = transform.position + direction;
            }
        }

        // 物理演算を行わないオブジェクトと接触した時に呼ばれるコールバック
        public void OnTriggerEnter(Collider hit)
        {
            // 接触したオブジェクトのタグが"Player"の場合
            if (hit.gameObject.CompareTag("Enemy_Trap"))
            {
                Destroy(this.GetComponent<Rigidbody>());
                this.MotionWait();
                this.GetComponent<Collider>().enabled = false;
                this.gameObject.transform.position = new Vector3(
                    gameObject.transform.position.x,
                    gameObject.transform.position.y - 10,
                    gameObject.transform.position.z
                );
            }
        }

        /// <summary>
        /// 指示された座標に向かって一回歩く（繰返し歩かせる場合は呼出し元で対応する）
        /// </summary>
        public void walkToVector3(Vector3 destination)
        {
            Vector3 direction = (destination - transform.position).normalized;

            direction.x *= speed;
            direction.z *= speed;

            Vector3 workVector3 = transform.position + direction;

            // 進行方向を変更した後にキャラクタを動かす
            transform.LookAt(workVector3);
            transform.position = workVector3;

            // 倒れさせない
            transform.rotation = new Quaternion(0.0f, transform.rotation.y, 0.0f, transform.rotation.w);
        }

        /// <summary>
        /// 指示された座標に向かって一回歩く（繰返し歩かせる場合は呼出し元で対応する）
        /// </summary>
        public void runToVector3(Vector3 destination)
        {
            Vector3 direction = (destination - transform.position).normalized;

            direction.x *= accelSpeed;
            direction.z *= accelSpeed;

            Vector3 workVector3 = transform.position + direction;

            // 進行方向を変更した後にキャラクタを動かす
            transform.LookAt(workVector3);
            transform.position = workVector3;

            // 倒れさせない
            transform.rotation = new Quaternion(0.0f, transform.rotation.y, 0.0f, transform.rotation.w);
        }

        protected void Dead()
        {
            this.GetComponent<Collider>().enabled = false;
        }

        public void MotionWait()
        {
            GetComponent<Animator>().SetBool("Stand", true);
            GetComponent<Animator>().SetBool("Walk", false);
            GetComponent<Animator>().SetBool("Run", false);
        }

        public void MotionWalk()
        {
            GetComponent<Animator>().SetBool("Stand", false);
            GetComponent<Animator>().SetBool("Walk", true);
            GetComponent<Animator>().SetBool("Run", false);
        }

        public void MotionRun()
        {
            GetComponent<Animator>().SetBool("Stand", false);
            GetComponent<Animator>().SetBool("Walk", false);
            GetComponent<Animator>().SetBool("Run", true);
        }

        public void SetWalkRange(float walkRange)
        {
            this.walkRange = walkRange;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
        }

        public void SetAccelSpeed(float accelSpeed)
        {
            this.accelSpeed = accelSpeed;
        }

        public void SetReactDistance(float reactDistance)
        {
            this.reactDistance = reactDistance;
        }

        public void SetRunMilliSeconds(int milliSeconds)
        {
            this.runMilliSeconds = milliSeconds;
        }

        public void SetRestMilliSeconds(int milliSeconds)
        {
            this.restMilliSeconds = milliSeconds;
        }
    }
}