using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event05_12_PlayBaseball : Event_ChangeBgm1
    {
        private EventController05 eventController05;

        public Event05_12_PlayBaseball(EventController05 eventController) : base(eventController)
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
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(eventController05.lightOff));
            eventList.Add(new EventController.eventProcess(eventController05.lightOn));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(event9));
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
                        @"もしかして お姉さん野球できる？",
                        @"ちょっとボール投げてみてよ"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_child_blue
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            return eventController05.playerTurnaround(eventController05.Child1.gameObject);
        }

        private bool event3()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"気晴らしがてら" + System.Environment.NewLine +
                        @"少しつきあおうかな"
                    },
                    CharaTalkController.Texture.talk_yucco_close,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_child_blue,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event4()
        {
            return eventController05.playerWalk(eventController05.MovePoint8_1);
        }

        private bool event5()
        {
            return eventController05.playerTurnaround(eventController05.MovePoint8_2);
        }

        private bool event6()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"いやー お姉さんすごいね",
                        @"こんなに投げられると思わなかったよ"
                    },
                    CharaTalkController.Texture.talk_yucco_close,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_child_blue,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event7()
        {
            return eventController05.charaWalk(eventController05.Child2, eventController05.MovePoint8_3);
        }

        private bool event8()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"なあ もう疲れたし" + System.Environment.NewLine +
                        @"野球は終わりにしてさ",
                        @"今朝話してた悪魔の話の続きを教えてよ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.talk_child_green,
                    CharaTalkController.Texture.talk_child_blue,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"悪魔の話？"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.talk_child_green,
                    CharaTalkController.Texture.talk_child_blue,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そういえば途中だったかー",
                        @"えーと 悪魔を呼んだあとに" + System.Environment.NewLine +
                        @"絶対にしちゃいけないことだよな？",
                        @"それは「イケニエを取り返すこと」なんだって",
                        @"イケニエとひきかえに願いを叶えるから" + System.Environment.NewLine +
                        @"取り返すことは契約違反になるんだってさ"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.talk_child_green,
                    CharaTalkController.Texture.talk_child_blue,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event9()
        {
            // イベント完了を保存
            SaveController05 saveController = new SaveController05();
            saveController.complete_Event05_12_PlayBaseball();
            return true;
        }
    }
}