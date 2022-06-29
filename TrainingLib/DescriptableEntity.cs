using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingLib
{
    public abstract class DescriptableEntity : Entity
    {
        public const int MaxDescriptionLength = 256;

        private string _description;

        public DescriptableEntity(string description = null)
        {
            Description = description;
        }

        public string Description
        {
            get { return _description; }
            set
            {
                ValidateDescription(value);
                _description = value;
            }
        }

        private static void ValidateDescription(string description)
        {
            if (description != null && description.Length > MaxDescriptionLength)
            {
                string message = string.Format("Description shouldn't contain more than {0} characters!", MaxDescriptionLength);
                throw new Exception(message);
            }
        }

        public override string ToString()
        {
            return $"Description = {Description}";
        }
    }
}
