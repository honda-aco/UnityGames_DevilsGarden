using UnityEngine;

namespace Assets.Script
{
    public class PlayButton : ClickEvent00
    {
        [SerializeField]
        private string stage;

        public void OnClick()
        {
            eventController00.OnClick_PlayGallery(stage);
        }
    }
}