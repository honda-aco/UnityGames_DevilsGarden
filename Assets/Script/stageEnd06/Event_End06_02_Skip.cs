using System.Collections.Generic;

namespace Assets.Script
{
    public class Event_End06_02_Skip
    {
        private EventController_End06 eventController_End06;

        public Event_End06_02_Skip(EventController_End06 eventController)
        {
            eventController_End06 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController_End06.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            return eventList;
        }

        private bool event1()
        {
            eventController_End06.loadScene(@"stage00");
            return true;
        }
    }
}