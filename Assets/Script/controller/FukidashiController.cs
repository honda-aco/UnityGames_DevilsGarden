using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class FukidashiController : MonoBehaviour
    {
        [SerializeField]
        private UnityEngine.UI.Text fukidashi;

        [SerializeField]
        private GameObject fukidashiBackground;

        [SerializeField]
        private GameObject nameBackground1;

        [SerializeField]
        private GameObject nameBackground2;

        [SerializeField]
        private GameObject nameBackground3;

        [SerializeField]
        private UnityEngine.UI.Text fukidashiName1;

        [SerializeField]
        private UnityEngine.UI.Text fukidashiName2;

        [SerializeField]
        private UnityEngine.UI.Text fukidashiName3;

        [SerializeField]
        private GameObject fukidashiTapCatch;

        [SerializeField]
        private CharaTalkController charaTalkController;

        [SerializeField]
        private AudioSource soundEffect;

        private List<CharaTalk> _charaTalkList;
        private string[] _talkTextList;
        private int _charaTalkNo = 0;
        private int _talkTextNo = 0;
        private string _processId = string.Empty;

        public bool ShowFukidashi(string processId, List<CharaTalk> charaTalkList)
        {
            // ループ内で繰返し呼ばれることを想定して、同一IDなら表示せずに処理中（false）、完了済（true）を返す
            if (_processId == processId)
            {
                //_processId = string.Empty;
                return !processRun();
            }
            else
            {
                _charaTalkList = charaTalkList;
                _processId = processId;

                // 一時停止
                Pause();
            }

            UpdateFukidashiText();
            return false;
        }

        public void CloseFukidashi()
        {
            if (UpdateFukidashiText() == false)
            {
                charaTalkController.UpdateCharaTalkImage(CharaTalkController.Position.Left, CharaTalkController.Texture.hide, CharaTalkController.Color.white);
                charaTalkController.UpdateCharaTalkImage(CharaTalkController.Position.Right, CharaTalkController.Texture.hide, CharaTalkController.Color.white);
                charaTalkController.UpdateCharaTalkImage(CharaTalkController.Position.Center, CharaTalkController.Texture.hide, CharaTalkController.Color.white);
                Restart();
            }
        }

        private void UpdateCharaTalkImage(CharaTalk charaTalk)
        {
            // アイコン画像を設定
            string name1 = charaTalkController.UpdateCharaTalkImage(CharaTalkController.Position.Left,
                                                                    charaTalk.LeftTexture,
                                                                    charaTalk.LeftColor);
            string name2 = charaTalkController.UpdateCharaTalkImage(CharaTalkController.Position.Center,
                                                                    charaTalk.CenterTexture,
                                                                    charaTalk.CenterColor);
            string name3 = charaTalkController.UpdateCharaTalkImage(CharaTalkController.Position.Right,
                                                                    charaTalk.RightTexture,
                                                                    charaTalk.RightColor);
            if (name1 != null)
            {
                nameBackground1.SetActive(true);
                fukidashiName1.text = name1;
            }
            else
            {
                nameBackground1.SetActive(false);
                fukidashiName1.text = string.Empty;
            }

            if (name2 != null)
            {
                nameBackground2.SetActive(true);
                fukidashiName2.text = name2;
            }
            else
            {
                nameBackground2.SetActive(false);
                fukidashiName2.text = string.Empty;
            }

            if (name3 != null)
            {
                nameBackground3.SetActive(true);
                fukidashiName3.text = name3;
            }
            else
            {
                nameBackground3.SetActive(false);
                fukidashiName3.text = string.Empty;
            }
        }

        private bool UpdateFukidashiText()
        {
            // 初回のtalkTextList設定
            if (_talkTextList == null)
            {
                UpdateCharaTalkImage(_charaTalkList[_charaTalkNo]);
                _talkTextList = _charaTalkList[_charaTalkNo].TalkText;
                _charaTalkNo = 1;
                _talkTextNo = 0;
            }
            else if (_talkTextList.Length <= _talkTextNo)
            {
                // talkTextの最後まで処理が終わった場合、charaTalkListから次のテキストを取得する
                if (_charaTalkList.Count > _charaTalkNo)
                {
                    // Listが設定されている場合はListの次の要素を配列に入れて処理を続ける
                    UpdateCharaTalkImage(_charaTalkList[_charaTalkNo]);
                    _talkTextList = _charaTalkList[_charaTalkNo].TalkText;
                    _charaTalkNo += 1;
                    _talkTextNo = 0;
                }
                else
                {
                    _charaTalkList = null;
                    _talkTextList = null;
                    _charaTalkNo = 0;
                    _talkTextNo = 0;
                    return false;
                }
            }
            // ふきだしを更新
            fukidashi.text = _talkTextList[_talkTextNo];
            _talkTextNo += 1;
            return true;
        }

        private void Pause()
        {
            Time.timeScale = 0;
            fukidashi.gameObject.SetActive(true);
            fukidashiBackground.SetActive(true);
            fukidashiTapCatch.SetActive(true);
        }

        private void Restart()
        {
            fukidashi.gameObject.SetActive(false);
            fukidashiBackground.SetActive(false);
            fukidashiTapCatch.SetActive(false);

            nameBackground1.SetActive(false);
            nameBackground2.SetActive(false);
            nameBackground3.SetActive(false);

            // 一時停止解除
            Time.timeScale = 1;
        }

        private bool processRun()
        {
            if (Time.timeScale == 0)
            {
                // 吹き出し表示が継続中
                return true;
            }
            else
            {
                // 吹き出し表示が終了済
                return false;
            }
        }

        public void setProcessId(string id)
        {
            _processId = id;
        }

        public string getProcessId()
        {
            return _processId;
        }

        public void playSound()
        {
            soundEffect.Play();
        }
    }
}