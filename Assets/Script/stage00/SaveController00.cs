using UnityEngine;

namespace Assets.Script
{
    class SaveController00 : SaveController
    {
        private const string _key_Event00_01_FirstStart = @"Event00_01_FirstStart";
        private const string _key_PlayButton = @"PlayButton";

        /// <summary>
        /// 本クラスで定義した全項目を削除
        /// </summary>
        public void deleteAllKeys()
        {
            PlayerPrefs.DeleteKey(_key_Event00_01_FirstStart);
            PlayerPrefs.DeleteKey(_key_PlayButton);
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event00_01_FirstStart()
        {
            saveInt(_key_Event00_01_FirstStart);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event00_01_FirstStart()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event00_01_FirstStart, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_PlayButton()
        {
            saveInt(_key_PlayButton);
        }

        /// <summary>
        /// イベント完了状況を削除
        /// </summary>
        public void delete_PlayButton()
        {
            PlayerPrefs.DeleteKey(_key_PlayButton);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_PlayButton()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_PlayButton, 0));
        }
    }
}
