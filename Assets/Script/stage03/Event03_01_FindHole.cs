using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_01_FindHole : Event_DeferredBgm
    {
        private EventController03 eventController03;

        public Event03_01_FindHole(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"よく見ると けもの道のような空間がある",
                        @"入ってみよう"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            // けもの道を通る際に「通り抜けられない」メッセージが表示されることを回避
            eventController03.EventPanel5.SetActive(false);
            eventController03.IvyWall1.SetActive(false);
            return true;
        }
    }
}