using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event03_04_03_FindHole : Event_ChangeBgm1
    {
        private EventController03 eventController03;
        private SaveController03 saveController03 = new SaveController03();

        public Event03_04_03_FindHole(EventController03 eventController) : base(eventController)
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
            eventList.Add(new EventController.eventProcess(event5));
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
                        @"さっき言ってた秘密基地って" + System.Environment.NewLine +
                        @"ここのことだよね",
                    },
                    CharaTalkController.Texture.talk_yucco,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            if (saveController03.completed_Event03_04_01_FindHole())
            {
                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"あれは何だろう"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));
            }
            else
            {
                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"今は何も残ってないみたい"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));
            }

            return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            if (saveController03.completed_Event03_04_01_FindHole())
            {
                return eventController03.playerWalk(eventController03.TreasureChest, 5.0f);
            }
            else
            {
                return true;
            }
        }

        private bool event3()
        {
            if (saveController03.completed_Event03_04_01_FindHole())
            {
                eventController03.TreasureChest.SetActive(false);
                return true;
            }
            else
            {
                return true;
            }
        }

        private bool event4()
        {
            if (saveController03.completed_Event03_04_01_FindHole())
            {
                List<CharaTalk> charaTalkList = new List<CharaTalk>();

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"古い宝箱をひろった",
                            @"中には３人の子どもを写した写真が入っている"
                         },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"これは持っていった方がよさそう"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"記念写真を手に入れた"
                        },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                return eventController03.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
            }
            else
            {
                return true;
            }
        }

        private bool event5()
        {
            // イベント完了を保存
            SaveController03 saveController03 = new SaveController03();
            saveController03.complete_Event03_04_03_FindHole();

            if (saveController03.completed_Event03_04_01_FindHole())
            {
                saveController03.save_KeyItem2Status(SaveController.KeyItemStatus.Level_100);
                eventController03.Update_KeyItem2();
            }
            return true;
        }
    }
}