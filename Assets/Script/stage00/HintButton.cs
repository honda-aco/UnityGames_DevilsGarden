namespace Assets.Script
{
    public class HintButton : ClickEvent00
    {
        public void OnClick()
        {
            eventController00.OnClick_HintButton(this);
        }
    }
}