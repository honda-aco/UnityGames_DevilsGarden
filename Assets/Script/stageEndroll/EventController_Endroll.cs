using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController_Endroll : EventController
    {
        [SerializeField]
        private SkipButton_Endroll skipButton;

        [SerializeField]
        private AudioSource soundEffect_Ok;

        [SerializeField]
        private GameObject endroll_text;

        [SerializeField]
        private GameObject movePoint_text;

        [SerializeField]
        private GameObject movePoint1_1;
        public GameObject MovePoint1_1
        {
            get { return movePoint1_1; }
        }

        [SerializeField]
        private GameObject movePoint1_2;
        public GameObject MovePoint1_2
        {
            get { return movePoint1_2; }
        }

        [SerializeField]
        private GameObject movePoint2_1;
        public GameObject MovePoint2_1
        {
            get { return movePoint2_1; }
        }

        [SerializeField]
        private GameObject movePoint2_2;
        public GameObject MovePoint2_2
        {
            get { return movePoint2_2; }
        }

        [SerializeField]
        private GameObject movePoint3_1;
        public GameObject MovePoint3_1
        {
            get { return movePoint3_1; }
        }

        [SerializeField]
        private GameObject movePoint3_2;
        public GameObject MovePoint3_2
        {
            get { return movePoint3_2; }
        }

        [SerializeField]
        private GameObject movePoint4_1;
        public GameObject MovePoint4_1
        {
            get { return movePoint4_1; }
        }

        [SerializeField]
        private GameObject movePoint4_2;
        public GameObject MovePoint4_2
        {
            get { return movePoint4_2; }
        }

        [SerializeField]
        private GameObject movePoint5_1;
        public GameObject MovePoint5_1
        {
            get { return movePoint5_1; }
        }

        [SerializeField]
        private GameObject movePoint5_2;
        public GameObject MovePoint5_2
        {
            get { return movePoint5_2; }
        }

        [SerializeField]
        private GameObject movePoint6_1;
        public GameObject MovePoint6_1
        {
            get { return movePoint6_1; }
        }

        [SerializeField]
        private GameObject movePoint6_2;
        public GameObject MovePoint6_2
        {
            get { return movePoint6_2; }
        }

        [SerializeField]
        private GameObject movePoint7_1;
        public GameObject MovePoint7_1
        {
            get { return movePoint7_1; }
        }

        [SerializeField]
        private GameObject movePoint7_2;
        public GameObject MovePoint7_2
        {
            get { return movePoint7_2; }
        }

        [SerializeField]
        private GameObject movePoint8_1;
        public GameObject MovePoint8_1
        {
            get { return movePoint8_1; }
        }

        [SerializeField]
        private GameObject movePoint8_2;
        public GameObject MovePoint8_2
        {
            get { return movePoint8_2; }
        }

        [SerializeField]
        private GameObject movePoint9_1;
        public GameObject MovePoint9_1
        {
            get { return movePoint9_1; }
        }

        [SerializeField]
        private GameObject movePoint9_2;
        public GameObject MovePoint9_2
        {
            get { return movePoint9_2; }
        }

        [SerializeField]
        private GameObject movePoint10_1;
        public GameObject MovePoint10_1
        {
            get { return movePoint10_1; }
        }

        [SerializeField]
        private GameObject movePoint10_2;
        public GameObject MovePoint10_2
        {
            get { return movePoint10_2; }
        }

        [SerializeField]
        private GameObject movePoint11_1;
        public GameObject MovePoint11_1
        {
            get { return movePoint11_1; }
        }

        [SerializeField]
        private GameObject movePoint11_2;
        public GameObject MovePoint11_2
        {
            get { return movePoint11_2; }
        }

        [SerializeField]
        private Camera mainCamera;
        public Camera MainCamera
        {
            get { return mainCamera; }
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

            skipButton.SetEventController(this);

            if (new SaveController00().completed_PlayButton())
            {
                skipButton.gameObject.SetActive(true);
            }
            eventList = new Event_Endroll_01_Ending(this).GetEventList();
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
            // エンドロールテキストの移動
            endroll_text.Move(movePoint_text.transform.position, 5.0f, 1.0f);
        }

        public void skip_Click()
        {
            soundEffect_Ok.Play();
            Time.timeScale = 1; // ふきだし表示中に割り込む必要がある
            eventList = new Event_Endroll_02_Skip(this).GetEventList();
            eventNo = 0;
        }
    }
}