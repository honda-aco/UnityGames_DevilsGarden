using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    class SaveController
    {
        protected string _key_Scene = @"Scene";
        protected string _key_LastScene = @"LastScene";
        protected string _key_Place = @"Place";
        protected string _key_KeyItem1Status = @"KeyItem1Status";
        protected string _key_KeyItem2Status = @"KeyItem2Status";
        protected string _key_KeyItem3Status = @"KeyItem3Status";
        protected string _key_HpCount = @"KeyHpCount";

        /// <summary>
        /// 本クラスで定義した全項目を削除
        /// </summary>
        public void deleteAllKeys()
        {
            PlayerPrefs.DeleteKey(_key_Scene);
            PlayerPrefs.DeleteKey(_key_LastScene);
            PlayerPrefs.DeleteKey(_key_Place);
            PlayerPrefs.DeleteKey(_key_KeyItem1Status);
            PlayerPrefs.DeleteKey(_key_KeyItem2Status);
            PlayerPrefs.DeleteKey(_key_KeyItem3Status);
        }

        private Dictionary<SceneNo, string> sceneDic = new Dictionary<SceneNo, string>();
        public Dictionary<SceneNo, string> SceneDict
        {
            get { return sceneDic; }
        }

        private Dictionary<PlaceNo, string> placeDic = new Dictionary<PlaceNo, string>();
        private Dictionary<KeyItemStatus, string> keyItemStatusDic = new Dictionary<KeyItemStatus, string>();

        public enum SceneNo
        {
            Scene01,
            Scene02,
            Scene03,
            Scene04,
            Scene05,
            Scene06,
            Scene07,
            Scene08,
            Scene09,
            SceneEnd01,
            SceneEnd02,
            SceneEnd03,
            SceneEnd04,
            SceneEnd05,
            SceneEnd06,
            None
        }

        public enum PlaceNo
        {
            Place01,
            Place02,
            Place03,
            Place04,
            None
        }

        public enum KeyItemStatus
        {
            Level_25,
            Level_50,
            Level_75,
            Level_100,
            None
        }

        public SaveController()
        {
            sceneDic.Add(SceneNo.Scene01,    @"stage01");
            sceneDic.Add(SceneNo.Scene02,    @"stage02");
            sceneDic.Add(SceneNo.Scene03,    @"stage03");
            sceneDic.Add(SceneNo.Scene04,    @"stage04");
            sceneDic.Add(SceneNo.Scene05,    @"stage05");
            sceneDic.Add(SceneNo.Scene06,    @"stage06");
            sceneDic.Add(SceneNo.Scene07,    @"stage07");
            sceneDic.Add(SceneNo.Scene08,    @"stage08");
            sceneDic.Add(SceneNo.Scene09,    @"stage09");
            sceneDic.Add(SceneNo.SceneEnd01, @"stage_End01");
            sceneDic.Add(SceneNo.SceneEnd02, @"stage_End02");
            sceneDic.Add(SceneNo.SceneEnd03, @"stage_End03");
            sceneDic.Add(SceneNo.SceneEnd04, @"stage_End04");
            sceneDic.Add(SceneNo.SceneEnd05, @"stage_End05");
            sceneDic.Add(SceneNo.SceneEnd06, @"stage_End06");
            sceneDic.Add(SceneNo.None,       @"None");

            placeDic.Add(PlaceNo.Place01, @"Place01");
            placeDic.Add(PlaceNo.Place02, @"Place02");
            placeDic.Add(PlaceNo.Place03, @"Place03");
            placeDic.Add(PlaceNo.Place04, @"Place04");
            placeDic.Add(PlaceNo.None,    @"None");

            keyItemStatusDic.Add(KeyItemStatus.Level_25,  @"Level_25");
            keyItemStatusDic.Add(KeyItemStatus.Level_50,  @"Level_50");
            keyItemStatusDic.Add(KeyItemStatus.Level_75,  @"Level_75");
            keyItemStatusDic.Add(KeyItemStatus.Level_100, @"Level_100");
        }

        /// <summary>
        /// シーンの保存
        /// </summary>
        /// <param name="sceneNo"></param>
        /// <param name="placeNo"></param>
        public void save_Scene(SceneNo sceneNo, PlaceNo placeNo)
        {
            PlayerPrefs.SetString(_key_Place, placeDic[placeNo]);

            string lastScene = PlayerPrefs.GetString(_key_Scene, string.Empty);
            if (convert_Scene(lastScene).Equals(sceneNo) == false)
            {
                PlayerPrefs.SetString(_key_LastScene, lastScene);
                PlayerPrefs.SetString(_key_Scene, sceneDic[sceneNo]);
            }

            PlayerPrefs.Save();
        }

        /// <summary>
        /// キーアイテム1の進捗の保存
        /// </summary>
        /// <param name="keyItemStatus"></param>
        public void save_KeyItem1Status(KeyItemStatus keyItemStatus)
        {
            PlayerPrefs.SetString(_key_KeyItem1Status, keyItemStatusDic[keyItemStatus]);
            PlayerPrefs.Save();
        }

        /// <summary>
        /// キーアイテム2の進捗の保存
        /// </summary>
        /// <param name="keyItemStatus"></param>
        public void save_KeyItem2Status(KeyItemStatus keyItemStatus)
        {
            PlayerPrefs.SetString(_key_KeyItem2Status, keyItemStatusDic[keyItemStatus]);
            PlayerPrefs.Save();
        }

        /// <summary>
        /// キーアイテム3の進捗の保存
        /// </summary>
        /// <param name="keyItemStatus"></param>
        public void save_KeyItem3Status(KeyItemStatus keyItemStatus)
        {
            PlayerPrefs.SetString(_key_KeyItem3Status, keyItemStatusDic[keyItemStatus]);
            PlayerPrefs.Save();
        }

        /// <summary>
        /// シーンの取得（[0]:現在のシーン、[1]:ひとつ前のシーン）
        /// </summary>
        /// <param name="scene"></param>
        public SceneNo[] get_Scene()
        {
            string scene = PlayerPrefs.GetString(_key_Scene, string.Empty);
            string lastScene = PlayerPrefs.GetString(_key_LastScene, string.Empty);
       
            return new SceneNo[]{ convert_Scene(scene), convert_Scene(lastScene) };
        }

        /// <summary>
        /// 位置の取得
        /// </summary>
        /// <returns></returns>
        public PlaceNo get_Place()
        {
            return convert_Place(PlayerPrefs.GetString(_key_Place, string.Empty));
        }

        /// <summary>
        /// キーアイテム1の進捗の取得
        /// </summary>
        /// <returns></returns>
        public KeyItemStatus get_KeyItem1Status()
        {
            return convert_KeyItem(PlayerPrefs.GetString(_key_KeyItem1Status, string.Empty));
        }

        /// <summary>
        /// キーアイテム2の進捗の取得
        /// </summary>
        /// <returns></returns>
        public KeyItemStatus get_KeyItem2Status()
        {
            return convert_KeyItem(PlayerPrefs.GetString(_key_KeyItem2Status, string.Empty));
        }

        /// <summary>
        /// キーアイテム3の進捗の取得
        /// </summary>
        /// <returns></returns>
        public KeyItemStatus get_KeyItem3Status()
        {
            return convert_KeyItem(PlayerPrefs.GetString(_key_KeyItem3Status, string.Empty));
        }

        /// <summary>
        /// シーン番号の変換
        /// </summary>
        /// <param name="keyItem"></param>
        /// <returns></returns>
        private SceneNo convert_Scene(string scene)
        {
            foreach (SceneNo key in sceneDic.Keys)
            {
                if (sceneDic[key].Equals(scene))
                {
                    return key;
                }
            }

            return SceneNo.None;
        }

        /// <summary>
        /// 位置番号の変換
        /// </summary>
        /// <param name="place"></param>
        /// <returns></returns>
        private PlaceNo convert_Place(string place)
        {
            foreach (PlaceNo key in placeDic.Keys)
            {
                if (placeDic[key].Equals(place))
                {
                    return key;
                }
            }

            return PlaceNo.None;
        }

        /// <summary>
        /// キーアイテムの変換
        /// </summary>
        /// <param name="keyItem"></param>
        /// <returns></returns>
        private KeyItemStatus convert_KeyItem(string keyItem)
        {
            foreach (KeyItemStatus key in keyItemStatusDic.Keys)
            {
                if (keyItemStatusDic[key].Equals(keyItem))
                {
                    return key;
                }
            }

            return KeyItemStatus.None;
        }

        /// <summary>
        /// Int型データの保存
        /// </summary>
        /// <param name="key"></param>
        protected void saveInt(string key)
        {
            PlayerPrefs.SetInt(key, 1);
            PlayerPrefs.Save();
        }

        /// <summary>
        /// int型からbool型への変換
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected bool convertIntToBool(int value)
        {
            if (value > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// イベント完了を保存
        /// </summary>
        public void save_KeyHpCount(int value)
        {
            PlayerPrefs.SetInt(_key_HpCount, value);
            PlayerPrefs.Save();
        }

        /// <summary>
        /// イベント完了状況の確認
        /// </summary>
        /// <returns></returns>
        public int get_KeyHpCount()
        {
            return PlayerPrefs.GetInt(_key_HpCount, 3);
        }
    }
}
