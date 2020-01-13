using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController04 : EventController
    {
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
        private GameObject eventPanel7;
        public GameObject EventPanel7
        {
            set { eventPanel7 = value; }
            get { return eventPanel7; }
        }

        [SerializeField]
        private GameObject eventPanel8;

        [SerializeField]
        private GameObject eventPanel9;

        [SerializeField]
        private GameObject eventPanel10;

        [SerializeField]
        private GameObject eventPanel11_1;
        public GameObject EventPanel11_1
        {
            get { return eventPanel11_1; }
        }

        [SerializeField]
        private GameObject eventPanel11_2_1;
        public GameObject EventPanel11_2_1
        {
            get { return eventPanel11_2_1; }
        }

        [SerializeField]
        private GameObject eventPanel11_2_2;
        public GameObject EventPanel11_2_2
        {
            get { return eventPanel11_2_2; }
        }

        [SerializeField]
        private GameObject eventPanel11_2_3;
        public GameObject EventPanel11_2_3
        {
            get { return eventPanel11_2_3; }
        }

        [SerializeField]
        private GameObject eventPanel11_2_4;
        public GameObject EventPanel11_2_4
        {
            get { return eventPanel11_2_4; }
        }

        [SerializeField]
        private GameObject eventPanel12;

        [SerializeField]
        private GameObject eventPanel13;

        [SerializeField]
        private GameObject eventPanel14;

        [SerializeField]
        private GameObject eventPanel15;

        [SerializeField]
        private GameObject eventPanel16;

        [SerializeField]
        private GameObject eventPanel17;

        [SerializeField]
        private GameObject eventPanel18;

        [SerializeField]
        private GameObject eventPanel19;

        [SerializeField]
        private GameObject entryPoint1;

        [SerializeField]
        private GameObject entryPoint2;

        [SerializeField]
        private GameObject entryPoint3;

        [SerializeField]
        private GameObject entryPoint4;

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
        private GameObject movePoint3;
        public GameObject MovePoint3
        {
            get { return movePoint3; }
        }

        [SerializeField]
        private GameObject movePoint4;
        public GameObject MovePoint4
        {
            get { return movePoint4; }
        }

        [SerializeField]
        private GameObject movePoint5;
        public GameObject MovePoint5
        {
            get { return movePoint5; }
        }

        [SerializeField]
        private GameObject movePoint6;
        public GameObject MovePoint6
        {
            get { return movePoint6; }
        }

        [SerializeField]
        private GameObject ceremony;
        public GameObject Ceremony
        {
            get { return ceremony; }
        }

        [SerializeField]
        private Charactor enemy1;
        public Charactor Enemy1
        {
            get { return enemy1; }
        }

        [SerializeField]
        private Charactor enemy2;
        public Charactor Enemy2
        {
            get { return enemy2; }
        }

        [SerializeField]
        private Charactor teacher;
        public Charactor Teacher
        {
            get { return teacher; }
        }

        [SerializeField]
        private Charactor yuko;
        public Charactor Yuko
        {
            set { yuko = value; }
            get { return yuko; }
        }

        [SerializeField]
        private Charactor yuko_Black;
        public Charactor Yuko_Black
        {
            get { return yuko_Black; }
        }

        [SerializeField]
        private Charactor rabbit;
        public Charactor Rabbit
        {
            get { return rabbit; }
        }

        [SerializeField]
        private GameObject rabbit_Corpse;
        public GameObject Rabbit_Corpse
        {
            get { return rabbit_Corpse; }
        }

        [SerializeField]
        private Charactor frog1;
        public Charactor Frog1
        {
            get { return frog1; }
        }

        [SerializeField]
        private Charactor frog2;
        public Charactor Frog2
        {
            get { return frog2; }
        }

        [SerializeField]
        private GameObject suicide1;
        public GameObject Suicide1
        {
            get { return suicide1; }
        }

        [SerializeField]
        private GameObject suicide2;
        public GameObject Suicide2
        {
            get { return suicide2; }
        }

        [SerializeField]
        private GameObject bloodStain1;
        public GameObject BloodStain1
        {
            get { return bloodStain1; }
        }

        [SerializeField]
        private GameObject bloodStain2;
        public GameObject BloodStain2
        {
            get { return bloodStain2; }
        }

        [SerializeField]
        private GameObject gymnasium;
        public GameObject Gymnasium
        {
            get { return gymnasium; }
        }

        [SerializeField]
        private ParticleSystem effect1;
        public ParticleSystem Effect1
        {
            get { return effect1; }
        }

        [SerializeField]
        private ParticleSystem effect2;
        public ParticleSystem Effect2
        {
            get { return effect2; }
        }

        [SerializeField]
        private ParticleSystem effect3;
        public ParticleSystem Effect3
        {
            get { return effect3; }
        }

        [SerializeField]
        private ParticleSystem shockwave1;
        public ParticleSystem Shockwave1
        {
            get { return shockwave1; }
        }

        [SerializeField]
        private GameObject mainCamera;
        public GameObject MainCamera
        {
            get { return mainCamera; }
        }

        [SerializeField]
        private GameObject eventCamera1;
        public GameObject EventCamera1
        {
            get { return eventCamera1; }
        }

        [SerializeField]
        private GameObject eventCamera2;
        public GameObject EventCamera2
        {
            get { return eventCamera2; }
        }

        [SerializeField]
        private GameObject eventCamera3;
        public GameObject EventCamera3
        {
            get { return eventCamera3; }
        }

        [SerializeField]
        private GameObject eventCamera4;
        public GameObject EventCamera4
        {
            get { return eventCamera4; }
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
            eventDictionary.Add(eventPanel1, new Event04_01_FindMud(this).GetEventList());
            eventDictionary.Add(eventPanel2, new Event04_02_FindRabbitHouse(this).GetEventList());
            eventDictionary.Add(eventPanel3, new Event04_03_FindRabbit1(this).GetEventList());
            eventDictionary.Add(eventPanel4, new Event04_04_FindRabbit2(this).GetEventList());
            eventDictionary.Add(eventPanel5, new Event04_05_FindEnemies(this).GetEventList());
            eventDictionary.Add(eventPanel6, new Event04_06_ChangeCamera(this).GetEventList());
            eventDictionary.Add(eventPanel7, new Event04_07_ChangeCamera(this).GetEventList());
            eventDictionary.Add(eventPanel8, new Event04_08_EnterGymnasium(this).GetEventList());
            eventDictionary.Add(eventPanel9, new Event04_09_FindBusstop(this).GetEventList());
            eventDictionary.Add(eventPanel10, new Event04_10_FindBusstop2(this).GetEventList());
            eventDictionary.Add(eventPanel11_1, new Event04_11_01_EnterCeremony(this).GetEventList());
            eventDictionary.Add(eventPanel11_2_1, new Event04_11_02_EnterCeremony(this).GetEventList());
            eventDictionary.Add(eventPanel11_2_2, new Event04_11_02_EnterCeremony(this).GetEventList());
            eventDictionary.Add(eventPanel11_2_3, new Event04_11_02_EnterCeremony(this).GetEventList());
            eventDictionary.Add(eventPanel11_2_4, new Event04_11_02_EnterCeremony(this).GetEventList());
            eventDictionary.Add(eventPanel12, new Event04_12_MoveScene(this).GetEventList());
            eventDictionary.Add(eventPanel13, new Event04_13_MoveScene(this).GetEventList());
            eventDictionary.Add(eventPanel14, new Event04_14_MoveScene(this).GetEventList());
            eventDictionary.Add(eventPanel15, new Event04_15_MoveScene(this).GetEventList());
            eventDictionary.Add(eventPanel16, new Event04_16_MeetTeacher(this).GetEventList());
            eventDictionary.Add(eventPanel17, new Event04_17_FindFrog1(this).GetEventList());
            eventDictionary.Add(eventPanel18, new Event04_18_FindFrog2(this).GetEventList());
            eventDictionary.Add(eventPanel19, new Event04_19_Suicide(this).GetEventList());
        }

        /// <summary>
        /// ステージの初期化
        /// </summary>
        private void initializeStage()
        {
            SaveController04 saveController04 = new SaveController04();

            // データのロード
            SaveController.SceneNo[] scene = saveController04.get_Scene();
            SaveController.PlaceNo place = saveController04.get_Place();

            // プレイヤーの位置を設定する
            if (scene[0].Equals(SaveController.SceneNo.Scene04) &&
               (place.Equals(SaveController.PlaceNo.Place02)))
            {
                Player.transform.position = entryPoint2.transform.position;
                Player.transform.rotation = entryPoint2.transform.rotation;
                saveController04.save_Scene(SaveController.SceneNo.Scene04, SaveController.PlaceNo.Place02);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene04) &&
                    (place.Equals(SaveController.PlaceNo.Place03)))
            {
                Player.transform.position = entryPoint3.transform.position;
                Player.transform.rotation = entryPoint3.transform.rotation;
                saveController04.save_Scene(SaveController.SceneNo.Scene04, SaveController.PlaceNo.Place03);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene04) &&
                    (place.Equals(SaveController.PlaceNo.Place04)))
            {
                Player.transform.position = entryPoint4.transform.position;
                Player.transform.rotation = entryPoint4.transform.rotation;
                saveController04.save_Scene(SaveController.SceneNo.Scene04, SaveController.PlaceNo.Place04);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene05) &&
                    (place.Equals(SaveController.PlaceNo.Place01)))
            {
                Player.transform.position = entryPoint3.transform.position;
                Player.transform.rotation = entryPoint3.transform.rotation;
                saveController04.save_Scene(SaveController.SceneNo.Scene04, SaveController.PlaceNo.Place03);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene05) &&
                    (place.Equals(SaveController.PlaceNo.Place02)))
            {
                Player.transform.position = entryPoint4.transform.position;
                Player.transform.rotation = entryPoint4.transform.rotation;
                saveController04.save_Scene(SaveController.SceneNo.Scene04, SaveController.PlaceNo.Place04);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene06))
            {
                Player.transform.position = entryPoint2.transform.position;
                Player.transform.rotation = entryPoint2.transform.rotation;
                saveController04.save_Scene(SaveController.SceneNo.Scene04, SaveController.PlaceNo.Place02);
            }
            else
            {
                Player.transform.position = entryPoint1.transform.position;
                saveController04.save_Scene(SaveController.SceneNo.Scene04, SaveController.PlaceNo.Place01);
            }

            load_Event04_02_FindRabbitHouse(saveController04);
            load_Event04_03_FindRabbit1(saveController04);
            load_Event04_04_FindRabbit2(saveController04);
            load_Event04_11_EnterCeremony(saveController04);
            load_Event04_08_EnterGymnasium(saveController04);
            load_Event04_19_Suicide(saveController04);
        }

        /// <summary>
        /// Event04_02_FindRabbitHouseのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event04_02_FindRabbitHouse(SaveController04 saveController)
        {
            if (saveController.completed_Event04_02_FindRabbitHouse())
            {
                bloodStain1.SetActive(true);
                bloodStain2.SetActive(true);
                eventPanel2.SetActive(false);
            }
        }

        /// <summary>
        /// Event04_03_FindRabbit1のロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event04_03_FindRabbit1(SaveController04 saveController)
        {
            if (saveController.completed_Event04_03_FindRabbit1())
            {
                eventPanel3.SetActive(false);
            }
        }

        /// <summary>
        /// Event04_04_FindRabbit2のロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event04_04_FindRabbit2(SaveController04 saveController)
        {
            if (saveController.completed_Event04_04_FindRabbit2())
            {
                eventPanel4.SetActive(false);
                eventPanel5.SetActive(true);
            }
            else
            {
                eventPanel5.SetActive(false);
            }
        }

        /// <summary>
        /// Event04_08_EnterGymnasiumのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event04_08_EnterGymnasium(SaveController04 saveController)
        {
            if (saveController.completed_Event04_08_EnterGymnasium())
            {
                gymnasium.SetActive(false);
                eventPanel8.SetActive(false);
            }
        }

        /// <summary>
        /// Event04_11_EnterCeremonyのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event04_11_EnterCeremony(SaveController04 saveController)
        {
            if (saveController.completed_Event04_11_EnterCeremony1())
            {
                eventPanel11_1.SetActive(false);
                gymnasium.SetActive(false);
                ceremony.SetActive(false);
            }

            if (saveController.completed_Event04_11_EnterCeremony2())
            {
                eventPanel11_2_1.SetActive(false);
                eventPanel11_2_2.SetActive(false);
                eventPanel11_2_3.SetActive(false);
                eventPanel11_2_4.SetActive(false);
                yuko_Black.gameObject.SetActive(false);
            }
            else
            {
                eventPanel11_2_1.SetActive(true);
                eventPanel11_2_2.SetActive(true);
                eventPanel11_2_3.SetActive(true);
                eventPanel11_2_4.SetActive(true);
            }
        }

        /// <summary>
        /// Event04_19_Suicideのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event04_19_Suicide(SaveController04 saveController)
        {
            if (saveController.completed_Event04_19_Suicide())
            {
                suicide1.SetActive(false);
                suicide2.SetActive(true);
                eventPanel19.SetActive(false);
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
            eventList = new Event04_99_GameOver(this).GetEventList();
            eventNo = 0;
        }
    }
}