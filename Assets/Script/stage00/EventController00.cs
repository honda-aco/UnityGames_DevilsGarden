using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;
using System.Collections.Generic;

namespace Assets.Script
{
    public class EventController00 : EventController
    {
        [SerializeField]
        private GameObject messagebox;

        [SerializeField]
        private GameObject creditView;

        [SerializeField]
        private GameObject galleryView;

        [SerializeField]
        private GameObject charityView;

        [SerializeField]
        private ClickEvent00 startButton;

        [SerializeField]
        private ClickEvent00 continueButton;

        [SerializeField]
        private ClickEvent00 galleryButton;

        [SerializeField]
        private ClickEvent00 charityButton;

        [SerializeField]
        private ClickEvent00 pay150Button;

        [SerializeField]
        private ClickEvent00 pay500Button;

        [SerializeField]
        private ClickEvent00 pay1000Button;

        [SerializeField]
        private ClickEvent00 pay10000Button;

        [SerializeField]
        private ClickEvent00 creditButton;

        [SerializeField]
        private ClickEvent00 okButton;

        [SerializeField]
        private ClickEvent00 cancelButton;

        [SerializeField]
        private ClickEvent00 closeButton_Credit;

        [SerializeField]
        private ClickEvent00 closeButton_Gallery;

        [SerializeField]
        private ClickEvent00 closeButton_Charity;

        [SerializeField]
        private ClickEvent00 link1;

        [SerializeField]
        private ClickEvent00 link2;

        [SerializeField]
        private ClickEvent00 link3;

        [SerializeField]
        private ClickEvent00 link4;

        [SerializeField]
        private ClickEvent00 link5;

        [SerializeField]
        private ClickEvent00 link6;

        [SerializeField]
        private ClickEvent00 link7;

        [SerializeField]
        private ClickEvent00 playEnd1;

        [SerializeField]
        private ClickEvent00 notPlayEnd1;

        [SerializeField]
        private ClickEvent00 playEnd2;

        [SerializeField]
        private ClickEvent00 notPlayEnd2;

        [SerializeField]
        private ClickEvent00 playEnd3;

        [SerializeField]
        private ClickEvent00 notPlayEnd3;

        [SerializeField]
        private ClickEvent00 playEnd4;

        [SerializeField]
        private ClickEvent00 notPlayEnd4;

        [SerializeField]
        private ClickEvent00 playEnd5;

        [SerializeField]
        private ClickEvent00 notPlayEnd5;

        [SerializeField]
        private ClickEvent00 playEnd6;

        [SerializeField]
        private ClickEvent00 notPlayEnd6;

        [SerializeField]
        private UnityEngine.UI.Image title2;
        public UnityEngine.UI.Image Title2
        {
            get { return title2; }
        }

        [SerializeField]
        private UnityEngine.UI.Image title3;
        public UnityEngine.UI.Image Title3
        {
            get { return title3; }
        }

        [SerializeField]
        private AudioSource soundEffect_Ok;

        [SerializeField]
        private AudioSource soundEffect_Cancel;

        [SerializeField]
        private GameObject rewardMessagebox;

        [SerializeField]
        private ClickEvent00 okButton_reward;

        [SerializeField]
        private ClickEvent00 cancelButton_reward;

        [SerializeField]
        private GameObject hintMessagebox;

        [SerializeField]
        private ClickEvent00 closeButton_hint;

        [SerializeField]
        private RewardButton LockButton1_1,
                             LockButton2_1, LockButton2_2,
                             LockButton3_1, LockButton3_2, LockButton3_3,
                             LockButton4_1, LockButton4_2,
                             LockButton5_1,
                             LockButton6_1, LockButton6_2;

        [SerializeField]
        private HintButton HintButton1_1,
                           HintButton2_1, HintButton2_2,
                           HintButton3_1, HintButton3_2, HintButton3_3,
                           HintButton4_1, HintButton4_2,
                           HintButton5_1,
                           HintButton6_1, HintButton6_2;

        [SerializeField]
        private GameObject Hint1_1,
                           Hint2_1, Hint2_2,
                           Hint3_1, Hint3_2, Hint3_3,
                           Hint4_1, Hint4_2,
                           Hint5_1,
                           Hint6_1, Hint6_2;

        Dictionary<RewardButton, Action> _rewardActionDic = new Dictionary<RewardButton, Action>();

        private bool _rewardAnnounce = false;

        private Action _rewardAction;

        private RewardedAd _rewardedAd;

        private Stack<Action> _rewardedAdEarned = new Stack<Action>();

        Dictionary<ClickEvent00, GameObject> _hintObjectDic = new Dictionary<ClickEvent00, GameObject>();

        private GameObject _hint;

        public void Start()
        {
            base.Start();

            // リワード広告オブジェクトの作成（読み込みが発生するため最初に）
            CreateAndLoadRewardedAd();

            SaveController00 saveController00 = new SaveController00();
            // ギャラリーから起動されたことを示すフラグを削除
            saveController00.delete_PlayButton();

            // ボタンの設定
            if (saveController00.completed_Event00_01_FirstStart() == false)
            {
                continueButton.GetComponent<Button>().interactable = false;
            }
            startButton.SetEventController(this);
            continueButton.SetEventController(this);
            galleryButton.SetEventController(this);
            charityButton.SetEventController(this);
            creditButton.SetEventController(this);

            pay150Button.SetEventController(this);
            pay500Button.SetEventController(this);
            pay1000Button.SetEventController(this);
            pay10000Button.SetEventController(this);

            okButton.SetEventController(this);
            cancelButton.SetEventController(this);

            closeButton_Credit.SetEventController(this);
            closeButton_Gallery.SetEventController(this);
            closeButton_Charity.SetEventController(this);

            link1.SetEventController(this);
            link2.SetEventController(this);
            link3.SetEventController(this);
            link4.SetEventController(this);
            link5.SetEventController(this);
            link6.SetEventController(this);
            link7.SetEventController(this);

            if (new SaveController_End01().completed_Event_End01_01_Ending())
            {
                playEnd1.gameObject.SetActive(true);
                playEnd1.SetEventController(this);
            }
            else
            {
                notPlayEnd1.gameObject.SetActive(true);
                notPlayEnd1.SetEventController(this);
            }

            if (new SaveController_End02().completed_Event_End02_01_Ending())
            {
                playEnd2.gameObject.SetActive(true);
                playEnd2.SetEventController(this);
            }
            else
            {
                notPlayEnd2.gameObject.SetActive(true);
                notPlayEnd2.SetEventController(this);
            }

            if (new SaveController_End03().completed_Event_End03_01_Ending())
            {
                playEnd3.gameObject.SetActive(true);
                playEnd3.SetEventController(this);
            }
            else
            {
                notPlayEnd3.gameObject.SetActive(true);
                notPlayEnd3.SetEventController(this);
            }

            if (new SaveController_End04().completed_Event_End04_01_Ending())
            {
                playEnd4.gameObject.SetActive(true);
                playEnd4.SetEventController(this);
            }
            else
            {
                notPlayEnd4.gameObject.SetActive(true);
                notPlayEnd4.SetEventController(this);
            }

            if (new SaveController_End05().completed_Event_End05_01_Ending())
            {
                playEnd5.gameObject.SetActive(true);
                playEnd5.SetEventController(this);
            }
            else
            {
                notPlayEnd5.gameObject.SetActive(true);
                notPlayEnd5.SetEventController(this);
            }

            if (new SaveController_End06().completed_Event_End06_01_Ending())
            {
                playEnd6.gameObject.SetActive(true);
                playEnd6.SetEventController(this);
            }
            else
            {
                notPlayEnd6.gameObject.SetActive(true);
                notPlayEnd6.SetEventController(this);
            }

            okButton_reward.SetEventController(this);
            cancelButton_reward.SetEventController(this);

            RewardButton[] rewardButtons = new RewardButton[]
            {
                LockButton1_1,
                LockButton2_1, LockButton2_2,
                LockButton3_1, LockButton3_2, LockButton3_3,
                LockButton4_1, LockButton4_2,
                LockButton5_1,
                LockButton6_1, LockButton6_2
            };

            foreach (RewardButton rewardButton in rewardButtons)
            {
                rewardButton.SetEventController(this);
            };

            _rewardActionDic.Add(LockButton1_1, new SaveController00().complete_Hint1_1);
            _rewardActionDic.Add(LockButton2_1, new SaveController00().complete_Hint2_1);
            _rewardActionDic.Add(LockButton2_2, new SaveController00().complete_Hint2_2);
            _rewardActionDic.Add(LockButton3_1, new SaveController00().complete_Hint3_1);
            _rewardActionDic.Add(LockButton3_2, new SaveController00().complete_Hint3_2);
            _rewardActionDic.Add(LockButton3_3, new SaveController00().complete_Hint3_3);
            _rewardActionDic.Add(LockButton4_1, new SaveController00().complete_Hint4_1);
            _rewardActionDic.Add(LockButton4_2, new SaveController00().complete_Hint4_2);
            _rewardActionDic.Add(LockButton5_1, new SaveController00().complete_Hint5_1);
            _rewardActionDic.Add(LockButton6_1, new SaveController00().complete_Hint6_1);
            _rewardActionDic.Add(LockButton6_2, new SaveController00().complete_Hint6_2);

            closeButton_hint.SetEventController(this);

            HintButton[] hintButtons = new HintButton[]
            {
                HintButton1_1,
                HintButton2_1, HintButton2_2,
                HintButton3_1, HintButton3_2, HintButton3_3,
                HintButton4_1, HintButton4_2,
                HintButton5_1,
                HintButton6_1, HintButton6_2
            };

            foreach (HintButton hintButton in hintButtons)
            {
                hintButton.SetEventController(this);
            };

            _hintObjectDic.Add(HintButton1_1, Hint1_1);
            _hintObjectDic.Add(HintButton2_1, Hint2_1);
            _hintObjectDic.Add(HintButton2_2, Hint2_2);
            _hintObjectDic.Add(HintButton3_1, Hint3_1);
            _hintObjectDic.Add(HintButton3_2, Hint3_2);
            _hintObjectDic.Add(HintButton3_3, Hint3_3);
            _hintObjectDic.Add(HintButton4_1, Hint4_1);
            _hintObjectDic.Add(HintButton4_2, Hint4_2);
            _hintObjectDic.Add(HintButton5_1, Hint5_1);
            _hintObjectDic.Add(HintButton6_1, Hint6_1);
            _hintObjectDic.Add(HintButton6_2, Hint6_2);

            // ヒントオブジェクトの切り替え
            UpdateHintButtons();

            eventList = new Event00_04_IndicateTitle(this).GetEventList();
            eventNo = 0;
        }

        public void FixedUpdate()
        {
            if (_rewardedAdEarned.Count > 0)
            {
                (_rewardedAdEarned.Pop())();
                UpdateHintButtons();

            }

            if (eventList != null && eventList.Count > eventNo)
            {
                if (eventList[eventNo].Invoke())
                {
                    eventNo += 1;
                    return;
                }
            }
        }

        /// <summary>
        /// はじめからボタン押下
        /// </summary>
        public void OnClick_StartButton()
        {
            soundEffect_Ok.Play();

            SaveController00 saveController00 = new SaveController00();
            if (saveController00.completed_Event00_01_FirstStart())
            {
                messagebox.SetActive(true);
            }
            else
            {
                eventList = new Event00_01_FirstStart(this).GetEventList();
                eventNo = 0;
            }
        }

        /// <summary>
        /// つづきからボタン押下
        /// </summary>
        public void OnClick_ContinueButton()
        {
            soundEffect_Ok.Play();

            eventList = new Event00_02_Continue(this).GetEventList();
            eventNo = 0;
        }

        /// <summary>
        /// ギャラリーボタン押下
        /// </summary>
        public void OnClick_GalleryButton()
        {
            soundEffect_Ok.Play();
            galleryView.SetActive(true);
        }

        /// <summary>
        /// クレジットボタン押下
        /// </summary>
        public void OnClick_CreditButton()
        {
            soundEffect_Ok.Play();
            creditView.SetActive(true);
        }

        /// <summary>
        /// 募金ボタン押下
        /// </summary>
        public void OnClick_CharityButton()
        {
            soundEffect_Ok.Play();
            charityView.SetActive(true);
        }

        /// <summary>
        /// 募金決定ボタン押下
        /// </summary>
        public void OnClick_PayButton()
        {
            soundEffect_Ok.Play();
        }

        /// <summary>
        /// データ削除確認のOKボタン押下
        /// </summary>
        public void OnClick_OkButton()
        {
            soundEffect_Ok.Play();
            eventList = new Event00_01_FirstStart(this).GetEventList();
            eventNo = 0;
        }

        /// <summary>
        /// データ削除確認のキャンセルボタン押下
        /// </summary>
        public void OnClick_CancelButton()
        {
            soundEffect_Cancel.Play();
            messagebox.SetActive(false);
        }

        /// <summary>
        /// リンククリック
        /// </summary>
        public void OnClick_Link(string url)
        {
            soundEffect_Ok.Play();
            Application.OpenURL(url);
        }

        /// <summary>
        /// ギャラリー再生クリック
        /// </summary>
        public void OnClick_PlayGallery(string stage)
        {
            if (string.IsNullOrEmpty(stage))
            {
                soundEffect_Cancel.Play();
            }
            else
            {
                new SaveController00().complete_PlayButton();
                soundEffect_Ok.Play();
                loadScene(stage);
            }
        }

        /// <summary>
        /// クレジット画面の閉じるボタン押下
        /// </summary>
        public void OnClick_CreditClose()
        {
            soundEffect_Cancel.Play();
            creditView.SetActive(false);
        }

        /// <summary>
        /// ギャラリー画面の閉じるボタン押下
        /// </summary>
        public void OnClick_GalleryClose()
        {
            soundEffect_Cancel.Play();
            galleryView.SetActive(false);
        }

        /// <summary>
        /// 募金画面の閉じるボタン押下
        /// </summary>
        public void OnClick_CharityClose()
        {
            soundEffect_Cancel.Play();
            charityView.SetActive(false);
        }

        /// <summary>
        /// ロックボタン押下
        /// </summary>
        public void OnClick_RewardButton(RewardButton rewardButton)
        {
            _rewardAction = _rewardActionDic[rewardButton];

            // 広告を表示して受取る報酬についての説明処理
            if (_rewardAnnounce)
            {
                if (_rewardedAd.IsLoaded())
                {
                    _rewardedAd.Show();
                }
            }
            else
            {
                rewardMessagebox.SetActive(true);
            }

        }

        /// <summary>
        /// 広告メッセージの続けるボタン押下
        /// </summary>
        public void OnClick_OkReward()
        {
            soundEffect_Ok.Play();
            _rewardAnnounce = true;
            rewardMessagebox.SetActive(false);

            if (_rewardedAd.IsLoaded())
            {
                _rewardedAd.Show();
            }
        }

        /// <summary>
        /// 広告メッセージのキャンセルボタン押下
        /// </summary>
        public void OnClick_CancelReward()
        {
            soundEffect_Cancel.Play();
            rewardMessagebox.SetActive(false);
        }

        /// <summary>
        /// ヒントボタン押下
        /// </summary>
        public void OnClick_HintButton(HintButton hintButton)
        {
            soundEffect_Ok.Play();
            _hint = _hintObjectDic[hintButton];
            _hint.SetActive(true);
            hintMessagebox.SetActive(true);
        }

        /// <summary>
        /// ヒントメッセージの閉じるボタン押下
        /// </summary>
        public void OnClick_CloseHint()
        {
            soundEffect_Cancel.Play();
            hintMessagebox.SetActive(false);
            _hint.SetActive(false);
        }

        public void CreateAndLoadRewardedAd()
        {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3375705566833853/7623702329";
#else
            string adUnitId = "ca-app-pub-3940256099942544/5224354917";
#endif
            _rewardedAd = new RewardedAd(adUnitId);

            _rewardedAd.OnUserEarnedReward +=
                (object sender, Reward args) =>
                {
                    _rewardedAdEarned.Push(_rewardAction);
                    //CreateAndLoadRewardedAd();
                };

            _rewardedAd.OnAdClosed +=
                (object sender, EventArgs args) =>
                {
                    CreateAndLoadRewardedAd();

                };

            AdRequest request = new AdRequest.Builder().Build();
            _rewardedAd.LoadAd(request);
        }

        public void UpdateHintButtons()
        {
            SaveController00 saveController00 = new SaveController00();

            bool showHint1_1 = saveController00.completed_Hint1_1();
 
            bool showHint2_1 = saveController00.completed_Hint2_1();
            bool showHint2_2 = saveController00.completed_Hint2_2();
 
            bool showHint3_1 = saveController00.completed_Hint3_1();
            bool showHint3_2 = saveController00.completed_Hint3_2();
            bool showHint3_3 = saveController00.completed_Hint3_3();

            bool showHint4_1 = saveController00.completed_Hint4_1();
            bool showHint4_2 = saveController00.completed_Hint4_2();

            bool showHint5_1 = saveController00.completed_Hint5_1();

            bool showHint6_1 = saveController00.completed_Hint6_1();
            bool showHint6_2 = saveController00.completed_Hint6_2();

            LockButton1_1.gameObject.SetActive(!showHint1_1);
            HintButton1_1.gameObject.SetActive(showHint1_1);

            LockButton2_1.gameObject.SetActive(!showHint2_1);
            HintButton2_1.gameObject.SetActive(showHint2_1);
            LockButton2_2.gameObject.SetActive(!showHint2_2);
            HintButton2_2.gameObject.SetActive(showHint2_2);

            LockButton3_1.gameObject.SetActive(!showHint3_1);
            HintButton3_1.gameObject.SetActive(showHint3_1);
            LockButton3_2.gameObject.SetActive(!showHint3_2);
            HintButton3_2.gameObject.SetActive(showHint3_2);
            LockButton3_3.gameObject.SetActive(!showHint3_3);
            HintButton3_3.gameObject.SetActive(showHint3_3);

            LockButton4_1.gameObject.SetActive(!showHint4_1);
            HintButton4_1.gameObject.SetActive(showHint4_1);
            LockButton4_2.gameObject.SetActive(!showHint4_2);
            HintButton4_2.gameObject.SetActive(showHint4_2);

            LockButton5_1.gameObject.SetActive(!showHint5_1);
            HintButton5_1.gameObject.SetActive(showHint5_1);

            LockButton6_1.gameObject.SetActive(!showHint6_1);
            HintButton6_1.gameObject.SetActive(showHint6_1);
            LockButton6_2.gameObject.SetActive(!showHint6_2);
            HintButton6_2.gameObject.SetActive(showHint6_2);
        }
    }
}