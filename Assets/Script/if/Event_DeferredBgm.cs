namespace Assets.Script
{
    public abstract class Event_DeferredBgm
    {
        protected EventController eventController;

        protected Event_DeferredBgm(EventController eventController)
        {
            this.eventController = eventController;
        }

        protected bool start()
        {
            Charactor.Pause();
            eventController.Player.Idle();
            eventController.MobileSingleStickControl.SetActive(false);
            return true;
        }

        protected bool end()
        {
            eventController.MobileSingleStickControl.SetActive(true);
            Charactor.Restart();
            return true;
        }
    }
}