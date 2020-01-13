using System.Collections.Generic;

namespace Assets.Script
{
    public class CharaTalk
    {
        private string[] _talkText;
        public string[] TalkText
        {
            get { return _talkText; }
        }

        private CharaTalkController.Texture _leftTexture;
        public CharaTalkController.Texture LeftTexture
        {
            get { return _leftTexture; }
        }

        private CharaTalkController.Texture _rightTexture;
        public CharaTalkController.Texture RightTexture
        {
            get { return _rightTexture; }
        }

        private CharaTalkController.Texture _centerTexture;
        public CharaTalkController.Texture CenterTexture
        {
            get { return _centerTexture; }
        }

        private CharaTalkController.Color _leftColor;
        public CharaTalkController.Color LeftColor
        {
            get { return _leftColor; }
        }

        private CharaTalkController.Color _rightColor;
        public CharaTalkController.Color RightColor
        {
            get { return _rightColor; }
        }

        private CharaTalkController.Color _centerColor;
        public CharaTalkController.Color CenterColor
        {
            get { return _centerColor; }
        }

        public CharaTalk(string[] talkText,
                         CharaTalkController.Texture leftTexture,
                         CharaTalkController.Texture centerTexture,
                         CharaTalkController.Texture rightTexture,
                         CharaTalkController.Color leftColor = CharaTalkController.Color.white,
                         CharaTalkController.Color centerColor = CharaTalkController.Color.white,
                         CharaTalkController.Color rightColor = CharaTalkController.Color.white)
        {
            _talkText = talkText;
            _leftTexture = leftTexture;
            _rightTexture = rightTexture;
            _centerTexture = centerTexture;
            _leftColor = leftColor;
            _rightColor = rightColor;
            _centerColor = centerColor;
        }
    }
}
