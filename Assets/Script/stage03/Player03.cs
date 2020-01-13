﻿using UnityEngine;

namespace Assets.Script
{
    public class Player03 : Player
    {
        [SerializeField]
        private EventController03 eventController;

        // 物理演算を行わないオブジェクトと接触した時に呼ばれるコールバック
        public void OnTriggerEnter(Collider hit)
        {
            base.OnTriggerEnter(hit);
            eventController.executeEvent(hit.gameObject);
        }
    }
}