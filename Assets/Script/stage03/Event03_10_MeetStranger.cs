using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_10_01_MeetStranger : Event_ChangeBgm1
    {
        private EventController03 eventController03;

        public Event03_10_01_MeetStranger(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(eventController03.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController03.lightOn));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(eventController03.lightOff));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(eventController03.lightOn));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(event11));
            eventList.Add(new EventController.eventProcess(eventController03.lightOff));
            eventList.Add(new EventController.eventProcess(event12));
            eventList.Add(new EventController.eventProcess(eventController03.lightOn));
            eventList.Add(new EventController.eventProcess(event13));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            eventController03.MainCamera.gameObject.SetActive(false);
            eventController03.EventCamera1.gameObject.SetActive(true);
            eventController03.Player.transform.position = eventController03.MovePoint3.transform.position;
            eventController03.Player.transform.rotation = eventController03.MovePoint3.transform.rotation;
            return true;
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"変質者注意の紙が貼ってある",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event3()
        {
            eventController03.Stranger.gameObject.SetActive(true);
            return true;
        }

        public bool event4()
        {
            return eventController03.charaWalk(eventController03.Stranger, eventController03.Player.gameObject, 10.0f);
        }

        private bool event5()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"怖いよね 変質者なんて",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event6()
        {
            eventController03.Player.transform.LookAt(eventController03.Stranger.transform);
            eventController03.Player.gameObject.SetActive(false);
            eventController03.EventCamera1.gameObject.SetActive(false);
            eventController03.EventCamera2.gameObject.SetActive(true);
            return true;
        }

        private bool event7()
        {
            return eventController03.EventCamera2.gameObject.Slope(eventController03.MovePoint6, 1.0f);
        }


        private bool event8()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あなたみたいにキレイな顔なら" + System.Environment.NewLine +
                        @"心配で仕方ないでしょう？",
                        @"大変よね",
                        @"キレイだと苦労が多くって",
                        @"ワタシも女だから" + System.Environment.NewLine +
                        @"やっぱりキレイにはあこがれがあるの",
                        @"とくに肌にはこだわってるのよ",
                        @"できものなんかができたら丁寧にとったりね",
                        @"できものはまだしもシミだと大変",
                        @"いつもカミソリ２本はダメにしちゃう",
                        @"それにしてもキレイな顔でうらやましい",
                        @"あー" + System.Environment.NewLine +
                        @"うらやましい うらやましい"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event9()
        {
            return eventController03.charaWalk(eventController03.Stranger, eventController03.MovePoint4);
        }

        public bool event10()
        {
            eventController03.Stranger.gameObject.SetActive(false);
            return true;
        }

        private bool event11()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"怖かったー……",
                        @"どうしよう",
                        @"あの人が夢の主なんだったら" + System.Environment.NewLine +
                        @"追いかけるべきなんだろうけど",
                        @"正直 あの人とはもう会わずに終わりたい",
                        @"……",
                        @"うん" + System.Environment.NewLine +
                        @"ほかに手がかりがなかったら考えることにして",
                        @"今は先に進もう",
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event12()
        {
            eventController03.Player.gameObject.SetActive(true);
            eventController03.MainCamera.gameObject.SetActive(true);
            eventController03.EventCamera2.gameObject.SetActive(false);
            return true;
        }

        private bool event13()
        {
            eventController03.EventPanel11_2.SetActive(true);
            // イベント完了を保存
            SaveController03 saveController03 = new SaveController03();
            saveController03.complete_Event03_10_MeetStranger();
            return true;
        }
    }
}