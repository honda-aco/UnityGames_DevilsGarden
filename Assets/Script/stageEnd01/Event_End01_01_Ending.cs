using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event_End01_01_Ending
    {
        private EventController_End01 eventController;

        public Event_End01_01_Ending(EventController_End01 eventController)
        {
            this.eventController = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(eventController.stopBgm));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(eventController.playGameOverBgm_Begin));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event7));
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
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"な なんとか……",
                        @"なんとか間に合った",
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"さっきは焦ってたから" + System.Environment.NewLine +
                        @"あまり考えずに乗りこんだけれど",
                        @"本当に乗ってよかったのかな",
                        @"何もアナウンスされないし 人の気配もない",
                        @"ちゃんと走ってるし 問題ないとは思うけれど……",
                        @"……"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"じっとしてても落ち着かないな",
                        @"ほかの車両を見て回ろう"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event3()
        {
            eventController.Blackout.color = new UnityEngine.Color(0.0f, 0.0f, 0.0f, 1.0f);
            eventController.Blackout.gameObject.SetActive(true);
            return true;
        }

        private bool event4()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"きゃあっ！",
                        @"な 何！？" + System.Environment.NewLine +
                        @"急に真っ暗に……",
                        @"ちょっと待ってよ",
                        @"視界だけじゃなくて",
                        @"電車の走る音もなくなった！",
                        @"だれか" + System.Environment.NewLine + 
                        @"だれか いませんか！",
                        @"だれか！"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……",
                        @"…………",
                        @"………………",
                        @"……………………",
                        @"どのくらい時間がたったんだろう" + System.Environment.NewLine +
                        @"あれから ずっと暗闇の中にいる",
                        @"どうやら助けはこないみたい",
                        @"いっさいの光がないから" + System.Environment.NewLine +
                        @"目が慣れることはないし",
                        @"車両も地面もなくなっているのか" + System.Environment.NewLine +
                        @"何かにふれる感覚もない",
                        @"触覚はあるのに痛みは感じないから" + System.Environment.NewLine +
                        @"だんだん体の感覚もあいまいになってくる"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"これはやりたくなかったけれど" + System.Environment.NewLine +
                        @"このままここにいることに比べたら……",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ガリッ",
                        @"わたしは自分の左手首にかみつく",
                        @"かむたびに塩辛いような苦いような" + System.Environment.NewLine +
                        @"不快な味が口中に広がるけれど",
                        @"おかまいなしに何度もかむ",
                        @"この世界にきてすぐに知ったことがある",
                        @"死ぬことができることと" + System.Environment.NewLine +
                        @"死んだら決まった場所に戻ること",
                        @"助けがこないなら死ねばいいんだ" + System.Environment.NewLine +
                        @"死ねば脱出できる",
                        //@"何もない空間で死ぬ方法なんて" + System.Environment.NewLine +
                        //@"これくらいしか思いつかない",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ゔええ……",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"何度も吐きながら" + System.Environment.NewLine +
                        @"ひらすら手首にかみつく",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"気持ち悪い" + System.Environment.NewLine +
                        @"頭がおかしくなりそう",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.gray
                    ));

            //charaTalkList.Add(
            //    new CharaTalk(
            //        new string[]
            //        {
            //            @"もう狂ってたりして……",
            //        },
            //        CharaTalkController.Texture.hide,
            //        CharaTalkController.Texture.hide,
            //        CharaTalkController.Texture.hide,
            //        CharaTalkController.Color.gray
            //        ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"その後しばらくして" + System.Environment.NewLine +
                        @"待ち望んだ終わりがやってきた",
                        @"悪夢は再びくりかえされる"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event5()
        {
            if (eventController.Blackout.color.r > 1.0f)
            {
                return true;
            }
            else
            {
                eventController.Blackout.color = new UnityEngine.Color(
                                                                    eventController.Blackout.color.r + 0.01f,
                                                                    eventController.Blackout.color.g,
                                                                    eventController.Blackout.color.b,
                                                                    eventController.Blackout.color.a);
                return false;
            }
        }

        private bool event6()
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

        private bool event7()
        {
            if (new SaveController00().completed_PlayButton() == false)
            {
                SaveController_End01 saveController_End01 = new SaveController_End01();
                saveController_End01.complete_Event_End01_01_Ending();

                SaveController00 saveController00 = new SaveController00();
                saveController00.deleteAllKeys();
                saveController00.save_Scene(SaveController.SceneNo.Scene01, SaveController.PlaceNo.None);
            }
            eventController.loadScene(@"stage00");
            return true;
        }
    }
}