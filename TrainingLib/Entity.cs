using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingLib
{
    public abstract class Entity
    {
        public Entity(Guid guid)
        {
            Guid = guid;
        }

        public Entity() : this(Guid.NewGuid())
        {
        }

        public Guid Guid { get; }
    }
}
