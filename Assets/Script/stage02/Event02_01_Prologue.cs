using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event02_01_Prologue : Event_DeferredBgm
    {
        private EventController02 eventController02;
        private float defaultZoom = 50.0f;

        public Event02_01_Prologue(EventController02 eventController) : base(eventController)
        {
            this.eventController02 = eventController;
            this.defaultZoom = eventController.MainCamera1.orthographicSize;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(eventController.playChaseBgm_Begin));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(event11));
            eventList.Add(new EventController.eventProcess(event12));
            eventList.Add(new EventController.eventProcess(eventController02.lightOff));
            eventList.Add(new EventController.eventProcess(event13));
            eventList.Add(new EventController.eventProcess(eventController02.lightOn));
            eventList.Add(new EventController.eventProcess(eventController.playDefaultBgm));
            eventList.Add(new EventController.eventProcess(event14));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(event11));
            eventList.Add(new EventController.eventProcess(event15));
            eventList.Add(new EventController.eventProcess(eventController02.lightOff));
            eventList.Add(new EventController.eventProcess(event13));
            eventList.Add(new EventController.eventProcess(eventController02.lightOn));
            eventList.Add(new EventController.eventProcess(eventController.playDefaultBgm));
            eventList.Add(new EventController.eventProcess(event16));
            eventList.Add(new EventController.eventProcess(eventController02.lightOff));
            eventList.Add(new EventController.eventProcess(event17));
            eventList.Add(new EventController.eventProcess(eventController02.lightOn));
            eventList.Add(new EventController.eventProcess(event18));
            eventList.Add(new EventController.eventProcess(event19));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        private bool event1()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ここはどこだろう……",
                        @"突然知らない場所にいるってことは" + System.Environment.NewLine +
                        @"また だれかの夢に入ってるんだろうけど",
                        @"夢にしてはずいぶんリアルだ",
                        @"夢の主も近くにいないし" + System.Environment.NewLine +
                        @"なんかいつもの夢と違う感じ",
                        @"現実的で歪みが少ないってことは" + System.Environment.NewLine +
                        @"大人が見てる夢なのかな？",
                        @"まあいっか",
                        @"夢の中に入るのも久しぶりだし" + System.Environment.NewLine +
                        @"少し探検してみよう"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            return eventController02.playerWalk(eventController02.MovePoint1, 20.0f);
        }

        private bool event3()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"誰かいる",
                        @"怪しい雰囲気だけど 声をかけてみよう"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event4()
        {
            return eventController02.MainCamera1.Zoom(25.0f, 0.3f);
        }

        private bool event5()
        {
            return eventController02.playerWalk(eventController02.MovePoint1);
        }

        private bool event6()
        {
            return eventController02.playerTurnaround(eventController02.Enemy1.gameObject);
        }

        private bool event7()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"すみません" + System.Environment.NewLine +
                        @"ちょっと聞きたいんですけれど……",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event8()
        {
            eventController02.VoiceEnemy.Play();
            return true;
        }

        private bool event9()
        {
            return eventController02.charaRun(eventController02.Enemy1, eventController02.MovePoint1);
        }

        private bool event10()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"痛っ！！",
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event11()
        {
            return eventController02.playerDead();
        }

        private bool event12()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"くはないか" + System.Environment.NewLine +
                        @"夢なんだから……",
                        @"ずいぶん唐突だけど" + System.Environment.NewLine +
                        @"夢から出られるし よかったかも",
                        @"出る前に 誰が見ている夢なのかは" + System.Environment.NewLine +
                        @"知りたかった……な……"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event13()
        {
            eventController02.Player.restorDefaultValue();
            eventController02.Enemy1.restorDefaultValue();
            eventController02.Blood.restorDefaultValue();
            eventController02.MainCamera1.orthographicSize = defaultZoom;
            return true;
        }

        private bool event14()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あれ？",
                        @"え……なんでまたここにいるの？",
                        @"さっき わたし死んだよね？",
                        @"えっと……",
                        @"とりあえずもう一回試してみよう"
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event15()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"気分は最悪だけど" + System.Environment.NewLine +
                        @"これで終われるなら……"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event16()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ちょっと待って" + System.Environment.NewLine +
                        @"なんでまたここにいるの？",
                        @"夢で死んだら かならず目を覚ますのに……！"
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event17()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"それから何度か死ぬことを繰り返したけれど" + System.Environment.NewLine +
                        @"夢から出られることはなかった",
                        @"夢がリアルすぎること" + System.Environment.NewLine +
                        @"夢の主がいないこと",
                        @"死んでも夢から覚めないこと",
                        @"いつもとは違う状況にとまどいつつ" + System.Environment.NewLine +
                        @"次に何をすべきか考えていた"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event18()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"よし まずはこの夢の主を探そう",
                        @"夢を見てる本人に会えば" + System.Environment.NewLine +
                        @"この夢から出る方法がわかるかもしれない",
                        @"途中で出口を見つけられる可能性もあるしね"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"これからプレイヤーの操作が可能になります",
                        @"キャラクターの操作は" + System.Environment.NewLine +
                        @"画面左下のスティックを動かして行ってください",
                        @"本ゲームでは" + System.Environment.NewLine +
                        @"キャラクターを動かす以外の操作はできません",
                        @"調べたいモノがある場合は" + System.Environment.NewLine +
                        @"対象物に近づくだけで調べたことになります",
                        @"また セーブは自動で行われます"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"それじゃあ 夢の主探しの旅へ！",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event19()
        {
            // プロローグ完了を保存
            SaveController02 saveController02 = new SaveController02();
            saveController02.complete_Event02_01_Prologue();

            eventController02.Enemy1.SetWalkRange(100.0f);
            eventController02.Enemy1.SetSpeed(0.7f);
            eventController02.Enemy1.SetReactDistance(20.0f);
            return true;
        }
    }
}