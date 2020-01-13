using UnityEngine;

namespace Assets.Script
{
    public class FukidashiTapCatch : MonoBehaviour
    {

        [SerializeField]
        private FukidashiController fukidashiController;

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                fukidashiController.playSound();
                fukidashiController.CloseFukidashi();
            }
        }
    }
}