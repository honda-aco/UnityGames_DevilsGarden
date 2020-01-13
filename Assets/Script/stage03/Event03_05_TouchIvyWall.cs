using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_05_TouchIvyWall : Event_DeferredBgm
    {
        private EventController03 eventController03;

        public Event03_05_TouchIvyWall(EventController03 eventController) : base(eventController)
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
                        @"ツタであふれかえってる" + System.Environment.NewLine +
                        @"これじゃあ通り抜けられない"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            eventController03.EventPanel5.SetActive(false);
            eventController03.EventPanel6_1.SetActive(false);
            eventController03.EventPanel6_2.SetActive(false);
            return true;
        }
    }
}