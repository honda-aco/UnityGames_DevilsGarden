using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event02_06_SmallTalk3 : Event_ChangeBgm1
    {
        private EventController02 eventController02;

        public Event02_06_SmallTalk3(EventController02 eventController) : base(eventController)
        {
            this.eventController02 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(start);
            eventList.Add(event1);
            eventList.Add(event2);
            eventList.Add(end);
            return eventList;
        }

        public bool event1()
        {
            return eventController02.charaTurnaround(eventController02.Child4, eventController02.Player.gameObject);
        }

        public bool event2()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"この町ってどこか変だと思うんだけど" + System.Environment.NewLine +
                        @"お姉ちゃんは何も感じない？",
                        @"だって あそこに人が死んでるのに" + System.Environment.NewLine +
                        @"だれも警察を呼ばないんだよ？",
                        @"それに僕が覚えていないだけで" + System.Environment.NewLine +
                        @"死体は毎日あるみたいなんだ",
                        @"僕の日記に死体のことが毎日書かれてるから",
                        @"僕は何も覚えてないのに" + System.Environment.NewLine +
                        @"絶対に何かおかしいよ"
                    },
                    CharaTalkController.Texture.talk_child2,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"夢の世界がループしてるってこと？",
                        @"夢の内容なんて人それぞれだけど"  + System.Environment.NewLine +
                        @"こんなに凝った夢は初めて"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }
    }
}