using System.Collections.Generic;

namespace Assets.Script
{
    public class Event_Endroll_02_Skip
    {
        private EventController_Endroll eventController_Endroll;

        public Event_Endroll_02_Skip(EventController_Endroll eventController)
        {
            eventController_Endroll = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController_Endroll.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            return eventList;
        }

        private bool event1()
        {
            eventController_Endroll.loadScene(@"stage00");
            return true;
        }
    }
}