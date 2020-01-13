using UnityEngine;

namespace Assets.Script
{
    public class FollowPlayer : MonoBehaviour
    {
        [SerializeField]
        private Transform target;    // ターゲットへの参照

        [SerializeField]
        private float x;

        [SerializeField]
        private float y;

        [SerializeField]
        private float z;

        private Vector3 offset;     // 相対座標
        private bool stop = false;

        void Start()
        {
            //自分自身とtargetとの相対距離を求める (-485.4, 263.5, -481.2)
            //offset = GetComponent<Transform>().position - target.position;
            //x = offset.x;
            //y = offset.y;
            //z = offset.z;

            offset = new Vector3(x, y, z);
        }

        void FixedUpdate()
        {
            if (stop == false)
            {
                // 自分自身の座標に、targetの座標に相対座標を足した値を設定する
                // GetComponent<Transform>().position = target.position + offset;
                GetComponent<Transform>().position = target.position + new Vector3(x, y, z);
            }
        }

        public void ChangeTarget(Transform target)
        {
            this.target = target;
        }

        public void stopFollow()
        {
            stop = true;
        }

        public void restartFollow()
        {
            stop = false;
        }
    }
}