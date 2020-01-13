using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event02_08_FindCorpses : Event_ChangeBgm1
    {
        private EventController02 eventController02;

        public Event02_08_FindCorpses(EventController02 eventController) : base(eventController)
        {
            this.eventController02 = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(start);
            eventList.Add(event1);
            eventList.Add(event2);
            eventList.Add(end);
            return eventList;
        }

        public bool event1()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"ひどい",
                        @"あの人たちにやられたのかな？"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"犬だよ"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_enemy,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"きゃっ！！！",
                        @"ビックリしたー……"
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_enemy,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"驚かせてごめんね",
                        @"気味の悪い男がさ" + System.Environment.NewLine +
                        @"いや 男かどうかも怪しいやつなんだ",
                        @"とにかく そいつの連れてきた犬に襲われて" + System.Environment.NewLine +
                        @"それでこのざまだよ",
                        @"こんなになってもなぜか生きてて" + System.Environment.NewLine +
                        @"死にたいんだけど死ねない"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_enemy,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"その気味の悪い人って どんな人でした？",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_enemy,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"白い肌にデカい目で真っ赤な唇だったよ",
                        @"悪魔だなんて名乗っていたが" + System.Environment.NewLine +
                        @"たしかに人間離れした見た目だったな",
                        @"あああああ" + System.Environment.NewLine +
                        @"オレはいつまでこのままなんだ",
                        @"いつになったら終わる！？" + System.Environment.NewLine +
                        @"だれかオレを殺してくれ！"
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.talk_enemy,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.white
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"白い肌にデカい目で真っ赤な唇……",
                        @"この人たちも似た姿なのに" + System.Environment.NewLine +
                        @"気づいてないみたい",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Color.white,
                    CharaTalkController.Color.gray,
                    CharaTalkController.Color.gray
                    ));

            return eventController02.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        public bool event2()
        {
            // イベント完了を保存
            SaveController02 saveController02 = new SaveController02();
            saveController02.complete_Event02_08_FindCorpses();
            return true;
        }
    }
}