using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event05_11_MeetRyotaro : Event_ChangeBgm1
    {
        private EventController05 eventController05;

        public Event05_11_MeetRyotaro(EventController05 eventController) : base(eventController)
        {
            this.eventController05 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(eventController05.lightOff));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(eventController05.lightOn));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(eventController05.lightOff));
            eventList.Add(new EventController.eventProcess(eventController05.lightOn));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(eventController05.lightOff));
            eventList.Add(new EventController.eventProcess(event7));
            eventList.Add(new EventController.eventProcess(eventController05.lightOn));
            eventList.Add(new EventController.eventProcess(end));

            return eventList;
        }

        private bool event2()
        {
            eventController05.MainCamera.gameObject.SetActive(false);
            eventController05.EventCamera4.gameObject.SetActive(true);
            eventController05.Ryotaro.gameObject.SetActive(true);
            return true;
        }

        private bool event3()
        {
            return eventController05.charaWalk(eventController05.Ryotaro, eventController05.Player.gameObject, 30.0f);
        }

        private bool event4()
        {
            return eventController05.playerTurnaround(eventController05.Ryotaro.gameObject);
        }

        private bool event5()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"きみもここから出る方法を探してるの？",
                        @"よかった！ようやく仲間が見つかった",
                        @"駅で待ってたら だれかがくると思ってたんだ"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event6()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"なるほど 夢の世界か……",
                        @"その予想が正しければ" + System.Environment.NewLine +
                        @"夢の主を見つけることが手がかりになると"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"死んでも出られない時点で" + System.Environment.NewLine +
                        @"わたしの知ってる夢と違うから",
                        @"確信を持ってるわけではないけれど"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"いや ほかに手がかりもないし" + System.Environment.NewLine +
                        @"オレもその線で調べてみるよ",
                        @"連絡をとりたい時は紙に書いて" + System.Environment.NewLine +
                        @"待合室に置いておくことにしよう",
                        @"それじゃあ 何かわかったら教えてね"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_ryotaro,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController05.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event7()
        {
            // イベント完了を保存
            SaveController05 saveController05 = new SaveController05();
            saveController05.complete_Event05_11_MeetRyotaro();
            saveController05.save_KeyItem1Status(SaveController.KeyItemStatus.Level_50);
            eventController05.Update_KeyItem1();

            eventController05.MainCamera.gameObject.SetActive(true);
            eventController05.EventCamera4.gameObject.SetActive(false);
            eventController05.Ryotaro.gameObject.SetActive(false);
            return true;
        }
    }
}