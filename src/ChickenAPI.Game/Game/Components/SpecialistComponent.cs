﻿using ChickenAPI.Core.ECS.Components;
using ChickenAPI.Core.ECS.Entities;

namespace ChickenAPI.Game.Components
{
    public class SpecialistComponent : IComponent
    {
        public SpecialistComponent(IEntity entity) => Entity = entity;

        public byte Upgrade { get; set; }

        public byte Level { get; set; }

        public byte Design { get; set; }

        public IEntity Entity { get; set; }
    }
}