namespace Assets.Script
{
    public class Event05_99_GameOver : Event_GameOver
    {
        public Event05_99_GameOver(EventController05 eventController) : base(eventController)
        {
            this.eventController = eventController;
        }

        public override string GetLoadScene()
        {
            return @"stage05";
        }
    }
}