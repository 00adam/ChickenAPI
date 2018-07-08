using System;
using System.Collections.Generic;
using ChickenAPI.Core.ECS.Components;
using ChickenAPI.Core.ECS.Entities;
using ChickenAPI.Data.TransferObjects.Map;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;
using ChickenAPI.Utils;

namespace ChickenAPI.Game.Entities.Npc
{
    public class NpcEntity : EntityBase
    {
        public NpcEntity(MapNpcDto npc) : base(EntityType.Npc)
        {
            Components = new Dictionary<Type, IComponent>
            {
                { typeof(BattleComponent), new BattleComponent(this) },
                { typeof(VisibilityComponent), new VisibilityComponent(this) },
                { typeof(MovableComponent), new MovableComponent(this)
                {
                    Actual = new Position<short>(npc.MapX, npc.MapY),
                    Destination = new Position<short>(npc.MapX, npc.MapY),
                    DirectionType = npc.Position
                } },
                { typeof(NpcMonsterComponent), new NpcMonsterComponent(this, npc) }
            };
        }

        public override void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}