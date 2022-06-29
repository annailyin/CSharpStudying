using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingLib
{
    public class TextMaterial : TrainingMaterial
    {
        public const int MaxTextLength = 10000;

        private string _text;

        public TextMaterial(string text)
        {
            Text = text;
        }

        public string Text
        {
            get { return _text; }
            set
            {
                ValidateText(value);
                _text = value;
            }
        }

        private void ValidateText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new Exception("Text shouldn't be null or empty.");
            }

            if (text.Length > MaxTextLength)
            {
                throw new Exception($"Text shouldn't contain more than {MaxTextLength} characters.");
            }
        }
    }
}