using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController02 : EventController
    {
        [SerializeField]
        private Charactor enemy1;
        public Charactor Enemy1
        {
            set { enemy1 = value; }
            get { return enemy1; }
        }

        [SerializeField]
        private Charactor enemy4;
        public Charactor Enemy4
        {
            set { enemy4 = value; }
            get { return enemy4; }
        }

        [SerializeField]
        private Charactor enemy5;
        public Charactor Enemy5
        {
            set { enemy5 = value; }
            get { return enemy5; }
        }

        [SerializeField]
        private Charactor enemyGirl1;
        public Charactor EnemyGirl1
        {
            set { enemyGirl1 = value; }
            get { return enemyGirl1; }
        }

        [SerializeField]
        private Charactor mother;
        public Charactor Mother
        {
            set { mother = value; }
            get { return mother; }
        }

        [SerializeField]
        private Charactor meiko;
        public Charactor Meiko
        {
            set { meiko = value; }
            get { return meiko; }
        }

        [SerializeField]
        private Charactor child4;
        public Charactor Child4
        {
            set { meiko = value; }
            get { return child4; }
        }

        [SerializeField]
        private GameObject eventPanel1;

        [SerializeField]
        private GameObject eventPanel2;

        [SerializeField]
        private GameObject eventPanel3;

        [SerializeField]
        private GameObject eventPanel4;

        [SerializeField]
        private GameObject eventPanel5;

        [SerializeField]
        private GameObject eventPanel6;

        [SerializeField]
        private GameObject eventPanel7;

        [SerializeField]
        private GameObject eventPanel8;

        [SerializeField]
        private GameObject entryPoint1;

        [SerializeField]
        private GameObject entryPoint2;

        [SerializeField]
        private GameObject movePoint1;
        public GameObject MovePoint1
        {
            get { return movePoint1; }
        }

        [SerializeField]
        private GameObject movePoint2;
        public GameObject MovePoint2
        {
            get { return movePoint2; }
        }

        [SerializeField]
        private Camera mainCamera1;
        public Camera MainCamera1
        {
            get { return mainCamera1; }
        }

        [SerializeField]
        private Camera eventCamera1;
        public Camera EventCamera1
        {
            get { return eventCamera1; }
        }

        [SerializeField]
        private Camera eventCamera2;
        public Camera EventCamera2
        {
            get { return eventCamera2; }
        }

        [SerializeField]
        private AudioSource voiceEnemy;
        public AudioSource VoiceEnemy
        {
            get { return voiceEnemy; }
        }

        private Dictionary<GameObject, List<eventProcess>> eventDictionary = new Dictionary<GameObject, List<eventProcess>>();

        public void Start()
        {
            base.Start();

            // イベント情報の設定
            setEventDictionary();

            // ステージの初期化
            initializeStage();
        }

        public void FixedUpdate()
        {
            if (eventList != null && eventList.Count > eventNo)
            {
                if (eventList[eventNo].Invoke())
                {
                    eventNo += 1;
                    return;
                }
            }
            else
            {
                if (GameOver)
                {
                    execute_gameOver();
                }
            }
        }

        /// <summary>
        /// EventDictionaryの設定
        /// </summary>
        private void setEventDictionary()
        {
            // イベント情報の設定
            eventDictionary.Add(eventPanel1, new Event02_03_SmallTalk(this).GetEventList());
            eventDictionary.Add(eventPanel2, new Event02_02_EnterFriendHouse(this).GetEventList());
            eventDictionary.Add(eventPanel3, new Event02_04_SmallTalk2(this).GetEventList());
            eventDictionary.Add(eventPanel4, new Event02_05_MeetMeiko(this).GetEventList());
            eventDictionary.Add(eventPanel5, new Event02_06_SmallTalk3(this).GetEventList());
            eventDictionary.Add(eventPanel6, new Event02_07_FindEnemies(this).GetEventList());
            eventDictionary.Add(eventPanel7, new Event02_08_FindCorpses(this).GetEventList());
            eventDictionary.Add(eventPanel8, new Event02_09_MoveScene(this).GetEventList());
        }

        /// <summary>
        /// ステージの初期化
        /// </summary>
        private void initializeStage()
        {
            SaveController02 saveController02 = new SaveController02();

            // データのロード
            SaveController.SceneNo[] scene = saveController02.get_Scene();
            SaveController.PlaceNo place = saveController02.get_Place();
            
            // プレイヤーの位置を設定する
            if (scene[0].Equals(SaveController.SceneNo.Scene02) &&
               (place.Equals(SaveController.PlaceNo.Place02)))
            {
                Player.transform.position = entryPoint2.transform.position;
                Player.transform.rotation = entryPoint2.transform.rotation;
                saveController02.save_Scene(SaveController.SceneNo.Scene02, SaveController.PlaceNo.Place02);
            }
            else if (scene[0].Equals(SaveController02.SceneNo.Scene03))
            {
                Player.transform.position = entryPoint2.transform.position;
                Player.transform.rotation = entryPoint2.transform.rotation;
                saveController02.save_Scene(SaveController.SceneNo.Scene02, SaveController.PlaceNo.Place02);
            }
            else
            {
                Player.transform.position = entryPoint1.transform.position;
                Player.transform.rotation = entryPoint1.transform.rotation;
                saveController02.save_Scene(SaveController.SceneNo.Scene02, SaveController.PlaceNo.Place01);
            }

            load_Event02_01_Prologue(saveController02);
            load_Event02_05_MeetMeiko(saveController02);
            load_Event02_07_FindEnemies(saveController02);
            load_Event02_08_FindCorpses(saveController02);
        }

        /// <summary>
        /// Event02_01_Prologueのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event02_01_Prologue(SaveController02 saveController)
        {
            if (saveController.completed_Event02_01_Prologue() == false)
            {
                Enemy1.SetWalkRange(0.0f);
                //Enemy1.SetSpeed(0.7f);
                //Enemy1.SetAccelSpeed(0.7f);
                Enemy1.SetReactDistance(0.0f);
                Enemy1.tag = "Enemy1";
                eventList = new Event02_01_Prologue(this).GetEventList();
            }
        }

        /// <summary>
        /// Event02_05_MeetMeikoのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event02_05_MeetMeiko(SaveController02 saveController)
        {
            if (saveController.completed_Event02_05_MeetMeiko())
            {
                eventPanel4.SetActive(false);
            }
        }

        /// <summary>
        /// Event02_07_FindEnemiesのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event02_07_FindEnemies(SaveController02 saveController)
        {
            if (saveController.completed_Event02_07_FindEnemies())
            {
                enemy4.SetSpeed(0.7f);
                enemy4.SetAccelSpeed(1.1f);
                enemy4.SetWalkRange(90.0f);

                enemy5.SetSpeed(0.7f);
                enemy5.SetAccelSpeed(1.1f);
                enemy5.SetWalkRange(90.0f);

                enemyGirl1.SetSpeed(0.7f);
                enemyGirl1.SetAccelSpeed(1.1f);
                enemyGirl1.SetWalkRange(60.0f);

                eventPanel6.SetActive(false);
            }
        }

        /// <summary>
        /// Event02_08_FindCorpsesのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event02_08_FindCorpses(SaveController02 saveController)
        {
            if (saveController.completed_Event02_08_FindCorpses())
            {
                eventPanel7.SetActive(false);
            }
        }

        /// <summary>
        /// イベントの実行
        /// </summary>
        /// <param name="eventObject"></param>
        public void executeEvent(GameObject eventObject)
        {
            if (eventDictionary.ContainsKey(eventObject))
            {
                eventObject.SetActive(false);
                eventList = eventDictionary[eventObject];
                eventNo = 0;
            }
        }

        /// <summary>
        /// ゲームオーバー
        /// </summary>
        private void execute_gameOver()
        {
            eventList = new Event02_99_GameOver(this).GetEventList();
            eventNo = 0;
        }
    }
}