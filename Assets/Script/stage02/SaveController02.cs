using UnityEngine;

namespace Assets.Script
{
    class SaveController02 : SaveController
    {
        private const string _key_Event02_01_Prologue = @"Event02_01_Prologue";
        private const string _key_Event02_05_MeetMeiko = @"Event02_05_MeetMeiko";
        private const string _key_Event02_07_FindEnemies = @"Event02_07_FindEnemies";
        private const string _key_Event02_08_FindCorpses = @"Event02_08_FindCorpses";

        /// <summary>
        /// 本クラスで定義した全項目を削除
        /// </summary>
        public void deleteAllKeys()
        {
            PlayerPrefs.DeleteKey(_key_Event02_01_Prologue);
            PlayerPrefs.DeleteKey(_key_Event02_05_MeetMeiko);
            PlayerPrefs.DeleteKey(_key_Event02_07_FindEnemies);
            PlayerPrefs.DeleteKey(_key_Event02_08_FindCorpses);
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event02_01_Prologue()
        {
            saveInt(_key_Event02_01_Prologue);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event02_01_Prologue()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event02_01_Prologue, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event02_05_MeetMeiko()
        {
            saveInt(_key_Event02_05_MeetMeiko);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event02_05_MeetMeiko()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event02_05_MeetMeiko, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event02_07_FindEnemies()
        {
            saveInt(_key_Event02_07_FindEnemies);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event02_07_FindEnemies()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event02_07_FindEnemies, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event02_08_FindCorpses()
        {
            saveInt(_key_Event02_08_FindCorpses);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event02_08_FindCorpses()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event02_08_FindCorpses, 0));
        }
    }
}
