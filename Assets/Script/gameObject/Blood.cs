using UnityEngine;

namespace Assets.Script
{
    public class Blood : MyMonoBehaviour
    {

        private Vector3 _appearPlace;
        private bool _appeared = false;

        public void restorDefaultValue()
        {
            base.restorDefaultValue();
            _appeared = false;
        }

        public void Start()
        {
            gameObject.SetActive(false);
            base.backupDefaultValue();
        }

        public void FixedUpdate()
        {
            if (_appeared)
            {
                return;
            }

            if (gameObject.activeSelf)
            {
                if (transform.localScale.x < 12)
                {
                    transform.position = _appearPlace;
                    transform.localScale = new Vector3(transform.localScale.x + 0.05f, transform.localScale.x + 0.05f, 0);
                }
                else
                {
                    _appeared = true;
                }
            }
        }

        public void appear(Vector3 appearPlace)
        {
            _appearPlace = appearPlace;
            gameObject.SetActive(true);
        }

        public bool isAppeared()
        {
            return _appeared;
        }
    }
}