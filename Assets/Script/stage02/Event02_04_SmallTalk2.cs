using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event02_04_SmallTalk2 : Event_ChangeBgm1
    {
        private EventController02 eventController02;

        public Event02_04_SmallTalk2(EventController02 eventController) : base(eventController)
        {
            this.eventController02 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(start);
            eventList.Add(event1);
            eventList.Add(end);
            return eventList;
        }

        public bool event1()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"んで 昼休みも終わるっていうのに" + System.Environment.NewLine +
                        @"コックリさんが帰ってくれなくてさー"
                    },
                    CharaTalkController.Texture.talk_child1,
                    CharaTalkController.Texture.talk_woman3,
                    CharaTalkController.Texture.talk_child3,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"お前ら まだコックリさんなんてやってたのかよ" + System.Environment.NewLine +
                        @"あんなの作り話だろ？",
                        @"オレはもっとすごい話知ってるぜ"
                    },
                    CharaTalkController.Texture.talk_child1,
                    CharaTalkController.Texture.talk_woman3,
                    CharaTalkController.Texture.talk_child3,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"すごい話？"
                    },
                    CharaTalkController.Texture.talk_child1,
                    CharaTalkController.Texture.talk_woman3,
                    CharaTalkController.Texture.talk_child3,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"本物の悪魔を呼び出す方法だよ",
                        @"イケニエをささげることで本物が呼べるんだよ"
                    },
                    CharaTalkController.Texture.talk_child1,
                    CharaTalkController.Texture.talk_woman3,
                    CharaTalkController.Texture.talk_child3,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"へえー やり方教えてよ" + System.Environment.NewLine +
                        @"本当にコックリさんよりすごいか試してみようぜ"
                    },
                    CharaTalkController.Texture.talk_child1,
                    CharaTalkController.Texture.talk_woman3,
                    CharaTalkController.Texture.talk_child3,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"見た目からは分からないけれど" + System.Environment.NewLine +
                        @"話を聞く限り この子たちは普通の子どもだ",
                        @"おそろしい姿に変わっているだけで" + System.Environment.NewLine +
                        @"モデルになった人がいるのかな"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }
    }
}