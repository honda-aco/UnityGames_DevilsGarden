using UnityEngine;

namespace Assets.Script
{
    public class Enemy07 : Charactor
    {
        [SerializeField]
        private EventController07 eventController;

        // 物理演算を行わないオブジェクトと接触した時に呼ばれるコールバック
        public void OnTriggerEnter(Collider hit)
        {
            base.OnTriggerEnter(hit);

            // 接触したオブジェクトのタグによって処理を変える
            if (hit.gameObject.CompareTag("Enemy_Event"))
            {
                eventController.executeEvent(hit.gameObject);
            }
        }
    }
}