using System.Collections.Generic;

namespace Assets.Script
{
    public class Event00_01_FirstStart
    {
        private EventController00 eventController;

        public Event00_01_FirstStart(EventController00 eventController)
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
            // データの削除処理
            new SaveController().deleteAllKeys();
            new SaveController00().deleteAllKeys();
            new SaveController02().deleteAllKeys();
            new SaveController03().deleteAllKeys();
            new SaveController04().deleteAllKeys();
            new SaveController05().deleteAllKeys();
            new SaveController07().deleteAllKeys();
            new SaveController08().deleteAllKeys();

            SaveController00 saveController00 = new SaveController00();
            saveController00.complete_Event00_01_FirstStart();

            return eventController.loadScene("stage01");
        }
    }
}