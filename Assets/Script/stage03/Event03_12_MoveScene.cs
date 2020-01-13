namespace Assets.Script
{
    public class Event03_12_MoveScene : Event_MoveScene
    {
        private EventController03 eventController03;

        public Event03_12_MoveScene(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        protected override void eventSave()
        {
            SaveController03 saveController03 = new SaveController03();
            saveController03.save_Scene(SaveController.SceneNo.Scene03, SaveController.PlaceNo.Place01);
        }

        protected override void eventLoadScene()
        {
            if (new SaveController08().completed_Event08_01_MoveWorld())
            {
                eventController03.loadScene(@"stage09");
            }
            else
            {
                eventController03.loadScene(@"stage02");
            }
        }
    }
}