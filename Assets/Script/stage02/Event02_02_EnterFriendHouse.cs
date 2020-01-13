using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event02_02_EnterFriendHouse : Event_ChangeBgm1
    {
        private EventController02 eventController02;

        public Event02_02_EnterFriendHouse(EventController02 eventController) :base(eventController)
        {
            this.eventController02 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(start);
            eventList.Add(event1);
            eventList.Add(event2);
            eventList.Add(event3);
            eventList.Add(event4);
            eventList.Add(event5);
            eventList.Add(event6);
            eventList.Add(event7);
            eventList.Add(end);
            return eventList;
        }

        public bool event1()
        {
            eventController02.EventCamera2.gameObject.SetActive(true);
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
                        @"おい！" + System.Environment.NewLine +
                        @"いつまで引きこもってんだよ！さっさと出てこい！",
                        @"聞いてんのか！？この恥さらし！",
                        @"おい！",
                        @"おい！！！",
                        @"無視してないで早く出てこい！！！"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"事情はわからないけど" + System.Environment.NewLine +
                        @"絶対関わりたくない雰囲気",
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event3()
        {
            // 母親がこちらを見る
            return eventController02.charaTurnaround(
                        eventController02.Mother,
                        eventController02.EventCamera2.gameObject);
        }

        public bool event4()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ひっ……！",
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"だれ？",
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_mother,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あら あの子のお友達？" + System.Environment.NewLine +
                        @"ごめんなさいね わざわざ家まできてくれて",
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_mother,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.white
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event5()
        {
            // 母親が家に向き直る
            return eventController02.charaTurnaround(eventController02.Mother, eventController02.MovePoint2);
        }

        public bool event6()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"めいちゃん お友達が来てくれてるわよー",
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_mother,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"お友達じゃないんだけど……" + System.Environment.NewLine +
                        @"あまり刺激せずにやり過ごそう",
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_mother,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event7()
        {
            eventController02.MainCamera1.gameObject.SetActive(true);
            eventController02.EventCamera2.gameObject.SetActive(false);
            return true;
        }
    }
}