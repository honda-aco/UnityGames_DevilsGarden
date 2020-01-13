using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event02_03_SmallTalk : Event_ChangeBgm1
    {
        private EventController02 eventController02;

        public Event02_03_SmallTalk(EventController02 eventController) : base(eventController)
        {
            this.eventController02 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(start);
            //eventList.Add(eventController.lightOff);
            eventList.Add(event1);
            //eventList.Add(eventController.lightOn);
            eventList.Add(event2);
            //eventList.Add(eventController.lightOff);
            eventList.Add(event3);
            //eventList.Add(eventController.lightOn);
            eventList.Add(end);
            return eventList;
        }

        public bool event1()
        {
            eventController02.EventCamera1.gameObject.SetActive(true);
            eventController02.MainCamera1.gameObject.SetActive(false);
            return true;
        }

        public bool event2()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あそこのお家も大変ね",
                    },
                    CharaTalkController.Texture.talk_woman1,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_woman1,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"本当にねえ" + System.Environment.NewLine +
                        @"今日もずいぶんやり合っているみたいだし",
                        @"めいちゃん ずっと引きこもってて出てこないんでしょ？",
                    },
                    CharaTalkController.Texture.talk_woman1,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_woman1,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"成績良くて真面目な子だって聞いてたのに" + System.Environment.NewLine +
                        @"どうしてこうなったのか",
                        @"やっぱりウワサって本当なのかしら"
                    },
                    CharaTalkController.Texture.talk_woman1,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_woman1,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"怪物じみた見た目だけど" + System.Environment.NewLine +
                        @"この人たちはウワサ好きのおばさんって感じだ",
                        @"襲ってくる様子もないし" + System.Environment.NewLine +
                        @"人によって個性があるのかな？"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event3()
        {
            eventController02.MainCamera1.gameObject.SetActive(true);
            eventController02.EventCamera1.gameObject.SetActive(false);
            return true;
        }
    }
}