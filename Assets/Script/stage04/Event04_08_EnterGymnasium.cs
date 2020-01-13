using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class Event04_08_EnterGymnasium : Event_DeferredBgm
    {
        private EventController04 eventController04;

        public Event04_08_EnterGymnasium(EventController04 eventController) : base(eventController)
        {
            this.eventController04 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event1_1));
            eventList.Add(new EventController.eventProcess(event1_2));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1_1()
        {
            eventController04.Gymnasium.transform.position = new Vector3(
                eventController04.Gymnasium.transform.position.x - 10f,
                eventController04.Gymnasium.transform.position.y,
                eventController04.Gymnasium.transform.position.z
            );

            return true;
        }

        private bool event1_2()
        {
            eventController04.Gymnasium.transform.position = new Vector3(
                eventController04.Gymnasium.transform.position.x + 10f,
                eventController04.Gymnasium.transform.position.y,
                eventController04.Gymnasium.transform.position.z
            );

            return true;
        }

        private bool event2()
        {
            eventController04.Gymnasium.SetActive(false);
            return true;
        }

        private bool event3()
        {
            // イベント完了を保存
            SaveController04 saveController04 = new SaveController04();
            saveController04.complete_Event04_08_EnterGymnasium();
            return true;
        }
    }
}