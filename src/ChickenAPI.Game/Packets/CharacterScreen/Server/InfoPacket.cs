using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.CharacterScreen.Server
{
    [PacketHeader("info")]
    public class InfoPacket : Packet<InfoPacket>
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}