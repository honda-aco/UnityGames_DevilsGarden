using UnityEngine;
using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event07_03_StopSacrifice : Event_ChangeBgm1
    {
        private EventController07 eventController07;
        private SaveController05 saveController05 = new SaveController05();
        private SaveController07 saveController07 = new SaveController07();

        public Event07_03_StopSacrifice(EventController07 eventController) : base(eventController)
        {
            this.eventController07 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
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
                        @"やっぱりダメ" + System.Environment.NewLine +
                        @"何考えてるんだろう",
                        @"でも どうしようか",
                        @"だれか協力者がいてくれたら" + System.Environment.NewLine +
                        @"この状況を変えられるけれど",
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            eventController07.EventPanel4.SetActive(false);

            if (saveController05.completed_Event05_11_MeetRyotaro())
            {
                eventController07.EventPanel10.SetActive(true);
                eventController07.EventPanel11.SetActive(true);
            }
            else
            {
                eventController07.Mountains.SetActive(true);
                eventController07.EventPanel2.SetActive(true);
            }

            return true;
        }
    }
}