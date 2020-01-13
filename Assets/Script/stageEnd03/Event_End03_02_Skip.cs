using System.Collections.Generic;

namespace Assets.Script
{
    public class Event_End03_02_Skip
    {
        private EventController_End03 eventController_End03;

        public Event_End03_02_Skip(EventController_End03 eventController)
        {
            eventController_End03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController_End03.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            return eventList;
        }

        private bool event1()
        {
            eventController_End03.loadScene(@"stage00");
            return true;
        }
    }
}