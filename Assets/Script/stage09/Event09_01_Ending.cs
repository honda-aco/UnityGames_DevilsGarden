using System.Collections.Generic;

namespace Assets.Script
{
    public class Event09_01_Ending : Event_DeferredBgm
    {
        private EventController09 eventController09;

        public Event09_01_Ending(EventController09 eventController) : base(eventController)
        {
            this.eventController09 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(eventController09.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            return eventList;
        }

        private bool event1()
        {
            eventController09.loadScene(@"stage_end04");
            Charactor.Restart();
            return true;
        }
    }
}