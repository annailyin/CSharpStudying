using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingLib
{
    public class NetworkResourceReference : TrainingMaterial
    {
        private string _contentURI;
        private ReferenceType _referenceType;

        public NetworkResourceReference(string contentURI, ReferenceType referenceType)
        {
            ContentURI = contentURI;
            ReferenceType = referenceType;
        }

        public string ContentURI
        {
            get { return _contentURI; }
            set
            {
                ValidateContentURI(value);
                _contentURI = value;
            }
        }

        public ReferenceType ReferenceType
        {
            get { return _referenceType; }
            set
            {
                _referenceType = value;
            }
        }

        private void ValidateContentURI(string contentURI)
        {
            if (string.IsNullOrEmpty(contentURI))
            {
                throw new Exception("ContentURI shouldn't be empty!");
            }
        }
    }
}
