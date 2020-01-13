using UnityEngine;

namespace Assets.Script
{
    class SaveController04 : SaveController
    {
        private const string _key_Event04_02_FindRabbitHouse = @"Event04_02_FindRabbitHouse"; 
        private const string _key_Event04_03_FindRabbit1 = @"Event04_03_FindRabbit1";
        private const string _key_Event04_04_FindRabbit2 = @"Event04_04_FindRabbit2";
        private const string _key_Event04_08_EnterGymnasium = @"Event04_08_EnterGymnasium";
        private const string _key_Event04_09_FindBusstop = @"Event04_09_FindBusstop";
        private const string _key_Event04_11_01_EnterCeremony1 = @"Event04_11_01EnterCeremony1";
        private const string _key_Event04_11_01_EnterCeremony2 = @"Event04_11_01EnterCeremony2";
        private const string _key_Event04_19_Suicide = @"Event04_19_Suicide";

        /// <summary>
        /// 本クラスで定義した全項目を削除
        /// </summary>
        public void deleteAllKeys()
        {
            PlayerPrefs.DeleteKey(_key_Event04_02_FindRabbitHouse);
            PlayerPrefs.DeleteKey(_key_Event04_03_FindRabbit1);
            PlayerPrefs.DeleteKey(_key_Event04_04_FindRabbit2);
            PlayerPrefs.DeleteKey(_key_Event04_08_EnterGymnasium);
            PlayerPrefs.DeleteKey(_key_Event04_09_FindBusstop);
            PlayerPrefs.DeleteKey(_key_Event04_11_01_EnterCeremony1);
            PlayerPrefs.DeleteKey(_key_Event04_11_01_EnterCeremony2);
            PlayerPrefs.DeleteKey(_key_Event04_19_Suicide);
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event04_02_FindRabbitHouse()
        {
            saveInt(_key_Event04_02_FindRabbitHouse);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event04_02_FindRabbitHouse()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event04_02_FindRabbitHouse, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event04_03_FindRabbit1()
        {
            saveInt(_key_Event04_03_FindRabbit1);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event04_03_FindRabbit1()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event04_03_FindRabbit1, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event04_04_FindRabbit2()
        {
            saveInt(_key_Event04_04_FindRabbit2);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event04_04_FindRabbit2()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event04_04_FindRabbit2, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event04_08_EnterGymnasium()
        {
            saveInt(_key_Event04_08_EnterGymnasium);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event04_08_EnterGymnasium()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event04_08_EnterGymnasium, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event04_09_FindBusstop()
        {
            saveInt(_key_Event04_09_FindBusstop);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event04_09_FindBusstop()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event04_09_FindBusstop, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event04_11_EnterCeremony1()
        {
            saveInt(_key_Event04_11_01_EnterCeremony1);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event04_11_EnterCeremony1()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event04_11_01_EnterCeremony1, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event04_11_EnterCeremony2()
        {
            saveInt(_key_Event04_11_01_EnterCeremony2);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event04_11_EnterCeremony2()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event04_11_01_EnterCeremony2, 0));
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event04_19_Suicide()
        {
            saveInt(_key_Event04_19_Suicide);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event04_19_Suicide()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event04_19_Suicide, 0));
        }
    }
}
