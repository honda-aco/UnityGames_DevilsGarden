using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController09 : EventController
    {
        [SerializeField]
        private GameObject eventPanel1;

        [SerializeField]
        private GameObject eventPanel2;

        [SerializeField]
        private GameObject eventPanel3;

        [SerializeField]
        private GameObject entryPoint1;

        [SerializeField]
        private Charactor yuko;
        public Charactor Yuko
        {
            get { return yuko; }
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

        /// <summary>
        /// EventDictionaryの設定
        /// </summary>
        private void setEventDictionary()
        {
            // イベント情報の設定
            eventDictionary.Add(eventPanel1, new Event09_01_Ending(this).GetEventList());
            eventDictionary.Add(eventPanel2, new Event09_02_Ending(this).GetEventList());
            eventDictionary.Add(eventPanel3, new Event09_03_Ending(this).GetEventList());
        }

        /// <summary>
        /// ステージの初期化
        /// </summary>
        private void initializeStage()
        {
            SaveController07 saveController07 = new SaveController07();

            // プレイヤーの位置を設定する
            Player.transform.position = entryPoint1.transform.position;
            Player.transform.rotation = entryPoint1.transform.rotation;
            saveController07.save_Scene(SaveController.SceneNo.Scene09, SaveController.PlaceNo.Place01);

            if (saveController07.get_KeyItem1Status() == SaveController.KeyItemStatus.Level_100
              && saveController07.get_KeyItem2Status() == SaveController.KeyItemStatus.Level_100
              && saveController07.get_KeyItem3Status() == SaveController.KeyItemStatus.Level_100)
            {
                eventPanel1.SetActive(false);
                eventPanel2.SetActive(false);
                eventPanel3.SetActive(true);
            }
            else if (saveController07.get_KeyItem1Status() == SaveController.KeyItemStatus.Level_100)
            {
                eventPanel1.SetActive(false);
                eventPanel2.SetActive(true);
                eventPanel3.SetActive(false);
            }
            else
            {
                eventPanel1.SetActive(true);
                eventPanel2.SetActive(false);
                eventPanel3.SetActive(false);
                yuko.gameObject.SetActive(false);
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
    }
}