namespace Assets.Script
{
    public class Event04_12_MoveScene : Event_MoveScene
    {
        private EventController04 eventController04;

        public Event04_12_MoveScene(EventController04 eventController) : base(eventController)
        {
            this.eventController04 = eventController;
        }

        protected override void eventSave()
        {
            SaveController04 saveController04 = new SaveController04();
            saveController04.save_Scene(SaveController.SceneNo.Scene04, SaveController.PlaceNo.Place01);
        }

        protected override void eventLoadScene()
        {
            eventController04.loadScene(@"stage03");
        }
    }
}