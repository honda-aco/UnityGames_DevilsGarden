using UnityEngine;

namespace Assets.Script
{
    public class SkipButton_End05 : MonoBehaviour
    {
        protected EventController_End05 eventController_End05;

        public void SetEventController(EventController_End05 eventController)
        {
            eventController_End05 = eventController;
        }

        public void OnClick()
        {
            eventController_End05.skip_Click();
        }
    }
}