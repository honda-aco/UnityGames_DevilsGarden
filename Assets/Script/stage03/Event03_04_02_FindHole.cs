using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_04_02_FindHole : Event_ChangeBgm1
    {
        private EventController03 eventController03;
        private SaveController03 saveController03 = new SaveController03();

        public Event03_04_02_FindHole(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController03.lightOff));
            eventList.Add(new EventController.eventProcess(event2));
            return eventList;
        }

        private bool event1()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"血？",
                        @"ここでいったい何が……"
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {

            eventController03.loadScene(@"stage_end02");
            Charactor.Restart();
            return true;
        }
    }
}