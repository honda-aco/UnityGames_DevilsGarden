using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Assets.Script
{
    public class Event04_04_FindRabbit2 : Event_ChangeBgm1
    {
        private EventController04 eventController04;
        private SaveController04 saveController04 = new SaveController04();

        public Event04_04_FindRabbit2(EventController04 eventController) : base(eventController)
        {
            this.eventController04 = eventController;
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
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            if (saveController04.completed_Event04_03_FindRabbit1())
            {
                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"足元に何か落ちてる",
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"ぬいぐるみのアタマを手に入れた"
                        },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"これとさっき拾ったカラダをつなげると……"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"ウサギのぬいぐるみを手に入れた"
                        },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"これって夢の主にとっては" + System.Environment.NewLine +
                            @"何か大切なものだったりするのかな？"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_rabbit,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));
            }
            else
            {
                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"足元に何か落ちてる",
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"ぬいぐるみのアタマを手に入れた"
                        },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));
            }

            return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            eventController04.MainCamera.SetActive(false);
            eventController04.EventCamera1.SetActive(true);
            return true;
        }

        private bool event3()
        {
            eventController04.Effect1.transform.position = new Vector3(
                eventController04.Enemy1.transform.position.x,
                10.0f,
                eventController04.Enemy1.transform.position.z
            );
            eventController04.Effect1.gameObject.SetActive(true);
            eventController04.Effect1.Play();

            eventController04.Effect2.transform.position = new Vector3(
                eventController04.Enemy2.transform.position.x,
                10.0f,
                eventController04.Enemy2.transform.position.z
            );
            eventController04.Effect2.gameObject.SetActive(true);
            eventController04.Effect2.Play();
            return true;
        }

        private bool event4()
        {
            eventController04.Enemy1.gameObject.SetActive(true);
            eventController04.Enemy2.gameObject.SetActive(true);
            return true;
        }

        private bool event5()
        {
            return eventController04.charaTurnaround(eventController04.Enemy1, eventController04.Player.gameObject);
        }

        private bool event6()
        {
            return eventController04.charaTurnaround(eventController04.Enemy2, eventController04.Player.gameObject);
        }

        private bool event7()
        {
            eventController04.MainCamera.SetActive(true);
            eventController04.EventCamera1.SetActive(false);
            return true;
        }

        private bool event8()
        {
            // イベント完了を保存
            saveController04.complete_Event04_04_FindRabbit2();

            if (saveController04.completed_Event04_03_FindRabbit1())
            {
                saveController04.save_KeyItem3Status(SaveController.KeyItemStatus.Level_75);
            }
            else
            {
                saveController04.save_KeyItem3Status(SaveController.KeyItemStatus.Level_50);
            }
            eventController04.Update_KeyItem3();
            return true;
        }
    }
}