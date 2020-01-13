using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController_End03 : EventController
    {
        [SerializeField]
        private SkipButton_End03 skipButton;

        [SerializeField]
        private AudioSource soundEffect_Ok;

        [SerializeField]
        private GameObject movePoint1;
        public GameObject MovePoint1
        {
            get { return movePoint1; }
        }

        [SerializeField]
        private GameObject movePoint1_2;
        public GameObject MovePoint1_2
        {
            get { return movePoint1_2; }
        }

        [SerializeField]
        private GameObject movePoint1_3;
        public GameObject MovePoint1_3
        {
            get { return movePoint1_3; }
        }

        [SerializeField]
        private GameObject movePoint2;
        public GameObject MovePoint2
        {
            get { return movePoint2; }
        }

        [SerializeField]
        private GameObject movePoint2_2;
        public GameObject MovePoint2_2
        {
            get { return movePoint2_2; }
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
        private Camera eventCamera1;
        public Camera EventCamera1
        {
            get { return eventCamera1; }
        }

        [SerializeField]
        private Charactor devil;
        public Charactor Devil
        {
            get { return devil; }
        }

        [SerializeField]
        private GameObject birdbox1;
        public GameObject Birdbox1
        {
            get { return birdbox1; }
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
                SaveController_End03 saveController_End03 = new SaveController_End03();
                saveController_End03.save_Scene(SaveController.SceneNo.SceneEnd03, SaveController.PlaceNo.None);
            }
            eventList = new Event_End03_01_Ending(this).GetEventList();
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
            eventList = new Event_End03_02_Skip(this).GetEventList();
            eventNo = 0;
        }
    }
}