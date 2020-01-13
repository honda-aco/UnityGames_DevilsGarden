using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController03 : EventController
    {
        [SerializeField]
        private Charactor meiko;
        public Charactor Meiko
        {
            get { return meiko; }
        }

        [SerializeField]
        private Charactor ryotaro;
        public Charactor Ryotaro
        {
            get { return ryotaro; }
        }

        [SerializeField]
        private Charactor father;
        public Charactor Father
        {
            get { return father; }
        }

        [SerializeField]
        private Charactor meikoAunt;
        public Charactor MeikoAunt
        {
            get { return meikoAunt; }
        }

        [SerializeField]
        private Charactor devil;
        public Charactor Devil
        {
            get { return devil; }
        }

        [SerializeField]
        private Charactor stranger;
        public Charactor Stranger
        {
            get { return stranger; }
        }

        [SerializeField]
        private Charactor stranger2;
        public Charactor Stranger2
        {
            get { return stranger2; }
        }

        [SerializeField]
        private GameObject eventPanel1;

        [SerializeField]
        private GameObject eventPanel2;

        [SerializeField]
        private GameObject eventPanel3;

        [SerializeField]
        private GameObject eventPanel4_1;

        [SerializeField]
        private GameObject eventPanel4_2;

        [SerializeField]
        private GameObject eventPanel4_3;

        [SerializeField]
        private GameObject eventPanel5;
        public GameObject EventPanel5
        {
            get { return eventPanel5; }
        }

        [SerializeField]
        private GameObject eventPanel6_1;
        public GameObject EventPanel6_1
        {
            get { return eventPanel6_1; }
        }

        [SerializeField]
        private GameObject eventPanel6_2;
        public GameObject EventPanel6_2
        {
            get { return eventPanel6_2; }
        }

        [SerializeField]
        private GameObject eventPanel7;
        public GameObject EventPanel7
        {
            get { return eventPanel7; }
        }

        [SerializeField]
        private GameObject eventPanel8;

        [SerializeField]
        private GameObject eventPanel9;

        [SerializeField]
        private GameObject eventPanel9_2;

        [SerializeField]
        private GameObject eventPanel10;

        [SerializeField]
        private GameObject eventPanel11;

        [SerializeField]
        private GameObject eventPanel11_2;
        public GameObject EventPanel11_2
        {
            get { return eventPanel11_2; }
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
        private GameObject blood_ryotaro;

        [SerializeField]
        private ParticleSystem smoke1;
        public ParticleSystem Smoke1
        {
            get { return smoke1; }
        }

        [SerializeField]
        private GameObject ivyWall1;
        public GameObject IvyWall1
        {
            get { return ivyWall1; }
        }

        [SerializeField]
        private GameObject ivyWall2;
        public GameObject IvyWall2
        {
            get { return ivyWall2; }
        }

        [SerializeField]
        private GameObject ivyWall3;
        public GameObject IvyWall3
        {
            get { return ivyWall3; }
        }

        [SerializeField]
        private GameObject schoolBug;
        public GameObject SchoolBug
        {
            get { return schoolBug; }
        }

        [SerializeField]
        private GameObject treasureChest;
        public GameObject TreasureChest
        {
            get { return treasureChest; }
        }

        private Dictionary<GameObject, List<eventProcess>> eventDictionary = new Dictionary<GameObject, List<eventProcess>>();

        public void Start()
        {
            base.Start();

            // イベント情報の設定
            setEventDictionary();

            // ステージの初期化
            initializeStage();

            // めいと会っていなければ会わせる
            SaveController02 saveController02 = new SaveController02();
            if (saveController02.completed_Event02_05_MeetMeiko() == false)
            {
                eventList = new Event03_00_MeetMeiko(this).GetEventList();
            }
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
            eventDictionary.Add(eventPanel1, new Event03_01_FindHole(this).GetEventList());
            eventDictionary.Add(eventPanel2, new Event03_02_FindHole(this).GetEventList());
            eventDictionary.Add(eventPanel3, new Event03_03_FindHole(this).GetEventList());
            eventDictionary.Add(eventPanel4_1, new Event03_04_01_FindHole(this).GetEventList());
            eventDictionary.Add(eventPanel4_2, new Event03_04_02_FindHole(this).GetEventList());
            eventDictionary.Add(eventPanel4_3, new Event03_04_03_FindHole(this).GetEventList());
            eventDictionary.Add(eventPanel5, new Event03_05_TouchIvyWall(this).GetEventList());
            eventDictionary.Add(eventPanel6_1, new Event03_05_TouchIvyWall(this).GetEventList());
            eventDictionary.Add(eventPanel6_2, new Event03_05_TouchIvyWall(this).GetEventList());
            eventDictionary.Add(eventPanel7, new Event03_06_MeetFather(this).GetEventList());
            eventDictionary.Add(eventPanel8, new Event03_07_FindSchoolBug(this).GetEventList());
            eventDictionary.Add(eventPanel9, new Event03_08_01_MeetAunt(this).GetEventList());
            eventDictionary.Add(eventPanel9_2, new Event03_08_02_MeetAunt(this).GetEventList());
            eventDictionary.Add(eventPanel10, new Event03_09_MeetDevil(this).GetEventList());
            eventDictionary.Add(eventPanel11, new Event03_10_01_MeetStranger(this).GetEventList());
            eventDictionary.Add(eventPanel11_2, new Event03_10_02_ChaseStranger(this).GetEventList());
            eventDictionary.Add(eventPanel12, new Event03_11_FindGrave(this).GetEventList());
            eventDictionary.Add(eventPanel13, new Event03_12_MoveScene(this).GetEventList());
            eventDictionary.Add(eventPanel14, new Event03_13_MoveScene(this).GetEventList());
            eventDictionary.Add(eventPanel15, new Event03_14_MoveScene(this).GetEventList());
        }

        /// <summary>
        /// ステージの初期化
        /// </summary>
        private void initializeStage()
        {
            SaveController03 saveController03 = new SaveController03();

            // データのロード
            SaveController.SceneNo[] scene = saveController03.get_Scene();
            SaveController.PlaceNo place = saveController03.get_Place();

            // プレイヤーの位置を設定する
            if (scene[0].Equals(SaveController.SceneNo.Scene08))
            {
                Player.transform.position = entryPoint4.transform.position;
                Player.transform.rotation = entryPoint4.transform.rotation;
                saveController03.save_Scene(SaveController.SceneNo.Scene03, SaveController.PlaceNo.Place04);
            }
            else if(scene[0].Equals(SaveController.SceneNo.Scene03) &&
               (place.Equals(SaveController.PlaceNo.Place02)))
            {
                Player.transform.position = entryPoint2.transform.position;
                Player.transform.rotation = entryPoint2.transform.rotation;
                saveController03.save_Scene(SaveController.SceneNo.Scene03, SaveController.PlaceNo.Place02);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene03) &&
                    (place.Equals(SaveController.PlaceNo.Place03)))
            {
                Player.transform.position = entryPoint3.transform.position;
                Player.transform.rotation = entryPoint3.transform.rotation;
                saveController03.save_Scene(SaveController.SceneNo.Scene03, SaveController.PlaceNo.Place03);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene03) &&
                    (place.Equals(SaveController.PlaceNo.Place04)))
            {
                Player.transform.position = entryPoint4.transform.position;
                Player.transform.rotation = entryPoint4.transform.rotation;
                saveController03.save_Scene(SaveController.SceneNo.Scene03, SaveController.PlaceNo.Place04);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene04) &&
                    (place.Equals(SaveController.PlaceNo.Place01)))
            {
                Player.transform.position = entryPoint2.transform.position;
                Player.transform.rotation = entryPoint2.transform.rotation;
                saveController03.save_Scene(SaveController.SceneNo.Scene03, SaveController.PlaceNo.Place02);
            }
            else if (scene[0].Equals(SaveController.SceneNo.Scene06))
            {
                Player.transform.position = entryPoint3.transform.position;
                Player.transform.rotation = entryPoint3.transform.rotation;
                saveController03.save_Scene(SaveController.SceneNo.Scene03, SaveController.PlaceNo.Place03);
            }
            else
            {
                Player.transform.position = entryPoint1.transform.position;
                Player.transform.rotation = entryPoint1.transform.rotation;
                saveController03.save_Scene(SaveController.SceneNo.Scene03, SaveController.PlaceNo.Place01);
            }

            load_Event03_04_FindHole(saveController03);
            // 父親は子どものイベント（Event03_04_FindHole）が完了するまで何度もイベントが発生してよい
            // load_Event03_06_MeetFather(saveController);
            load_Event03_07_FindSchoolBug(saveController03);
            //load_Event03_08_MeetAunt(saveController03);
            load_Event03_09_MeetDevil(saveController03);
            load_Event03_10_MeetStranger(saveController03);
        }

        /// <summary>
        /// Event03_04_FindHoleのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event03_04_FindHole(SaveController03 saveController)
        {
            SaveController08 saveController08 = new SaveController08();
            // ラストイベント直前の場合
            if (saveController08.completed_Event08_01_MoveWorld())
            {
                eventPanel4_1.SetActive(false);
                ryotaro.gameObject.SetActive(false);

                eventPanel7.SetActive(false);
                father.gameObject.SetActive(false);

                // イベントを終えていない
                if (saveController.completed_Event03_04_03_FindHole() == false)
                {
                    eventPanel4_3.SetActive(true);

                    // 通常のりょうたろうイベントを終えている場
                    if (saveController.completed_Event03_04_01_FindHole())
                    {
                        treasureChest.SetActive(true);
                    }
                }
            }
            else
            {
                // 通常のりょうたろうイベントを終えている場合
                if (saveController.completed_Event03_04_01_FindHole())
                {
                    eventPanel4_1.SetActive(false);
                    ryotaro.gameObject.SetActive(false);

                    eventPanel7.SetActive(false);
                    father.gameObject.SetActive(false);
                }
                else
                {
                    // りょうたろうと会うイベントを行う前にゆい子と会っている場合
                    SaveController04 saveController04 = new SaveController04();
                    if (saveController04.completed_Event04_09_FindBusstop())
                    {
                        blood_ryotaro.SetActive(true);
                        eventPanel4_1.SetActive(false);
                        eventPanel4_2.SetActive(true);
                    }
                }
            }
        }

        /// <summary>
        /// Event03_07_FindSchoolBugのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event03_07_FindSchoolBug(SaveController03 saveController)
        {
            if (saveController.completed_Event03_07_FindSchoolBug())
            {
                schoolBug.SetActive(false);
                eventPanel8.SetActive(false);
            }
        }

        ///// <summary>
        ///// Event03_08_MeetAuntのロード
        ///// </summary>
        ///// <param name="saveController"></param>
        //private void load_Event03_08_MeetAunt(SaveController03 saveController)
        //{
        //    if (saveController.completed_Event03_08_MeetAunt())
        //    {
        //        eventPanel9.SetActive(false);
        //    }
        //}

        /// <summary>
        /// Event03_09_MeetDevilのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event03_09_MeetDevil(SaveController03 saveController)
        {
            if (saveController.completed_Event03_09_MeetDevil())
            {
                eventPanel10.SetActive(false);
            }

            //SaveController05 saveController05 = new SaveController05();
            //if (saveController05.completed_Event05_07_01_MeetDevil())
            //{
            //    eventPanel10.SetActive(false);
            //}
        }

        /// <summary>
        /// Event03_10_MeetStrangerのロード
        /// </summary>
        /// <param name="saveController"></param>
        private void load_Event03_10_MeetStranger(SaveController03 saveController)
        {
            if (saveController.completed_Event03_10_MeetStranger())
            {
                eventPanel11.SetActive(false);
                eventPanel11_2.SetActive(true);
            }
        }

        ///// <summary>
        ///// Event03_11_FindGraveのロード
        ///// </summary>
        ///// <param name="saveController"></param>
        //private void load_Event03_11_FindGrave(SaveController03 saveController)
        //{
        //    if (saveController.completed_Event03_11_FindGrave())
        //    {
        //        eventPanel12.SetActive(false);
        //    }
        //}

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
            eventList = new Event03_99_GameOver(this).GetEventList();
            eventNo = 0;
        }
    }
}