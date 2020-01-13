using UnityEngine;
using System.Collections.Generic;

namespace Assets.Script
{
    public class Event05_10_GetOffTrain : Event_DeferredBgm
    {
        private EventController05 eventController05;
        private SaveController05 saveController05;

        public Event05_10_GetOffTrain(EventController05 eventController) : base(eventController)
        {
            this.eventController05 = eventController;
            saveController05 = new SaveController05();
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(end));

            return eventList;
        }

        private bool event1()
        {
            eventController05.MainCamera.gameObject.SetActive(false);
            eventController05.EventCamera2.gameObject.SetActive(true);
            return true;
        }

        private bool event2()
        {
            return eventController05.Train1.Move(
                        new Vector3(
                            eventController05.MovePoint6_2.transform.position.x,
                            eventController05.Train1.transform.position.y,
                            eventController05.MovePoint6_2.transform.position.z),
                        5.0f,
                        2.0f);
        }

        private bool event3()
        {
            eventController05.Train1.SetActive(false);
            return true;
        }

        private bool event4()
        {
            // イベント完了を保存
            SaveController05 saveController05 = new SaveController05();
            saveController05.complete_Event05_10_GetOffTrain();

            eventController05.EventPanel9.SetActive(false);
            eventController05.EventPanel11.SetActive(true);
            eventController05.MainCamera.gameObject.SetActive(true);
            eventController05.EventCamera2.gameObject.SetActive(false);
            return true;
        }
    }
}