using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event05_08_ArriveTrain : Event_ChangeBgm1
    {
        private EventController05 eventController05;

        public Event05_08_ArriveTrain(EventController05 eventController) : base(eventController)
        {
            this.eventController05 = eventController;
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
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"どうしよう" + System.Environment.NewLine +
                        @"今ならギリギリのりこめるけど……"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            eventController05.EventPanel9.SetActive(true);
            eventController05.EventPanel10.SetActive(true);
            return true;
        }
    }
}