using UnityEngine;
using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event05_07_01_MeetDevil : Event_DeferredBgm
    {
        private EventController05 eventController05;
        private SaveController03 saveController03 = new SaveController03();

        public Event05_07_01_MeetDevil(EventController05 eventController) : base(eventController)
        {
            this.eventController05 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(eventController05.lightOff));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(eventController05.lightOn));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(event11));
            eventList.Add(new EventController.eventProcess(event12));
            eventList.Add(new EventController.eventProcess(eventController05.lightOff));
            eventList.Add(new EventController.eventProcess(event13));
            eventList.Add(new EventController.eventProcess(eventController05.lightOn));
            eventList.Add(new EventController.eventProcess(end));

            return eventList;
        }

        private bool event1()
        {
            return eventController05.charaTurnaround(eventController05.Devil, eventController05.Player.gameObject);
        }

        private bool event2()
        {
            return eventController05.playerTurnaround(eventController05.Devil.gameObject);
        }

        private bool event3()
        {
            if (saveController03.completed_Event03_09_MeetDevil())
            {
                BgmController.GetInstance().playEvent4Bgm();
                return true;
            }
            else
            {
                return true;
            }
        }

        private bool event4()
        {
            if (saveController03.completed_Event03_09_MeetDevil())
            {
                List<CharaTalk> charaTalkList = new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"やあ また会ったね",
                            @"おまえさ ここから出たいんだろ？",
                            @"だったら急いだ方がいい" + System.Environment.NewLine +
                            @"早くしないと間に合わないよ"
                        },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_devil
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"？"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_devil,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));

                return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
            else
            {
                return true;
            }
        }

        private bool event6()
        {
            if (saveController03.completed_Event03_09_MeetDevil())
            {
                BgmController.GetInstance().playDefaultBgm();
                return true;
            }
            else
            {
                return true;
            }
        }

        private bool event5()
        {
            eventController05.MainCamera.gameObject.SetActive(false);
            eventController05.EventCamera1.gameObject.SetActive(true);
            return true;
        }

        private bool event7()
        {
            eventController05.RailroadCrossing1.MotionStop();
            eventController05.RailroadCrossing2.MotionStop();
            return true;
        }

        private bool event8()
        {
            return eventController05.EventCamera1.gameObject.Move(
                        new Vector3(
                            eventController05.MovePoint5.transform.position.x, 
                            eventController05.EventCamera1.transform.position.y,
                            eventController05.MovePoint5.transform.position.z),
                        5.0f,
                        1.5f);
        }

        private bool event9()
        {
            eventController05.Train1.SetActive(true);
            return true;
        }

        private bool event10()
        {
            eventController05.SeTrain.Play();
            return true;
        }

        private bool event11()
        {
            return eventController05.Train1.Move(
                        new Vector3(
                            eventController05.MovePoint6_1.transform.position.x,
                            eventController05.Train1.transform.position.y,
                            eventController05.MovePoint6_1.transform.position.z),
                        5.0f,
                        2.0f);
        }

        private bool event12()
        {
            eventController05.RailroadCrossing1.MotionPass();
            eventController05.RailroadCrossing2.MotionPass();
            return true;
        }

        private bool event13()
        {
            if (saveController03.completed_Event03_09_MeetDevil())
            {
                eventController05.EventPanel7_2.SetActive(true);
            }

            // イベント完了を保存
            SaveController05 saveController05 = new SaveController05();
            saveController05.complete_Event05_07_01_MeetDevil();

            eventController05.MainCamera.gameObject.SetActive(true);
            eventController05.EventCamera1.gameObject.SetActive(false);
            return true;
        }
    }
}