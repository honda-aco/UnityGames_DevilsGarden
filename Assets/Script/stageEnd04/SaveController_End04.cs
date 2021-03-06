﻿using UnityEngine;

namespace Assets.Script
{
    class SaveController_End04 : SaveController
    {
        private const string _key_Event_End04_01_Ending = @"Event_End04_01_Ending";

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void complete_Event_End04_01_Ending()
        {
            saveInt(_key_Event_End04_01_Ending);
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public bool completed_Event_End04_01_Ending()
        {
            return convertIntToBool(PlayerPrefs.GetInt(_key_Event_End04_01_Ending, 0));
        }
    }
}
