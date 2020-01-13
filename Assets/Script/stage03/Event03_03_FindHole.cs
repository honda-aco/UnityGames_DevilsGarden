using System.Collections.Generic;

namespace Assets.Script
{
    public class Event03_03_FindHole
    {
        private EventController03 eventController;

        public Event03_03_FindHole(EventController03 eventController)
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
            if (new SaveController03().completed_Event03_04_01_FindHole() == false &&
                new SaveController04().completed_Event04_09_FindBusstop() == false &&
                new SaveController08().completed_Event08_01_MoveWorld() == false)
            {
                eventController.Ryotaro.gameObject.SetActive(true);
            }

            eventController.IvyWall3.SetActive(false);
            return true;
        }
    }
}