using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

namespace Assets.Script
{
    public class EventController : MonoBehaviour
    {
        [SerializeField]
        private FukidashiController fukidashiController;
        public FukidashiController FukidashiController
        {
            set { fukidashiController = value; }
            get { return fukidashiController; }
        }

        [SerializeField]
        private KeyItemController keyItemController;
        public KeyItemController KeyItemController
        {
            set { keyItemController = value; }
            get { return keyItemController; }
        }

        [SerializeField]
        private GameObject mobileSingleStickControl;
        public GameObject MobileSingleStickControl
        {
            set { mobileSingleStickControl = value; }
            get { return mobileSingleStickControl; }
        }

        [SerializeField]
        private Joystick joystick;
        public Joystick Joystick
        {
            set { joystick = value; }
            get { return joystick; }
        }

        [SerializeField]
        private Player player;
        public Player Player
        {
            set { player = value; }
            get { return player; }
        }

        [SerializeField]
        private UnityEngine.UI.Image blackout;
        public UnityEngine.UI.Image Blackout
        {
            set { blackout = value; }
            get { return blackout; }
        }

        [SerializeField]
        private Blood blood;
        public Blood Blood
        {
            set { blood = value; }
            get { return blood; }
        }

        private bool gameOver = false;
        public bool GameOver
        {
            set { gameOver = value; }
            get { return gameOver; }
        }

        [SerializeField]
        private bool debug = false;

        public delegate bool eventProcess();
        protected List<eventProcess> eventList = new List<eventProcess>();
        protected int eventNo = 0;
        private Vector3 joystickDefaultPosition;
        private string startTime = null;

        /// <summary>
        /// 初期処理
        /// </summary>
        public void Start()
        {
            if (joystick != null)
            {
                joystickDefaultPosition = joystick.transform.position;
            }

#if DEBUG
            // データ全削除
            if (debug)
            {
                PlayerPrefs.DeleteAll();
            }
#endif
        }

        /// <summary>
        /// 指定シーンのロード
        /// </summary>
        /// <param name="sceneName"></param>
        /// <returns></returns>
        public bool loadScene(string sceneName)
        {
            // シーンをロード
            SceneManager.LoadScene(sceneName);
            return true;
        }

        /// <summary>
        /// 前回シーンのロード
        /// </summary>
        /// <returns></returns>
        public bool loadLastScene()
        {
            // シーンを保存
            SaveController saveController = new SaveController();
            SaveController.SceneNo[] scene = saveController.get_Scene();

            // シーンをロード
            string sceneText = scene[0].Equals(SaveController.SceneNo.None) ? @"stage01" : scene[0].ToString();
            SceneManager.LoadScene(sceneText);
            return true;
        }

        /// <summary>
        /// プレイヤーの移動
        /// </summary>
        /// <param name="gameObject"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public bool playerWalk(GameObject gameObject, float range = 0.5f)
        {
            return playerWalk(
                        gameObject.transform.position.x,
                        gameObject.transform.position.y,
                        gameObject.transform.position.z,
                        range
                    );
        }

        /// <summary>
        /// プレイヤーの移動
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public bool playerWalk(float x, float y, float z, float range = 0.5f)
        {
            if ((Player.transform.position.x > x - range && Player.transform.position.x < x + range)
             && (Player.transform.position.z > z - range && Player.transform.position.z < z + range))
            {
                Player.Idle();
                return true;
            }
            else
            {
                Player.Walk();
                Player.WalkToVector3(new Vector3(x, y, z));
                return false;
            }
        }

        /// <summary>
        /// プレイヤーの移動
        /// </summary>
        /// <param name="gameObject"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public bool playerRun(GameObject gameObject, float range = 0.5f)
        {
            return playerRun(
                        gameObject.transform.position.x,
                        gameObject.transform.position.y,
                        gameObject.transform.position.z,
                        range
                    );
        }

        /// <summary>
        /// プレイヤーの移動
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public bool playerRun(float x, float y, float z, float range = 0.5f)
        {
            if ((Player.transform.position.x > x - range && Player.transform.position.x < x + range)
             && (Player.transform.position.z > z - range && Player.transform.position.z < z + range))
            {
                Player.Idle();
                return true;
            }
            else
            {
                Player.Run();
                Player.RunToVector3(new Vector3(x, y, z));
                return false;
            }
        }

        /// <summary>
        /// プレイヤーの向き変更
        /// </summary>
        /// <param name="gameObject"></param>
        /// <returns></returns>
        public bool playerTurnaround(GameObject gameObject, float speed = 0.1f)
        {
            float lastAngle = player.transform.eulerAngles.y;
            Quaternion workRotate = player.transform.rotation;

            // 時間をかけて振り返るように設定
            player.transform.LookAt(gameObject.transform.position);
            player.transform.rotation = Quaternion.Slerp(workRotate, player.transform.rotation, speed);

            if (lastAngle - player.transform.eulerAngles.y < speed * 10 &&
                lastAngle - player.transform.eulerAngles.y > speed * - 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// キャラクターの移動
        /// </summary>
        /// <param name="chara"></param>
        /// <param name="movePoint"></param>
        /// <returns></returns>
        public bool charaWalk(Charactor chara, GameObject movePoint)
        {
            float x = movePoint.transform.position.x;
            float y = movePoint.transform.position.y;
            float z = movePoint.transform.position.z;

            return charaWalk(chara, x, y, z);
        }

        /// <summary>
        /// キャラクターの移動
        /// </summary>
        /// <param name="chara"></param>
        /// <param name="movePoint"></param>
        /// <returns></returns>
        public bool charaRun(Charactor chara, GameObject movePoint)
        {
            float x = movePoint.transform.position.x;
            float y = movePoint.transform.position.y;
            float z = movePoint.transform.position.z;

            return charaRun(chara, x, y, z);
        }

        /// <summary>
        /// キャラクターの移動
        /// </summary>
        /// <param name="chara"></param>
        /// <param name="movePoint"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public bool charaWalk(Charactor chara, GameObject movePoint, float range)
        {
            float x = movePoint.transform.position.x;
            float y = movePoint.transform.position.y;
            float z = movePoint.transform.position.z;

            return charaWalk(chara, x, y, z, range);
        }

        /// <summary>
        /// キャラクターの移動
        /// </summary>
        /// <param name="chara"></param>
        /// <param name="movePoint"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public bool charaRun(Charactor chara, GameObject movePoint, float range)
        {
            float x = movePoint.transform.position.x;
            float y = movePoint.transform.position.y;
            float z = movePoint.transform.position.z;

            return charaRun(chara, x, y, z, range);
        }

        /// <summary>
        /// キャラクターの移動
        /// </summary>
        /// <param name="chara"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public bool charaWalk(Charactor chara, float x, float y, float z)
        {
            return charaWalk(chara, x, y, z, 5.0f);
        }

        /// <summary>
        /// キャラクターの移動
        /// </summary>
        /// <param name="chara"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public bool charaRun(Charactor chara, float x, float y, float z)
        {
            return charaRun(chara, x, y, z, 5.0f);
        }

        /// <summary>
        /// キャラクターの移動
        /// </summary>
        /// <param name="chara"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// /// <param name="range"></param>
        /// <returns></returns>
        public bool charaWalk(Charactor chara, float x, float y, float z, float range)
        {
            if ((chara.transform.position.x > x - range && chara.transform.position.x < x + range)
             && (chara.transform.position.z > z - range && chara.transform.position.z < z + range))
            {
                chara.MotionWait();
                return true;
            }
            else
            {
                chara.MotionWalk();
                chara.walkToVector3(new Vector3(x, y, z));
                return false;
            }
        }

        /// <summary>
        /// キャラクターの移動
        /// </summary>
        /// <param name="chara"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// /// <param name="range"></param>
        /// <returns></returns>
        public bool charaRun(Charactor chara, float x, float y, float z, float range)
        {
            if ((chara.transform.position.x > x - range && chara.transform.position.x < x + range)
             && (chara.transform.position.z > z - range && chara.transform.position.z < z + range))
            {
                chara.MotionWait();
                return true;
            }
            else
            {
                chara.MotionRun();
                chara.runToVector3(new Vector3(x, y, z));
                return false;
            }
        }

        /// <summary>
        /// キャラクターの向き変更
        /// </summary>
        /// <param name="chara"></param>
        /// <param name="gameObject"></param>
        /// <returns></returns>
        public bool charaTurnaround(Charactor chara, GameObject gameObject, float speed = 0.1f)
        {
            float lastAngle = chara.transform.eulerAngles.y;
            Quaternion workRotate = chara.transform.rotation;

            // 時間をかけて振り返るように設定
            chara.transform.LookAt(gameObject.transform.position);
            chara.transform.rotation = Quaternion.Slerp(workRotate, chara.transform.rotation, speed);

            if (lastAngle - chara.transform.eulerAngles.y < speed * 10 &&
                lastAngle - chara.transform.eulerAngles.y > speed * -10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// プレイヤーの死亡
        /// </summary>
        /// <returns></returns>
        public bool playerDead()
        {
            if (Player.IsAlive())
            {
                BgmController.GetInstance().playGameOverBgm(true);

                Charactor.Pause();
                Player.Dead();

                StartCoroutine(this.DelayMethod(3.0f, () =>
                {
                    Blood.appear(new Vector3(Player.transform.position.x, 0.5f, Player.transform.position.z));
                }));
            }
            return Blood.isAppeared();
        }

        /// <summary>
        /// プレイヤーの復活
        /// </summary>
        /// <returns></returns>
        public bool playerRevived()
        {
            Charactor.Restart();
            return true;
        }

        /// <summary>
        /// 画面のブラックアウト
        /// </summary>
        /// <returns></returns>
        public bool lightOff()
        {
            if (Blackout.color.a > 1.0f)
            {
                return true;
            }
            else
            {
                Blackout.gameObject.SetActive(true);
                Blackout.color = new Color(Blackout.color.r, Blackout.color.g, Blackout.color.b, Blackout.color.a + 0.01f);
                return false;
            }
        }

        /// <summary>
        /// 画面のブラックアウト解除
        /// </summary>
        /// <returns></returns>
        public bool lightOn()
        {
            if (Blackout.color.a < 0.0f)
            {
                Blackout.gameObject.SetActive(false);
                return true;
            }
            else
            {
                Blackout.color = new Color(Blackout.color.r, Blackout.color.g, Blackout.color.b, Blackout.color.a - 0.01f);
                return false;
            }
        }

        /// <summary>
        /// BGM停止
        /// </summary>
        /// <returns></returns>
        public bool stopBgm()
        {
            BgmController.GetInstance().stopBgm();
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playDefaultBgm()
        {
            BgmController.GetInstance().playDefaultBgm();
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playDefaultBgm_Begin()
        {
            BgmController.GetInstance().playDefaultBgm(true);
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playChaseBgm()
        {
            BgmController.GetInstance().playChaseBgm();
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playChaseBgm_Begin()
        {
            BgmController.GetInstance().playChaseBgm(true);
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playGameOverBgm()
        {
            BgmController.GetInstance().playGameOverBgm();
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playGameOverBgm_Begin()
        {
            BgmController.GetInstance().playGameOverBgm(true);
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEndrollBgm()
        {
            BgmController.GetInstance().playEndrollBgm();
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEndrollBgm_Begin()
        {
            BgmController.GetInstance().playEndrollBgm(true);
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEvent1Bgm()
        {
            BgmController.GetInstance().playEvent1Bgm();
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEvent1Bgm_Begin()
        {
            BgmController.GetInstance().playEvent1Bgm(true);
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEvent2Bgm()
        {
            BgmController.GetInstance().playEvent2Bgm();
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEvent2Bgm_Begin()
        {
            BgmController.GetInstance().playEvent2Bgm(true);
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEvent3Bgm()
        {
            BgmController.GetInstance().playEvent3Bgm();
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEvent3Bgm_Begin()
        {
            BgmController.GetInstance().playEvent3Bgm(true);
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEvent4Bgm()
        {
            BgmController.GetInstance().playEvent4Bgm();
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEvent4Bgm_Begin()
        {
            BgmController.GetInstance().playEvent4Bgm(true);
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEvent5Bgm()
        {
            BgmController.GetInstance().playEvent5Bgm();
            return true;
        }

        /// <summary>
        /// BGM変更
        /// </summary>
        /// <returns></returns>
        public bool playEvent5Bgm_Begin()
        {
            BgmController.GetInstance().playEvent5Bgm(true);
            return true;
        }

        /// <summary>
        /// ジョイスティックの位置をデフォルトに戻す
        /// </summary>
        public void resetPosition_Joystick()
        {
            ////mobileJoystick.transform.position = joystickDefaultPosition;
            //CrossPlatformInputManager.SetAxis("Horizontal", 0);
            //CrossPlatformInputManager.SetAxis("Vertical", 0);
            joystick.ResetPosition();
        }

        /// <summary>
        /// キーアイテム１の更新
        /// </summary>
        public void Update_KeyItem1()
        {
            keyItemController.Update_KeyItem1();
        }

        /// <summary>
        /// キーアイテム２の更新
        /// </summary>
        public void Update_KeyItem2()
        {
            keyItemController.Update_KeyItem2();
        }

        /// <summary>
        /// キーアイテム３の更新
        /// </summary>
        public void Update_KeyItem3()
        {
            keyItemController.Update_KeyItem3();
        }

        /// <summary>
        /// 指定時間待機
        /// </summary>
        /// <param name="msec"></param>
        /// <returns></returns>
        public bool timeWait(int msec)
        {
            if (startTime == null)
            {
                startTime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                return false;
            }
            else
            {
                string nowTime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                if ((decimal.Parse(nowTime) - decimal.Parse(startTime)) > msec)
                {
                    startTime = null;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}