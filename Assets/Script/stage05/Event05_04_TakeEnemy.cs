using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event05_04_TakeEnemy : Event_DeferredBgm
    {
        private EventController05 eventController05;

        private bool result1_1 = false;
        private bool result1_2 = false;
        private bool result2 = false;
        private bool result3_1 = false;
        private bool result3_2 = false;
        private bool result4_1 = false;
        private bool result4_2 = false;

        public Event05_04_TakeEnemy(EventController05 eventController) : base(eventController)
        {
            this.eventController05 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            eventController05.Player.gameObject.SetActive(false);
            return true;
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"きゃー！！！"
                    },
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Texture.talk_girl
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event3()
        {
            if (result1_1)
            {
                result1_2 = eventController05.charaWalk(eventController05.Classmate1, eventController05.MovePoint1_2);
            }
            else
            {
                result1_1 = eventController05.charaWalk(eventController05.Classmate1, eventController05.MovePoint1_1);
            }

            result2 = eventController05.charaWalk(eventController05.Classmate2, eventController05.MovePoint2);

            if (result3_1)
            {
                result3_2 = eventController05.charaWalk(eventController05.Classmate3, eventController05.MovePoint3_2);
            }
            else
            {
                result3_1 = eventController05.charaWalk(eventController05.Classmate3, eventController05.MovePoint3_1);
            }

            return result1_1 && result1_2 && result2 && result3_1 && result3_2;
        }

        private bool event4()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"待てえええええええ！！！！！！！！！！"
                    },
                    CharaTalkController.Texture.talk_enemy,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event5()
        {
            if (result4_1)
            {
                result4_2 = eventController05.charaRun(eventController05.Enemy1, eventController05.MovePoint4_2);
            }
            else
            {
                result4_1 = eventController05.charaRun(eventController05.Enemy1, eventController05.MovePoint4_1);
            }

            return result4_1 && result4_2;
        }

        private bool event6()
        {
            // イベント完了を保存
            SaveController05 saveController05 = new SaveController05();
            saveController05.complete_Event05_04_TakeEnemy();

            eventController05.EventPanel6.SetActive(true);
            eventController05.Player.gameObject.SetActive(true);
            eventController05.Enemy1.gameObject.SetActive(false);
            eventController05.Classmate1.gameObject.SetActive(false);
            eventController05.Classmate3.gameObject.SetActive(false);
            return true;
        }
    }
}