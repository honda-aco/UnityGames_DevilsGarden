using UnityEngine;

namespace Assets.Script
{
    class SaveController07 : SaveController
    {
        private const string _key_Event07_04_SacrificeRabbit = @"Event07_04_SacrificeRabbit";
        private const string _key_Event07_05_FindSchool = @"Event07_05_FindSchool";
        private const string _key_Event07_06_FindLetter1 = @"Event07_06_FindLetter1";
        private const string _key_Event07_07_FindLetter2 = @"Event07_07_FindLetter2";
        private const string _key_Event07_08_MoveMeiko = @"Event07_08_MoveMeiko";
        private const string _key_Event07_11_AskRyotaro = @"Event07_11_AskRyotaro";

        /// <summary>
        /// 本クラスで定義した全項目を削除
        /// </summary>
        public void deleteAllKeys()
        {
            PlayerPrefs.DeleteKey(_key_Event07_04_SacrificeRabbit);
            PlayerPrefs.DeleteKey(_key_Event07_05_FindSchool);
            PlayerPrefs.DeleteKey(_key_Event07_06_FindLetter1);
            PlayerPrefs.DeleteKey(_key_Event07_07_FindLetter2);
            PlayerPrefs.DeleteKey(_key_Event07_08_MoveMeiko);
            PlayerPrefs.DeleteKey(_key_Event07_11_AskRyotaro);
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event07_04_SacrificeRabbit()
        {
            saveInt(_key_Event07_04_SacrificeRabbit);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event07_04_SacrificeRabbit()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event07_04_SacrificeRabbit, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event07_05_FindSchool()
        {
            saveInt(_key_Event07_05_FindSchool);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event07_05_FindSchool()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event07_05_FindSchool, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event07_06_FindLetter1()
        {
            saveInt(_key_Event07_06_FindLetter1);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event07_06_FindLetter1()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event07_06_FindLetter1, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event07_07_FindLetter2()
        {
            saveInt(_key_Event07_07_FindLetter2);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event07_07_FindLetter2()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event07_07_FindLetter2, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event07_08_MoveMeiko()
        {
            saveInt(_key_Event07_08_MoveMeiko);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event07_08_MoveMeiko()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event07_08_MoveMeiko, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event07_11_AskRyotaro()
        {
            saveInt(_key_Event07_11_AskRyotaro);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event07_11_AskRyotaro()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event07_11_AskRyotaro, 0));
        }
    }
}
