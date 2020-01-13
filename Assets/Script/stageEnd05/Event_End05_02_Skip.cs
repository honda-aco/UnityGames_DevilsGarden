using System.Collections.Generic;

namespace Assets.Script
{
    public class Event_End05_02_Skip
    {
        private EventController_End05 eventController_End05;

        public Event_End05_02_Skip(EventController_End05 eventController)
        {
            eventController_End05 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController_End05.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            return eventList;
        }

        private bool event1()
        {
            eventController_End05.loadScene(@"stage00");
            return true;
        }
    }
}