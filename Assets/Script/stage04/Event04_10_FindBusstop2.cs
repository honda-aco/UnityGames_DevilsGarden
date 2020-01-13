using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event04_10_FindBusstop2 : Event_ChangeBgm1
    {
        private EventController04 eventController04;

        public Event04_10_FindBusstop2(EventController04 eventController) : base(eventController)
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
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"バスの時刻表だ",
                        @"平日 04:02" + System.Environment.NewLine +
                        @"平日 04:03",
                        @"平日 04:04" + System.Environment.NewLine +
                        @"平日 04:07",
                        @"平日 04:08" + System.Environment.NewLine +
                        @"平日 04:09",
                        @"ほぼ一分きざみで続いて" + System.Environment.NewLine +
                        @"最終が06:08……",
                        @"明らかにでたらめだ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }
    }
}