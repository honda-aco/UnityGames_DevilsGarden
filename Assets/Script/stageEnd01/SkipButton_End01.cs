using UnityEngine;

namespace Assets.Script
{
    public class SkipButton_End01 : MonoBehaviour
    {
        protected EventController_End01 eventController_End01;

        public void SetEventController(EventController_End01 eventController)
        {
            eventController_End01 = eventController;
        }

        public void OnClick()
        {
            eventController_End01.skip_Click();
        }
    }
}