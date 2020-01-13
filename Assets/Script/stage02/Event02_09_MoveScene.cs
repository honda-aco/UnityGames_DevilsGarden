namespace Assets.Script
{
    public class Event02_09_MoveScene : Event_MoveScene
    {
        private EventController02 eventController02;

        public Event02_09_MoveScene(EventController02 eventController) : base(eventController)
        {
            this.eventController02 = eventController;
        }

        protected override void eventSave()
        {
            SaveController02 saveController02 = new SaveController02();
            saveController02.save_Scene(SaveController.SceneNo.Scene02, SaveController.PlaceNo.Place02);
        }

        protected override void eventLoadScene()
        {
            eventController02.loadScene(@"stage03");
        }
    }
}