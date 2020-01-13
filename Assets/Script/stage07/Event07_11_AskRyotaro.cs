using UnityEngine;
using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event07_11_AskRyotaro : Event_ChangeBgm1
    {
        private EventController07 eventController07;
        private SaveController05 saveController05 = new SaveController05();
        private SaveController07 saveController07 = new SaveController07();

        public Event07_11_AskRyotaro(EventController07 eventController) : base(eventController)
        {
            this.eventController07 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(eventController07.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController07.lightOn));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(eventController07.lightOff));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(eventController07.lightOn));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            eventController07.Player.transform.position = new Vector3(
                eventController07.MovePoint3.transform.position.x,
                eventController07.Player.transform.position.y,
                eventController07.MovePoint3.transform.position.z
            );
            eventController07.Player.transform.rotation = eventController07.MovePoint3.transform.rotation;

            eventController07.Ryotaro1.gameObject.SetActive(true);

            eventController07.Mountains.SetActive(true);
            eventController07.EventPanel4.SetActive(false);
            return true;
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……という状況で"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"道中聞いてたけれど" + System.Environment.NewLine +
                        @"ここまで多いとはね",
                        @"じゃあ さっき打ち合わせたように" + System.Environment.NewLine +
                        @"オレが気を引くからその間に通りぬけて"
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
                        @"やっぱり他の方法を探そう" + System.Environment.NewLine +
                        @"何度も言うように危なすぎるよ"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
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
                        @"大丈夫！",
                        @"失敗しても本当に死ぬわけじゃないし" + System.Environment.NewLine +
                        @"足にはけっこう自信あるから！"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event3()
        {
            return eventController07.charaRun(
                    eventController07.Ryotaro1,
                    eventController07.MovePoint4
                    );
        }

        private bool event4()
        {
            return eventController07.charaRun(
                    eventController07.Ryotaro1,
                    eventController07.MovePoint5
                    );
        }

        private bool event5()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ああああああああ！"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro
                    ));

            return eventController07.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event6()
        {
            eventController07.Ryotaro1.gameObject.SetActive(false);
            eventController07.Enemies1.SetActive(false);

            eventController07.Mountains.SetActive(true);
            eventController07.EventPanel10.SetActive(false);

            saveController07.complete_Event07_11_AskRyotaro();
            return true;
        }
    }
}