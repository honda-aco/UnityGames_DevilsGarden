using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_10_02_ChaseStranger : Event_DeferredBgm
    {
        private EventController03 eventController03;

        public Event03_10_02_ChaseStranger(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(eventController03.lightOff));
            eventList.Add(new EventController.eventProcess(eventController03.playEvent2Bgm_Begin));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController03.lightOn));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            eventController03.MainCamera.gameObject.SetActive(false);
            eventController03.EventCamera3.gameObject.SetActive(true);
            eventController03.Player.transform.position = eventController03.MovePoint7.transform.position;
            eventController03.Player.transform.rotation = eventController03.MovePoint7.transform.rotation;
            return true;
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"このあたりへ歩いて行ったと思うんだけど……",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event3()
        {
            return eventController03.playerTurnaround(eventController03.MovePoint8, 0.05f);
        }

        private bool event4()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"もう帰ったのかな",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event5()
        {
            eventController03.Stranger2.gameObject.SetActive(true);
            return true;
        }

        public bool event6()
        {
            return eventController03.charaWalk(eventController03.Stranger2, eventController03.Player.gameObject);
        }

        private bool event7()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あ",
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event8()
        {
            eventController03.Player.transform.rotation = new UnityEngine.Quaternion(
                eventController03.Player.transform.rotation.x + 0.01f,
                eventController03.Player.transform.rotation.y,
                eventController03.Player.transform.rotation.z,
                eventController03.Player.transform.rotation.w);

            eventController03.playerDead();
            return true;
        }
    }
}