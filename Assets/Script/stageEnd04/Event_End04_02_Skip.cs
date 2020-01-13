using System.Collections.Generic;

namespace Assets.Script
{
    public class Event_End04_02_Skip
    {
        private EventController_End04 eventController_End04;

        public Event_End04_02_Skip(EventController_End04 eventController)
        {
            eventController_End04 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController_End04.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            return eventList;
        }

        private bool event1()
        {
            eventController_End04.loadScene(@"stage00");
            return true;
        }
    }
}