using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event07_06_FindLetter1 : Event_ChangeBgm2
    {
        private EventController07 eventController07;

        public Event07_06_FindLetter1(EventController07 eventController) : base(eventController)
        {
            this.eventController07 = eventController;
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
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(event11));
            eventList.Add(new EventController.eventProcess(eventController07.lightOff));
            eventList.Add(new EventController.eventProcess(event12));
            eventList.Add(new EventController.eventProcess(eventController07.lightOn));
            eventList.Add(new EventController.eventProcess(event13));
            eventList.Add(new EventController.eventProcess(event14));
            eventList.Add(new EventController.eventProcess(end));

            return eventList;
        }

        private bool event1()
        {
            return eventController07.playerTurnaround(eventController07.MovePoint7);
        }

        private bool event2()
        {
            return eventController07.playerWalk(eventController07.MovePoint7.gameObject, 3.0f);
        }

        private bool event3()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"手紙？"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event4()
        {
            eventController07.Letter1.SetActive(false);
            return true;
        }

        private bool event5()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"手紙というよりは遺書かな"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event6()
        {
            eventController07.Ryotaro2.gameObject.SetActive(true);
            return true;
        }

        private bool event7()
        {
            return eventController07.charaWalk(
                    eventController07.Ryotaro2,
                    eventController07.MovePoint8
                    );
        }

        private bool event8()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"すごい状況になってるね"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event9()
        {
            return eventController07.playerTurnaround(eventController07.Ryotaro2.gameObject);
        }

        private bool event10()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"よかった！" + System.Environment.NewLine +
                        @"無事だったんだね",
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
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
                        @"ギリギリ助かったって感じ",
                        @"光の柱が見えたから来たんだけど" + System.Environment.NewLine +
                        @"手がかりになりそうなものは見つかった？"
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"遺書みたいな紙を見つけたよ" + System.Environment.NewLine +
                        @"たぶん夢の主のもの",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event11()
        {
            return eventController07.charaWalk(
                    eventController07.Ryotaro2,
                    eventController07.Player.gameObject,
                    15.0f
                    );
        }

        private bool event12()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あれからずっと後悔している" + System.Environment.NewLine +
                        @"あの日どうして一人で帰ったのだろう",
                        @"一人でなければ",
                        @"あんな事件に巻き込まれることも" + System.Environment.NewLine +
                        @"なかったかもしれない",
                        @"後悔したところでもう遅いとわかっているけれど" + System.Environment.NewLine +
                        @"それでも毎日考えてしまう",
                        @"ああすれば良かった こうすれば良かった" + System.Environment.NewLine +
                        @"回避する方法はいくらでもあったのに",
                        @"自分たちには無縁だと思っていた",
                        @"後悔してる",
                        @"二度と失敗しないから" + System.Environment.NewLine +
                        @"もう一度だけやり直したい",
                        @"次はぜったいに失敗しない",
                        @"ぜったいに失敗しないから" + System.Environment.NewLine +
                        @"やり直させてください",
                        @"ぜったいに失敗しません" + System.Environment.NewLine +
                        @"ぜったいに失敗しませんから",
                        @"ぜったいに失敗しないから！",
                        @"死んでつぐなうからやり直させて！"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event13()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ここってオレが通ってる学校でさ",
                        @"この学校でこの内容なら" + System.Environment.NewLine +
                        @"たぶん だれが書いたのかわかる",
                        @"オレの幼なじみの「めい」って子なんだけど" + System.Environment.NewLine +
                        @"下校途中におそわれたらしくて",
                        @"それからずっと引きこもってるんだよね",
                        @"この遺書はそのときの後悔をつづったもので" + System.Environment.NewLine +
                        @"ここがだれかの夢の世界なら",
                        @"きっと めいの夢なんだと思う",
                        @"この世界がそうであるように",
                        @"めいから見える世界は" + System.Environment.NewLine +
                        @"いびつで怖いものなんだろうな",
                        @"……",
                        @"行こう" + System.Environment.NewLine +
                        @"めいのところへ",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event14()
        {
            SaveController07 saveController07 = new SaveController07();
            saveController07.complete_Event07_06_FindLetter1();

            if (saveController07.get_KeyItem1Status() == SaveController.KeyItemStatus.Level_75)
            {
                saveController07.save_KeyItem1Status(SaveController.KeyItemStatus.Level_100);
            }
            else
            {
                saveController07.save_KeyItem1Status(SaveController.KeyItemStatus.Level_75);
            }
            eventController07.Update_KeyItem1();

            eventController07.EventPanel8.SetActive(true);
            eventController07.MainCamera.gameObject.SetActive(true);
            eventController07.EventCamera2.gameObject.SetActive(false);
            return true;
        }
    }
}