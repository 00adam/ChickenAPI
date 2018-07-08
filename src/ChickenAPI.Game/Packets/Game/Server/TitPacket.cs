using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("tit")]
    public class TitPacket : Packet<>
    {
        [PacketIndex(0)]
        public string ClassType { get; set; }

        [PacketIndex(1)]
        public string Name { get; set; }
    }
}