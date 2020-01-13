using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class HpController : MonoBehaviour
    {
        [SerializeField]
        private EventController eventController;

        [SerializeField]
        private UnityEngine.UI.Image Hp1;

        [SerializeField]
        private UnityEngine.UI.Image Hp2;

        [SerializeField]
        private UnityEngine.UI.Image Hp3;

        [SerializeField]
        private Texture2D HpImage;

        [SerializeField]
        private Texture2D LostHpImage;

        private List<UnityEngine.UI.Image> _HpList;
        private int _HpCount;
        private int _LastHpCount;

        public void Start()
        {
            _HpList = new List<UnityEngine.UI.Image>();
            _HpList.Add(Hp1);
            _HpList.Add(Hp2);
            _HpList.Add(Hp3);
            _HpCount = new SaveController().get_KeyHpCount();
        }

        // Update is called once per frame
        public void FixedUpdate()
        {
            if (_LastHpCount != _HpCount)
            {
                for (int i = 0; i < _HpList.Count; i++)
                {
                    if (i < _HpCount)
                    {
                        // 有効なHP
                        _HpList[i].sprite = Sprite.Create(HpImage, new Rect(0, 0, HpImage.width, HpImage.height), Vector2.zero);
                    }
                    else
                    {
                        // 消失したHP
                        _HpList[i].sprite = Sprite.Create(LostHpImage, new Rect(0, 0, HpImage.width, HpImage.height), Vector2.zero);
                    }
                }
                // 前回のHPとして保持
                _LastHpCount = _HpCount;

                if (_HpCount == 0)
                {
                    new SaveController().save_KeyHpCount(3);
                }
                else
                {
                    new SaveController().save_KeyHpCount(_HpCount);
                }
            }

            // GameOverの設定
            if (_HpCount == 0)
            {
                if (eventController.playerDead())
                {
                    eventController.GameOver = true;
                }
            }
            else
            {               
                eventController.GameOver = false;
            }
        }

        /// <summary>
        /// HP喪失
        /// </summary>
        public void Damage()
        {
            _HpCount -= 1;
            if (_HpCount < 0)
            {
                _HpCount = 0;
            }
        }

        /// <summary>
        /// HP回復
        /// </summary>
        public void Regained()
        {
            _HpCount += 1;
            if (_HpCount > _HpList.Count)
            {
                _HpCount = _HpList.Count;
            }
        }

        /// <summary>
        /// HP全回復
        /// </summary>
        public void FullRegained()
        {
            _HpCount = _HpList.Count;
        }

        /// <summary>
        /// 死亡（一撃死）
        /// </summary>
        public void Died()
        {
            _HpCount = 0;
        }
    }
}