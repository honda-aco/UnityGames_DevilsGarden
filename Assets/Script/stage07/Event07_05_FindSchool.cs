using UnityEngine;
using System.Collections.Generic;

namespace Assets.Script
{
    public class Event07_05_FindSchool : Event_DeferredBgm
    {
        private EventController07 eventController07;

        public Event07_05_FindSchool(EventController07 eventController) : base(eventController)
        {
            this.eventController07 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(eventController07.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController07.lightOn));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(eventController07.lightOff));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(eventController07.lightOn));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            eventController07.Light2.SetActive(true);
            eventController07.Land9.SetActive(true);
            eventController07.HideField.SetActive(true);
            eventController07.Poison1.SetActive(false);
            eventController07.Poison2.SetActive(true);
            eventController07.MainCamera.gameObject.SetActive(false);
            eventController07.EventCamera2.gameObject.SetActive(true);
            return true;
        }

        private bool event2()
        {
            eventController07.Light1.SetActive(true);
            return eventController07.Light1.Move(
                new Vector3(
                    eventController07.Light1.transform.position.x,
                    eventController07.MovePoint6.transform.position.y,
                    eventController07.Light1.transform.position.z),
                5.0f,
                1.0f);
        }

        private bool event3()
        {
            SaveController07 saveController07 = new SaveController07();
            saveController07.complete_Event07_05_FindSchool();

            eventController07.MainCamera.gameObject.SetActive(true);
            eventController07.EventCamera2.gameObject.SetActive(false);
            eventController07.HideField.SetActive(true);
            eventController07.EventPanel6.SetActive(true);
            eventController07.EventPanel7.SetActive(true);
            return true;
        }
    }
}