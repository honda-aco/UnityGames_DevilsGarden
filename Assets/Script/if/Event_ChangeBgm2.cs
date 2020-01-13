namespace Assets.Script
{
    public abstract class Event_ChangeBgm2
    {
        protected EventController eventController;

        protected Event_ChangeBgm2(EventController eventController)
        {
            this.eventController = eventController;
        }

        protected bool start()
        {
            BgmController.GetInstance().playEvent2Bgm(true);
            Charactor.Pause();
            eventController.Player.Idle();
            eventController.MobileSingleStickControl.SetActive(false);
            return true;
        }

        protected bool end()
        {
            eventController.MobileSingleStickControl.SetActive(true);
            Charactor.Restart();
            BgmController.GetInstance().playDefaultBgm();
            return true;
        }
    }
}