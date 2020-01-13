using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController05 : EventController
    {
        [SerializeField]
        private AudioSource seTrain;
        public AudioSource SeTrain
        {
            get { return seTrain; }
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
        public GameObject EventPanel6
        {
            get { return eventPanel6; }
        }

        [SerializeField]
        private GameObject eventPanel7_1;

        [SerializeField]
        private GameObject eventPanel7_2;
        public GameObject EventPanel7_2
        {
            get { return eventPanel7_2; }
        }

        [SerializeField]
        private GameObject eventPanel8;

        [SerializeField]
        private GameObject eventPanel9;
        public GameObject EventPanel9
        {
            get { return eventPanel9; }
        }

        [SerializeField]
        private GameObject eventPanel10;
        public GameObject EventPanel10
        {
            get { return eventPanel10; }
        }

        [SerializeField]
        private GameObject eventPanel11;
        public GameObject EventPanel11
        {
            get { return eventPanel11; }
        }

        [SerializeField]
        private GameObject eventPanel12;

        [SerializeField]
        private GameObject entryPoint1;

        [SerializeField]
        private GameObject entryPoint2;

        [SerializeField]
        private GameObject entryPoint3;

        [SerializeField]
        private GameObject movePoint1_1;
        public GameObject MovePoint1_1
        {
            get { return movePoint1_1; }
        }

        [SerializeField]
        private GameObject movePoint1_2;
        public GameObject MovePoint1_2
        {
            get { return movePoint1_2; }
        }

        [SerializeField]
        private GameObject movePoint2;
        public GameObject MovePoint2
        {
            get { return movePoint2; }
        }

        [SerializeField]
        private GameObject movePoint3_1;
        public GameObject MovePoint3_1
        {
            get { return movePoint3_1; }
        }

        [SerializeField]
        private GameObject movePoint3_2;
        public GameObject MovePoint3_2
        {
            get { return movePoint3_2; }
        }

        [SerializeField]
        private GameObject movePoint4_1;
        public GameObject MovePoint4_1
        {
            get { return movePoint4_1; }
        }

        [SerializeField]
        private GameObject movePoint4_2;
        public GameObject MovePoint4_2
        {
            get { return movePoint4_2; }
        }

        [SerializeField]
        private GameObject movePoint5;
        public GameObject MovePoint5
        {
            get { return movePoint5; }
        }

        [SerializeField]
        private GameObject movePoint6_1;
        public GameObject MovePoint6_1
        {
            get { return movePoint6_1; }
        }

        [SerializeField]
        private GameObject movePoint6_2;
        public GameObject MovePoint6_2
        {
            get { return movePoint6_2; }
        }

        [SerializeField]
        private GameObject movePoint7_1;
        public GameObject MovePoint7_1
        {
            get { return movePoint7_1; }
        }

        [SerializeField]
        private GameObject movePoint7_2;
        public GameObject MovePoint7_2
        {
            get { return movePoint7_2; }
        }

        [SerializeField]
        private GameObject movePoint8_1;
        public GameObject MovePoint8_1
        {
            get { return movePoint8_1; }
        }

        [SerializeField]
        private GameObject movePoint8_2;
        public GameObject MovePoint8_2
        {
            get { return movePoint8_2; }
        }

        [SerializeField]
        private GameObject movePoint8_3;
        public GameObject MovePoint8_3
        {
            get { return movePoint8_3; }
        }

        [SerializeField]
        private Camera mainCamera;
        public Camera MainCamera
        {
            get { return mainCamera; }
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
        private Camera eventCamera3;
        public Camera EventCamera3
        {
            get { return eventCamera3; }
        }

        [SerializeField]
        private Camera eventCamera4;
        public Camera EventCamera4
        {
            get { return eventCamera4; }
        }

        [SerializeField]
        private Charactor devil;
        public Charactor Devil
        {
            get { return devil; }
        }

        [SerializeField]
        private Charactor ryotaro;
        public Charactor Ryotaro
        {
            get { return ryotaro; }
        }

        [SerializeField]
        private Charactor enemy1;
        public Charactor Enemy1
        {
            get { return enemy1; }
        }

        [SerializeField]
        private Charactor classmate1;
        public Charactor Classmate1
        {
            get { return classmate1; }
        }

        [SerializeField]
        private Charactor classmate2;
        public Charactor Classmate2
        {
            get { return classmate2; }
        }

        [SerializeField]
        private Charactor classmate3;
        public Charactor Classmate3
        {
            get { return classmate3; }
        }

        [SerializeField]
        private Charactor child1;
        public Charactor Child1
        {
            get { return child1; }
        }

        [SerializeField]
        private Charactor child2;
        public Charactor Child2
        {
            get { return child2; }
        }

        [SerializeField]
        private RailroadCrossing05 railroadCrossing1;
        public RailroadCrossing05 RailroadCrossing1
        {
            get { return railroadCrossing1; }
        }

        [SerializeField]
        private RailroadCrossing05 railroadCrossing2;
        public RailroadCrossing05 RailroadCrossing2
        {
            get { return railroadCrossing2; }
        }

        [SerializeField]
        private GameObject train1;
        public GameObject Train1
        {
            get { return train1; }
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
            eventDictionary.Add(eventPanel1, new Event05_01_MoveScene(this).GetEventList());
            eventDictionary.Add(eventPanel2, new Event05_02_MoveScene(this).GetEventList());
            eventDictionary.Add(eventPanel3, new Event05_03_MoveScene(this).GetEventList());
            eventDictionary.Add(eventPanel4, new Event05_04_TakeEnemy(this).GetEventList());
            eventDictionary.Add(eventPanel5, new Event05_05_SmallTalk(this).GetEventList());
            eventDictionary.Add(eventPanel6, new Event05_06_TalkClassmate(this).GetEventList());
            eventDictionary.Add(eventPanel7_1, new Event05_07_01_MeetDevil(this).GetEventList());
            eventDictionary.Add(eventPanel7_2, new Event05_07_02_MeetDevil(this).GetEventList());
            eventDictionary.Add(eventPanel8, new Event05_08_ArriveTrain(this).GetEventList());
            eventDictionary.Add(eventPanel9, new Event05_09_GetOnTrain(this).GetEventList());
            eventDictionary.Add(eventPanel10, new Event05_10_GetOffTrain(this).GetEventList());
            eventDictionary.Add(eventPanel11, new Event05_11_MeetRyotaro(this).GetEventList());
            eventDictionary.Add(eventPanel12, new Event05_12_PlayBaseball(this).GetEventList());
        }

        /// <summary>
        /// ステージの初期化
        /// </summary>
        private void initializeStage()
        {
            SaveController05 saveController05 = new SaveController05();

            // データのロード
            SaveController.SceneNo[] scene = saveController05.get_Scene();
            SaveController.PlaceNo place = saveController05.get_Place();

            // プレイヤーの位置を設定する
            if (scene[0].Equals(SaveController.SceneNo.Scene04) &&
               (place.Equals(SaveController.PlaceNo.Place03)))
            {
                Player.transform.position = entryPoint1.transform.position;
                Player.transform.rotation = entryPoint1.transform.rotation;
                saveController05.save_Scene(SaveController.SceneNo.Scene05, SaveController.PlaceNo.Place01);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene04) &&
                    (place.Equals(SaveController.PlaceNo.Place04)))
            {
                Player.transform.position = entryPoint2.transform.position;
                Player.transform.rotation = entryPoint2.transform.rotation;
                saveController05.save_Scene(SaveController.SceneNo.Scene05, SaveController.PlaceNo.Place02);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene07) &&
                    (place.Equals(SaveController.PlaceNo.Place01)))
            {
                Player.transform.position = entryPoint3.transform.position;
                Player.transform.rotation = entryPoint3.transform.rotation;
                saveController05.save_Scene(SaveController.SceneNo.Scene05, SaveController.PlaceNo.Place03);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene05) &&
                    (place.Equals(SaveController.PlaceNo.Place02)))
            {
                Player.transform.position = entryPoint2.transform.position;
                Player.transform.rotation = entryPoint2.transform.rotation;
                saveController05.save_Scene(SaveController.SceneNo.Scene05, SaveController.PlaceNo.Place02);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene05) &&
                    (place.Equals(SaveController.PlaceNo.Place03)))
            {
                Player.transform.position = entryPoint3.transform.position;
                Player.transform.rotation = entryPoint3.transform.rotation;
                saveController05.save_Scene(SaveController.SceneNo.Scene05, SaveController.PlaceNo.Place03);
            }
            else
            {
                Player.transform.position = entryPoint1.transform.position;
                Player.transform.rotation = entryPoint1.transform.rotation;
                saveController05.save_Scene(SaveController.SceneNo.Scene05, SaveController.PlaceNo.Place01);
            }

            load_Event05_04_TakeEnemy(saveController05);
            load_Event05_07_01_MeetDevil(saveController05);
            load_Event05_10_GetOffTrain(saveController05);
            load_Event05_11_MeetRyotaro(saveController05);
            load_Event05_12_PlayBaseball(saveController05);
        }

        /// <summary>
        /// Event05_04_TakeEnemyのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event05_04_TakeEnemy(SaveController05 saveController)
        {
            if (saveController.completed_Event05_04_TakeEnemy())
            {
                eventPanel4.SetActive(false);
                eventPanel5.SetActive(false);

                classmate1.gameObject.SetActive(false);
                classmate3.gameObject.SetActive(false);
                enemy1.gameObject.SetActive(false);

                Classmate2.transform.position = movePoint2.transform.position;
                Classmate2.transform.rotation = movePoint2.transform.rotation;
            }
        }

        /// <summary>
        /// Event05_07_01_MeetDevilのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event05_07_01_MeetDevil(SaveController05 saveController)
        {
            if (saveController.completed_Event05_07_01_MeetDevil())
            {
                eventPanel7_1.SetActive(false);
                eventPanel7_2.SetActive(true);
                train1.SetActive(true);
                train1.transform.position = movePoint6_1.transform.position;
                eventCamera1.transform.position = movePoint5.transform.position;
            }

            SaveController03 saveController03 = new SaveController03();
            if (saveController03.completed_Event03_09_MeetDevil() == false)
            {
                devil.gameObject.SetActive(false);
                eventPanel7_2.SetActive(false);
            }
        }

        /// <summary>
        /// Event05_10_GetOffTrainのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event05_10_GetOffTrain(SaveController05 saveController)
        {
            if (saveController.completed_Event05_10_GetOffTrain())
            {
                eventPanel8.SetActive(false);
                train1.SetActive(false);
                train1.transform.position = movePoint6_2.transform.position;

                if (saveController.completed_Event05_11_MeetRyotaro() == false)
                {
                    eventPanel11.SetActive(true);
                }
            }
        }

        /// <summary>
        /// Event05_11_MeetRyotaroのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event05_11_MeetRyotaro(SaveController05 saveController)
        {
            if (saveController.completed_Event05_11_MeetRyotaro())
            {
                eventPanel11.SetActive(false);
            }
        }

        /// <summary>
        /// Event05_12_PlayBaseballのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event05_12_PlayBaseball(SaveController05 saveController)
        {
            if (saveController.completed_Event05_12_PlayBaseball())
            {
                eventPanel12.SetActive(false);
                child2.transform.position = movePoint8_3.transform.position;
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
            eventList = new Event05_99_GameOver(this).GetEventList();
            eventNo = 0;
        }
    }
}