using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_08_02_MeetAunt : Event_ChangeBgm1
    {
        private EventController03 eventController03;

        public Event03_08_02_MeetAunt(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(end));
            return eventList;
        }

        public bool event1()
        {
            return eventController03.charaTurnaround(
                eventController03.MeikoAunt,
                eventController03.Player.gameObject);
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"言い忘れてた",
                        @"このあたりの子なら知ってると思うけど" + System.Environment.NewLine +
                        @"最近ぶっそうな事件が起きてるから",
                        @"あまり長居せずに早めに帰るんだよ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko_aunt,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ぶっそうな事件？"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko_aunt,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"知らないのか",
                        @"女の子が顔をはがされた事件" + System.Environment.NewLine +
                        @"ニュースでもやってるだろ？",
                        @"現代の口裂け女だなんて" + System.Environment.NewLine +
                        @"面白おかしく報道されてる",
                        @"それがあったのがこの近くなんだよ",
                        @"犯人はわかりきってるんだから" + System.Environment.NewLine +
                        @"さっさと逮捕すればいいものを",
                        @"本当に警察の無能さには呆れるよ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_meiko_aunt,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }
    }
}