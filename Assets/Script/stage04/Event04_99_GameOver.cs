namespace Assets.Script
{
    public class Event04_99_GameOver : Event_GameOver
    {
        public Event04_99_GameOver(EventController04 eventController) : base(eventController)
        {
            this.eventController = eventController;
        }

        public override string GetLoadScene()
        {
            return @"stage04";
        }
    }
}