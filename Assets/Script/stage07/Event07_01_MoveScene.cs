namespace Assets.Script
{
    public class Event07_01_MoveScene : Event_MoveScene
    {
        private EventController07 eventController07;

        public Event07_01_MoveScene(EventController07 eventController) : base(eventController)
        {
            this.eventController07 = eventController;
        }

        protected override void eventSave()
        {
            SaveController07 saveController07 = new SaveController07();
            saveController07.save_Scene(SaveController.SceneNo.Scene07, SaveController.PlaceNo.Place01);
        }

        protected override void eventLoadScene()
        {
            eventController07.loadScene(@"stage05");
        }
    }
}