using UnityEngine;
using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event07_04_SacrificeRabbit : Event_ChangeBgm2
    {
        private EventController07 eventController07;

        public Event07_04_SacrificeRabbit(EventController07 eventController) : base(eventController)
        {
            this.eventController07 = eventController;
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
            eventList.Add(new EventController.eventProcess(eventController07.lightOff));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(eventController07.lightOn));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"大丈夫" + System.Environment.NewLine +
                        @"どうせただの夢なんだ",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            eventController07.Rabbit.transform.position
                = new Vector3(
                        eventController07.Player.transform.position.x,
                        eventController07.Rabbit.transform.position.y,
                        eventController07.Player.transform.position.z - 10
                        );
            eventController07.Rabbit.gameObject.SetActive(true);
            return true;
        }

        private bool event3()
        {
            return eventController07.charaTurnaround(eventController07.Rabbit, eventController07.Player.gameObject);
        }

        private bool event4()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ごめんね" + System.Environment.NewLine +
                        @"どうしてもこの先に進みたいの",
                        @"行って！"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event5()
        {
            return eventController07.charaWalk(eventController07.Rabbit, eventController07.MovePoint4);
        }

        private bool event6()
        {
            return eventController07.charaWalk(eventController07.Rabbit, eventController07.MovePoint2);
        }

        private bool event7()
        {
            SaveController07 saveController07 = new SaveController07();
            saveController07.complete_Event07_04_SacrificeRabbit();

            eventController07.Mountains.SetActive(true);
            eventController07.Enemies1.SetActive(false);
            eventController07.Enemies2.SetActive(true);
            eventController07.Rabbit.gameObject.SetActive(false);

            eventController07.EventPanel3.SetActive(false);
            eventController07.EventPanel9.SetActive(true);
            return true;
        }
    }
}