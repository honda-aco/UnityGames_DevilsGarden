using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_08_01_MeetAunt : Event_ChangeBgm1
    {
        private EventController03 eventController03;

        public Event03_08_01_MeetAunt(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        public bool event1()
        {
            return eventController03.charaTurnaround(
                eventController03.MeikoAunt,
                eventController03.Player.gameObject);
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あんた 学生かい？",
                        @"だったら色々なウワサを耳にするだろうけど" + System.Environment.NewLine +
                        @"根拠のないウワサをうのみにしたらダメだよ",
                        @"何が本当かなんてわからないことが多いし" + System.Environment.NewLine +
                        @"ウソの方がつじつまが合うことも多いんだから",
                        @"説教くさくてごめんなさいね",
                        @"めいっ子がウワサに苦労してるから" + System.Environment.NewLine +
                        @"同じ年ごろの子にはつい言っちゃうのよ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide, 
                    CharaTalkController.Texture.talk_meiko_aunt,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }
    }
}