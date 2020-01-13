using System.Collections.Generic;

namespace Assets.Script
{
    public class Event03_02_FindHole
    {
        private EventController03 eventController;

        public Event03_02_FindHole(EventController03 eventController)
        {
            this.eventController = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(event1));
            return eventList;
        }

        private bool event1()
        {
            eventController.IvyWall2.SetActive(false);
            return true;
        }
    }
}