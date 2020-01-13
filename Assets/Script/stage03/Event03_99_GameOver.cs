namespace Assets.Script
{
    public class Event03_99_GameOver : Event_GameOver
    {
        public Event03_99_GameOver(EventController03 eventController) : base(eventController)
        {
            this.eventController = eventController;
        }

        public override string GetLoadScene()
        {
            return @"stage03";
        }
    }
}