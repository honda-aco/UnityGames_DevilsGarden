using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_09_MeetDevil : Event_DeferredBgm
    {
        private EventController03 eventController03;

        public Event03_09_MeetDevil(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController.playEvent4Bgm_Begin));
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(event11));
            eventList.Add(new EventController.eventProcess(event12));
            eventList.Add(new EventController.eventProcess(eventController.playDefaultBgm));
            eventList.Add(new EventController.eventProcess(event13));
            eventList.Add(new EventController.eventProcess(event14));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }
        
        public bool event1()
        {
            eventController03.Devil.gameObject.SetActive(true);
            return true;
        }

        public bool event2()
        {
            return eventController03.charaWalk(eventController03.Devil, eventController03.MovePoint1);
        }

        public bool event3()
        {
            return eventController03.charaWalk(eventController03.Devil, eventController03.Player.gameObject, 20.0f);
        }

        public bool event4()
        {
            return eventController03.charaTurnaround(eventController03.Devil, eventController03.Player.gameObject);
        }

        private bool event5()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ねえ"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event6()
        {
            return eventController03.playerTurnaround(
                eventController03.Devil.gameObject);
        }

        private bool event7()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"やっぱり初めて見る顔だな",
                        @"まだ知らないやつがいたのか" + System.Environment.NewLine +
                        @"おまえ 今までどこにいたの？",
                        @"ねえ？聞こえてる？" + System.Environment.NewLine +
                        @"返事してよ"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"（なんだろう この人すごく嫌な感じがする……）",
                        @"ええと どこにいたのかと聞かれても" + System.Environment.NewLine +
                        @"自分でもよく分からなくて……"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ふーん そうなんだ" + System.Environment.NewLine +
                        @"まあいいか",
                        @"それよりこのあたりは野犬が出るから" + System.Environment.NewLine +
                        @"遅くならないうちに帰ったほうがいいよ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"わ、わかりました",
                        @"あの…… あなたはここがどこか知ってるんですか？"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ここがどこかは知らない",
                        @"でも だれが望んだ世界かは知ってるよ",
                        @"教えないけどね"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event8()
        {
            return eventController03.charaWalk(eventController03.Devil, eventController03.MovePoint2);
        }

        public bool event9()
        {
            eventController03.Smoke1.gameObject.SetActive(true);
            eventController03.Smoke1.Play();
            return true;
        }

        private bool event10()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"え？ちょっと！",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event11()
        {
            eventController03.Devil.gameObject.SetActive(false);
            return true;
        }

        public bool event12()
        {
            return eventController03.playerRun(eventController03.Devil.gameObject, 5.0f);
        }

        private bool event13()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"消えちゃった……",
                        @"一体何者なんだろう あの人"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event14()
        {
            // イベント完了を保存
            SaveController03 saveController03 = new SaveController03();
            saveController03.complete_Event03_09_MeetDevil();
            return true;
        }
    }
}