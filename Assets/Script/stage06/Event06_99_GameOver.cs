namespace Assets.Script
{
    public class Event06_99_GameOver : Event_GameOver
    {
        public Event06_99_GameOver(EventController06 eventController) : base(eventController)
        {
            this.eventController = eventController;
        }

        public override string GetLoadScene()
        {
            return @"stage06";
        }
    }
}