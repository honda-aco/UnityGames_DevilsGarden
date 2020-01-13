using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event07_08_MoveMeiko : Event_ChangeBgm1
    {
        private EventController07 eventController07;
        private SaveController07 saveController07 = new SaveController07();

        public Event07_08_MoveMeiko(EventController07 eventController) : base(eventController)
        {
            this.eventController07 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            return eventList;
        }

        public bool event2()
        {
            if (saveController07.completed_Event07_07_FindLetter2())
            {
                return eventController07.playerTurnaround(eventController07.Ryotaro2.gameObject);
            }
            else
            {
                return true;
            }
        }

        public bool event3()
        {
            if (saveController07.completed_Event07_07_FindLetter2())
            {
                return eventController07.charaWalk(eventController07.Ryotaro2, eventController07.Player.gameObject, 8.0f);
            }
            else
            {
                return true;
            }
        }

        public bool event4()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"じゃあ行こうか"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro
                    ));

            if (saveController07.completed_Event07_07_FindLetter2())
            {
                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"ちょっと待って",
                            @"むこうで赤い日記をひろったんだけど" + System.Environment.NewLine +
                            @"中を見てくれる？",
                            @"この内容は" + System.Environment.NewLine +
                            @"めいちゃんが書いたものじゃないよね？"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_ryotaro,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));
            }

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event5()
        {
            if (saveController07.completed_Event07_07_FindLetter2())
            {
                return eventController07.lightOff();
            }
            else
            {
                return true;
            }
        }

        public bool event6()
        {
            if (saveController07.completed_Event07_07_FindLetter2())
            {
                return eventController07.lightOn();
            }
            else
            {
                return true;
            }
        }

        public bool event7()
        {
            if (saveController07.completed_Event07_07_FindLetter2())
            {
                List<CharaTalk> charaTalkList = new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"たしかに これはめいじゃない" + System.Environment.NewLine +
                            @"そうなると遺書の意味もかわってくるか……",
                            @"勘違いしてたんだな" + System.Environment.NewLine +
                            @"気づいてもよかった",
                            @"あの事件をつよく後悔していたのは" + System.Environment.NewLine +
                            @"めいだけじゃなかったこと"
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
                            @"これを書いたのはだれだかわかる？"
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
                            @"わかる",
                            @"めいと これを書いた人間" + System.Environment.NewLine +
                            @"そしてオレの３人は幼なじみだから"
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
            else
            {
                return true;
            }
        }

        public bool event8()
        {
            SaveController07 saveController07 = new SaveController07();
            saveController07.save_Scene(SaveController.SceneNo.Scene07, SaveController.PlaceNo.Place01);

            eventController07.loadScene(@"stage08");
            Charactor.Restart();
            return true;
        }
    }
}