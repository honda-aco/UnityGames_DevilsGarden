using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event04_11_01_EnterCeremony : Event_ChangeBgm1
    {
        protected EventController04 eventController04;
        private SaveController04 saveController = new SaveController04();

        public Event04_11_01_EnterCeremony(EventController04 eventController) : base(eventController)
        {
            this.eventController04 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(lightOff_FirstEvent));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(lightOn_FirstEvent));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(lightOff_FirstEvent));
            eventList.Add(new EventController.eventProcess(event2_2));
            eventList.Add(new EventController.eventProcess(lightOn_FirstEvent));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(lightOff_FirstEvent));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(lightOn_FirstEvent));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(lightOff_FirstEvent));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(lightOn_FirstEvent));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(lightOff_FirstEvent));
            eventList.Add(new EventController.eventProcess(lightOn_FirstEvent));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(event10_2));
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
            eventList.Add(new EventController.eventProcess(eventController04.lightOff));
            eventList.Add(new EventController.eventProcess(event24));
            eventList.Add(new EventController.eventProcess(eventController04.lightOn));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        protected bool lightOff_FirstEvent()
        {
            if (saveController.completed_Event04_11_EnterCeremony1())
            {
                return true;
            }
            else
            {
                return eventController04.lightOff();
            }
        }

        protected bool lightOn_FirstEvent()
        {
            if (saveController.completed_Event04_11_EnterCeremony1())
            {
                return true;
            }
            else
            {
                return eventController04.lightOn();
            }
        }
        
        protected bool event1()
        {
            eventController04.MainCamera.SetActive(false);
            eventController04.EventCamera4.SetActive(true);
            eventController04.Player.transform.position = eventController04.MovePoint3.transform.position;
            eventController04.Player.transform.rotation = eventController04.MovePoint3.transform.rotation;
            return true;
        }

        protected bool event2()
        {
            if (saveController.completed_Event04_11_EnterCeremony1())
            {
                return true;
            }
            else
            {
                List<CharaTalk> charaTalkList= new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"ねじれた動物がつるされてる",
                            @"ウサギ？" + System.Environment.NewLine +
                            @"それよりもここはいったい……？"
                        },
                        CharaTalkController.Texture.talk_yucco_surprised,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"どうしよう" + System.Environment.NewLine +
                            @"おそろしいことをしてしまった",
                            @"どうしよう",
                            @"どうしたら",
                        },
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"どうしよう",
                            @"どうにかしなきゃ",
                            @"どうしてこんなこと……",
                            @"どうしよう",
                        },
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
        }

        protected bool event2_2()
        {
            if (saveController.completed_Event04_11_EnterCeremony1())
            {
                return true;
            }
            else
            {
                eventController04.Ceremony.SetActive(false);
                return true;
            }
        }

        protected bool event3()
        {
            if (saveController.completed_Event04_11_EnterCeremony1())
            {
                return true;
            }
            else
            {
                List<CharaTalk> charaTalkList= new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"……",
                            @"見つけなきゃ……",
                            @"見つけてかえしてもらわなきゃ"
                        },
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
        }

        protected bool event4()
        {
            if (saveController.completed_Event04_11_EnterCeremony1())
            {
                return true;
            }
            else
            {
                return eventController04.charaWalk(eventController04.Yuko_Black, eventController04.MovePoint4);
            }
        }

        protected bool event5()
        {
            if (saveController.completed_Event04_11_EnterCeremony1())
            {
                return true;
            }
            else
            {
                eventController04.Yuko_Black.transform.position = eventController04.MovePoint5.transform.position;
                eventController04.Yuko_Black.transform.rotation = eventController04.MovePoint5.transform.rotation;
                return true;
            }
        }

        protected bool event6()
        {
            if (saveController.completed_Event04_11_EnterCeremony1())
            {
                return true;
            }
            else
            {
                List<CharaTalk> charaTalkList= new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"どこにつれていかれたんだろう",
                            @"今日こそ見つけないと",
                        },
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
        }

        protected bool event7()
        {
            if (saveController.completed_Event04_11_EnterCeremony1())
            {
                return true;
            }
            else
            {
                return eventController04.charaWalk(eventController04.Yuko_Black, eventController04.MovePoint4);
            }
        }

        protected bool event8()
        {
            if (saveController.completed_Event04_11_EnterCeremony1())
            {
                return true;
            }
            else
            {
                eventController04.Yuko_Black.transform.position = eventController04.MovePoint5.transform.position;
                eventController04.Yuko_Black.transform.rotation = eventController04.MovePoint5.transform.rotation;
                return true;
            }
        }

        protected bool event9()
        {
            // イベント初回ではなくウサギもない場合はこのメッセージのみ見せる
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"いない",
                        @"今日も見つからない",
                        @"見つからない！" + System.Environment.NewLine +
                        @"見つからない！",
                        @"見つからない！！！" + System.Environment.NewLine +
                        @"見つからない！！！",
                        @"見つからない！！！！！！" + System.Environment.NewLine +
                        @"見つからない！！！！！！",
                    },
                    CharaTalkController.Texture.talk_girl_black,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        protected bool event10()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                BgmController.GetInstance().playEvent2Bgm(true);
                return true;
            }
            else
            {
                return true;
            }
        }

        protected bool event10_2()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                return eventController04.charaTurnaround(
                            eventController04.Yuko_Black,
                            eventController04.Player.gameObject);
            }
            else
            {
                return true;
            }
        }

        protected bool event11()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                List<CharaTalk> charaTalkList= new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"うそ……",
                            @"その子をどこで見つけたの？",
                            @"ずっと見つからなかったのに",
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.white
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"その子？"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"あなたのつれてるウサギのこと",
                            @"わたし その子をずっと探していたの"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.white
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"ウサギって このぬいぐるみの？",
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));

                return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
            else
            {
                return true;
            }
        }

        protected bool event12()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                eventController04.Shockwave1.transform.position = eventController04.MovePoint6.transform.position;
                eventController04.Shockwave1.transform.rotation = eventController04.MovePoint6.transform.rotation;
                eventController04.Shockwave1.gameObject.SetActive(true);
                eventController04.Shockwave1.Play();
                return true;
            }
            else
            {
                return true;
            }
        }

        protected bool event13()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                if (eventController04.timeWait(1000))
                {
                    eventController04.Rabbit.transform.position = eventController04.MovePoint6.transform.position;
                    eventController04.Rabbit.transform.rotation = eventController04.MovePoint6.transform.rotation;
                    eventController04.Rabbit.gameObject.SetActive(true);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        protected bool event14()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                List<CharaTalk> charaTalkList = new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"！？" + System.Environment.NewLine +
                            @"ぬいぐるみが……"
                        },
                        CharaTalkController.Texture.talk_yucco_surprised,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));

                return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
            else
            {
                return true;
            }
        }

        protected bool event15()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                return eventController04.charaWalk(
                            eventController04.Rabbit,
                            eventController04.Yuko_Black.gameObject,
                            10.0f);
            }
            else
            {
                return true;
            }
        }

        protected bool event16()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                List<CharaTalk> charaTalkList= new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"ごめんなさい" + System.Environment.NewLine +
                            @"わたし とりかえしのつかないことを",
                        },
                        CharaTalkController.Texture.talk_yucco_surprised,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.white
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"本当にごめんなさい",
                            @"あやまって許されるとは思わないけれど" + System.Environment.NewLine +
                            @"それでもあやまりたかった"
                        },
                        CharaTalkController.Texture.talk_yucco_surprised,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.white
                        ));

                return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
            else
            {
                return true;
            }
        }

        protected bool event17()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                List<CharaTalk> charaTalkList= new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"ねえ あなたは……"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_girl_black,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));

                return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
            else
            {
                return true;
            }
        }

        protected bool event18()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                eventController04.Effect3.gameObject.SetActive(true);
                eventController04.Effect3.Play();
                eventController04.Yuko_Black.gameObject.SetActive(false);
                return true;
            }
            else
            {
                return true;
            }
        }

        protected bool event19()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                return eventController04.playerWalk(eventController04.Yuko_Black.gameObject);
            }
            else
            {
                return true;
            }
        }

        protected bool event20()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                List<CharaTalk> charaTalkList = new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"消えちゃった",
                            @"……",
                        },
                        CharaTalkController.Texture.talk_yucco_awayright,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
            else
            {
                return true;
            }
        }

        protected bool event21()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                return eventController04.playerTurnaround(eventController04.Rabbit.gameObject);
            }
            else
            {
                return true;
            }
        }

        protected bool event22()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                List<CharaTalk> charaTalkList= new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"わたしは行くけれど" + System.Environment.NewLine +
                            @"あなたもひとりなら いっしょに来る？"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_rabbit,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"……"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_rabbit,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.white
                        ));

                charaTalkList.Add(
                     new CharaTalk(
                        new string[]
                        {
                            @"うん じゃあいっしょに行こう"
                        },
                        CharaTalkController.Texture.talk_yucco_close,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_rabbit,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));

                return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
            else
            {
                return true;
            }
        }

        protected bool event23()
        {
            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                eventController04.Rabbit.gameObject.SetActive(false);
                return true;
            }
            else
            {
                return true;
            }
        }

        protected bool event24()
        {
            if (saveController.completed_Event04_11_EnterCeremony1() == false)
            {
                // 前半部分の完了フラグを立てる
                saveController.complete_Event04_11_EnterCeremony1();
            }

            if (saveController.completed_Event04_03_FindRabbit1() &&
                saveController.completed_Event04_04_FindRabbit2())
            {
                // 後半部分の完了フラグを立てる
                saveController.complete_Event04_11_EnterCeremony2();
                saveController.save_KeyItem3Status(SaveController.KeyItemStatus.Level_100);
                eventController04.Update_KeyItem3();
            }
            else
            {
                eventController04.EventPanel11_2_1.SetActive(true);
                eventController04.EventPanel11_2_2.SetActive(true);
                eventController04.EventPanel11_2_3.SetActive(true);
                eventController04.EventPanel11_2_4.SetActive(true);
            }
            eventController04.MainCamera.SetActive(true);
            eventController04.EventCamera4.SetActive(false);
            return true;
        }
    }
}