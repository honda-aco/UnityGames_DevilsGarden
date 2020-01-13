using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController_End05 : EventController
    {
        [SerializeField]
        private SkipButton_End05 skipButton;

        [SerializeField]
        private AudioSource soundEffect_Ok;

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
        private Charactor yuko;
        public Charactor Yuko
        {
            get { return yuko; }
        }

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
        private Charactor enemy1;
        public Charactor Enemy1
        {
            get { return enemy1; }
        }

        [SerializeField]
        private Charactor devil;
        public Charactor Devil
        {
            get { return devil; }
        }

        [SerializeField]
        private ParticleSystem smoke1;
        public ParticleSystem Smoke1
        {
            get { return smoke1; }
        }

        [SerializeField]
        private ParticleSystem duststorm1;
        public ParticleSystem DustStorm1
        {
            get { return duststorm1; }
        }

        [SerializeField]
        private Material skybox;
        public Material Skybox
        {
            get { return skybox; }
        }

        [SerializeField]
        private GameObject sepiafilter;
        public GameObject Sepiafilter
        {
            get { return sepiafilter; }
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

            skipButton.SetEventController(this);

            if (new SaveController00().completed_PlayButton())
            {
                skipButton.gameObject.SetActive(true);
            }
            else
            {
                SaveController_End05 saveController_End05 = new SaveController_End05();
                saveController_End05.save_Scene(SaveController.SceneNo.SceneEnd05, SaveController.PlaceNo.Place01);
            }
            eventList = new Event_End05_01_Ending(this).GetEventList();
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
            eventList = new Event_End05_02_Skip(this).GetEventList();
            eventNo = 0;
        }
    }
}