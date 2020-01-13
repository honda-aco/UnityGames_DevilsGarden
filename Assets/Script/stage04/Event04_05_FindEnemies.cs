using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class Event04_05_FindEnemies : Event_DeferredBgm
    {
        private EventController04 eventController04;

        public Event04_05_FindEnemies(EventController04 eventController) : base(eventController)
        {
            this.eventController04 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            eventController04.MainCamera.SetActive(false);
            eventController04.EventCamera1.SetActive(true);
            return true;
        }

        private bool event2()
        {
            eventController04.Effect1.transform.position = new Vector3(
                eventController04.Enemy1.transform.position.x,
                10.0f,
                eventController04.Enemy1.transform.position.z
            );
            eventController04.Effect1.gameObject.SetActive(true);
            eventController04.Effect1.Play();

            eventController04.Effect2.transform.position = new Vector3(
                eventController04.Enemy2.transform.position.x,
                10.0f,
                eventController04.Enemy2.transform.position.z
            );
            eventController04.Effect2.gameObject.SetActive(true);
            eventController04.Effect2.Play();
            return true;
        }

        private bool event3()
        {
            eventController04.Enemy1.gameObject.SetActive(true);
            eventController04.Enemy2.gameObject.SetActive(true);
            return true;
        }

        private bool event4()
        {
            return eventController04.charaTurnaround(eventController04.Enemy1, eventController04.Player.gameObject);
        }

        private bool event5()
        {
            return eventController04.charaTurnaround(eventController04.Enemy2, eventController04.Player.gameObject);
        }

        private bool event6()
        {
            eventController04.MainCamera.SetActive(true);
            eventController04.EventCamera1.SetActive(false);
            return true;
        }
    }
}