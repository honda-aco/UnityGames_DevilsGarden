using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event_End06_01_Ending
    {
        private EventController_End06 eventController;

        public Event_End06_01_Ending(EventController_End06 eventController)
        {
            this.eventController = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController.playEvent2Bgm_Begin));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(eventController.stopBgm));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(eventController.playEvent4Bgm_Begin));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(event11));
            eventList.Add(new EventController.eventProcess(event12));
            eventList.Add(new EventController.eventProcess(event13));
            eventList.Add(new EventController.eventProcess(event14));
            eventList.Add(new EventController.eventProcess(event15));
            eventList.Add(new EventController.eventProcess(event16));
            eventList.Add(new EventController.eventProcess(eventController.playEvent3Bgm_Begin));
            eventList.Add(new EventController.eventProcess(event17));
            eventList.Add(new EventController.eventProcess(event18));
            eventList.Add(new EventController.eventProcess(event19));
            eventList.Add(new EventController.eventProcess(event20));
            eventList.Add(new EventController.eventProcess(event21));
            eventList.Add(new EventController.eventProcess(event22));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event27));
            eventList.Add(new EventController.eventProcess(event28));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event29));
            eventList.Add(new EventController.eventProcess(event30));
            eventList.Add(new EventController.eventProcess(event31));
            eventList.Add(new EventController.eventProcess(event34));
            eventList.Add(new EventController.eventProcess(event35));
            eventList.Add(new EventController.eventProcess(event36));
            eventList.Add(new EventController.eventProcess(event37));
            eventList.Add(new EventController.eventProcess(event38));
            eventList.Add(new EventController.eventProcess(event39));
            eventList.Add(new EventController.eventProcess(event40));
            eventList.Add(new EventController.eventProcess(event41));
            eventList.Add(new EventController.eventProcess(event42));
            eventList.Add(new EventController.eventProcess(event43));
            eventList.Add(new EventController.eventProcess(event44));
            eventList.Add(new EventController.eventProcess(eventController.stopBgm));
            eventList.Add(new EventController.eventProcess(event45));
            eventList.Add(new EventController.eventProcess(event46));
            eventList.Add(new EventController.eventProcess(eventController.playEvent2Bgm_Begin));
            eventList.Add(new EventController.eventProcess(event47));
            eventList.Add(new EventController.eventProcess(event48));
            eventList.Add(new EventController.eventProcess(event49));
            eventList.Add(new EventController.eventProcess(event50));
            eventList.Add(new EventController.eventProcess(event51));
            eventList.Add(new EventController.eventProcess(event52));
            eventList.Add(new EventController.eventProcess(event53));
            eventList.Add(new EventController.eventProcess(event54));
            eventList.Add(new EventController.eventProcess(event55));
            eventList.Add(new EventController.eventProcess(event56));
            eventList.Add(new EventController.eventProcess(event57));
            eventList.Add(new EventController.eventProcess(event58));
            eventList.Add(new EventController.eventProcess(event59));
            eventList.Add(new EventController.eventProcess(event59_2));
            eventList.Add(new EventController.eventProcess(event59_3));
            eventList.Add(new EventController.eventProcess(event62));
            eventList.Add(new EventController.eventProcess(event63));
            eventList.Add(new EventController.eventProcess(event64));
            eventList.Add(new EventController.eventProcess(event65));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event66));
            eventList.Add(new EventController.eventProcess(event67));
            eventList.Add(new EventController.eventProcess(event68));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event69));
            eventList.Add(new EventController.eventProcess(event70));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event71));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event72));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event73));
            eventList.Add(new EventController.eventProcess(event74));

            return eventList;
        }

        private bool event1()
        {
            Charactor.Pause();
            eventController.Player.Idle();
            return true;
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"学校に行ってきたよ",
                        @"いろいろ見て確信をもてた",
                        @"この世界をつくったのは ゆい子だね",
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event3()
        {
            return eventController.charaTurnaround(eventController.Meiko, eventController.Ryotaro.gameObject);
        }

        private bool event4()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ちょっと りょうたろう" + System.Environment.NewLine +
                        @"急に何を言ってるの？",
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そう",
                        @"学校まで行かれたんじゃ言い逃れはムリか",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event5()
        {
            return eventController.charaTurnaround(eventController.Meiko, eventController.Yuko.gameObject);
        }

        private bool event6()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ゆい子？",
                    },
                    CharaTalkController.Texture.talk_meiko_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そうだね",
                        @"どうやってこの世界を作ったのかとか" + System.Environment.NewLine +
                        @"知りたいことはたくさんあるけれど",
                        @"別に責めるつもりはないんだ",
                        @"ゆい子がツラい立場にあったことは" + System.Environment.NewLine +
                        @"近くで見てて知ってるからね",
                        @"オレたちはここから出られればそれでいい",
                        @"出る方法を教えてくれ"
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"残念だけど出る方法はわからない",
                        @"たしかにここはわたしの望んだ世界",
                        @"だからといって" + System.Environment.NewLine +
                        @"わたしが支配しているわけではないから",
                        @"この世界はさ" + System.Environment.NewLine +
                        @"悪魔が作った世界なんだ",
                        @"わたしが取引して作ってもらった世界",
                        @"作る方法もわからなければ" + System.Environment.NewLine +
                        @"終わらせる方法もわからない",
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"なんでそんなことを",
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"やり直したかった",
                        @"何かを犠牲にしてでも" + System.Environment.NewLine +
                        @"どうしても",
                        @"こんなに人を巻き込むつもりはなかったけど",
                        @"もし巻き込むと知っていたとしても" + System.Environment.NewLine +
                        @"わたしはこの世界を望んだと思う",
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……",
                        @"そっか",
                        @"やっぱりだめだな",
                        @"怒るべきなんだろうけど" + System.Environment.NewLine +
                        @"全然怒りがわいてこないんだ……",
                        @"出る方法がわからないなら" + System.Environment.NewLine +
                        @"この世界を作った悪魔に会う方法でもいい",
                        @"どうやって出るかは" + System.Environment.NewLine +
                        @"作った本人に聞いてみるから"
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"それは……",
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"呼んだ？",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event7()
        {
            if (eventController.Smoke1.gameObject.activeSelf == false)
            {
                eventController.Smoke1.transform.position = eventController.Devil.transform.position;
                eventController.Smoke1.gameObject.SetActive(true);
                eventController.Smoke1.Play();
            }
            return eventController.timeWait(1000);
        }

        private bool event8()
        {
            eventController.Devil.gameObject.SetActive(true);
            return true;
        }

        private bool event9()
        {
            return eventController.charaWalk(eventController.Devil, eventController.Player.gameObject, 15.0f);
        }

        private bool event10()
        {
            bool result1 = eventController.playerTurnaround(eventController.Devil.gameObject);
            bool result2 = eventController.charaTurnaround(eventController.Ryotaro, eventController.Devil.gameObject);
            bool result3 = eventController.charaTurnaround(eventController.Meiko, eventController.Devil.gameObject);
            bool result4 = eventController.charaTurnaround(eventController.Yuko, eventController.Devil.gameObject);
            return result1 && result2 && result3 && result4;
        }

        private bool event11()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"何？",
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
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
                        @"なっ！",
                        @"これが悪魔……"
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
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
                        @"あなたがこの世界を作った悪魔？",
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
                        @"そうだよ",
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
                        @"わたしたち この世界から出たいんだけど" + System.Environment.NewLine +
                        @"どうやったら出られますか？",
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
                        @"なんだそんなことか",
                        @"簡単だよ",
                        @"そこの女の願いを叶えただけなんだから" + System.Environment.NewLine +
                        @"そいつが終わりでいいと言うなら終わらせるよ",
                        @"ただし この世界を作る対価としてもらった" + System.Environment.NewLine +
                        @"ウサギの命とそいつの魂は返せない"
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
                        @"対価？"
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
                        @"世界を作ってもらう代わりに" + System.Environment.NewLine +
                        @"ウサギをイケニエとして渡したんだ",
                        @"でもそれじゃあ足りなくて",
                        @"不足をおぎなうため わたしの魂も渡してる",
                        @"だから わたしは出られない",
                        @"出られるとしても出る気はないけれど",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そんな……",
                        @"なにか方法は？"
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"オマエたちの誰かが身代わりになる" + System.Environment.NewLine +
                        @"そうすれば この女は解放してもいい"
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
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
                        @"そんなことしなくていい" + System.Environment.NewLine +
                        @"わたしはこのままでかまわない"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event12()
        {
            return eventController.charaTurnaround(eventController.Meiko, eventController.Yuko.gameObject);
        }

        private bool event13()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"よくないよ",
                        @"一人残れというなら わたしが残る",
                        @"どうせ帰りたい場所なんてないんだから"
                    },
                    CharaTalkController.Texture.talk_meiko_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event14()
        {
            return eventController.charaTurnaround(eventController.Ryotaro, eventController.Yuko.gameObject);
        }

        private bool event15()
        {
            return eventController.charaTurnaround(eventController.Yuko, eventController.Meiko.gameObject);
        }

        private bool event16()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"永遠にここに一人ぼっちでも？" + System.Environment.NewLine +
                        @"それでも本当にいいと思える？"
                    },
                    CharaTalkController.Texture.talk_meiko_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……"
                    },
                    CharaTalkController.Texture.talk_meiko_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そんなふうに思えないでしょ",
                        @"わたしはそう思えるから"
                    },
                    CharaTalkController.Texture.talk_meiko_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event17()
        {
            return eventController.playerTurnaround(eventController.Yuko.gameObject);
        }

        private bool event18()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"それって本心？",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event19()
        {
            return eventController.charaTurnaround(eventController.Yuko, eventController.Player.gameObject);
        }

        private bool event20()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"わたしはゆい子ちゃんのことをよく知らない",
                        @"だけど この世界を歩いて感じたことがある",
                        @"たしかに暗くて怖い世界だけど" + System.Environment.NewLine +
                        @"絶望しかない世界でもなかったよ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event21()
        {
            return eventController.playerWalk(eventController.Yuko.gameObject, 10.0f);
        }

        private bool event22()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"わたしは昔 絶望だけの世界を見たことがある",
                        @"そんな夢にはこんな素敵なものはなかった",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"記念写真を渡した"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"これは……",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"秘密基地で見つけたんだ",
                        @"覚えてるよね？" + System.Environment.NewLine +
                        @"ゆい子ちゃんが二人と作った場所",
                        @"これだけじゃないよ" + System.Environment.NewLine +
                        @"この世界には他にもたくさんのものがあった",
                        @"なかには自分のしたことを後悔するものだったり" + System.Environment.NewLine +
                        @"辛いものだってあったけれど……",
                        @"それでもずっと一人でいいなんて人の" + System.Environment.NewLine +
                        @"世界じゃなかった",
                        @"ねえ ゆい子ちゃん" + System.Environment.NewLine +
                        @"本当の話をしようよ",
                        @"本当はどうしたいの？" + System.Environment.NewLine +
                        @"二人と一緒にいられなくて本当にいいの？"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……",
                        @"わたしは……",
                        @"わたしの本当は……",
                        @"だけど 今さらもう"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そう決めるのはまだ早いんじゃない？",
                        @"ここから出る方法なら" + System.Environment.NewLine +
                        @"わたしに一つ考えがある",
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event27()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……",
                        @"そこで わたしがおびきよせてー……",
                        @"あとは適当に誘導してー……",
                        @"ね？上手くいきそうでしょ？",
                        @"それじゃあ さっそく移動しよう",
                        @"心配しなくても大丈夫だって" + System.Environment.NewLine +
                        @"みんなは離れたところで見守っててよ"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event28()
        {
            eventController.EventCamera1.gameObject.SetActive(false);
            eventController.EventCamera2.gameObject.SetActive(true);
            eventController.Meiko.transform.position = eventController.MovePoint5.transform.position;
            eventController.Meiko.transform.rotation = eventController.MovePoint5.transform.rotation;
            return true;
        }

        public bool event29()
        {
            return eventController.charaWalk(eventController.Pervent, eventController.Meiko.gameObject, 15.0f);
        }

        public bool event30()
        {
            return eventController.charaTurnaround(eventController.Meiko, eventController.Pervent.gameObject);
        }

        private bool event31()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あら あなた" + System.Environment.NewLine +
                        @"このあいだの子よね？",
                        @"よかった" + System.Environment.NewLine +
                        @"また会いたいと思っていたの",
                        @"あなたからもらった皮",
                        @"しおれちゃって" + System.Environment.NewLine +
                        @"全然使いものにならなかったのよ",
                        @"顔のケガも元に戻ったようだし" + System.Environment.NewLine +
                        @"また分けてもらえないかしら？",
                        @"いいでしょ？",
                        @"ワタシもあなたみたいに" + System.Environment.NewLine +
                        @"キレイな肌になりたいのよ"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"（怒ってはダメ 冷静に……）",
                        //@"この人は自分がしたことで" + System.Environment.NewLine +
                        //@"わたしがどれだけ苦しんだか",
                        //@"考えたことすらないんだろうな……",
                        @"……",
                        @"顔をキレイにしたいんですよね？" + System.Environment.NewLine +
                        @"だったら手っ取り早い方法があります",
                        @"このおかしな世界は" + System.Environment.NewLine +
                        @"わたしの想像力が生んだ世界なんです",
                        @"だから わたしが望めば" + System.Environment.NewLine +
                        @"すぐにでも望む顔にできます",
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"本当？" + System.Environment.NewLine +
                        @"そんな都合のいい話……"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"証明することもできますが",
                        @"それよりも実際にやってみせます" + System.Environment.NewLine +
                        @"そっちの方が早いですから",
                        @"肌をキレイにしたいんですよね？"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そうね",
                        @"やっぱり肌よ" + System.Environment.NewLine +
                        @"女のキレイは肌から始まるの！"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"わかりました",
                        @"ただし条件があります",
                        @"悪魔の契約を知ってますか？",
                        @"悪魔が願いを叶えるかわりに" + System.Environment.NewLine +
                        @"契約者は自分の魂を差し出す……",
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"このへんの子は悪魔の話が好きね",
                        @"何？あなたは悪魔なの？"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"いいえ",
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"くだらない" + System.Environment.NewLine +
                        @"ただのごっこ遊びなのね",
                        @"いいでしょう 魂はあげます",
                        @"その代わりウソなら承知しないから"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"大丈夫です" + System.Environment.NewLine +
                        @"もう済んでますから",
                        @"顔をさわってみてください"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……！？",
                        @"ツルツルしてる！？" + System.Environment.NewLine +
                        @"たしかに！肌がキレイになってる！",
                        @"肌がキレイになってるわ！！！"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ウソじゃなかったでしょ？",
                        @"じゃあ対価をもらいますね",
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"魂ね" + System.Environment.NewLine +
                        @"でもあなた悪魔じゃないんでしょ？",
                        @"知ってる？" + System.Environment.NewLine +
                        @"悪魔はウソをつけないのよ",
                        @"だから 悪魔かと聞かれて" + System.Environment.NewLine +
                        @"「いいえ」と答えたあなたは悪魔じゃない",
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そうですね" + System.Environment.NewLine +
                        @"だけど……",
                        @"悪魔さーん 聞こえてますかー？",
                        @"この人の魂をあげるので" + System.Environment.NewLine +
                        @"ゆい子ちゃんは解放してくださーい！"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event34()
        {
            if (eventController.Smoke2.gameObject.activeSelf == false)
            {
                eventController.Smoke2.transform.position = eventController.MovePoint6.transform.position;
                eventController.Smoke2.gameObject.SetActive(true);
                eventController.Smoke2.Play();
                eventController.Devil.transform.position = eventController.MovePoint6.transform.position;
                eventController.Devil.transform.rotation = eventController.MovePoint6.transform.rotation;
            }

            return eventController.timeWait(2500);
        }

        private bool event35()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"何を企んでるかと思えば" + System.Environment.NewLine +
                        @"こんなことか"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event36()
        {
            return eventController.charaTurnaround(eventController.Pervent, eventController.Devil.gameObject);
        }

        private bool event37()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"な、アンタ誰よ！？"
                    },
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"コイツの魂ではつり合わない気がするが" + System.Environment.NewLine +
                        @"人間ではあるし認めてやるよ",
                        @"邪悪な魂はそれはそれで使い道があるしな"
                    },
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event38()
        {
            if (eventController.Smoke3.gameObject.activeSelf == false)
            {
                eventController.Smoke3.transform.position = eventController.Pervent.transform.position;
                eventController.Smoke3.gameObject.SetActive(true);
                eventController.Smoke3.Play();
            }
            return eventController.timeWait(1500);
        }

        private bool event39()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ちょ、ちょっと待――"
                    },
                    CharaTalkController.Texture.talk_stranger,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event40()
        {
            if (eventController.timeWait(1000))
            {
                if (eventController.Pervent.gameObject.activeSelf == true)
                {
                    eventController.Pervent.gameObject.SetActive(false);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool event41()
        {
            return eventController.timeWait(2000);
        }

        private bool event42()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"約束通りオマエたちは解放してやる" + System.Environment.NewLine +
                        @"少し待てば世界は消えて元通りだ",
                        @"よかったな めい",
                        @"オマエはようやく" + System.Environment.NewLine +
                        @"自分の望んだ終わりを手に入れられるわけだ"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_devil,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event43()
        {
            eventController.Smoke2.Play();
            return true;
        }

        public bool event44()
        {
            if (eventController.timeWait(1500))
            {
                if (eventController.Devil.gameObject.activeSelf == true)
                {
                    eventController.Devil.gameObject.SetActive(false);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool event45()
        {
            return eventController.timeWait(2000);
        }

        private bool event46()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"わたしの望んだ終わり……？",
                        @"わたしはアイツに顔を切られて",
                        @"そのあとはどうしたんだっけ？",
                        @"ああ そうか",
                        @"そうだった",
                        @"忘れていた",
                        @"わたしは終わりを望んだんだ……"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event47()
        {
            eventController.Yuko.transform.position = eventController.MovePoint8.transform.position;
            eventController.Yuko.transform.rotation = eventController.MovePoint8.transform.rotation;
            eventController.Player.transform.position = eventController.MovePoint9.transform.position;
            eventController.Player.transform.rotation = eventController.MovePoint9.transform.rotation;
            eventController.Ryotaro.transform.position = eventController.MovePoint10.transform.position;
            eventController.Ryotaro.transform.rotation = eventController.MovePoint10.transform.rotation;
            return true;
        }

        public bool event48()
        {
            eventController.playerRun(eventController.Meiko.gameObject, 25.0f);
            eventController.charaRun(eventController.Ryotaro, eventController.Meiko.gameObject, 25.0f);
            if (eventController.charaRun(eventController.Yuko, eventController.Meiko.gameObject, 25.0f))
            {
                eventController.Player.Idle();
                eventController.Ryotaro.MotionWait();
                eventController.Yuko.MotionWait();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool event49()
        {
            return eventController.EventCamera2.gameObject.Move(eventController.MovePoint11.transform.position, 1.0f, 0.2f);
        }

        public bool event50()
        {
            return eventController.charaTurnaround(eventController.Meiko, eventController.Yuko.gameObject);
        }

        private bool event51()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ゆい子 全部思い出したよ",
                        @"わたしが忘れていたこと全部",
                        @"この世界はわたしのための世界だったんだね",
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"めい……",
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"わたし 取り返しのつかないことをしちゃった",
                        @"あの時は絶望でいっぱいで……" + System.Environment.NewLine +
                        @"今はすごく後悔してる",
                        @"くやしいなあ",
                        @"ようやく全部思い出せて" + System.Environment.NewLine +
                        @"たくさん話したいこともあるのに",
                        @"そんな時間はもらえないみたい",
                        @"ごめんね ゆい子" + System.Environment.NewLine +
                        @"たくさんつらい思いをさせて",
                        @"あなたは優しいからすごく悩んだよね",
                        @"会いに来てくれて嬉しかった",
                        @"ありがとう"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event52()
        {
            if (eventController.ShockWave1.gameObject.activeSelf == false)
            {
                eventController.ShockWave1.transform.position = eventController.Meiko.transform.position;
                eventController.ShockWave1.gameObject.SetActive(true);
                eventController.ShockWave1.Play();
            }

            if (eventController.timeWait(1000))
            {
                eventController.Meiko.gameObject.SetActive(false);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool event53()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"めい！"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"なあ 今の話って……",
                        @"大丈夫だよな？",
                        @"オレが考えすぎてるだけだよな？",
                        @"このまま夢から覚めたら" + System.Environment.NewLine +
                        @"めいの見舞いに行って",
                        @"そしてまた３人で過ごす日が続くんだよな？"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event54()
        {
            return eventController.EventCamera2.gameObject.Move(eventController.MovePoint12.transform.position, 1.0f, 0.5f);
        }

        public bool event55()
        {
            return eventController.charaTurnaround(eventController.Yuko, eventController.Ryotaro.gameObject);
        }

        private bool event56()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"りょうたろう……",
                        @"そっちに連絡が行く前だったんだね",
                        @"めいは――"
                    },
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"やめてくれ！",
                        @"聞きたくない！",
                        @"だってオレは……",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event57()
        {
            if (eventController.ShockWave2.gameObject.activeSelf == false)
            {
                eventController.ShockWave2.transform.position = eventController.Ryotaro.transform.position;
                eventController.ShockWave2.gameObject.SetActive(true);
                eventController.ShockWave2.Play();
            }

            if (eventController.timeWait(1000))
            {
                eventController.Ryotaro.gameObject.SetActive(false);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool event58()
        {
            return eventController.timeWait(1500);
        }

        private bool event59()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"りょうたろう！？",
                        @"向こうでちゃんと話すから……"
                    },
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event59_2()
        {
            if (eventController.charaWalk(eventController.Yuko, eventController.Player.gameObject, 15.0f))
            {
                return eventController.timeWait(1000);
            }
            return false;
        }

        private bool event59_3()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ゆっこさん",
                        @"言いたいことがありすぎて" + System.Environment.NewLine +
                        @"何から話したらいいのか……",
                        @"わたしが最後に希望を持てたのは" + System.Environment.NewLine +
                        @"あなたが写真を見つけてくれたおかげです",
                        @"これから戻った先にはつらい現実があって" + System.Environment.NewLine +
                        @"絶望する日もたくさんあると思う",
                        @"でもきっと それだけじゃないんだよね",
                        @"絶望の中にも小さな希望は落ちていて",
                        @"それを見つけられるかどうかなんだって" + System.Environment.NewLine +
                        @"ゆっこさんが教えてくれたから",
                        @"今度はちゃんと自分の力で見つけます",
                        @"ありがとう",
                        @"ここでのこと" + System.Environment.NewLine +
                        @"ずっと忘れないです"
                    },
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"わたしも忘れないよ",
                        @"戻ったら会いに行くから" + System.Environment.NewLine +
                        @"次は現実で会おう",
                        @"それでまた会えたら今度は" + System.Environment.NewLine +
                        @"たくさん話をして友達になろうよ"
                        //@"そしてまた会えたら……",
                        //@"その時はわたしたち友達になろう"
                    },
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yucco_reverse,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"はい" + System.Environment.NewLine +
                        @"待ってます",
                        @"……",
                        @"そういえば……"
                    },
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yucco_reverse,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event62()
        {
            return eventController.timeWait(1000);
        }

        public bool event63()
        {
            if (eventController.ShockWave3.gameObject.activeSelf == false)
            {
                eventController.ShockWave3.transform.position = eventController.Yuko.transform.position;
                eventController.ShockWave3.gameObject.SetActive(true);
                eventController.ShockWave3.Play();
            }

            if (eventController.timeWait(1000))
            {
                eventController.Yuko.gameObject.SetActive(false);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool event64()
        {
            if (eventController.ShockWave4.gameObject.activeSelf == false)
            {
                eventController.ShockWave4.transform.position = eventController.Player.transform.position;
                eventController.ShockWave4.gameObject.SetActive(true);
                eventController.ShockWave4.Play();
            }

            if (eventController.timeWait(1000))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool event65()
        {
            eventController.Blackout.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f, 0.0f);
            return true;
        }

        private bool event66()
        {
            eventController.Player.transform.position = eventController.MovePoint3.transform.position;
            eventController.Player.transform.rotation = eventController.MovePoint3.transform.rotation;
            eventController.Player.Sit();
            eventController.EventCamera2.gameObject.SetActive(false);
            eventController.EventCamera3.gameObject.SetActive(true);

            if (eventController.timeWait(1500))
            {
                eventController.Yuko.gameObject.SetActive(false);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool event67()
        {
            UnityEngine.RenderSettings.skybox = eventController.Skybox;
            return true;
        }

        private bool event68()
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

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event69()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あれ？ここは？",
                        @"……",
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そうだ わたし",
                        @"お世話になった先生に会いに行くため" + System.Environment.NewLine +
                        @"電車に乗ってて……",
                        @"それで寝ちゃったのか",
                        @"みんなちゃんと戻れたかな？",
                        @"戻れてるよね" + System.Environment.NewLine +
                        @"うん！きっと戻ってる",
                        @"わたしが出られてるんだから",
                        @"先生に会ったあと" + System.Environment.NewLine +
                        @"あの町に行ってみよう",
                        @"ところで ゆい子ちゃんの最後の話"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event70()
        {
            eventController.Blackout.color = new UnityEngine.Color(0.0f, 0.0f, 0.0f, 0.0f);
            return true;
        }

        private bool event71()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そういえば一つ気になってたことが……",
                        @"わたしたちって" + System.Environment.NewLine +
                        @"元から知り合いだったりしないですよね？",
                        @"いや ゆっこさんが" + System.Environment.NewLine +
                        @"どうやってこの世界に来たのかが不思議で",
                    },
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event72()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"言われてみれば不思議なんだよね",
                        @"ゆい子ちゃんの無意識に" + System.Environment.NewLine +
                        @"助けを求める気持ちがあって",
                        @"それに呼ばれたとか……？",
                        @"うーん 先生だったら何かわかるかな？" + System.Environment.NewLine +
                        @"会うついでに聞いてみようか"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event73()
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

        private bool event74()
        {
            if (new SaveController00().completed_PlayButton() == false)
            {
                SaveController_End06 saveController_End06 = new SaveController_End06();
                saveController_End06.complete_Event_End06_01_Ending();

                SaveController00 saveController00 = new SaveController00();
                saveController00.deleteAllKeys();
                saveController00.save_Scene(SaveController.SceneNo.Scene01, SaveController.PlaceNo.None);
            }
            eventController.loadScene(@"stage_endroll");
            return true;
        }
    }
}