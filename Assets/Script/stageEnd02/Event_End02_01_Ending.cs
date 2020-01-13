using System.Collections.Generic;
using System.Reflection;

namespace Assets.Script
{
    public class Event_End02_01_Ending
    {
        private EventController_End02 eventController;

        public Event_End02_01_Ending(EventController_End02 eventController)
        {
            this.eventController = eventController;
        }

        public List<EventController.eventProcess> GetEventList()
        {
            List<EventController.eventProcess> eventList = new List<EventController.eventProcess>();
            eventList.Add(new EventController.eventProcess(eventController.playEvent4Bgm_Begin));
            eventList.Add(new EventController.eventProcess(event1));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(event2));
            eventList.Add(new EventController.eventProcess(event3));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event4));
            eventList.Add(new EventController.eventProcess(event5));
            eventList.Add(new EventController.eventProcess(eventController.stopBgm));
            eventList.Add(new EventController.eventProcess(event6));
            eventList.Add(new EventController.eventProcess(eventController.lightOn));
            eventList.Add(new EventController.eventProcess(eventController.playEvent2Bgm_Begin));
            eventList.Add(new EventController.eventProcess(event8));
            eventList.Add(new EventController.eventProcess(event9));
            eventList.Add(new EventController.eventProcess(eventController.lightOff));
            eventList.Add(new EventController.eventProcess(event10));
            eventList.Add(new EventController.eventProcess(event11));
            return eventList;
        }

        private bool event1()
        {
            Charactor.Pause();
            eventController.Player.Idle();
            return true;
        }

        private bool event2()
        {
            eventController.Handinknife.Move(eventController.Player.transform.position, 1.0f, 0.1f);
            return eventController.EventCamera1.Zoom(3.0f, 0.02f);
        }

        private bool event3()
        {
            eventController.Blackout.color = new UnityEngine.Color(0.75f, 0.0f, 0.0f, 0.0f);
            return eventController.EventCamera1.Zoom(3.0f, 0.02f);
        }

        private bool event4()
        {
            eventController.Handinknife.SetActive(false);
            return true;
        }

        private bool event5()
        {
            List<CharaTalk> charaTalkList= new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"きゃあああああ！！！！！",
                    },
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event6()
        {
            eventController.Player.transform.position = eventController.MovePoint1.transform.position;
            eventController.Player.transform.rotation = eventController.MovePoint1.transform.rotation;
            eventController.Player.Sit();
            eventController.EventCamera1.gameObject.SetActive(false);
            eventController.EventCamera2.gameObject.SetActive(true);
            UnityEngine.RenderSettings.skybox = eventController.Skybox;
            return true;
        }

        private bool event8()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"あれ？ここは？",
                        @"……",
                    },
                    CharaTalkController.Texture.talk_yucco_surprised,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            charaTalkList.Add(
                new CharaTalk(
                    new string[]
                    {
                        @"そうだ わたし",
                        @"お世話になった先生に会いに行くため" + System.Environment.NewLine +
                        @"電車に乗ってて……",
                        @"それで寝ちゃったのか",
                        @"夢から出られたみたい" + System.Environment.NewLine +
                        @"でもどうして？",
                        @"たしか最後にうしろから刺されて",
                        @"あれが夢の主で追い出されたってこと？",
                        @"夢の主が目を覚ました可能性もあるか……",
                        @"……",
                        @"考えたところでわからないことばかりだ",
                        @"出られたことだし 深く考えるのはやめよう",
                        @"ただなんとなく 本当になんとなく",
                        @"あの夢はわたしにとって大切なもののような" + System.Environment.NewLine +
                        @"出てはいけなかったような そんな気がする"
                    },
                    CharaTalkController.Texture.talk_yucco_awayright,
                    CharaTalkController.Texture.hide,
                    CharaTalkController.Texture.hide
                    ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event9()
        {
            eventController.Blackout.color = new UnityEngine.Color(0.0f, 0.0f, 0.0f, 0.0f);
            return true;
        }

        private bool event10()
        {
            List<CharaTalk> charaTalkList = new List<CharaTalk>();

            charaTalkList.Add(
                    new CharaTalk(
                        new string[]
                        {
                            @"THE END"
                        },
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide,
                        CharaTalkController.Texture.hide
                        ));

            return eventController.FukidashiController.ShowFukidashi(this.GetType().Name + MethodBase.GetCurrentMethod().Name, charaTalkList);
        }

        private bool event11()
        {
            if (new SaveController00().completed_PlayButton() == false)
            {
                SaveController_End02 saveController_End02 = new SaveController_End02();
                saveController_End02.complete_Event_End02_01_Ending();

                SaveController00 saveController00 = new SaveController00();
                saveController00.deleteAllKeys();
                saveController00.save_Scene(SaveController.SceneNo.Scene01, SaveController.PlaceNo.None);
            }
            eventController.loadScene(@"stage00");
            return true;
        }
    }
}