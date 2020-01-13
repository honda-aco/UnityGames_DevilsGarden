using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public abstract class Event_GameOver
    {
        protected EventController eventController;

        public Event_GameOver(EventController eventController)
        {
            this.eventController = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(event1);
            eventList.Add(event2);
            eventList.Add(event3);
            eventList.Add(event4);
            return eventList;
        }

        public bool event1()
        {
            Charactor.Pause();
            eventController.Player.Idle();
            return true;
        }

        public bool event2()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"GAME OVER"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event3()
        {
            return eventController.lightOff();
        }

        public bool event4()
        {
            Charactor.Restart();
            eventController.playerRevived();
            return eventController.loadScene(GetLoadScene());
        }

        public abstract string GetLoadScene();
    }
}