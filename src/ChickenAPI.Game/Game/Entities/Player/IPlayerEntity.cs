using System.Collections.Generic;
using ChickenAPI.Core.ECS.Entities;
using ChickenAPI.Core.Network;
using ChickenAPI.Core.Network.Packets;
using ChickenAPI.Game.Components;
using ChickenAPI.Packets;

namespace ChickenAPI.Game.Entities.Player
{
    public interface IPlayerEntity : IEntity, IMovableEntity, IBattleEntity, IInventoriedEntity, IExperenciedEntity, INamedEntity
    {
        CharacterComponent Character { get; }
        ISession Session { get; }

        long LastPulse { get; }

        void SendPacket<T>(T packetBase) where T : IPacket;
        void SendPackets(IEnumerable<IPacket> packets);
    }
}