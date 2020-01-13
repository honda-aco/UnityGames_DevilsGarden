using UnityEngine;

namespace Assets.Script
{
    public class MyMonoBehaviour : MonoBehaviour
    {
        private bool _activeSelf;

        private float _positionX = 0.0f;
        private float _positionY = 0.0f;
        private float _positionZ = 0.0f;

        private float _rotationX = 0.0f;
        private float _rotationY = 0.0f;
        private float _rotationZ = 0.0f;
        private float _rotationW = 0.0f;

        private float _scaleX = 0.0f;
        private float _scaleY = 0.0f;
        private float _scaleZ = 0.0f;

        protected void backupDefaultValue()
        {
            _activeSelf = gameObject.activeSelf;

            _positionX = transform.position.x;
            _positionY = transform.position.y;
            _positionZ = transform.position.z;

            _rotationX = transform.rotation.x;
            _rotationY = transform.rotation.y;
            _rotationZ = transform.rotation.z;
            _rotationW = transform.rotation.w;

            _scaleX = transform.localScale.x;
            _scaleY = transform.localScale.y;
            _scaleZ = transform.localScale.z;
        }

        public void restorDefaultValue()
        {
            gameObject.SetActive(_activeSelf);

            transform.position = new Vector3(_positionX, _positionY, _positionZ);
            transform.rotation = new Quaternion(_rotationX, _rotationY, _rotationZ, _rotationW);
            transform.localScale = new Vector3(_scaleX, _scaleY, _scaleZ);
        }
    }
}
