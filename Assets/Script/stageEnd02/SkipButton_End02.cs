using UnityEngine;

namespace Assets.Script
{
    public class SkipButton_End02 : MonoBehaviour
    {
        protected EventController_End02 eventController_End02;

        public void SetEventController(EventController_End02 eventController)
        {
            eventController_End02 = eventController;
        }

        public void OnClick()
        {
            eventController_End02.skip_Click();
        }
    }
}