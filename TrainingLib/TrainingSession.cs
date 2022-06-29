using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingLib
{
    public class TrainingSession : DescriptableEntity
    {
        private readonly List<TrainingMaterial> _trainingMaterials = new List<TrainingMaterial>();

        public List<TrainingMaterial> TrainingMaterials
        {
            get { return _trainingMaterials; }
        }

        public SessionType GetSessionType()
        {
            return TrainingMaterials.OfType<VideoMaterial>().Any() ? SessionType.VideoLesson : SessionType.TextLesson;
        }
    }
}