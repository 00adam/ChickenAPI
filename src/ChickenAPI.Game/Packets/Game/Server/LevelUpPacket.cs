using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("levelup")]
    public class LevelUpPacket : Packet<LevelUpPacket>
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}