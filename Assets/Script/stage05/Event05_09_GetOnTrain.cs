using System.Collections.Generic;

namespace Assets.Script
{
    public class Event05_09_GetOnTrain : Event_ChangeBgm1
    {
        private EventController05 eventController05;

        public Event05_09_GetOnTrain(EventController05 eventController) : base(eventController)
        {
            this.eventController05 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(eventController05.lightOff));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(eventController05.lightOn));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(eventController05.lightOff));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(eventController05.lightOn));
            eventList.Add(new EventController.eventProcess(eventController05.lightOff));
            eventList.Add(new EventController.eventProcess(event5));

            return eventList;
        }

        private bool event2()
        {
            eventController05.MainCamera.gameObject.SetActive(false);
            eventController05.EventCamera2.gameObject.SetActive(true);
            eventController05.EventCamera2.orthographicSize = 70.0f;
            return true;
        }

        private bool event3()
        {
            return eventController05.playerRun(eventController05.MovePoint7_1);
        }

        private bool event4()
        {
            eventController05.Player.transform.position = eventController05.MovePoint7_2.transform.position;
            eventController05.Player.transform.localRotation = eventController05.MovePoint7_2.transform.localRotation;
            return true;
        }

        private bool event5()
        {
            eventController05.loadScene(@"stage_end01");
            Charactor.Restart();
            return true;
        }
    }
}