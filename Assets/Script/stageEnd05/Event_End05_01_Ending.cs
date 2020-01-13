using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event_End05_01_Ending
    {
        private EventController_End05 eventController;

        public Event_End05_01_Ending(EventController_End05 eventController)
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
            eventList.Add(new EventController.eventProcess(event17));
            eventList.Add(new EventController.eventProcess(event18));
            eventList.Add(new EventController.eventProcess(event19));
            eventList.Add(new EventController.eventProcess(event20));
            eventList.Add(new EventController.eventProcess(event21));
            eventList.Add(new EventController.eventProcess(event22));
            eventList.Add(new EventController.eventProcess(event23));
            eventList.Add(new EventController.eventProcess(event24));
            eventList.Add(new EventController.eventProcess(event25));
            eventList.Add(new EventController.eventProcess(event26));
            eventList.Add(new EventController.eventProcess(event27));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event28));
            eventList.Add(new EventController.eventProcess(event29));
            eventList.Add(new EventController.eventProcess(event30));
            eventList.Add(new EventController.eventProcess(event31));
            eventList.Add(new EventController.eventProcess(event32));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(eventController.playEvent2Bgm_Begin));
            eventList.Add(new EventController.eventProcess(event33));
            eventList.Add(new EventController.eventProcess(event34));
            eventList.Add(new EventController.eventProcess(event35));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event36));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event37));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event38));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event39));
            eventList.Add(new EventController.eventProcess(event40));
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
            eventController.Blackout.color = new UnityEngine.Color(0.7f, 0.7f, 0.7f, 0.0f);
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

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"どうしてそこまで"
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
                        @"きっとすぐにわかるよ",
                        @"わたしがどれだけ" + System.Environment.NewLine +
                        @"取り返しのつかないことをしたか"
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
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
            return eventController.charaTurnaround(eventController.Yuko, eventController.Devil.gameObject);
        }

        private bool event18()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そういうことだから 悪魔",
                        @"わたしはこの世界に残る" + System.Environment.NewLine +
                        @"みんなのことは帰してあげて",
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
                        @"わかった"
                    },
                    CharaTalkController.Texture.talk_devil,
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
                        @"ちょっと！" + System.Environment.NewLine +
                        @"勝手に話を進めないでよ"
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
                        @"ごめん",
                        @"前から決めてたんだ" + System.Environment.NewLine +
                        @"バレたら終わりにするって",
                        @"もう満足したから"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_yuko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event19()
        {
            eventController.DustStorm1.gameObject.SetActive(true);
            eventController.DustStorm1.Play();
            return true;
        }

        public bool event20()
        {
            eventController.DustStorm1.gameObject.SetActive(true);
            eventController.DustStorm1.Play();
            return true;
        }

        private bool event21()
        {
            eventController.Blackout.color = new UnityEngine.Color(0.7f, 0.7f, 0.7f, 0.0f);
            return true;
        }

        private bool event22()
        {
            eventController.charaWalk(eventController.Yuko, eventController.MovePoint2);
            return eventController.charaWalk(eventController.Devil, eventController.MovePoint2, 90.0f);
        }

        private bool event23()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"まだ話は終わってないでしょ"
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

        private bool event24()
        {
            eventController.charaWalk(eventController.Devil, eventController.MovePoint2);
            eventController.charaWalk(eventController.Yuko, eventController.MovePoint2);
            return eventController.charaRun(eventController.Meiko, eventController.Yuko.gameObject, 105.0f);
        }

        private bool event25()
        {
            eventController.charaWalk(eventController.Devil, eventController.MovePoint2);
            eventController.charaWalk(eventController.Yuko, eventController.MovePoint2);
            eventController.charaRun(eventController.Meiko, eventController.Yuko.gameObject);
            return eventController.lightOff();
        }

        private bool event26()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ちょっと！" + System.Environment.NewLine +
                        @"なんなの この霧！"
                    },
                    CharaTalkController.Texture.talk_meiko,
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
                        @"待って めいちゃん" + System.Environment.NewLine +
                        @"一人はあぶない！"
                    },
                    CharaTalkController.Texture.talk_yucco,
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
                        @"一回集まろう",
                        @"オレがそっちに行くから" + System.Environment.NewLine +
                        @"二人ともその場で待ってくれ"
                    },
                    CharaTalkController.Texture.talk_ryotaro,
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
                        @"わかった",
                        @"場所わかる？" + System.Environment.NewLine +
                        @"こっちだよ"
                    },
                    CharaTalkController.Texture.talk_yucco,
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
                        @"ん？こっちか？"
                    },
                    CharaTalkController.Texture.talk_ryotaro,
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
                        @"そう" + System.Environment.NewLine +
                        @"こっちこっち！"
                    },
                    CharaTalkController.Texture.talk_yucco,
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
                        @"お！ここだな"
                    },
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event27()
        {
            eventController.Yuko.gameObject.SetActive(false);
            eventController.Devil.gameObject.SetActive(false);
            eventController.EventCamera1.gameObject.SetActive(false);
            eventController.EventCamera2.gameObject.SetActive(true);
            eventController.Enemy1.gameObject.SetActive(true);
            return true;
        }

        private bool event28()
        {
            return eventController.EventCamera2.gameObject.Slope(eventController.Enemy1.gameObject, 0.5f);
        }

        //private bool event29()
        //{
        //    List<CharaTalk> charaTalkList = new List<CharaTalk>();

        //    charaTalkList.Add(
        //        new CharaTalk(
        //            new string[]
        //            {
        //                @"ひっ！"
        //            },
        //            CharaTalkController.Texture.talk_yucco_surprised,
        //            CharaTalkController.Texture.hide,
        //            CharaTalkController.Texture.hide,
        //            CharaTalkController.Color.white,
        //            CharaTalkController.Color.gray,
        //            CharaTalkController.Color.gray
        //            ));

        //    return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        //}

        private bool event29()
        {
            eventController.VoiceEnemy.Play();
            return true;
        }

        private bool event30()
        {
            return eventController.charaRun(eventController.Enemy1, eventController.EventCamera2.gameObject, 15.0f);
        }

        private bool event31()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"きゃああ！"
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
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
                        @"なんだこいつら",
                        @"うわああ！！！"
                    },
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"いや！ちょっと！",
                        @"あああ！"
                    },
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event32()
        {
            eventController.Blackout.color = new UnityEngine.Color(0.0f, 0.0f, 0.0f, 0.0f);
            return true;
        }

        private bool event33()
        {
            eventController.Player.transform.position = eventController.MovePoint3.transform.position;
            eventController.Player.transform.rotation = eventController.MovePoint3.transform.rotation;
            eventController.Player.Sit();
            eventController.EventCamera2.gameObject.SetActive(false);
            eventController.EventCamera3.gameObject.SetActive(true);
            return true;
        }

        private bool event34()
        {
            UnityEngine.RenderSettings.skybox = eventController.Skybox;
            return true;
        }

        private bool event35()
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

        private bool event36()
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
                        @"夢から出られたのはよかったけれど" + System.Environment.NewLine +
                        @"みんなはどうなったんだろう",
                        @"りょうたろうくんと" + System.Environment.NewLine +
                        @"めいちゃんは出ていると思う",
                        @"気になるのはゆい子ちゃんだ",
                        @"駅の名前は覚えてる" + System.Environment.NewLine +
                        @"めいちゃんの家の場所も",
                        @"もう一度あの町に行ってみよう"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event37()
        {
            eventController.Player.transform.position = eventController.MovePoint4.transform.position;
            eventController.Player.transform.rotation = eventController.MovePoint4.transform.rotation;
            eventController.Sepiafilter.gameObject.SetActive(true);
            eventController.EventCamera3.gameObject.SetActive(false);
            eventController.MainCamera.gameObject.SetActive(true);
            return true;
        }

        private bool event38()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"その後 わたしはもう一度あの町へ行った",
                        @"町並みは夢で見たものと変わらず",
                        @"でも めいちゃんの家は空き家になっていた",
                        @"めいちゃんは亡くなって" + System.Environment.NewLine +
                        @"一緒に住んでいた母親はどこかへ消えたらしい",
                        @"それも十年以上も前に",
                        @"そして名前をたどって見つけた" + System.Environment.NewLine +
                        @"りょうたろうくんと ゆい子ちゃんの家も",
                        @"同じく空き家になっていた",
                        @"ゆい子ちゃんは行方知れず",
                        @"りょうたろうくんはある日正気を失って" + System.Environment.NewLine +
                        @"家族と一緒に引っ越して行ったらしい",
                        @"あの夢の後に何があったのか",
                        @"それから何年もかけて調べたけれど" + System.Environment.NewLine +
                        @"最後までわたしが真相を知ることはなかった",
                        @"ただ漠然と 自分が何か取り返しのつかない" + System.Environment.NewLine +
                        @"失敗をしたことだけは感じていた"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event39()
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

        private bool event40()
        {
            if (new SaveController00().completed_PlayButton() == false)
            {
                SaveController_End05 saveController_End05 = new SaveController_End05();
                saveController_End05.complete_Event_End05_01_Ending();

                SaveController00 saveController00 = new SaveController00();
                saveController00.deleteAllKeys();
                saveController00.save_Scene(SaveController.SceneNo.Scene01, SaveController.PlaceNo.None);
            }
            eventController.loadScene(@"stage00");
            return true;
        }
    }
}