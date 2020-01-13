using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event07_07_FindLetter2 : Event_ChangeBgm2
    {
        private EventController07 eventController07;
        private SaveController05 saveController05 = new SaveController05();

        public Event07_07_FindLetter2(EventController07 eventController) : base(eventController)
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
            eventList.Add(new EventController.eventProcess(eventController07.lightOff));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(eventController07.lightOn));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(end));

            return eventList;
        }

        private bool event1()
        {
            return eventController07.playerTurnaround(eventController07.MovePoint9);
        }

        private bool event2()
        {
            return eventController07.playerWalk(eventController07.MovePoint9.gameObject, 3.0f);
        }

        private bool event3()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"気味の悪い色……"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event4()
        {
            eventController07.Letter2.SetActive(false);
            return true;
        }

        private bool event5()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"いつからこうなったんだろう",
                        @"昔は単純だったのに" + System.Environment.NewLine +
                        @"今は何をするにもめんどうくさい",
                        @"まわりのことを気にせず 好きに生きたいのに" + System.Environment.NewLine +
                        @"どうしてもまわりに合わせてしまう",
                        @"今日だって めいと帰るはずなのに" + System.Environment.NewLine +
                        @"断りきれずに あの子たちと帰ってしまった",
                        @"あの子たちが わたしを誘ったのは" + System.Environment.NewLine +
                        @"めいに嫌がらせしたいからなんだろうな",
                        @"学校を出たら" + System.Environment.NewLine + 
                        @"すぐに理由をつけて別れて行ったし……",
                        @"最低な人たちだけど",
                        @"そうわかっていながら断れない" + System.Environment.NewLine +
                        @"わたしの方がもっと最低だと思う",
                        @"やっぱりこんなんじゃダメだ",
                        @"明日めいに会ったらあやまろう",
                        @"そうしてこれからは" + System.Environment.NewLine +
                        @"まわりに合わせて生きるのはやめよう"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event6()
        {
            if (saveController05.completed_Event05_06_TalkClassmate())
            {
                List<CharaTalk> charaTalkList = new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"この日記の内容……" + System.Environment.NewLine +
                            @"コンビニで会った子の話とつながる",
                            @"ということは この日記を書いた日に事件が起きたんだ"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
            else
            {
                return true;
            }
        }

        private bool event7()
        {
            SaveController07 saveController07 = new SaveController07();
            saveController07.complete_Event07_07_FindLetter2();

            if (saveController07.get_KeyItem1Status() == SaveController.KeyItemStatus.Level_75)
            {
                saveController07.save_KeyItem1Status(SaveController.KeyItemStatus.Level_100);
            }
            else
            {
                saveController07.save_KeyItem1Status(SaveController.KeyItemStatus.Level_75);
            }
            eventController07.Update_KeyItem1();

            return true;
        }
    }
}