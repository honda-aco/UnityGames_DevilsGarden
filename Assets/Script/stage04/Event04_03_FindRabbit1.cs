using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event04_03_FindRabbit1 : Event_ChangeBgm1
    {
        private EventController04 eventController04;
        private SaveController04 saveController04 = new SaveController04();

        public Event04_03_FindRabbit1(EventController04 eventController) : base(eventController)
        {
            this.eventController04 = eventController;
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
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            if (saveController04.completed_Event04_04_FindRabbit2())
            {
                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"足元に何か落ちてる",
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"ぬいぐるみのカラダを手に入れた"
                        },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"これとさっき拾ったアタマをつなげると……"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"ウサギのぬいぐるみを手に入れた"
                        },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"これって夢の主にとっては" + System.Environment.NewLine +
                            @"何か大切なものだったりするのかな？"
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.talk_rabbit,
                        CharaTalkController.Color.white,
                        CharaTalkController.Color.gray,
                        CharaTalkController.Color.gray
                        ));
            }
            else
            {
                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"足元に何か落ちてる",
                        },
                        CharaTalkController.Texture.talk_yucco,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

                charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"ぬいぐるみのカラダを手に入れた"
                        },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));
            };

            return eventController04.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event2()
        {
            // イベント完了を保存
            saveController04.complete_Event04_03_FindRabbit1();

            if (saveController04.completed_Event04_04_FindRabbit2())
            {
                saveController04.save_KeyItem3Status(SaveController.KeyItemStatus.Level_75);
            }
            else
            {
                saveController04.save_KeyItem3Status(SaveController.KeyItemStatus.Level_50);
            }
            eventController04.Update_KeyItem3();
            return true;
        }
    }
}