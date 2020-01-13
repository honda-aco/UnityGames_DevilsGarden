using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class BgmController : MonoBehaviour
    {
        [SerializeField]
        private AudioSource bgmDefault;
        public AudioSource BgmDefault
        {
            set { bgmDefault = value; }
        }

        [SerializeField]
        private AudioSource bgmChase;
        public AudioSource BgmChase
        {
            set { bgmChase = value; }
        }

        [SerializeField]
        private AudioSource bgmGameOver;
        public AudioSource BgmGameOver
        {
            set { bgmGameOver = value; }
        }

        [SerializeField]
        private AudioSource bgmEndroll;
        public AudioSource BgmEndroll
        {
            set { bgmEndroll = value; }
        }

        [SerializeField]
        private AudioSource bgmEvent1;
        public AudioSource BgmEvent1
        {
            set { bgmEvent1 = value; }
        }

        [SerializeField]
        private AudioSource bgmEvent2;
        public AudioSource BgmEvent2
        {
            set { bgmEvent2 = value; }
        }

        [SerializeField]
        private AudioSource bgmEvent3;
        public AudioSource BgmEvent3
        {
            set { bgmEvent3 = value; }
        }

        [SerializeField]
        private AudioSource bgmEvent4;
        public AudioSource BgmEvent4
        {
            set { bgmEvent4 = value; }
        }

        [SerializeField]
        private AudioSource bgmEvent5;
        public AudioSource BgmEvent5
        {
            set { bgmEvent5 = value; }
        }

        private List<AudioSource> bgmList = new List<AudioSource>();
        public List<AudioSource> BgmList
        {
            set { bgmList = value; }
        }

        private static BgmController me = new BgmController();

        public static BgmController GetInstance()
        {
            return me;
        }

        // シングルトン化
        private BgmController()
        {
        }

        /// <summary>
        /// 初期処理
        /// </summary>
        public void Start()
        {
            bgmDefault.Play();
            me.BgmDefault = bgmDefault;
            me.BgmChase = bgmChase;
            me.BgmGameOver = bgmGameOver;
            me.BgmEndroll = bgmEndroll;
            me.BgmEvent1 = bgmEvent1;
            me.BgmEvent2 = bgmEvent2;
            me.BgmEvent3 = bgmEvent3;
            me.BgmEvent4 = bgmEvent4;
            me.BgmEvent5 = bgmEvent5;

            // リストの初期化
            bgmList.Add(bgmDefault);
            bgmList.Add(bgmChase);
            bgmList.Add(bgmGameOver);
            bgmList.Add(bgmEndroll);
            bgmList.Add(bgmEvent1);
            bgmList.Add(bgmEvent2);
            bgmList.Add(bgmEvent3);
            bgmList.Add(bgmEvent4);
            bgmList.Add(bgmEvent5);

            me.BgmList = bgmList;
        }

        /// <summary>
        /// 初期BGMの再生
        /// </summary>
        public void playDefaultBgm(bool playStart = false)
        {
            playBgm(bgmDefault, playStart);
        }

        /// <summary>
        /// 追跡用BGMの再生
        /// </summary>
        public void playChaseBgm(bool playStart = false)
        {
            playBgm(bgmChase, playStart);
        }

        /// <summary>
        /// ゲームオーバーBGMの再生
        /// </summary>
        public void playGameOverBgm(bool playStart = false)
        {
            playBgm(bgmGameOver, playStart);
        }

        /// <summary>
        /// エンドロールBGMの再生
        /// </summary>
        public void playEndrollBgm(bool playStart = false)
        {
            playBgm(bgmEndroll, playStart);
        }

        /// <summary>
        /// イベントBGM1の再生
        /// </summary>
        public void playEvent1Bgm(bool playStart = false)
        {
            playBgm(bgmEvent1, playStart);
        }

        /// <summary>
        /// イベントBGM2の再生
        /// </summary>
        public void playEvent2Bgm(bool playStart = false)
        {
            playBgm(bgmEvent2, playStart);
        }

        /// <summary>
        /// イベントBGM3の再生
        /// </summary>
        public void playEvent3Bgm(bool playStart = false)
        {
            playBgm(bgmEvent3, playStart);
        }

        /// <summary>
        /// イベントBGM4の再生
        /// </summary>
        public void playEvent4Bgm(bool playStart = false)
        {
            playBgm(bgmEvent4, playStart);
        }

        /// <summary>
        /// イベントBGM5の再生
        /// </summary>
        public void playEvent5Bgm(bool playStart = false)
        {
            playBgm(bgmEvent5, playStart);
        }

        /// <summary>
        /// BGMの再生
        /// </summary>
        /// <param name="audioSource"></param>
        private void playBgm(AudioSource audioSource, bool playStart = false)
        {
            stopBgm();  // 全てのBGMを止める

            if (audioSource == null)
            {
                return;
            }
            else
            {
                if (audioSource.mute)
                {
                    audioSource.mute = false;
                }

                if (playStart || audioSource.isPlaying == false)
                {
                    audioSource.Play();
                }        
            }
        }

        /// <summary>
        /// BGMの停止
        /// </summary>
        public void stopBgm()
        {
            // 全てのBGMを止める
            foreach (AudioSource bgm in bgmList)
            {
                if (bgm == null)
                {
                    continue;
                }
                else
                {
                    bgm.mute = true;
                }
            }
        }
    }
}