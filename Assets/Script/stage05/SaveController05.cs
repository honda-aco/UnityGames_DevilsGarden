using UnityEngine;

namespace Assets.Script
{
    class SaveController05 : SaveController
    {
        private const string _key_Event05_04_TakeEnemy = @"Event05_04_TakeEnemy";
        private const string _key_Event05_06_TalkClassmate = @"Event05_06_TalkClassmate";
        private const string _key_Event05_07_01_MeetDevil = @"Event05_07_01_MeetDevil";
        private const string _key_Event05_09_GetOnTrain = @"Event05_09_GetOnTrain";
        private const string _key_Event05_10_GetOffTrain = @"Event05_10_GetOffTrain";
        private const string _key_Event05_11_MeetRyotaro = @"Event05_11_MeetRyotaro";
        private const string _key_Event05_12_PlayBaseball = @"Event05_12_PlayBaseball";

        /// <summary>
        /// 本クラスで定義した全項目を削除
        /// </summary>
        public void deleteAllKeys()
        {
            PlayerPrefs.DeleteKey(_key_Event05_04_TakeEnemy);
            PlayerPrefs.DeleteKey(_key_Event05_06_TalkClassmate);
            PlayerPrefs.DeleteKey(_key_Event05_07_01_MeetDevil);
            PlayerPrefs.DeleteKey(_key_Event05_09_GetOnTrain);
            PlayerPrefs.DeleteKey(_key_Event05_10_GetOffTrain);
            PlayerPrefs.DeleteKey(_key_Event05_11_MeetRyotaro);
            PlayerPrefs.DeleteKey(_key_Event05_12_PlayBaseball);
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event05_04_TakeEnemy()
        {
            saveInt(_key_Event05_04_TakeEnemy);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event05_04_TakeEnemy()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event05_04_TakeEnemy, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event05_06_TalkClassmate()
        {
            saveInt(_key_Event05_06_TalkClassmate);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event05_06_TalkClassmate()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event05_06_TalkClassmate, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event05_07_01_MeetDevil()
        {
            saveInt(_key_Event05_07_01_MeetDevil);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event05_07_01_MeetDevil()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event05_07_01_MeetDevil, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event05_09_GetOnTrain()
        {
            saveInt(_key_Event05_09_GetOnTrain);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event05_09_GetOnTrain()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event05_09_GetOnTrain, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event05_10_GetOffTrain()
        {
            saveInt(_key_Event05_10_GetOffTrain);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event05_10_GetOffTrain()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event05_10_GetOffTrain, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event05_11_MeetRyotaro()
        {
            saveInt(_key_Event05_11_MeetRyotaro);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event05_11_MeetRyotaro()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event05_11_MeetRyotaro, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event05_12_PlayBaseball()
        {
            saveInt(_key_Event05_12_PlayBaseball);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event05_12_PlayBaseball()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event05_12_PlayBaseball, 0));
        }
    }
}
