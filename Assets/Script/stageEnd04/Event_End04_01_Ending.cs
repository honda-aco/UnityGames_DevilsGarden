using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event_End04_01_Ending
    {
        private EventController_End04 eventController;

        public Event_End04_01_Ending(EventController_End04 eventController)
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
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event11));
            eventList.Add(new EventController.eventProcess(event12));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event13));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event14));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(eventController.stopBgm));
            eventList.Add(new EventController.eventProcess(event16));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event17));
            eventList.Add(new EventController.eventProcess(eventController.playEvent3Bgm_Begin));
            eventList.Add(new EventController.eventProcess(event19));
            eventList.Add(new EventController.eventProcess(event20));
            eventList.Add(new EventController.eventProcess(event21));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event22));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event23));
            eventList.Add(new EventController.eventProcess(event24));
            eventList.Add(new EventController.eventProcess(event25));
            eventList.Add(new EventController.eventProcess(event26));
            eventList.Add(new EventController.eventProcess(event27));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event28));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event29));
            eventList.Add(new EventController.eventProcess(event30));
            eventList.Add(new EventController.eventProcess(event31));
            eventList.Add(new EventController.eventProcess(event32));
            eventList.Add(new EventController.eventProcess(eventController.playDefaultBgm_Begin));
            eventList.Add(new EventController.eventProcess(event34));
            eventList.Add(new EventController.eventProcess(event35));
            eventList.Add(new EventController.eventProcess(event36));
            eventList.Add(new EventController.eventProcess(event37));
            eventList.Add(new EventController.eventProcess(event38));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event39));
            eventList.Add(new EventController.eventProcess(event40));
            eventList.Add(new EventController.eventProcess(event41));
            eventList.Add(new EventController.eventProcess(event42));
            return eventList;
        }

        private bool event1()
        {
            Charactor.Pause();
            eventController.Yucco.Sit();
            eventController.MainCamera.gameObject.SetActive(false);
            eventController.EventCamera1.gameObject.SetActive(true);
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
                        @"この世界をつくったのは めいだね",
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
                        @"学校で何を見たのか知らないけれど" + System.Environment.NewLine +
                        @"わたしはこの世界とは無関係だよ"
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
                        @"無関係じゃないだろ",
                        @"学校でひろった紙に書いてあったよ" + System.Environment.NewLine +
                        @"あの日のことを後悔してるって",
                        @"それって あの事件のことだろ？"
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"学校に紙が……？",
                        @"そっか",
                        @"……",
                        @"たしかにわたしはあの日を後悔してる",
                        @"だから もしかしたら" + System.Environment.NewLine +
                        @"わたしの無意識がこの世界を生んだのかもね",
                        @"ただ そうだったとしても" + System.Environment.NewLine +
                        @"わたしはこの世界を終わらせ方を知らない",
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event5()
        {
            return eventController.charaTurnaround(eventController.Meiko, eventController.Player.gameObject);
        }

        private bool event6()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あなたは知ってる？",
                    },
                    CharaTalkController.Texture.talk_yucco,
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
                        @"分からない",
                        @"いつもは夢の主に自分の夢と気づかせれば" + System.Environment.NewLine +
                        @"夢が不安定になって自然に目覚めるけれど",
                        @"今回はそういう気配がないから" + System.Environment.NewLine +
                        @"もっと強引に覚ますしかないかも",
                        @"高いところからジャンプするとか" + System.Environment.NewLine +
                        @"何か強い衝撃を与えるとか……"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"死んでみるとか？"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
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
                        @"……",
                        @"そうだね",
                        @"あまり気持ちのいいものじゃないから" + System.Environment.NewLine +
                        @"最後の手段だけれど"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"痛みもないなら それが手っ取り早いかな",
                        @"あくまで夢だもんね",
                        @"だけど 少し時間をもらってもいい？" + System.Environment.NewLine +
                        @"最後にこの世界をよく見ておきたいの",
                        @"りょうたろうもそれでいいかな？"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
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
                        @"そのくらい別にかまわないよ",
                    },
                    CharaTalkController.Texture.talk_ryotaro_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event7()
        {
            return eventController.charaTurnaround(eventController.Ryotaro, eventController.Player.gameObject);
        }

        private bool event8()
        {
            return eventController.playerTurnaround(eventController.Ryotaro.gameObject);
        }

        private bool event9()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そういうわけで少し時間をもらえるかな",
                        @"オレが前に住んでた家が近くにあるから" + System.Environment.NewLine +
                        @"待ってる間 そこを使ってよ",
                        @"オレも今の家に帰るからさ" + System.Environment.NewLine +
                        @"めいも一人になりたいだろうし"
                    },
                    CharaTalkController.Texture.talk_yucco,
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
                        @"ありがとう" + System.Environment.NewLine +
                        @"そうさせてもらうね",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event10()
        {
            eventController.MainCamera.gameObject.SetActive(true);
            eventController.EventCamera1.gameObject.SetActive(false);
            eventController.Player.transform.position = eventController.MovePoint1.transform.position;
            eventController.Player.transform.rotation = eventController.MovePoint1.transform.rotation;
            eventController.Ryotaro.transform.position = eventController.MovePoint2.transform.position;
            eventController.Ryotaro.transform.rotation = eventController.MovePoint2.transform.rotation;
            return true;
        }

        private bool event11()
        {
            return eventController.charaTurnaround(eventController.Ryotaro, eventController.Player.gameObject);
        }

        private bool event12()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"どうぞ",
                        @"今は空き家だから荒れてるかもしれないけれど" + System.Environment.NewLine +
                        @"休むことくらいはできるはずだから",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event13()
        {
            eventController.Player.Sit();
            eventController.Player.transform.rotation = eventController.MovePoint3.transform.rotation;
            eventController.Player.transform.position = eventController.MovePoint3.transform.position;
            eventController.MainCamera.gameObject.SetActive(false);
            eventController.EventCamera2.gameObject.SetActive(true);
            eventController.Ryotaro.gameObject.SetActive(false);
            return true;
        }

        private bool event14()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ふう……",
                        @"一時はどうなることかと思ったけれど" + System.Environment.NewLine +
                        @"意外に早い解決でよかったな",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"歩きどおしで疲れたけどね"
                    },
                    CharaTalkController.Texture.talk_yucco_close,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event16()
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

        private bool event17()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"さて だいぶ経ったと思うけれど" + System.Environment.NewLine +
                        @"今は何時だろう？",
                        @"この部屋 時計ないのかな？"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"家具はそのままなのに" + System.Environment.NewLine +
                        @"時計だけがないなんて変な感じ",
                        @"変といえば",
                        @"りょうたろうくんは１年もかけて" + System.Environment.NewLine +
                        @"中学校にも行ってなかったんだよね",
                        @"いったいどこを調べてたんだろう"
                    },
                    CharaTalkController.Texture.talk_yucco_close,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event19()
        {
            return eventController.timeWait(2000);
        }

        private bool event20()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"いや 違うか",
                        @"りょうたろうくんは記憶を継続してなくて" + System.Environment.NewLine +
                        @"行ったことがあるかも わからないんだ",
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"でも きっと行ったよね" + System.Environment.NewLine +
                        @"学校なら知り合いがいるかもしれないんだから",
                        @"そうしたら 手紙を見つけて" + System.Environment.NewLine +
                        @"めいちゃんに会いに行ったはず",
                        @"夢の世界と知らなくても" + System.Environment.NewLine +
                        @"手がかりになると考えるだろうから",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"もし この想像が正しいなら……",
                        @"めいちゃんは自分の夢の可能性が高いと" + System.Environment.NewLine +
                        @"知っていながら黙っていたことにならない？",
                        @"……",
                        @"知ってて隠しているとしたら" + System.Environment.NewLine +
                        @"それはこの世界を続けたいからなのかな",
                        @"そのために自分にたどり着く情報を隠してた？",
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"うーん……",
                        @"ちょっと悪い方に考えすぎかな？",
                        @"そもそも隠しごとをするくらいなら" + System.Environment.NewLine +
                        @"最初から記憶のないフリをするか",
                        @"隠れていればいいんだから"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"いや それはそれで都合が悪いのかも",
                        @"だって記憶がないフリをされてたら" + System.Environment.NewLine +
                        @"わたしは一緒に行こうって誘ってた",
                        @"そうしたら死のリスクがある",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"夢の世界を続けたいのなら" + System.Environment.NewLine +
                        @"世界への影響が不確定な死は避けたいはず",
                        @"隠れているのもそう",
                        @"わたしたちに疑われてしまったら" + System.Environment.NewLine +
                        @"メモを残したり対策されるかもしれない",
                        @"そうなったら記憶がリセットされても" + System.Environment.NewLine +
                        @"いつかはつかまってしまうと考えた"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そう考えると記憶はあるけれど何も知らないって" + System.Environment.NewLine +
                        @"立場は一番都合がいいように感じる",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"だめだ！",
                        @"考えれば考えるほど" + System.Environment.NewLine +
                        @"めいちゃんがウソをついてるとしか思えなくなる",
                        @"この部屋に筆記用具がないことも" + System.Environment.NewLine +
                        @"すべてがあやしく思えてくる",
                        //@"時計と筆記用具のないこの部屋も" + System.Environment.NewLine +
                        //@"すべてが用意されていたように思えてしまう",
                        @"ここで悩んでいても仕方ない" + System.Environment.NewLine +
                        @"めいちゃんを探そう！"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));
           
            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event21()
        {
            return eventController.playerRun(eventController.MovePoint4);
        }

        private bool event22()
        {
            eventController.MainCamera2.gameObject.SetActive(true);
            eventController.EventCamera2.gameObject.SetActive(false);
            return true;
        }

        private bool event23()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"４５",
                        @"４６",
                        @"４７",
                        @"……",
                        @"あと１０秒で今日が終わる" + System.Environment.NewLine +
                        @"今日もいつもと同じ結末か……",
                    },
                    CharaTalkController.Texture.talk_meiko_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event24()
        {
            return eventController.charaWalk(eventController.Meiko2, eventController.MovePoint9);
        }

        private bool event25()
        {
            return eventController.charaTurnaround(eventController.Meiko2, eventController.MovePoint10);
        }

        private bool event26()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"明日はだれが来てくれるかな？",
                    },
                    CharaTalkController.Texture.talk_meiko_reverse,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event27()
        {
            return eventController.MainCamera2.Zoom(50.0f);
        }

        private bool event28()
        {
            eventController.MainCamera.gameObject.SetActive(true);
            eventController.MainCamera2.gameObject.SetActive(false);
            eventController.Player.transform.position = eventController.MovePoint5.transform.position;
            eventController.Player.transform.rotation = eventController.MovePoint5.transform.rotation;
            eventController.Enemy1.SetActive(true);
            UnityEngine.RenderSettings.skybox = eventController.Skybox;
            return true;
        }

        private bool event29()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"夕焼けが消えた？",
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"急ごう" + System.Environment.NewLine +
                        @"嫌な予感がする"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event30()
        {
            return eventController.playerRun(eventController.MovePoint6);
        }

        private bool event31()
        {
            eventController.Player.Idle();
            return true;
        }

        private bool event32()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"！"
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event34()
        {
            return eventController.playerTurnaround(eventController.MovePoint7, 0.03f);
        }

        private bool event35()
        {
            return eventController.playerTurnaround(eventController.MovePoint8, 0.03f);
        }

        private bool event36()
        {
            return eventController.playerTurnaround(eventController.MovePoint7, 0.03f);
        }

        private bool event37()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ここはどこだろう……",
                        @"突然知らない場所にいるってことは" + System.Environment.NewLine +
                        @"また だれかの夢に入ってるんだろうけど",
                        @"夢にしてはずいぶんリアルだ",
                        @"夢の主も近くにいないし" + System.Environment.NewLine +
                        @"なんかいつもの夢と違う感じ",
                        @"現実的で歪みが少ないってことは" + System.Environment.NewLine +
                        @"大人が見てる夢なのかな？",
                        @"まあいっか",
                        @"夢の中に入るのも久しぶりだし" + System.Environment.NewLine +
                        @"少し探検してみよう"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event38()
        {
            return eventController.playerWalk(eventController.MovePoint7);
        }

        private bool event39()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"誰かいる",
                            @"怪しい雰囲気だけど 声をかけてみよう",
                        },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event40()
        {
            return eventController.timeWait(1000);
        }

        private bool event41()
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

        private bool event42()
        {
            if (new SaveController00().completed_PlayButton() == false)
            {
                SaveController_End04 saveController_End04 = new SaveController_End04();
                saveController_End04.complete_Event_End04_01_Ending();

                SaveController00 saveController00 = new SaveController00();
                saveController00.deleteAllKeys();
                saveController00.save_Scene(SaveController.SceneNo.Scene01, SaveController.PlaceNo.None);
            }
            eventController.loadScene(@"stage00");
            return true;
        }
    }
}