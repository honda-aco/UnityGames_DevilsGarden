using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_07_FindSchoolBug : Event_ChangeBgm1
    {
        private EventController03 eventController03;

        public Event03_07_FindSchoolBug(EventController03 eventController) : base(eventController)
        {
            this.eventController03 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(start));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(event4));
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
                        @"ランドセルが落ちてる",
                        @"勝手に開けるのは気が引けるけれど" + System.Environment.NewLine +
                        @"ちょっと失礼してっと",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            eventController03.SchoolBug.SetActive(false);
            return true;
        }

        private bool event3()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"……",
                        @"これは絵日記かな？",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"日記は男の子と２人の女の子の絵で埋まっている"
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"楽しそうな絵",
                        @"ここに置いていたら汚れちゃうし" + System.Environment.NewLine +
                        @"とりあえず預かっておこう"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event4()
        {
            // イベント完了を保存
            SaveController03 saveController03 = new SaveController03();
            saveController03.complete_Event03_07_FindSchoolBug();
            return true;
        }
    }
}