using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController_End01 : EventController
    {
        [SerializeField]
        private SkipButton_End01 skipButton;

        [SerializeField]
        private AudioSource soundEffect_Ok;

        [SerializeField]
        private Camera eventCamera1;
        public Camera EventCamera1
        {
            get { return eventCamera1; }
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
                SaveController08 saveController08 = new SaveController08();
                saveController08.save_Scene(SaveController.SceneNo.SceneEnd01, SaveController.PlaceNo.None);
            }
            eventList = new Event_End01_01_Ending(this).GetEventList();
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
            eventList = new Event_End01_02_Skip(this).GetEventList();
            eventNo = 0;
        }
    }
}