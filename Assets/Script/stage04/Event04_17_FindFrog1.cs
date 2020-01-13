using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event04_17_FindFrog1 : Event_ChangeBgm1
    {
        private EventController04 eventController04;

        public Event04_17_FindFrog1(EventController04 eventController) : base(eventController)
        {
            this.eventController04 = eventController;
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
                        @"まいったな",
                        @"約束の時間はとうに過ぎてるのに" + System.Environment.NewLine +
                        @"あいつが来る気配がない",
                        @"まさか野良犬に食われちまったりしてないよな"
                    },
                    CharaTalkController.Texture.talk_frog1,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }
    }
}