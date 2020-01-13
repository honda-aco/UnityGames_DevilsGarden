namespace Assets.Script
{
    public class Event07_99_GameOver : Event_GameOver
    {
        public Event07_99_GameOver(EventController07 eventController) : base(eventController)
        {
            this.eventController = eventController;
        }

        public override string GetLoadScene()
        {
            return @"stage07";
        }
    }
}