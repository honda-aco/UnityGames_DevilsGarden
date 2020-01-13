using UnityEngine;

namespace Assets.Script
{
    class SaveController08 : SaveController
    {
        private const string _key_Event08_01_MoveWorld = @"Event08_01_MoveWorld";

        /// <summary>
        /// 本クラスで定義した全項目を削除
        /// </summary>
        public void deleteAllKeys()
        {
            PlayerPrefs.DeleteKey(_key_Event08_01_MoveWorld);
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event08_01_MoveWorld()
        {
            saveInt(_key_Event08_01_MoveWorld);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event08_01_MoveWorld()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event08_01_MoveWorld, 0));
        }
    }
}