using UnityEngine;
using UnityEngine.UI;

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

        public void Start()
        {
            base.Start();
            
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

            eventList = new Event00_04_IndicateTitle(this).GetEventList();
            eventNo = 0;
        }

        public void FixedUpdate()
        {
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
    }
}