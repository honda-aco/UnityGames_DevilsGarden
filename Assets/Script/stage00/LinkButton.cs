using UnityEngine;

namespace Assets.Script
{
    public class LinkButton : ClickEvent00
    {
        [SerializeField]
        private string url;

        public void OnClick()
        {
            eventController00.OnClick_Link(url);
        }
    }
}