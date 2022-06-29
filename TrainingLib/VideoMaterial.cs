using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingLib
{
    public class VideoMaterial : TrainingMaterial
    {
        private string _videoURI, _screenURI;
        private VideoFormat _format;

        public VideoMaterial()
        {
        }

        public VideoMaterial(string videoURI, string screenURI, VideoFormat format)
        {
            VideoURI = videoURI;
            ScreenURI = screenURI;
            Format = format;
        }

        public string VideoURI
        {
            get { return _videoURI; }

            set
            {
                ValidateVideoURI(value);
                _videoURI = value;
            }
        }

        public string ScreenURI
        {
            get { return _screenURI; }
            set
            {
                ValidateScreenURI(value);
                _screenURI = value;
            }
        }

        public VideoFormat Format
        {
            get { return _format; }

            set
            {
                _format = value;
            }
        }

        private void ValidateVideoURI(string videoURI)
        {
            if (string.IsNullOrEmpty(videoURI))
            {
                throw new Exception("VideoURI shouldn't be empty!");
            }
        }

        private void ValidateScreenURI(string screenURI)
        {
            if (string.IsNullOrEmpty(screenURI))
            {
                throw new Exception("ScreenURI shouldn't be empty!");
            }
        }
    }
}
