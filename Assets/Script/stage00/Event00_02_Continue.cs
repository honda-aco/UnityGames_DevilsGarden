using System.Collections.Generic;

namespace Assets.Script
{
    public class Event00_02_Continue
    {
        private EventController00 eventController;

        public Event00_02_Continue(EventController00 eventController)
        {
            this.eventController = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event1));
            return eventList;
        }

        private bool event1()
        {
            SaveController00 saveController00 = new SaveController00();
            SaveController.SceneNo[] scene = saveController00.get_Scene();

            if (saveController00.SceneDict.ContainsKey(scene[0]))
            {
                return eventController.loadScene(saveController00.SceneDict[scene[0]]);
            }
            else
            {
                // イレギュラー（初回にはじめからを押して即落ちたときとか）
                return eventController.loadScene(@"stage01");
            }
        }
    }
}