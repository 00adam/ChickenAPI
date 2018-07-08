using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.CharacterScreen.Server
{
    [PacketHeader("OK")]
    public class OkPacket : Packet<OkPacket>
    {
        // packet has no content
    }
}