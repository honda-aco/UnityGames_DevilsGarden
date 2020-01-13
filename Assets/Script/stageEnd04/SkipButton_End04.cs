using UnityEngine;

namespace Assets.Script
{
    public class SkipButton_End04 : MonoBehaviour
    {
        protected EventController_End04 eventController_End04;

        public void SetEventController(EventController_End04 eventController)
        {
            eventController_End04 = eventController;
        }

        public void OnClick()
        {
            eventController_End04.skip_Click();
        }
    }
}