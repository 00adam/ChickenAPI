using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.CharacterScreen.Server
{
    [PacketHeader("clist_end")]
    public class ClistEndPacket : Packet<ClistEndPacket>
    {
        // not filled by any data
    }
}