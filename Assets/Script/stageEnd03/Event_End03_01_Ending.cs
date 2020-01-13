using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event_End03_01_Ending
    {
        private EventController_End03 eventController;

        public Event_End03_01_Ending(EventController_End03 eventController)
        {
            this.eventController = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController.playEvent4Bgm_Begin));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
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
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event22));
            eventList.Add(new EventController.eventProcess(event23));
            return eventList;
        }

        private bool event1()
        {
            Charactor.Pause();
            eventController.Player.Sit();
            return true;
        }

        private bool event2()
        {
            return eventController.charaWalk(eventController.Devil, eventController.MovePoint1);
        }

        private bool event3()
        {
            return eventController.charaTurnaround(eventController.Devil, eventController.MovePoint1_2, 0.03f);
        }

        private bool event4()
        {
            return eventController.charaTurnaround(eventController.Devil, eventController.MovePoint1_3, 0.03f);
        }

        private bool event5()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"毎日毎日 こんな世界を繰り返して" + System.Environment.NewLine +
                        @"いったい何が楽しいんだろうな",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }
        
        private bool event6()
        {
            return eventController.charaWalk(eventController.Devil, eventController.MovePoint2);
        }

        private bool event7()
        {
            return eventController.charaTurnaround(eventController.Devil, eventController.MovePoint2_2, 0.03f);
        }

        private bool event8()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"くだらない人間の作ったくだらない世界",
                        @"こんな世界に住むくらいなら" + System.Environment.NewLine +
                        @"死んだ方がいいくらいだ",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event9()
        {
            return eventController.charaTurnaround(eventController.Devil, eventController.Birdbox1, 0.03f);
        }

        private bool event10()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"おまえもそう思わないか？"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event11()
        {
            return eventController.EventCamera1.gameObject.Move(eventController.MovePoint3.transform.position, 3.0f, 0.1f);
        }

        private bool event12()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"なあ 返事しろよ",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ああ そうか",
                        @"あんまりうるさいから" + System.Environment.NewLine +
                        @"しゃべれなくしたんだった",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event13()
        {
            return eventController.charaTurnaround(eventController.Devil, eventController.MovePoint2_2);
        }

        private bool event14()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"反応がなくなると" + System.Environment.NewLine +
                        @"こうもつまらないなんて",
                        @"もう少し加減しておけばよかったな",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event15()
        {
            return eventController.charaTurnaround(eventController.Devil, eventController.Birdbox1, 0.03f);
        }

        private bool event16()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"まあ加減しようがしまいが" + System.Environment.NewLine +
                        @"すぐに反応なんてなくなるんだから",
                        @"どうでもいいか",
                        @"オレのものに手をつけなければ" + System.Environment.NewLine +
                        @"こんな目にあわずに済んだのに",
                        @"時間は無限にあるから" + System.Environment.NewLine +
                        @"ゆっくり後悔するといいよ"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event17()
        {
            return eventController.charaWalk(eventController.Devil, eventController.MovePoint1_2);
        }

        private bool event18()
        {
            eventController.Devil.gameObject.SetActive(false);
            return true;
        }

        private bool event19()
        {
            return eventController.EventCamera1.gameObject.Move(eventController.MovePoint4.transform.position, 1.0f, 0.1f);
        }

        private bool event20()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"…………",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"………………",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event21()
        {
            return eventController.EventCamera1.gameObject.Move(eventController.MovePoint5.transform.position, 3.0f, 0.05f);
        }

        private bool event22()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"THE END"
                        },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event23()
        {
            if (new SaveController00().completed_PlayButton() == false)
            {
                SaveController_End03 saveController_End03 = new SaveController_End03();
                saveController_End03.complete_Event_End03_01_Ending();

                SaveController00 saveController00 = new SaveController00();
                saveController00.deleteAllKeys();
                saveController00.save_Scene(SaveController.SceneNo.Scene01, SaveController.PlaceNo.None);
            }
            eventController.loadScene(@"stage00");
            return true;
        }
    }
}