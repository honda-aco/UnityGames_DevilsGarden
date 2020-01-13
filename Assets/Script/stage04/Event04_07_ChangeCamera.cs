using System.Collections.Generic;

namespace Assets.Script
{
    public class Event04_07_ChangeCamera : Event_DeferredBgm
    {
        private EventController04 eventController04;

        public Event04_07_ChangeCamera(EventController04 eventController) : base(eventController)
        {
            this.eventController04 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(eventController04.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController04.lightOn));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            eventController04.EventCamera2.SetActive(false);
            eventController04.MainCamera.SetActive(true);
            eventController04.Player.MainCamera = eventController04.MainCamera;
            eventController04.resetPosition_Joystick();
            eventController04.EventPanel6.SetActive(true);
            return true;
        }
    }
}