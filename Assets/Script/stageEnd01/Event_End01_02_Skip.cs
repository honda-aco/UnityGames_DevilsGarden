using System.Collections.Generic;

namespace Assets.Script
{
    public class Event_End01_02_Skip
    {
        private EventController_End01 eventController_End01;

        public Event_End01_02_Skip(EventController_End01 eventController)
        {
            eventController_End01 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController_End01.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            return eventList;
        }

        private bool event1()
        {
            eventController_End01.loadScene(@"stage00");
            return true;
        }
    }
}