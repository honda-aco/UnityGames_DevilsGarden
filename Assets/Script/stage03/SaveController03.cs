using UnityEngine;

namespace Assets.Script
{
    class SaveController03 : SaveController
    {
        private const string _key_Event03_04_01_FindHole = @"Event03_04_01_FindHole";
        private const string _key_Event03_04_03_FindHole = @"Event03_04_03_FindHole";
        private const string _key_Event03_06_MeetFather = @"Event03_06_MeetFather";
        private const string _key_Event03_07_FindSchoolBug = @"Event03_07_FindSchoolBug";
        private const string _key_Event03_09_MeetDevil = @"Event03_09_MeetDevil";
        private const string _key_Event03_10_MeetStranger = @"Event03_10_MeetStranger";

        /// <summary>
        /// 本クラスで定義した全項目を削除
        /// </summary>
        public void deleteAllKeys()
        {
            PlayerPrefs.DeleteKey(_key_Event03_04_01_FindHole);
            PlayerPrefs.DeleteKey(_key_Event03_04_03_FindHole);
            PlayerPrefs.DeleteKey(_key_Event03_06_MeetFather);
            PlayerPrefs.DeleteKey(_key_Event03_07_FindSchoolBug);
            PlayerPrefs.DeleteKey(_key_Event03_09_MeetDevil);
            PlayerPrefs.DeleteKey(_key_Event03_10_MeetStranger);
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event03_04_01_FindHole()
        {
            saveInt(_key_Event03_04_01_FindHole);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event03_04_01_FindHole()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event03_04_01_FindHole, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event03_04_03_FindHole()
        {
            saveInt(_key_Event03_04_03_FindHole);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event03_04_03_FindHole()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event03_04_03_FindHole, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event03_06_MeetFather()
        {
            saveInt(_key_Event03_06_MeetFather);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event03_06_MeetFather()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event03_06_MeetFather, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event03_07_FindSchoolBug()
        {
            saveInt(_key_Event03_07_FindSchoolBug);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event03_07_FindSchoolBug()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event03_07_FindSchoolBug, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event03_09_MeetDevil()
        {
            saveInt(_key_Event03_09_MeetDevil);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event03_09_MeetDevil()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event03_09_MeetDevil, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event03_10_MeetStranger()
        {
            saveInt(_key_Event03_10_MeetStranger);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event03_10_MeetStranger()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event03_10_MeetStranger, 0));
        }
    }
}
