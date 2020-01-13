using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_11_FindGrave : Event_ChangeBgm1
    {
        private EventController03 eventController03;

        public Event03_11_FindGrave(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
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
                        @"嫌な雰囲気……",
                        @"このあたりの雰囲気からして",
                        @"ここは夢の主にとって" + System.Environment.NewLine + 
                        @"とても嫌な場所なんだろうな"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }
    }
}