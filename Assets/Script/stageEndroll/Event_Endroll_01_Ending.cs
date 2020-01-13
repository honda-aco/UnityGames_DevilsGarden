using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event_Endroll_01_Ending
    {
        private EventController_Endroll eventController;

        public Event_Endroll_01_Ending(EventController_Endroll eventController)
        {
            this.eventController = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(event0));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(event11));
            eventList.Add(new EventController.eventProcess(event12));
            eventList.Add(new EventController.eventProcess(event13));
            eventList.Add(new EventController.eventProcess(event14));
            eventList.Add(new EventController.eventProcess(event15));
            eventList.Add(new EventController.eventProcess(event16));

            return eventList;
        }

        private bool event0()
        {
            return eventController.timeWait(10000);
        }

        private bool event1()
        {
            bool walk1 = eventController.charaWalk(eventController.Ryotaro, eventController.MovePoint1_1);
            bool walk2 = eventController.playerWalk(eventController.MovePoint1_2);
            return walk1 || walk2;
        }

        private bool event2()
        {
            bool walk1 = eventController.charaWalk(eventController.Ryotaro, eventController.MovePoint2_1);
            bool walk2 = eventController.playerWalk(eventController.MovePoint2_2);
            return walk1 || walk2;
        }

        private bool event3()
        {
            bool walk1 = eventController.charaWalk(eventController.Ryotaro, eventController.MovePoint3_1);
            bool walk2 = eventController.playerWalk(eventController.MovePoint3_2);
            return walk1 || walk2;
        }

        private bool event4()
        {
            bool walk1 = eventController.charaWalk(eventController.Ryotaro, eventController.MovePoint4_1);
            bool walk2 = eventController.playerWalk(eventController.MovePoint4_2);
            return walk1 || walk2;
        }

        private bool event5()
        {
            bool walk1 = eventController.charaWalk(eventController.Ryotaro, eventController.MovePoint5_1);
            bool walk2 = eventController.playerWalk(eventController.MovePoint5_2);
            return walk1 && walk2;
        }

        private bool event6()
        {
            bool walk1 = eventController.charaTurnaround(eventController.Ryotaro, eventController.Player.gameObject);
            bool walk2 = eventController.playerTurnaround(eventController.Ryotaro.gameObject);
            return walk1 && walk2;
        }

        private bool event7()
        {
            return eventController.timeWait(1000);
        }

        private bool event8()
        {
            bool walk1 = eventController.charaWalk(eventController.Ryotaro, eventController.MovePoint6_1);
            bool walk2 = eventController.playerWalk(eventController.MovePoint6_2);
            return walk1 && walk2;
        }

        private bool event9()
        {
            bool walk1 = eventController.charaRun(eventController.Ryotaro, eventController.Player.gameObject, 10.0f);
            bool walk2 = eventController.playerWalk(eventController.MovePoint7_2);
            return walk1 && walk2;
        }

        private bool event10()
        {
            bool walk1 = eventController.charaTurnaround(eventController.Ryotaro, eventController.Player.gameObject);
            bool walk2 = eventController.playerTurnaround(eventController.Ryotaro.gameObject);
            return walk1 && walk2;
        }

        private bool event11()
        {
            bool walk1 = eventController.charaWalk(eventController.Ryotaro, eventController.MovePoint8_1);
            bool walk2 = eventController.playerWalk(eventController.MovePoint8_2);
            return walk1 || walk2;
        }

        private bool event12()
        {
            bool walk1 = eventController.charaWalk(eventController.Ryotaro, eventController.MovePoint9_1);
            bool walk2 = eventController.playerWalk(eventController.MovePoint9_2);
            return walk1 || walk2;
        }

        private bool event13()
        {
            bool walk1 = eventController.charaWalk(eventController.Ryotaro, eventController.MovePoint10_1);
            bool walk2 = eventController.playerWalk(eventController.MovePoint10_2);
            return walk1 || walk2;
        }

        private bool event14()
        {
            bool walk1 = eventController.charaWalk(eventController.Ryotaro, eventController.MovePoint11_1);
            bool walk2 = eventController.playerWalk(eventController.MovePoint11_2);
            return eventController.lightOff();
        }

        private bool event15()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"Thank you for playing",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event16()
        {
            eventController.loadScene(@"stage00");
            return true;
        }
    }
}