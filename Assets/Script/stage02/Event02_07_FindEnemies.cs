using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event02_07_FindEnemies : Event_ChangeBgm1
    {
        private EventController02 eventController02;

        public Event02_07_FindEnemies(EventController02 eventController) : base(eventController)
        {
            this.eventController02 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(start);
            eventList.Add(event1);
            eventList.Add(event2);
            eventList.Add(event3);
            eventList.Add(event4);
            eventList.Add(event5);
            eventList.Add(event6);
            eventList.Add(event7);
            eventList.Add(event8);
            eventList.Add(event9);
            eventList.Add(end);
            return eventList;
        }

        public bool event1()
        {
            // 敵がこちらを見る
            return eventController02.charaTurnaround(
                eventController02.Enemy4,
                eventController02.Player.gameObject);
        }

        public bool event2()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"うううううううううううううううううううう"
                    },
                    CharaTalkController.Texture.talk_enemy,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event3()
        {
            // 敵がこちらを見る
            return eventController02.charaTurnaround(
                eventController02.Enemy5,
                eventController02.Player.gameObject);
        }

        public bool event4()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"きいああああああああああああああああああ"
                    },
                    CharaTalkController.Texture.talk_enemy,
                    CharaTalkController.Texture.talk_woman2,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event5()
        {
            // 敵がこちらを見る
            return eventController02.charaTurnaround(
                eventController02.EnemyGirl1,
                eventController02.Player.gameObject);
        }

        public bool event6()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"いいいいいいいいいいいいいいいいいいいい"
                    },
                    CharaTalkController.Texture.talk_enemy,
                    CharaTalkController.Texture.talk_woman2,
                    CharaTalkController.Texture.talk_enemy,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event7()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"うううううううううううううううううううう"  + System.Environment.NewLine +
                        @"きいああああああああああああああああああ"  + System.Environment.NewLine +
                        @"いいいいいいいいいいいいいいいいいいいい",
                    },
                    CharaTalkController.Texture.talk_enemy,
                    CharaTalkController.Texture.talk_woman2,
                    CharaTalkController.Texture.talk_enemy
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"真っ赤な手 なんかやばそう！"
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event8()
        {
            eventController02.Enemy4.SetSpeed(0.7f);
            eventController02.Enemy4.SetAccelSpeed(1.1f);
            eventController02.Enemy4.SetWalkRange(90.0f);

            eventController02.Enemy5.SetSpeed(0.7f);
            eventController02.Enemy5.SetAccelSpeed(1.1f);
            eventController02.Enemy5.SetWalkRange(90.0f);

            eventController02.EnemyGirl1.SetSpeed(0.7f);
            eventController02.EnemyGirl1.SetAccelSpeed(1.1f);
            eventController02.EnemyGirl1.SetWalkRange(60.0f);

            return true;
        }

        public bool event9()
        {
            // イベント完了を保存
            SaveController02 saveController02 = new SaveController02();
            saveController02.complete_Event02_07_FindEnemies();
            return true;
        }
    }
}