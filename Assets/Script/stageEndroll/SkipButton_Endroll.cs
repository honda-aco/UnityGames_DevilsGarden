using UnityEngine;

namespace Assets.Script
{
    public class SkipButton_Endroll : MonoBehaviour
    {
        protected EventController_Endroll eventController_Endroll;

        public void SetEventController(EventController_Endroll eventController)
        {
            eventController_Endroll = eventController;
        }

        public void OnClick()
        {
            eventController_Endroll.skip_Click();
        }
    }
}