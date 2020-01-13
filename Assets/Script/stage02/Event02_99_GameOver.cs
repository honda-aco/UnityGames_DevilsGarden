namespace Assets.Script
{
    public class Event02_99_GameOver : Event_GameOver
    {
        public Event02_99_GameOver(EventController02 eventController) : base(eventController)
        {
            this.eventController = eventController;
        }

        public override string GetLoadScene()
        {
            return @"stage02";
        }
    }
}