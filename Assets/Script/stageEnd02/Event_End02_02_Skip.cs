using System.Collections.Generic;

namespace Assets.Script
{
    public class Event_End02_02_Skip
    {
        private EventController_End02 eventController_End02;

        public Event_End02_02_Skip(EventController_End02 eventController)
        {
            eventController_End02 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController_End02.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            return eventList;
        }

        private bool event1()
        {
            eventController_End02.loadScene(@"stage00");
            return true;
        }
    }
}