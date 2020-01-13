namespace Assets.Script
{
    public class Event06_02_MoveScene : Event_MoveScene
    {
        private EventController06 eventController06;

        public Event06_02_MoveScene(EventController06 eventController) : base(eventController)
        {
            this.eventController06 = eventController;
        }

        protected override void eventSave()
        {
            SaveController05 saveController06 = new SaveController05();
            saveController06.save_Scene(SaveController.SceneNo.Scene06, SaveController.PlaceNo.Place02);
        }

        protected override void eventLoadScene()
        {
            eventController06.loadScene(@"stage04");
        }
    }
}