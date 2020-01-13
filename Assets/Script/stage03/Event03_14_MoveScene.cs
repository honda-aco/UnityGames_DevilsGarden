namespace Assets.Script
{
    public class Event03_14_MoveScene : Event_MoveScene
    {
        private EventController03 eventController03;

        public Event03_14_MoveScene(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        protected override void eventSave()
        {
            SaveController03 saveController03 = new SaveController03();
            saveController03.save_Scene(SaveController.SceneNo.Scene03, SaveController.PlaceNo.Place03);
        }

        protected override void eventLoadScene()
        {
            eventController03.loadScene(@"stage06");
        }
    }
}