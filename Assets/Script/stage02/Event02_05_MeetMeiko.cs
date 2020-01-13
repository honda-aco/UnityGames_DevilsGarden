using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event02_05_MeetMeiko : Event_ChangeBgm1
    {
        private EventController02 eventController02;

        public Event02_05_MeetMeiko(EventController02 eventController) : base(eventController)
        {
            this.eventController02 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(start);
            eventList.Add(event1);
            eventList.Add(event2);
            eventList.Add(eventController02.lightOff);
            eventList.Add(event3);
            eventList.Add(eventController02.lightOn);
            eventList.Add(event4);
            eventList.Add(event5);
            eventList.Add(end);
            return eventList;
        }

        public bool event1()
        {
            // めいがこちらを見る
            return eventController02.charaTurnaround(
                eventController02.Meiko,
                eventController02.Player.gameObject);
        }

        public bool event2()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あれ？普通の人？",
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

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event3()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

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

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event4()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

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
                        @"目の前の家がわたしの家だから" + System.Environment.NewLine +
                        @"何かあったらいつでも来てね",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event5()
        {
            // イベント完了を保存
            SaveController02 saveController02 = new SaveController02();
            saveController02.complete_Event02_05_MeetMeiko();
            return true;
        }
    }
}