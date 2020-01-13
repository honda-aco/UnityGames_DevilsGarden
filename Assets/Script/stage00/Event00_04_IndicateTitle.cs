using System.Collections.Generic;

namespace Assets.Script
{
    public class Event00_04_IndicateTitle
    {
        private EventController00 eventController;

        public Event00_04_IndicateTitle(EventController00 eventController)
        {
            this.eventController = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            return eventList;
        }

        private bool event1()
        {
            if (eventController.Title3.color.a > 1.0f)
            {
                return true;
            }
            else
            {
                eventController.Title3.color = new UnityEngine.Color(
                                                                eventController.Title3.color.r, 
                                                                eventController.Title3.color.g, 
                                                                eventController.Title3.color.b, 
                                                                eventController.Title3.color.a + 0.002f);
                return false;
            }
        }

        private bool event2()
        {
            if (eventController.Title2.color.a > 1.0f)
            {
                return true;
            }
            else
            {
                eventController.Title2.color = new UnityEngine.Color(
                                                                eventController.Title2.color.r,
                                                                eventController.Title2.color.g,
                                                                eventController.Title2.color.b,
                                                                eventController.Title2.color.a + 0.002f);
                return false;
            }
        }
    }
}