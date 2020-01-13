namespace Assets.Script
{
    public class Event05_01_MoveScene : Event_MoveScene
    {
        private EventController05 eventController05;

        public Event05_01_MoveScene(EventController05 eventController) : base(eventController)
        {
            this.eventController05 = eventController;
        }

        protected override void eventSave()
        {
            SaveController05 saveController05 = new SaveController05();
            saveController05.save_Scene(SaveController.SceneNo.Scene05, SaveController.PlaceNo.Place01);
        }

        protected override void eventLoadScene()
        {
            eventController05.loadScene(@"stage04");
        }
    }
}