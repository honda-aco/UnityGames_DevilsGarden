using UnityEngine;

namespace Assets.Script
{
    public class SkipButton_End06 : MonoBehaviour
    {
        protected EventController_End06 eventController_End06;

        public void SetEventController(EventController_End06 eventController)
        {
            eventController_End06 = eventController;
        }

        public void OnClick()
        {
            eventController_End06.skip_Click();
        }
    }
}