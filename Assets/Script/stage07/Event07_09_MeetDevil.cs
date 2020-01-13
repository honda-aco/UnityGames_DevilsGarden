using UnityEngine;
using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event07_09_MeetDevil : Event_ChangeBgm1
    {
        private EventController07 eventController07;

        public Event07_09_MeetDevil(EventController07 eventController) : base(eventController)
        {
            this.eventController07 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(eventController07.lightOff));
            eventList.Add(new EventController.eventProcess(event5));
            return eventList;
        }

        private bool event1()
        {
            eventController07.Smoke1.transform.position
                = new Vector3(
                        eventController07.Devil.transform.position.x,
                        eventController07.Smoke1.transform.position.y,
                        eventController07.Devil.transform.position.z);

            eventController07.Smoke1.gameObject.SetActive(true);
            eventController07.Smoke1.Play();
            return true;
        }

        private bool event2()
        {
            eventController07.Devil.gameObject.SetActive(true);
            return true;
        }

        private bool event3()
        {
            return eventController07.charaWalk(eventController07.Devil, eventController07.Player.gameObject, 30.0f);
        }

        private bool event4()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"見たぞ",
                        @"おまえ うさぎを殺したな",
                        @"殺したのは自分じゃないって？",
                        @"おまえだろ",
                        @"おまえがつれ出して" + System.Environment.NewLine +
                        @"おまえが死なせたんだから",
                        @"自分が何をしたのか分かっているのか？",
                        @"あれはオレのモノだ",
                        @"それを奪ったんだから" + System.Environment.NewLine +
                        @"おまえには代わりを差し出してもらう",
                        @"代わりの魂をな"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event5()
        {
            eventController07.loadScene(@"stage_end03");
            Charactor.Restart();
            return true;
        }
    }
}