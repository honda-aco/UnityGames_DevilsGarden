using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    public class CharaTalkController : MonoBehaviour
    {
        [SerializeField]
        private UnityEngine.UI.Image charaTalkLeft;
        [SerializeField]
        private UnityEngine.UI.Image charaTalkCenter;
        [SerializeField]
        private UnityEngine.UI.Image charaTalkRight;

        private Dictionary<Texture, string> textureDic = new Dictionary<Texture, string>();
        private Dictionary<Texture, string> nameDic = new Dictionary<Texture, string>();
        private Dictionary<Color, UnityEngine.Color> colorDic = new Dictionary<Color, UnityEngine.Color>();

        public enum Position
        {
            Left,
            Center,
            Right,
            none    
        }

        public enum Color
        {
            white,
            gray,
        }

        public enum Texture
        {
            talk_child_black,
            talk_child_blue,
            talk_child_green,
            talk_child_red,
            talk_child1,
            talk_child2,
            talk_child3,
            talk_devil,
            talk_enemy,
            talk_frog1,
            talk_frog2,
            talk_girl,
            talk_girl_black,
            talk_meiko,
            talk_meiko_reverse,
            talk_meiko_aunt,
            talk_mother,
            talk_rabbit,
            talk_ryotaro,
            talk_ryotaro_reverse,
            talk_ryotaro_child,
            talk_ryotaro_father,
            talk_stranger,
            talk_teacher,
            talk_woman1,
            talk_woman2,
            talk_woman3,
            talk_yucco,
            talk_yucco_reverse,
            talk_yucco_awayright,
            talk_yucco_close,
            talk_yucco_surprised,
            talk_yucco_swagger,
            talk_yucco_wink,
            talk_yuko,
            //no_change,
            hide
        }

        public CharaTalkController()
        {
            // textureDicの初期化
            textureDic.Add(Texture.talk_child_black,     "talk_child_black");
            textureDic.Add(Texture.talk_child_blue,      "talk_child_blue");
            textureDic.Add(Texture.talk_child_green,     "talk_child_green");
            textureDic.Add(Texture.talk_child_red,       "talk_child_red");
            textureDic.Add(Texture.talk_child1,          "talk_child1");
            textureDic.Add(Texture.talk_child2,          "talk_child2");
            textureDic.Add(Texture.talk_child3,          "talk_child3");
            textureDic.Add(Texture.talk_devil,           "talk_devil");
            textureDic.Add(Texture.talk_enemy,           "talk_enemy");
            textureDic.Add(Texture.talk_frog1,           "talk_frog1");
            textureDic.Add(Texture.talk_frog2,           "talk_frog2");
            textureDic.Add(Texture.talk_girl,            "talk_girl");
            textureDic.Add(Texture.talk_girl_black,      "talk_girl_black");
            textureDic.Add(Texture.talk_meiko,           "talk_meiko");
            textureDic.Add(Texture.talk_meiko_reverse,   "talk_meiko_reverse");
            textureDic.Add(Texture.talk_meiko_aunt,      "talk_meiko_aunt");
            textureDic.Add(Texture.talk_mother,          "talk_mother");
            textureDic.Add(Texture.talk_rabbit,          "talk_rabbit");
            textureDic.Add(Texture.talk_ryotaro,         "talk_ryotaro");
            textureDic.Add(Texture.talk_ryotaro_reverse, "talk_ryotaro_reverse");
            textureDic.Add(Texture.talk_ryotaro_child,   "talk_ryotaro_child");
            textureDic.Add(Texture.talk_ryotaro_father,  "talk_ryotaro_father");
            textureDic.Add(Texture.talk_stranger,        "talk_stranger");
            textureDic.Add(Texture.talk_teacher,         "talk_teacher");
            textureDic.Add(Texture.talk_woman1,          "talk_woman1");
            textureDic.Add(Texture.talk_woman2,          "talk_woman2");
            textureDic.Add(Texture.talk_woman3,          "talk_woman3");
            textureDic.Add(Texture.talk_yucco,           "talk_yucco");
            textureDic.Add(Texture.talk_yucco_reverse,   "talk_yucco_reverse");
            textureDic.Add(Texture.talk_yucco_awayright, "talk_yucco_awayright");
            textureDic.Add(Texture.talk_yucco_close,     "talk_yucco_close");
            textureDic.Add(Texture.talk_yucco_surprised, "talk_yucco_surprised");
            textureDic.Add(Texture.talk_yucco_swagger,   "talk_yucco_swagger");
            textureDic.Add(Texture.talk_yucco_wink,      "talk_yucco_wink");
            textureDic.Add(Texture.talk_yuko,            "talk_yuko");

            // nameDicの初期化
            nameDic.Add(Texture.talk_child_black,     "黒い子ども");
            nameDic.Add(Texture.talk_child_blue,      "青い子ども");
            nameDic.Add(Texture.talk_child_green,     "緑の子ども");
            nameDic.Add(Texture.talk_child_red,       "赤い子ども");
            nameDic.Add(Texture.talk_child1,          "子ども");
            nameDic.Add(Texture.talk_child2,          "子ども");
            nameDic.Add(Texture.talk_child3,          "子ども");
            nameDic.Add(Texture.talk_devil,           "不気味な…");
            nameDic.Add(Texture.talk_enemy,           null);
            nameDic.Add(Texture.talk_frog1,           "カエル");
            nameDic.Add(Texture.talk_frog2,           "カエル");
            nameDic.Add(Texture.talk_girl,            "学生");
            nameDic.Add(Texture.talk_girl_black,      "女の影");
            nameDic.Add(Texture.talk_meiko,           "めい");
            nameDic.Add(Texture.talk_meiko_reverse,   "めい");
            nameDic.Add(Texture.talk_meiko_aunt,      "スナックのママ");
            nameDic.Add(Texture.talk_mother,          "女");
            nameDic.Add(Texture.talk_rabbit,          "ウサギ");
            nameDic.Add(Texture.talk_ryotaro,         "りょうたろう");
            nameDic.Add(Texture.talk_ryotaro_reverse, "りょうたろう");
            nameDic.Add(Texture.talk_ryotaro_child,   "子ども");
            nameDic.Add(Texture.talk_ryotaro_father,  "男");
            nameDic.Add(Texture.talk_stranger,        "狂った女");
            nameDic.Add(Texture.talk_teacher,         "男");
            nameDic.Add(Texture.talk_woman1,          "女");
            nameDic.Add(Texture.talk_woman2,          null);
            nameDic.Add(Texture.talk_woman3,          "女");
            nameDic.Add(Texture.talk_yucco,           "ゆっこ");
            nameDic.Add(Texture.talk_yucco_reverse,   "ゆっこ");
            nameDic.Add(Texture.talk_yucco_awayright, "ゆっこ");
            nameDic.Add(Texture.talk_yucco_close,     "ゆっこ");
            nameDic.Add(Texture.talk_yucco_surprised, "ゆっこ");
            nameDic.Add(Texture.talk_yucco_swagger,   "ゆっこ");
            nameDic.Add(Texture.talk_yucco_wink,      "ゆっこ");
            nameDic.Add(Texture.talk_yuko,            "ゆい子");
            nameDic.Add(Texture.hide,                 null);

            // colorDicの初期化
            colorDic.Add(Color.white, UnityEngine.Color.white);
            colorDic.Add(Color.gray, UnityEngine.Color.gray);
        }

        public string UpdateCharaTalkImage(Position position, Texture texture, Color color)
        {
            UnityEngine.UI.Image image = null;
            if (position == Position.Left)
            {
                image = charaTalkLeft;
            }
            else if (position == Position.Right)
            {
                image = charaTalkRight;
            }
            else
            {
                image = charaTalkCenter;
            }

            if (texture == Texture.hide)
            {
                image.sprite = null;
                image.gameObject.SetActive(false);
            }
            else
            {
                Texture2D texture2d = Resources.Load(textureDic[texture]) as Texture2D;
                image.sprite = Sprite.Create(texture2d, new Rect(0, 0, texture2d.width, texture2d.height), Vector2.zero);
                image.color = colorDic[color];
                image.gameObject.SetActive(true);
            }

            if (color == Color.white)
            {
                return nameDic[texture];
            }
            else
            {
                return null;
            }
        }
    }
}