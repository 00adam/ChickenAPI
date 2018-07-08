using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.Game.Server.Inventory
{
    [PacketHeader("e_info")]
    public class EInfoPacket : Packet<EInfoPacket>
    {
        [PacketIndex(0)]
        public byte EInfoType { get; set; }
    }
}