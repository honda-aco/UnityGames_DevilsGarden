using UnityEngine;

namespace Assets.Script
{
    public class Player05 : Player
    {
        [SerializeField]
        private EventController05 eventController;

        // 物理演算を行わないオブジェクトと接触した時に呼ばれるコールバック
        public void OnTriggerEnter(Collider hit)
        {
            base.OnTriggerEnter(hit);

            // 接触したオブジェクトのタグによって処理を変える
            if (hit.gameObject.CompareTag("Enemy_Event") == false)
            {
                eventController.executeEvent(hit.gameObject);
            }
        }
    }
}