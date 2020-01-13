using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event05_07_02_MeetDevil : Event_DeferredBgm
    {
        private EventController05 eventController05;

        public Event05_07_02_MeetDevil(EventController05 eventController) : base(eventController)
        {
            this.eventController05 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController.playEvent4Bgm_Begin));
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(end));
            eventList.Add(new EventController.eventProcess(eventController.playDefaultBgm));
            return eventList;
        }

        private bool event1()
        {
            return eventController05.charaTurnaround(eventController05.Devil, eventController05.Player.gameObject);
        }

        private bool event2()
        {
            return eventController05.playerTurnaround(eventController05.Devil.gameObject);
        }

        private bool event3()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"どうせ行きつく未来は同じなんだ" + System.Environment.NewLine +
                        @"悩む必要なんてないだろ"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }
    }
}