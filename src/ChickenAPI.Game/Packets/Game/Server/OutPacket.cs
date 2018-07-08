using ChickenAPI.Core.Network.Packets;
using ChickenAPI.Enums.Game.Entity;
using ChickenAPI.Game.Components;
using ChickenAPI.Game.Entities.Player;

namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("out")]
    public class OutPacket : Packet<OutPacket>
    {
        public OutPacket(IPlayerEntity entity)
        {
            Type = VisualType.Character;
            EntityId = entity.GetComponent<CharacterComponent>().Id;
        }

        public VisualType Type { get; set; }

        public long EntityId { get; set; }
    }
}