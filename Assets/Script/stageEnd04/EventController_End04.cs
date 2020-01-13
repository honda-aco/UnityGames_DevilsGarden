using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController_End04 : EventController
    {
        [SerializeField]
        private SkipButton_End04 skipButton;

        [SerializeField]
        private AudioSource soundEffect_Ok;

        [SerializeField]
        private AudioSource bgmDefault;
        public AudioSource BgmDefault
        {
            get { return bgmDefault; }
        }

        [SerializeField]
        private AudioSource bgmEvent3;
        public AudioSource BgmEvent3
        {
            get { return bgmEvent3; }
        }

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
        private GameObject movePoint10;
        public GameObject MovePoint10
        {
            get { return movePoint10; }
        }

        [SerializeField]
        private Camera mainCamera;
        public Camera MainCamera
        {
            get { return mainCamera; }
        }

        [SerializeField]
        private Camera mainCamera2;
        public Camera MainCamera2
        {
            get { return mainCamera2; }
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
        private Charactor_End04 yucco;
        public Charactor_End04 Yucco
        {
            get { return yucco; }
        }

        [SerializeField]
        private Charactor meiko;
        public Charactor Meiko
        {
            get { return meiko; }
        }

        [SerializeField]
        private Charactor meiko2;
        public Charactor Meiko2
        {
            get { return meiko2; }
        }

        [SerializeField]
        private Charactor ryotaro;
        public Charactor Ryotaro
        {
            get { return ryotaro; }
        }

        [SerializeField]
        private GameObject enemy1;
        public GameObject Enemy1
        {
            get { return enemy1; }
        }

        [SerializeField]
        private Material skybox;
        public Material Skybox
        {
            get { return skybox; }
        }

        private Dictionary<GameObject, List<eventProcess>> eventDictionary = new Dictionary<GameObject, List<eventProcess>>();

        public void Start()
        {
            base.Start();

            skipButton.SetEventController(this);

            if (new SaveController00().completed_PlayButton())
            {
                skipButton.gameObject.SetActive(true);
            }
            else
            {
                SaveController_End04 saveController_End04 = new SaveController_End04();
                saveController_End04.save_Scene(SaveController.SceneNo.SceneEnd04, SaveController.PlaceNo.Place01);
            }
            eventList = new Event_End04_01_Ending(this).GetEventList();
            eventNo = 0;
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
        }

        public void skip_Click()
        {
            soundEffect_Ok.Play();
            Time.timeScale = 1; // ふきだし表示中に割り込む必要がある
            eventList = new Event_End04_02_Skip(this).GetEventList();
            eventNo = 0;
        }
    }
}