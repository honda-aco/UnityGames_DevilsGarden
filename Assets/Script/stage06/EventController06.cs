using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class EventController06 : EventController
    {
        [SerializeField]
        private GameObject eventPanel1;

        [SerializeField]
        private GameObject eventPanel2;

        [SerializeField]
        private GameObject entryPoint1;

        [SerializeField]
        private GameObject entryPoint2;

        private Dictionary<GameObject, List<eventProcess>> eventDictionary = new Dictionary<GameObject, List<eventProcess>>();

        public void Start()
        {
            base.Start();

            // イベント情報の設定
            setEventDictionary();

            // ステージの初期化
            initializeStage();
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
            eventDictionary.Add(eventPanel1, new Event06_01_MoveScene(this).GetEventList());
            eventDictionary.Add(eventPanel2, new Event06_02_MoveScene(this).GetEventList());
        }

        /// <summary>
        /// ステージの初期化
        /// </summary>
        private void initializeStage()
        {
            SaveController saveController = new SaveController();

            // データのロード
            SaveController.SceneNo[] scene = saveController.get_Scene();
            SaveController.PlaceNo place = saveController.get_Place();

            // プレイヤーの位置を設定する
            if (scene[0].Equals(SaveController.SceneNo.Scene03))
            {
                Player.transform.position = entryPoint1.transform.position;
                Player.transform.rotation = entryPoint1.transform.rotation;
                saveController.save_Scene(SaveController.SceneNo.Scene06, SaveController.PlaceNo.Place01);
            }
            else
            {
                Player.transform.position = entryPoint2.transform.position;
                Player.transform.rotation = entryPoint2.transform.rotation;
                saveController.save_Scene(SaveController.SceneNo.Scene06, SaveController.PlaceNo.Place02);
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

        /// <summary>
        /// ゲームオーバー
        /// </summary>
        private void execute_gameOver()
        {
            eventList = new Event06_99_GameOver(this).GetEventList();
            eventNo = 0;
        }
    }
}