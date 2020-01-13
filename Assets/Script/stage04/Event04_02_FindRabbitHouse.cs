using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event04_02_FindRabbitHouse : Event_ChangeBgm1
    {
        private EventController04 eventController04;

        public Event04_02_FindRabbitHouse(EventController04 eventController) : base(eventController)
        {
            this.eventController04 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(eventController04.lightOff);
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(eventController04.lightOn);
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あれ 急にめまいが……"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);

        }

        private bool event2()
        {
            eventController04.BloodStain1.SetActive(true);
            eventController04.BloodStain2.SetActive(true);
            return true;
        }

        private bool event3()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"血！？",
                        @"……",
                        @"飼育小屋の中は空っぽだ",
                        @"この血の先には何がいるんだろう？"
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event4()
        {
            // イベント完了を保存
            SaveController04 saveController04 = new SaveController04();
            saveController04.complete_Event04_02_FindRabbitHouse();
            return true;
        }
    }
}