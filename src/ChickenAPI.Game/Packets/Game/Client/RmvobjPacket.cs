using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("rmvobj")]
    public class RmvobjPacket : Packet<RmvobjPacket>
    {
        [PacketIndex(0)]
        public short Slot { get; set; }
    }
}
