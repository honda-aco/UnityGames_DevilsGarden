namespace Assets.Script
{
    public class EventController01 : EventController
    {
        public void Start()
        {
            base.Start();

            SaveController saveController = new SaveController();
            saveController.save_Scene(SaveController.SceneNo.Scene01, SaveController.PlaceNo.None);

            eventList = new Event01_01_Prologue(this).GetEventList();
            eventNo = 0;
        }

        public void FixedUpdate()
        {
            if (eventList != null && eventList.Count > eventNo)
            {
                if (eventList[eventNo].Invoke())
                {
                    eventNo += 1;
                    return;
                }
            }
        }
    }
}