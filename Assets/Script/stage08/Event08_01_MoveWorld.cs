using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event08_01_MoveWorld
    {
        private EventController08 eventController08;

        public Event08_01_MoveWorld(EventController08 eventController)
        {
            this.eventController08 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
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
            eventList.Add(new EventController.eventProcess(event13));
            eventList.Add(new EventController.eventProcess(event14));
            eventList.Add(new EventController.eventProcess(event15));
            eventList.Add(new EventController.eventProcess(event16));
            eventList.Add(new EventController.eventProcess(event17));
            eventList.Add(new EventController.eventProcess(event18));
            eventList.Add(new EventController.eventProcess(event19));
            eventList.Add(new EventController.eventProcess(event20));
            eventList.Add(new EventController.eventProcess(event21));
            eventList.Add(new EventController.eventProcess(event22));
            return eventList;
        }

        protected bool event1()
        {
            Charactor.Pause();
            eventController08.Player.Idle();
            return true;
        }

        private bool event2()
        {
            return eventController08.EventCamera1.gameObject.Move(eventController08.MovePoint1.transform.position, 5.0f, 3.0f);
        }

        private bool event3()
        {
            return eventController08.EventCamera1.gameObject.Move(eventController08.MovePoint2.transform.position, 5.0f, 3.0f);
        }

        private bool event4()
        {
            return eventController08.EventCamera1.gameObject.Move(eventController08.MovePoint3.transform.position, 5.0f, 3.0f);
        }

        private bool event5()
        {
            return eventController08.EventCamera1.gameObject.Move(eventController08.MovePoint4.transform.position, 5.0f, 3.0f);
        }

        private bool event6()
        {
            return eventController08.EventCamera1.gameObject.Move(eventController08.MovePoint5.transform.position, 5.0f, 3.0f);
        }

        private bool event7()
        {
            return eventController08.EventCamera1.gameObject.Move(eventController08.MovePoint6.transform.position, 5.0f, 3.0f);
        }

        private bool event8()
        {
            return eventController08.EventCamera1.gameObject.Move(eventController08.MovePoint7.transform.position, 5.0f, 3.0f);
        }

        private bool event9()
        {
            return eventController08.EventCamera1.Zoom(50.0f, 1.0f);
        }

        private bool event10()
        {
            return eventController08.charaTurnaround(eventController08.Ryotaro, eventController08.Player.gameObject);
        }

        private bool event11()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"疲れたね",
                        @"少し休憩しよう",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro
                    ));

            return eventController08.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event12()
        {
            return eventController08.charaWalk(eventController08.Ryotaro, eventController08.MovePoint8, 5.0f);
        }

        private bool event13()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そういえば このあたりだったかな",

                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro
                    ));

            return eventController08.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event14()
        {
            return eventController08.playerTurnaround(eventController08.Ryotaro.gameObject);
        }

        private bool event15()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"小学生のころ" + System.Environment.NewLine +
                        @"秘密基地をつくって遊んでた場所があるんだ",
                        @"あのころは悩みも少なくて" + System.Environment.NewLine +
                        @"今より自由だったな",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro
                    ));

            return eventController08.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event16()
        {
            return eventController08.charaTurnaround(eventController08.Ryotaro, eventController08.Player.gameObject);
        }

        private bool event17()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あの遺書に書いてあったこと" + System.Environment.NewLine +
                        @"分からないこともなくてさ",
                        @"今は今で楽しいけれど" + System.Environment.NewLine +
                        @"いろいろと悩むことは増えた気がして",
                        @"たまにどうしようもなく" + System.Environment.NewLine +
                        @"昔に戻りたくなる日があるんだ",
                        @"大人になったら もっと悩んで" + System.Environment.NewLine +
                        @"もっと昔が恋しくなるのかな……"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"どうだろう",
                        @"わたしは昔に戻りたいって" + System.Environment.NewLine +
                        @"あまり考えたことないんだ",
                        @"年をとって悩みが増える不安より" + System.Environment.NewLine +
                        @"できることが広がる楽しみの方が大きいから",
                        @"それに忘れてるだけで" + System.Environment.NewLine +
                        @"子どものころにも悩みや不安はあったはずだよ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"たしかに" + System.Environment.NewLine +
                        @"昔は昔でいろいろ悩んでたかも",
                        @"できることが広がる楽しみか……" + System.Environment.NewLine +
                        @"そう考えると大人になるのも悪くないね",
                        @"よし！",
                        @"大人になって楽しみを増やすためにも" + System.Environment.NewLine +
                        @"まずはここから出よう！"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController08.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event18()
        {
            return eventController08.charaRun(eventController08.Ryotaro, eventController08.MovePoint9, 3.0f);
        }

        private bool event19()
        {
            eventController08.Ryotaro.gameObject.SetActive(false);
            return true;
        }

        private bool event20()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あれ 休憩するはずじゃ……",
                        @"ちょっと待ってよ～"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController08.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event21()
        {
            SaveController08 saveController08 = new SaveController08();
            saveController08.complete_Event08_01_MoveWorld();

            eventController08.loadScene(@"stage03");
            Charactor.Restart();
            return true;
        }

        protected bool event22()
        {
            Charactor.Restart();
            return true;
        }
    }
}