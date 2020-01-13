using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_06_MeetFather : Event_ChangeBgm1
    {
        private EventController03 eventController03;
        private SaveController03 saveController03 = new SaveController03();

        public Event03_06_MeetFather(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        public bool event1()
        {
            return eventController03.charaTurnaround(
                eventController03.Father,
                eventController03.Player.gameObject);
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"すみません" + System.Environment.NewLine +
                        @"このあたりで小学生の男の子を見ませんでしたか？",
                        @"うちの息子なんですが 見失ってしまって……",
                    },
                    CharaTalkController.Texture.talk_ryotaro_father,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event3()
        {
            // イベント完了を保存
            SaveController03 saveController = new SaveController03();
            saveController.complete_Event03_06_MeetFather();
            return true;
        }
    }
}