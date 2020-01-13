using UnityEngine;
using KeyItemStatus = Assets.Script.SaveController.KeyItemStatus;

namespace Assets.Script
{
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField]
        private UnityEngine.UI.Image KeyItem1;

        [SerializeField]
        private UnityEngine.UI.Image KeyItem2;

        [SerializeField]
        private UnityEngine.UI.Image KeyItem3;

        [SerializeField]
        private Texture2D KeyItem1_Level_25;

        [SerializeField]
        private Texture2D KeyItem1_Level_50;

        [SerializeField]
        private Texture2D KeyItem1_Level_75;

        [SerializeField]
        private Texture2D KeyItem1_Level_100;

        [SerializeField]
        private Texture2D KeyItem2_Level_25;

        [SerializeField]
        private Texture2D KeyItem2_Level_50;

        [SerializeField]
        private Texture2D KeyItem2_Level_75;

        [SerializeField]
        private Texture2D KeyItem2_Level_100;

        [SerializeField]
        private Texture2D KeyItem3_Level_25;

        [SerializeField]
        private Texture2D KeyItem3_Level_50;

        [SerializeField]
        private Texture2D KeyItem3_Level_75;

        [SerializeField]
        private Texture2D KeyItem3_Level_100;

        [SerializeField]
        private KeyItemStatus debug_keyItem1Status = KeyItemStatus.None;

        [SerializeField]
        private KeyItemStatus debug_keyItem2Status = KeyItemStatus.None;

        [SerializeField]
        private KeyItemStatus debug_keyItem3Status = KeyItemStatus.None;

        SaveController saveContoroller = new SaveController();

        public void Start()
        {
#if DEBUG
            if (debug_keyItem1Status != KeyItemStatus.None)
            {
                saveContoroller.save_KeyItem1Status(debug_keyItem1Status);
            }
            if (debug_keyItem2Status != KeyItemStatus.None)
            {
                saveContoroller.save_KeyItem2Status(debug_keyItem2Status);
            }
            if (debug_keyItem3Status != KeyItemStatus.None)
            {
                saveContoroller.save_KeyItem3Status(debug_keyItem3Status);
            }
#endif
            Update_KeyItem1();
            Update_KeyItem2();
            Update_KeyItem3();
        }

        public void Update_KeyItem1()
        {
            Texture2D keyItem1 = KeyItem1_Level_25;

            if (saveContoroller.get_KeyItem1Status().Equals(SaveController.KeyItemStatus.Level_25))
            {
                keyItem1 = KeyItem1_Level_25;
            }
            else if (saveContoroller.get_KeyItem1Status().Equals(SaveController.KeyItemStatus.Level_50))
            {
                keyItem1 = KeyItem1_Level_50;
            }
            else if (saveContoroller.get_KeyItem1Status().Equals(SaveController.KeyItemStatus.Level_75))
            {
                keyItem1 = KeyItem1_Level_75;
            }
            else if (saveContoroller.get_KeyItem1Status().Equals(SaveController.KeyItemStatus.Level_100))
            {
                keyItem1 = KeyItem1_Level_100;
            }

            KeyItem1.sprite = Sprite.Create(keyItem1, new Rect(0, 0, keyItem1.width, keyItem1.height), Vector2.zero);
        }

        public void Update_KeyItem2()
        {
            Texture2D keyItem2 = KeyItem2_Level_25;

            if (saveContoroller.get_KeyItem2Status().Equals(SaveController.KeyItemStatus.Level_25))
            {
                keyItem2 = KeyItem2_Level_25;
            }
            else if (saveContoroller.get_KeyItem2Status().Equals(SaveController.KeyItemStatus.Level_50))
            {
                keyItem2 = KeyItem2_Level_50;
            }
            else if (saveContoroller.get_KeyItem2Status().Equals(SaveController.KeyItemStatus.Level_75))
            {
                keyItem2 = KeyItem2_Level_75;
            }
            else if (saveContoroller.get_KeyItem2Status().Equals(SaveController.KeyItemStatus.Level_100))
            {
                keyItem2 = KeyItem2_Level_100;
            }

            KeyItem2.sprite = Sprite.Create(keyItem2, new Rect(0, 0, keyItem2.width, keyItem2.height), Vector2.zero);
        }

        public void Update_KeyItem3()
        {
            Texture2D keyItem3 = KeyItem3_Level_25;

            if (saveContoroller.get_KeyItem3Status().Equals(SaveController.KeyItemStatus.Level_25))
            {
                keyItem3 = KeyItem3_Level_25;
            }
            else if (saveContoroller.get_KeyItem3Status().Equals(SaveController.KeyItemStatus.Level_50))
            {
                keyItem3 = KeyItem3_Level_50;
            }
            else if (saveContoroller.get_KeyItem3Status().Equals(SaveController.KeyItemStatus.Level_75))
            {
                keyItem3 = KeyItem3_Level_75;
            }
            else if (saveContoroller.get_KeyItem3Status().Equals(SaveController.KeyItemStatus.Level_100))
            {
                keyItem3 = KeyItem3_Level_100;
            }

            KeyItem3.sprite = Sprite.Create(keyItem3, new Rect(0, 0, keyItem3.width, keyItem3.height), Vector2.zero);
        }
    }
}