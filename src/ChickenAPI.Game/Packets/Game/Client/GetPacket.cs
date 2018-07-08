using ChickenAPI.Core.Network.Packets;
using ChickenAPI.Enums.Game.Entity;

namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("get")]
    public class GetPacket : Packet<>
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public short CharacterId { get; set; }

        [PacketIndex(2)]
        public long DropID { get; set; }

        [PacketIndex(3)]
        public byte Unknown2 { get; set; } // seems to be always 0
    }
}
