using ChickenAPI.Core.Network.Packets;
using ChickenAPI.Game.Entities.Player;

namespace ChickenAPI.Packets.Game.Server.Inventory
{
    [PacketHeader("gold")]
    public class GoldPacket : Packet<GoldPacket>
    {
        public GoldPacket(IPlayerEntity entity)
        {
            Gold = 0;
        }

        [PacketIndex(0)]
        public long Gold { get; set; }

        [PacketIndex(1)]
        public byte Unknown { get; set; } = 0;
    }
}