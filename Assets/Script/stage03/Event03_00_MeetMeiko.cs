using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_00_MeetMeiko : Event_ChangeBgm1
    {
        private EventController03 eventController03;

        public Event03_00_MeetMeiko(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
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
            eventList.Add(new EventController.eventProcess(eventController03.lightOff));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(eventController03.lightOn));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            eventController03.Meiko.gameObject.SetActive(true);
            return true;
        }

        private bool event2()
        {
            return eventController03.charaRun(eventController03.Meiko, eventController03.Player.gameObject, 20.0f);
        }

        private bool event3()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"待ってくださーい"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event4()
        {
            return eventController03.playerTurnaround(eventController03.Meiko.gameObject);
        }

        private bool event5()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"まさか怪物じゃない人がいるなんて！",
                        @"ここには怪物しかいないと思っていたのに" + System.Environment.NewLine +
                        @"どこから来たんですか？"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"どこからっていうか 気づいたらここにいた感じで",
                        @"えっと 色々聞きたいことがあるんですが",
                        @"ここはどこなんですか？" + System.Environment.NewLine +
                        @"それとあの怪物たちはいったい？"
                    },
                    CharaTalkController.Texture.talk_yucco,
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
                        @"ここがどこなのか わたしもよく分からないんです",
                        @"場所的にはわたしの住んでいた町なんだけど" + System.Environment.NewLine +
                        @"気づいたらみんな怪物になっていて……",
                        @"なんでそうなっているのかも" + System.Environment.NewLine +
                        @"どうして自分だけ普通のままなのかも",
                        @"何も分からないんです"
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
                        @"そうなんだ……",
                        @"……",
                        @"ちょっと変な話になるんですけど",
                        @"わたしはここが夢の世界じゃないかって" + System.Environment.NewLine +
                        @"考えてるんです"
                    },
                    CharaTalkController.Texture.talk_yucco,
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
                        @"夢の世界？"
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
                        @"オカルトな話で信じてもらえないと思いますが" + System.Environment.NewLine +
                        @"わたし 他人の夢に入ることができるんです",
                        @"だからこの世界も夢の世界で" + System.Environment.NewLine +
                        @"もしかしたら あなたの見てる夢なんじゃないかと"
                    },
                    CharaTalkController.Texture.talk_yucco,
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
                        @"たしかにオカルトというか突飛な話ですね……",
                        @"でも 今のこの状況の方がオカルトですし" + System.Environment.NewLine +
                        @"夢に入れるって話は信じますよ",
                        @"ただ ここを夢の世界と考えるには" + System.Environment.NewLine +
                        @"いくらなんでも時間がたちすぎてないですか？"
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
                        @"時間がたちすぎてる……？"
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
                        @"え！？たってますよね？",
                        @"わたしの感覚だと１年" + System.Environment.NewLine +
                        @"もしかしたら もっとたってる感覚なんですが……"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event6()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"つい先ほど生まれたと思っていた世界に" + System.Environment.NewLine +
                        @"彼女は１年ちかく閉じ込められているという",
                        @"いつもの夢と違っていても" + System.Environment.NewLine +
                        @"時間がたてば終わると考えていた わたしには",
                        @"この話はとてもショックだった",
                        @"その後も話を続けたけれど" + System.Environment.NewLine +
                        @"脱出の手がかりになる情報は得られなかった"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event7()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"色々話を聞かせてくれてありがとう"
                    },
                    CharaTalkController.Texture.talk_yucco,
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
                        @"こちらこそ 話せて楽しかった",
                        @"遅くなったけれど わたし めいです",
                        @"この近くにわたしの家があるから" + System.Environment.NewLine +
                        @"何かあったらいつでも来てね",
                        @"家の前に巨大な怪物がいる家で" + System.Environment.NewLine +
                        @"来ればすぐにわかるはずだから",
                        @"それじゃあ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event8()
        {
            return eventController03.charaWalk(eventController03.Meiko, eventController03.MovePoint5);
        }

        private bool event9()
        {
            eventController03.Meiko.gameObject.SetActive(false);
            return true;
        }

        private bool event10()
        {
            // イベント完了を保存
            SaveController02 saveController02 = new SaveController02();
            saveController02.complete_Event02_05_MeetMeiko();
            return true;
        }
    }
}