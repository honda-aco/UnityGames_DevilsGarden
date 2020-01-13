using System.Collections.Generic;

namespace Assets.Script
{
    public abstract class Event_MoveScene
    {
        protected EventController eventController;

        public Event_MoveScene(EventController eventController)
        {
            this.eventController = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(start);
            eventList.Add(event1);
            eventList.Add(end);
            return eventList;
        }

        public bool start()
        {
            Charactor.Pause();
            eventController.Player.Idle();
            eventController.MobileSingleStickControl.SetActive(false);
            return true;
        }
        
        public bool event1()
        {
            return eventController.lightOff();
        }

        abstract protected void eventSave();

        abstract protected void eventLoadScene();

        public bool end()
        {
            eventSave();
            eventLoadScene();
            Charactor.Restart();
            return true;
        }
    }
}