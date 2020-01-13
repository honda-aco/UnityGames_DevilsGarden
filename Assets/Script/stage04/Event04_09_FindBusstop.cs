using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event04_09_FindBusstop : Event_ChangeBgm1
    {
        private EventController04 eventController04;
        SaveController04 saveController04 = new SaveController04();

        public Event04_09_FindBusstop(EventController04 eventController) : base(eventController)
        {
            this.eventController04 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(eventController04.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController04.lightOn));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(event11));
            eventList.Add(new EventController.eventProcess(event12));
            eventList.Add(new EventController.eventProcess(event13));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            eventController04.EventCamera3.SetActive(true);
            eventController04.MainCamera.SetActive(false);
            return true;
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"バスの時刻表だ",
                        @"平日 06:08",
                        @"一本だけ……",
                        @"そもそも今は何時なんだろう",
                        @"バスが走ってるかもあやしいし" + System.Environment.NewLine +
                        @"待つよりは進むべきかな"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event3()
        {
            if (saveController04.completed_Event04_09_FindBusstop())
            {
                return true;
            }
            else
            {
                eventController04.Yuko.gameObject.SetActive(true);
                return true;
            }
        }

        private bool event4()
        {
            if (saveController04.completed_Event04_09_FindBusstop())
            {
                return true;
            }
            else
            {
                return eventController04.charaWalk(eventController04.Yuko, eventController04.MovePoint1);
            }
        }

        private bool event5()
        {
            if (saveController04.completed_Event04_09_FindBusstop())
            {
                return true;
            }
            else
            {
                return eventController04.playerTurnaround(eventController04.Yuko.gameObject);
            }
        }

        private bool event6()
        {
            if (saveController04.completed_Event04_09_FindBusstop())
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
                            @"あ、あのー……"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
        }

        private bool event8()
        {
            if (saveController04.completed_Event04_09_FindBusstop())
            {
                return true;
            }
            else if (saveController04.get_KeyItem3Status() == SaveController.KeyItemStatus.Level_100)
            {
                return eventController04.charaTurnaround(
                            eventController04.Yuko,
                            eventController04.Player.gameObject);
            }
            else
            {
                return true;
            }
        }

        private bool event9()
        {
            if (saveController04.completed_Event04_09_FindBusstop())
            {
                return true;
            }
            else if (saveController04.get_KeyItem3Status() == SaveController.KeyItemStatus.Level_100)
            {
                List<CharaTalk> charaTalkList= new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"かわいいウサギだね",
                            @"大切にしてあげて",
                            @"その子の飼い主こわい人だから" + System.Environment.NewLine +
                            @"何かあったら大変だよ"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_yuko,
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

        private bool event10()
        {
            if (saveController04.completed_Event04_09_FindBusstop())
            {
                return true;
            }
            else
            {
                return eventController04.charaWalk(eventController04.Yuko, eventController04.MovePoint2);
            }
        }

        private bool event11()
        {
            if (saveController04.completed_Event04_09_FindBusstop())
            {
                return true;
            }
            else
            {
                eventController04.Yuko.gameObject.SetActive(false);
                return true;
            }
        }

        private bool event12()
        {
            if (saveController04.completed_Event04_09_FindBusstop())
            {
                return true;
            }
            else if (saveController04.get_KeyItem3Status() == SaveController.KeyItemStatus.Level_100)
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
                            @"ふしぎな雰囲気の子",
                            @"なんでだろう",
                            @"無視されたのに" + System.Environment.NewLine +
                            @"いやな気分にならなかったな"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));

                return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
        }

        private bool event13()
        {
            saveController04.complete_Event04_09_FindBusstop();

            eventController04.EventCamera3.SetActive(false);
            eventController04.MainCamera.SetActive(true);
            return true;
        }
    }
}