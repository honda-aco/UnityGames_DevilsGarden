namespace Assets.Script
{
    public class Event03_13_MoveScene : Event_MoveScene
    {
        private EventController03 eventController03;

        public Event03_13_MoveScene(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        protected override void eventSave()
        {
            SaveController03 saveController03 = new SaveController03();
            saveController03.save_Scene(SaveController.SceneNo.Scene03, SaveController.PlaceNo.Place02);
        }

        protected override void eventLoadScene()
        {
            eventController03.loadScene(@"stage04");
        }
    }
}