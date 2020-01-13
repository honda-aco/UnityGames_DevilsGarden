using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event05_05_SmallTalk : Event_ChangeBgm1
    {
        private EventController05 eventController05;

        public Event05_05_SmallTalk(EventController05 eventController) : base(eventController)
        {
            this.eventController05 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
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
                        @"今さらあせるなよ",
                        @"別にわたしら関係ないじゃん"
                    },
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"でも……"
                    },
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"でもじゃなくてさ",
                    },
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……",
                        @"なあ おまえさっきから何か用？" + System.Environment.NewLine +
                        @"用がないなら向こう行けよ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_girl,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }
    }
}