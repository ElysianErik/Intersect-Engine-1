﻿namespace Intersect.GameObjects.Maps
{
    public partial class ResourceSpawn
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid ResourceId;

        public byte X;

        public byte Y;

        public byte Z;
    }
}
