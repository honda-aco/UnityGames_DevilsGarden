using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController07 : EventController
    {
        [SerializeField]
        private GameObject eventPanel1;

        [SerializeField]
        private GameObject eventPanel2;
        public GameObject EventPanel2
        {
            get { return eventPanel2; }
        }

        [SerializeField]
        private GameObject eventPanel3;
        public GameObject EventPanel3
        {
            get { return eventPanel3; }
        }

        [SerializeField]
        private GameObject eventPanel4;
        public GameObject EventPanel4
        {
            get { return eventPanel4; }
        }

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
            get { return eventPanel7; }
        }

        [SerializeField]
        private GameObject eventPanel8;
        public GameObject EventPanel8
        {
            get { return eventPanel8; }
        }

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
        private GameObject entryPoint1;

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
        private GameObject movePoint7;
        public GameObject MovePoint7
        {
            get { return movePoint7; }
        }

        [SerializeField]
        private GameObject movePoint8;
        public GameObject MovePoint8
        {
            get { return movePoint8; }
        }

        [SerializeField]
        private GameObject movePoint9;
        public GameObject MovePoint9
        {
            get { return movePoint9; }
        }

        [SerializeField]
        private GameObject land9;
        public GameObject Land9
        {
            get { return land9; }
        }

        [SerializeField]
        private ParticleSystem smoke1;
        public ParticleSystem Smoke1
        {
            get { return smoke1; }
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
        private Charactor ryotaro1;
        public Charactor Ryotaro1
        {
            get { return ryotaro1; }
        }

        [SerializeField]
        private Charactor ryotaro2;
        public Charactor Ryotaro2
        {
            get { return ryotaro2; }
        }

        [SerializeField]
        private Charactor devil;
        public Charactor Devil
        {
            get { return devil; }
        }

        [SerializeField]
        private GameObject enemies1;
        public GameObject Enemies1
        {
            get { return enemies1; }
        }

        [SerializeField]
        private GameObject enemies2;
        public GameObject Enemies2
        {
            get { return enemies2; }
        }

        [SerializeField]
        private Charactor rabbit;
        public Charactor Rabbit
        {
            get { return rabbit; }
        }

        [SerializeField]
        private GameObject mountains;
        public GameObject Mountains
        {
            get { return mountains; }
        }

        [SerializeField]
        private GameObject light1;
        public GameObject Light1
        {
            get { return light1; }
        }

        [SerializeField]
        private GameObject light2;
        public GameObject Light2
        {
            get { return light2; }
        }

        [SerializeField]
        private GameObject letter1;
        public GameObject Letter1
        {
            get { return letter1; }
        }

        [SerializeField]
        private GameObject letter2;
        public GameObject Letter2
        {
            get { return letter2; }
        }

        [SerializeField]
        private GameObject hideField;
        public GameObject HideField
        {
            get { return hideField; }
        }

        [SerializeField]
        private GameObject poison1;
        public GameObject Poison1
        {
            get { return poison1; }
        }

        [SerializeField]
        private GameObject poison2;
        public GameObject Poison2
        {
            get { return poison2; }
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
            eventDictionary.Add(eventPanel1, new Event07_01_MoveScene(this).GetEventList());
            eventDictionary.Add(eventPanel2, new Event07_02_FindEnemies(this).GetEventList());
            eventDictionary.Add(eventPanel3, new Event07_03_StopSacrifice(this).GetEventList());
            eventDictionary.Add(eventPanel4, new Event07_04_SacrificeRabbit(this).GetEventList());
            eventDictionary.Add(eventPanel5, new Event07_05_FindSchool(this).GetEventList());
            eventDictionary.Add(eventPanel6, new Event07_06_FindLetter1(this).GetEventList());
            eventDictionary.Add(eventPanel7, new Event07_07_FindLetter2(this).GetEventList());
            eventDictionary.Add(eventPanel8, new Event07_08_MoveMeiko(this).GetEventList());
            eventDictionary.Add(eventPanel9, new Event07_09_MeetDevil(this).GetEventList());
            eventDictionary.Add(eventPanel10, new Event07_10_StopAsk(this).GetEventList());
            eventDictionary.Add(eventPanel11, new Event07_11_AskRyotaro(this).GetEventList());
        }

        /// <summary>
        /// ステージの初期化
        /// </summary>
        private void initializeStage()
        {
            SaveController07 saveController07 = new SaveController07();

            // データのロード
            SaveController.SceneNo[] scene = saveController07.get_Scene();
            SaveController.PlaceNo place = saveController07.get_Place();

            // プレイヤーの位置を設定する
            Player.transform.position = entryPoint1.transform.position;
            Player.transform.rotation = entryPoint1.transform.rotation;
            saveController07.save_Scene(SaveController.SceneNo.Scene07, SaveController.PlaceNo.Place01);

            load_Event07_04_SacrificeRabbit(saveController07);
            load_Event07_05_FindSchool(saveController07);
            load_Event07_06_FindLetter1(saveController07);
            load_Event07_11_AskRyotaro(saveController07);
        }

        /// <summary>
        /// Event07_04_SacrificeRabbitのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event07_04_SacrificeRabbit(SaveController07 saveController)
        {
            if (saveController.completed_Event07_04_SacrificeRabbit())
            {
                eventPanel2.SetActive(false);
                eventPanel9.SetActive(true);
                enemies1.SetActive(false);
                enemies2.SetActive(true);
            }
        }

        /// <summary>
        /// Event07_04_SacrificeRabbitのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event07_11_AskRyotaro(SaveController07 saveController)
        {
            if (saveController.completed_Event07_11_AskRyotaro())
            {
                eventPanel2.SetActive(false);
                enemies1.SetActive(false);
            }
        }

        /// <summary>
        /// Event07_05_FindSchoolのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event07_05_FindSchool(SaveController07 saveController)
        {
            if (saveController.completed_Event07_05_FindSchool())
            {
                eventPanel5.SetActive(false);
                eventPanel6.SetActive(true);
                eventPanel7.SetActive(true);

                hideField.SetActive(true);
                light1.SetActive(true);
                light2.SetActive(true);

                light1.transform.position =
                    new Vector3(
                            light1.transform.position.x,
                            movePoint6.transform.position.y + 5,
                            light1.transform.position.z
                        );
            }
        }

        /// <summary>
        /// Event07_06_FindLetter1のロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event07_06_FindLetter1(SaveController07 saveController)
        {
            if (saveController.completed_Event07_06_FindLetter1())
            {
                eventPanel6.SetActive(false);
                eventPanel8.SetActive(true);
                letter1.SetActive(false);
                ryotaro2.transform.position = MovePoint8.transform.position;
                ryotaro2.gameObject.SetActive(true);
            }
        }

        /// <summary>
        /// Event07_07_FindLetter2のロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event07_07_FindLetter2(SaveController07 saveController)
        {
            if (saveController.completed_Event07_07_FindLetter2())
            {
                if (saveController.completed_Event07_07_FindLetter2())
                {
                    eventPanel7.SetActive(false);
                    letter2.SetActive(false);
                }
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
            eventList = new Event07_99_GameOver(this).GetEventList();
            eventNo = 0;
        }
    }
}