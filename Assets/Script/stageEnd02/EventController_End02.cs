using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController_End02 : EventController
    {
        [SerializeField]
        private SkipButton_End02 skipButton;

        [SerializeField]
        private AudioSource soundEffect_Ok;

        [SerializeField]
        private GameObject entryPoint1;

        [SerializeField]
        private GameObject movePoint1;
        public GameObject MovePoint1
        {
            get { return movePoint1; }
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
        private Material skybox;
        public Material Skybox
        {
            get { return skybox; }
        }

        [SerializeField]
        private GameObject handinknife;
        public GameObject Handinknife
        {
            get { return handinknife; }
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
                SaveController_End02 saveController_End02 = new SaveController_End02();
                saveController_End02.save_Scene(SaveController.SceneNo.SceneEnd02, SaveController.PlaceNo.None);
            }
            eventList = new Event_End02_01_Ending(this).GetEventList();
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
            eventList = new Event_End02_02_Skip(this).GetEventList();
            eventNo = 0;
        }
    }
}