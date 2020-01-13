using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event05_06_TalkClassmate : Event_ChangeBgm1
    {
        private EventController05 eventController05;

        public Event05_06_TalkClassmate(EventController05 eventController) : base(eventController)
        {
            this.eventController05 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(end));

            return eventList;
        }

        private bool event1()
        {
            return eventController05.charaTurnaround(eventController05.Classmate2, eventController05.Player.gameObject);
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"きゃっ！びっくりした",
                        @"さっきの話 どこまで聞いてた？",
                        @"みんなは関係ないっていうけど" + System.Environment.NewLine +
                        @"やっぱり罪悪感あるよ",
                        @"わたしたちが意地悪しなければ" + System.Environment.NewLine +
                        @"あんな事件起きなかったんだから……",
                        @"本当にちょっとした意地悪のつもりだったの",
                        @"ケンカの理由も大したことじゃなくて",
                        @"ただ まわりに流されない感じが" + System.Environment.NewLine +
                        @"気に入らなかっただけ",
                        @"今さら後悔しても遅いよね"
                    },
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event3()
        {
            // イベント完了を保存
            SaveController05 saveController05 = new SaveController05();
            saveController05.complete_Event05_06_TalkClassmate();
            return true;
        }
    }
}