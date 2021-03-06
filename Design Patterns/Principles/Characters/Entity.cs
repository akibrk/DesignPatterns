﻿using Design_Patterns.Principles.Interfaces;

namespace Design_Patterns.Principles.Characters
{
    class Entity : IEntity
    {
        private static long IdSeed = 0;
        public decimal PosX { get; set; }
        public decimal PosY { get; set; }

        public string Id { get;}
        public string Name { get; set; }

        public Entity()
        {
            Id = (++IdSeed).ToString();
            PosX = 0;
            PosY = 0;
        }

        new public string GetType()
        {
            return "Entity";
        }

        new public string ToString()
        {
            return Name;
        }
    }
}
