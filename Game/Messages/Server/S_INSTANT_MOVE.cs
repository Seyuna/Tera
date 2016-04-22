﻿using System;

namespace Tera.Game.Messages
{
    public class S_INSTANT_MOVE : ParsedMessage
    {
        internal S_INSTANT_MOVE(TeraMessageReader reader) : base(reader)
        {
            Entity = reader.ReadEntityId();
            Finish = reader.ReadVector3f();
            Heading = reader.ReadAngle();
        }

        public EntityId Entity { get; }
        public Vector3f Finish { get; private set; }
        public Angle Heading { get; private set; }
    }
}