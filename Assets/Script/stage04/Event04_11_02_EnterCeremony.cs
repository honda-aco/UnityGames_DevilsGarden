using System.Collections.Generic;

namespace Assets.Script
{
    public class Event04_11_02_EnterCeremony
    {
        private EventController04 eventController;
        private SaveController04 saveContoller04 = new SaveController04();

        public Event04_11_02_EnterCeremony(EventController04 eventController)
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
            eventController.EventPanel11_1.SetActive(true);
            eventController.EventPanel11_2_1.SetActive(false);
            eventController.EventPanel11_2_2.SetActive(false);
            eventController.EventPanel11_2_3.SetActive(false);
            eventController.EventPanel11_2_4.SetActive(false);
            return true;
        }
    }
}