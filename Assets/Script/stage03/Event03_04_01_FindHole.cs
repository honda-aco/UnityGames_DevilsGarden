using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_04_01_FindHole : Event_ChangeBgm1
    {
        private EventController03 eventController03;
        private SaveController03 saveController03 = new SaveController03();

        public Event03_04_01_FindHole(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController03.lightOff));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(eventController03.lightOn));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"まさか ここが見つかるなんて",
                        @"オレたちだけの秘密の場所なのに",
                        @"お願い！" + System.Environment.NewLine +
                        @"ここのこと だれにも言わないで！"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro_child
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ここ 秘密基地だったんだ" + System.Environment.NewLine +
                        @"わたしも昔つくってたな",
                        @"心配しなくても だれかに言ったりしないよ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro_child,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"よかった",
                        @"ここが知られると３人で遊べなくなるから"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro_child,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"？"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro_child,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"仲良しの友達がいるんだけど",
                        @"２人とも女の子だから" + System.Environment.NewLine +
                        @"一緒に遊んでると冷やかされるんだ",
                        @"だけど ここなら何も言われないから"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro_child,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"女の子でも友達なんだから" + System.Environment.NewLine +
                        @"冷やかしなんて無視したらいいよ",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro_child,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"うちの親もそう言うけどさ" + System.Environment.NewLine +
                        @"そんな簡単じゃないんだよ……"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro_child,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            if (saveController03.completed_Event03_06_MeetFather())
            {
                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"そっか",
                            @"ところで さっき" + System.Environment.NewLine +
                            @"子どもを探してるってお父さんに会ったよ",
                            @"たぶんキミのことだよね？"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_ryotaro_child,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"やばい！" + System.Environment.NewLine +
                            @"あとをつけられてたんだ",
                            @"急いで戻らないと"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_ryotaro_child,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.white
                        ));
            }
            else
            {
                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"でもまあ……" + System.Environment.NewLine +
                            @"ずっとこのままはよくないよね",
                            @"すこし考えてみるよ"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_ryotaro_child,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));
            }

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            eventController03.Ryotaro.gameObject.SetActive(false);
            // 帰る場合、途中で父親に会うはずなので父親も非表示にする
            eventController03.Father.gameObject.SetActive(false);
            eventController03.EventPanel7.SetActive(false);
            return true;
        }

        private bool event3()
        {
            // イベント完了を保存
            SaveController03 saveController03 = new SaveController03();
            saveController03.complete_Event03_04_01_FindHole();
            saveController03.save_KeyItem2Status(SaveController.KeyItemStatus.Level_75);
            eventController03.Update_KeyItem2();
            return true;
        }
    }
}