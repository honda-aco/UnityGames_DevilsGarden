using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event04_16_MeetTeacher : Event_ChangeBgm1
    {
        private EventController04 eventController;
        private SaveController04 saveContoller04 = new SaveController04();

        public Event04_16_MeetTeacher(EventController04 eventController) : base(eventController)
        {
            this.eventController = eventController;
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

        private bool event1()
        {
            return eventController.charaTurnaround(eventController.Teacher, eventController.Player.gameObject);
        }

        private bool event2()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"やあ はじめまして" + System.Environment.NewLine +
                        @"それともまた会ったね……かな？",
                        @"キミは覚えてる？" + System.Environment.NewLine +
                        @"僕らがこれまで何回会ったのか",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_teacher,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"？",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_teacher,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"何のことか分からないか",
                        @"ここは無限につづく地獄の世界なんだよ",
                        @"僕は日記をつける習慣があるから気づいたんだ",
                        @"記憶はないけれど" + System.Environment.NewLine +
                        @"僕らはこの怪物だらけの世界を何度も繰り返してる",
                        @"何度も何度も何度も何度もね",
                        @"きっとこれは罰なんだ" + System.Environment.NewLine +
                        @"生前の罪にたいする罰",
                        @"僕の罪は生徒を守れなかったことだろう",
                        @"キミにも罪の心当たりがあるのなら" + System.Environment.NewLine +
                        @"早く悔いたほうがいい",
                        @"反省が認められれば" + System.Environment.NewLine +
                        @"少しは早く出られるかもしれない"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_teacher,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }
    }
}