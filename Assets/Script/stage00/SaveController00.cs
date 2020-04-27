using UnityEngine;

namespace Assets.Script
{
    class SaveController00 : SaveController
    {
        private const string _key_Event00_01_FirstStart = @"Event00_01_FirstStart";
        private const string _key_PlayButton = @"PlayButton";

        private const string _key_Hint1_1 = @"Hint1_1";
        private const string _key_Hint1_2 = @"Hint1_2";
        private const string _key_Hint1_3 = @"Hint1_3";

        private const string _key_Hint2_1 = @"Hint2_1";
        private const string _key_Hint2_2 = @"Hint2_2";
        private const string _key_Hint2_3 = @"Hint2_3";

        private const string _key_Hint3_1 = @"Hint3_1";
        private const string _key_Hint3_2 = @"Hint3_2";
        private const string _key_Hint3_3 = @"Hint3_3";

        private const string _key_Hint4_1 = @"Hint4_1";
        private const string _key_Hint4_2 = @"Hint4_2";
        private const string _key_Hint4_3 = @"Hint4_3";

        private const string _key_Hint5_1 = @"Hint5_1";
        private const string _key_Hint5_2 = @"Hint5_2";
        private const string _key_Hint5_3 = @"Hint5_3";

        private const string _key_Hint6_1 = @"Hint6_1";
        private const string _key_Hint6_2 = @"Hint6_2";
        private const string _key_Hint6_3 = @"Hint6_3";

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

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint1_1()
        {
            saveInt(_key_Hint1_1);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint1_1()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint1_1, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint1_2()
        {
            saveInt(_key_Hint1_2);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint1_2()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint1_2, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint1_3()
        {
            saveInt(_key_Hint1_3);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint1_3()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint1_3, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint2_1()
        {
            saveInt(_key_Hint2_1);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint2_1()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint2_1, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint2_2()
        {
            saveInt(_key_Hint2_2);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint2_2()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint2_2, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint2_3()
        {
            saveInt(_key_Hint2_3);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint2_3()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint2_3, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint3_1()
        {
            saveInt(_key_Hint3_1);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint3_1()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint3_1, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint3_2()
        {
            saveInt(_key_Hint3_2);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint3_2()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint3_2, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint3_3()
        {
            saveInt(_key_Hint3_3);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint3_3()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint3_3, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint4_1()
        {
            saveInt(_key_Hint4_1);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint4_1()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint4_1, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint4_2()
        {
            saveInt(_key_Hint4_2);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint4_2()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint4_2, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint4_3()
        {
            saveInt(_key_Hint4_3);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint4_3()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint4_3, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint5_1()
        {
            saveInt(_key_Hint5_1);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint5_1()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint5_1, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint5_2()
        {
            saveInt(_key_Hint5_2);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint5_2()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint5_2, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint5_3()
        {
            saveInt(_key_Hint5_3);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint5_3()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint5_3, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint6_1()
        {
            saveInt(_key_Hint6_1);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint6_1()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint6_1, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint6_2()
        {
            saveInt(_key_Hint6_2);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint6_2()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint6_2, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Hint6_3()
        {
            saveInt(_key_Hint6_3);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Hint6_3()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Hint6_3, 0));
        }
    }
}
