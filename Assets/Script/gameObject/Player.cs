using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace Assets.Script
{
    public class Player : MyMonoBehaviour
    {
        // speedを制御する
        [SerializeField]
        protected float speed = 1.0f;

        //[SerializeField]
        private int accelRange = (Screen.width / 16) - 2;

        [SerializeField]
        protected float accelSpeed = 1.0f;

        [SerializeField]
        protected float reactDistanceEnemy1 = 1.0f;

        [SerializeField]
        protected GameObject mainCamera;
        public GameObject MainCamera
        {
            set { mainCamera = value; }
        }

        [SerializeField]
        protected GameObject mobileSingleStickControl;

        protected bool death = false;
        protected float defaultY;

        // Hpを制御する
        public HpController hpController;

        public void restorDefaultValue()
        {
            base.restorDefaultValue();
            death = false;
            hpController.FullRegained();
        }

        public void Start()
        {
            base.backupDefaultValue();
        }

        // 仮想ジョイスティックでキャラクタを動かす
        protected void FixedUpdate()
        {
            // 静止していても衝突判定を有効にする
            GetComponent<Rigidbody>().WakeUp();
            // 死んだら起こさない
            if (death)
            {
                return;
            }

            // 倒れさせない
            // if (Mathf.Abs(transform.rotation.x) > 5 || Mathf.Abs(transform.rotation.z) > 5)
            if (Mathf.Abs(transform.localEulerAngles.x) > 5 || Mathf.Abs(transform.localEulerAngles.z) > 5)
                {
                transform.rotation = new Quaternion(0.0f, transform.rotation.y, 0.0f, transform.rotation.w);
            }

            // 宙に浮かぶのを止める
            if (defaultY == 0)
            {
                defaultY = transform.position.y;
            }
            else if (defaultY + 1.0f < transform.position.y)
            {
                transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y - 0.1f,
                    transform.position.z);
            }

            // スティックが無効の場合は処理を抜ける
            // この処理を行わないとスティックのActiveステータス変更時に例外が出る
            if (mobileSingleStickControl.activeSelf == false)
            {
                return;
            }

            // 右・左
            float x = CrossPlatformInputManager.GetAxisRaw("Horizontal");

            // 上・下
            float y = CrossPlatformInputManager.GetAxisRaw("Vertical");

            if (x == 0 && y == 0)
            {
                Idle();
            }
            else
            {
                //=====================[ジョイスティックの角度を考慮しない場合]=====================
                //Vector3 direction = new Vector3(x, 0, y).normalized;

                //// ジョイスティックの位置がAccelRangeを超えている場合、速度を変化させる
                //if ((x * x) + (y * y) > (AccelRange * AccelRange))
                //{
                //    direction.x *= AccelSpeed;
                //    direction.z *= AccelSpeed;
                //}
                //else
                //{
                //    direction.x *= speed;
                //    direction.z *= speed;
                //}

                //// プレイヤーの座標を取得
                //Vector3 workVector3 = transform.position + direction;
                //// 進行方向を変更した後にキャラクタを動かす
                //transform.LookAt(workVector3);
                //transform.position = workVector3;
                //================================================================================

                // カメラの傾きからキャラクタの動くべき方向を計算する
                float angle = Vector3.Angle(new Vector3(1, 0, 0), new Vector3(x, 0, y));
                angle = y < 0 ? 360 - angle : angle;
                angle = angle - mainCamera.transform.localEulerAngles.y;

                float radian = angle * Mathf.PI / 180;
                float x2 = Mathf.Cos(radian) * 1;
                float y2 = Mathf.Sin(radian) * 1;

                Vector3 direction = new Vector3(x2, 0, y2).normalized;

                // ジョイスティックの位置がAccelRangeを超えている場合、速度を変化させる
                if ((x * x) + (y * y) > (accelRange * accelRange))
                {
                    Run();
                    direction.x *= accelSpeed;
                    direction.z *= accelSpeed;
                }
                else
                {
                    Walk();
                    direction.x *= speed;
                    direction.z *= speed;
                }

                // プレイヤーの座標を取得
                Vector3 workVector3 = transform.position + direction;
                // 進行方向を変更した後にキャラクタを動かす
                transform.LookAt(workVector3);
                transform.position = workVector3;
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
        /// オブジェクトと接触した時に呼ばれるコールバック（Player共通）
        /// </summary>
        /// <param name="hit"></param>
        public void OnCollisionEnterBase(Collision hit)
        {
            // 接触したオブジェクトのタグによって処理を変える
            if (hit.gameObject.CompareTag("Enemy1"))
            {
                //Vector3 direction = (hit.transform.position - transform.position).normalized;
                //// Enemy1と衝突した場合は反動をイメージして反対方向へ移動させる
                //direction.x *= -reactDistanceEnemy1;
                //direction.z *= -reactDistanceEnemy1;
                //transform.position = transform.position + direction;

                if (hpController != null)
                {
                    hpController.Damage();
                }
            }
        }

        // 物理演算を行わないオブジェクトと接触した時に呼ばれるコールバック
        public void OnTriggerEnter(Collider hit)
        {
        }

        /// <summary>
        /// 指示された座標に向かって一回歩く（繰返し歩かせる場合は呼出し元で対応する）
        /// </summary>
        public void WalkToVector3(Vector3 destination)
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
        public void RunToVector3(Vector3 destination)
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

        /// <summary>
        /// アニメーションを「立つ」に設定
        /// </summary>
        public void Idle()
        {
            GetComponent<Animator>().SetBool("Stand", true);
            GetComponent<Animator>().SetBool("Walk", false);
            GetComponent<Animator>().SetBool("Run", false);
            GetComponent<Animator>().SetBool("Sit", false);
        }

        /// <summary>
        /// アニメーションを「歩く」に設定
        /// </summary>
        public void Walk()
        {
            GetComponent<Animator>().SetBool("Stand", false);
            GetComponent<Animator>().SetBool("Walk", true);
            GetComponent<Animator>().SetBool("Run", false);
            GetComponent<Animator>().SetBool("Sit", false);
        }

        /// <summary>
        /// アニメーションを「走る」に設定
        /// </summary>
        public void Run()
        {
            GetComponent<Animator>().SetBool("Stand", false);
            GetComponent<Animator>().SetBool("Walk", false);
            GetComponent<Animator>().SetBool("Run", true);
            GetComponent<Animator>().SetBool("Sit", false);
        }

        public void Sit()
        {
            GetComponent<Animator>().SetBool("Stand", false);
            GetComponent<Animator>().SetBool("Walk", false);
            GetComponent<Animator>().SetBool("Run", false);
            GetComponent<Animator>().SetBool("Sit", true);
        }

        /// <summary>
        /// 死亡処理
        /// </summary>
        /// <returns></returns>
        public bool Dead()
        {
            if (death == false)
            {
                // コントローラを無効にし、歩くモーションを終了する
                mobileSingleStickControl.SetActive(false);
                Idle();

                death = true;
                hpController.Died();
                transform.localRotation = new Quaternion(-0.3f, transform.localRotation.y, transform.localRotation.z, transform.localRotation.w);
            }
            return true;
        }

        /// <summary>
        /// 生存確認
        /// </summary>
        /// <returns></returns>
        public bool IsAlive()
        {
            return death ? false : true;
        }
    }
}