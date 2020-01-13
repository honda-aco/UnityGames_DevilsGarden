using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController_End06 : EventController
    {
        [SerializeField]
        private SkipButton_End06 skipButton;

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
        private GameObject movePoint11;
        public GameObject MovePoint11
        {
            get { return movePoint11; }
        }

        [SerializeField]
        private GameObject movePoint12;
        public GameObject MovePoint12
        {
            get { return movePoint12; }
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
        private Charactor devil;
        public Charactor Devil
        {
            get { return devil; }
        }

        [SerializeField]
        private Charactor stranger;
        public Charactor Pervent
        {
            get { return stranger; }
        }

        [SerializeField]
        private ParticleSystem smoke1;
        public ParticleSystem Smoke1
        {
            get { return smoke1; }
        }

        [SerializeField]
        private ParticleSystem smoke2;
        public ParticleSystem Smoke2
        {
            get { return smoke2; }
        }

        [SerializeField]
        private ParticleSystem smoke3;
        public ParticleSystem Smoke3
        {
            get { return smoke3; }
        }

        [SerializeField]
        private ParticleSystem shockWave1;
        public ParticleSystem ShockWave1
        {
            get { return shockWave1; }
        }

        [SerializeField]
        private ParticleSystem shockWave2;
        public ParticleSystem ShockWave2
        {
            get { return shockWave2; }
        }

        [SerializeField]
        private ParticleSystem shockWave3;
        public ParticleSystem ShockWave3
        {
            get { return shockWave3; }
        }

        [SerializeField]
        private ParticleSystem shockWave4;
        public ParticleSystem ShockWave4
        {
            get { return shockWave4; }
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
                SaveController_End06 saveController_End06 = new SaveController_End06();
                saveController_End06.save_Scene(SaveController.SceneNo.SceneEnd06, SaveController.PlaceNo.Place01);
            }
            eventList = new Event_End06_01_Ending(this).GetEventList();
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
            eventList = new Event_End06_02_Skip(this).GetEventList();
            eventNo = 0;
        }
    }
}