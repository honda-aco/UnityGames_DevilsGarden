using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event04_19_Suicide : Event_DeferredBgm
    {
        private EventController04 eventController04;

        public Event04_19_Suicide(EventController04 eventController) : base(eventController)
        {
            this.eventController04 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController04.lightOff));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(eventController04.lightOn));
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
                        @"あああああああああああああ"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"パンッ！！！"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event3()
        {
            eventController04.Suicide1.SetActive(false);
            eventController04.Suicide2.SetActive(true);
            return true;
        }

        private bool event4()
        {
            SaveController04 saveController04 = new SaveController04();
            saveController04.complete_Event04_19_Suicide();
            return true;
        }
    }
}