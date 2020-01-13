using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController08 : EventController
    {
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
        private GameObject mainCamera;
        public GameObject MainCamera
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
        private Charactor ryotaro;
        public Charactor Ryotaro
        {
            get { return ryotaro; }
        }

        private Dictionary<GameObject, List<eventProcess>> eventDictionary = new Dictionary<GameObject, List<eventProcess>>();

        public void Start()
        {
            base.Start();

            SaveController_End01 saveController_End01 = new SaveController_End01();
            saveController_End01.save_Scene(SaveController.SceneNo.Scene08, SaveController.PlaceNo.None);

            eventList = new Event08_01_MoveWorld(this).GetEventList();
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
    }
}