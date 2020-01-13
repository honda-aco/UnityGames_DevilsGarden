using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event01_01_Prologue
    {
        private EventController01 eventController;

        public Event01_01_Prologue(EventController01 eventController)
        {
            this.eventController = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event2));
            return eventList;
        }

        private bool event1()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"自覚したのは小学２年生のころだったと思う",
                        @"前の日の夢のことを母に話したら" + System.Environment.NewLine +
                        @"「同じ夢を見た」と言われたことがあった",
                        @"その時は偶然で済ませたけれど",
                        @"それからも" + System.Environment.NewLine +
                        @"夢に知り合いが現れることがあって",
                        @"本人に確認すると" + System.Environment.NewLine +
                        @"やはり同じ夢を見ていたという",
                        @"そういうことを何度か繰り返すうちに",
                        @"自分が他人の夢に入っているのだと気がついた",
                        @"見ている夢が「自分の夢」か「他人の夢」なのかは" + System.Environment.NewLine +
                        @"夢の中で夢だと気づけるかで区別できる",
                        @"夢だと気づければ他人の夢で" + System.Environment.NewLine +
                        @"夢だと気づけなければ自分の夢",
                        @"だから夢だと気づけるこの悪夢は" + System.Environment.NewLine +
                        @"きっと だれかの見ている夢で",
                        @"ほうっておいても" + System.Environment.NewLine +
                        @"すぐに覚めるものだと思っていた"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            return eventController.loadScene("stage02");
        }
    }
}