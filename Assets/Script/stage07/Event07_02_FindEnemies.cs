using UnityEngine;
using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event07_02_FindEnemies : Event_ChangeBgm1
    {
        private EventController07 eventController07;
        private SaveController05 saveController05 = new SaveController05();
        private SaveController07 saveController07 = new SaveController07();

        public Event07_02_FindEnemies(EventController07 eventController) : base(eventController)
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
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(eventController07.lightOff));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(eventController07.lightOn));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            return eventController07.playerTurnaround(eventController07.MovePoint2);
        }

        private bool event2()
        {
            eventController07.MainCamera.gameObject.SetActive(false);
            eventController07.EventCamera1.gameObject.SetActive(true);
            return true;
        }

        private bool event3()
        {
            return eventController07.EventCamera1.gameObject.Move(
                        new Vector3(
                            eventController07.EventCamera1.transform.position.x,
                            eventController07.MovePoint1.transform.position.y,
                            eventController07.EventCamera1.transform.position.z),
                        5.0f,
                        1.5f);
        }

        private bool event4()
        {
            return eventController07.EventCamera1.Zoom(70.0f, 0.3f);
        }

        private bool event5()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"どうしよう……" + System.Environment.NewLine +
                        @"あの人数を突破するのはむずかしいな",
                        @"だれかが引きつけてくれたら" + System.Environment.NewLine +
                        @"抜けられるかもしれないけど"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            if (saveController07.get_KeyItem3Status().Equals(SaveController.KeyItemStatus.Level_100))
            {
                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"……",
                            @"いや ダメだよね",
                            @"うん 絶対ダメだ",
                            @"夢の中とはいえ" + System.Environment.NewLine +
                            @"ウサギにだって命があるんだから",
                            @"でも この先に進むためには……"
                        },
                        CharaTalkController.Texture.talk_yucco_awayright,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));
            }
            else if (saveController05.completed_Event05_11_MeetRyotaro())
            {
                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"そうだ" + System.Environment.NewLine +
                            @"こういう時こそ彼に相談してみよう",
                        },
                        CharaTalkController.Texture.talk_yucco_awayright,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));
            }

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event6()
        {
            eventController07.EventCamera1.gameObject.SetActive(false);
            eventController07.MainCamera.gameObject.SetActive(true);

            if (saveController07.get_KeyItem3Status().Equals(SaveController.KeyItemStatus.Level_100))
            {
                eventController07.Mountains.SetActive(false);
                eventController07.EventPanel3.SetActive(true);
                eventController07.EventPanel4.SetActive(true);
            }
            else if (saveController05.completed_Event05_11_MeetRyotaro())
            {
                eventController07.Mountains.SetActive(false);
                eventController07.EventPanel10.SetActive(true);
                eventController07.EventPanel11.SetActive(true);
            }
            else
            {
                eventController07.Mountains.SetActive(true);
            }
            return true;
        }
    }
}