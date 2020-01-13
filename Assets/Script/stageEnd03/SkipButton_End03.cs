using UnityEngine;

namespace Assets.Script
{
    public class SkipButton_End03 : MonoBehaviour
    {
        protected EventController_End03 eventController_End03;

        public void SetEventController(EventController_End03 eventController)
        {
            eventController_End03 = eventController;
        }

        public void OnClick()
        {
            eventController_End03.skip_Click();
        }
    }
}