using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.CharacterScreen.Client
{
    [PacketHeader("select", NeedCharacter = false)]
    public class SelectPacket : Packet<SelectPacket>
    {
        [PacketIndex(0)]
        public byte Slot { get; set; }
    }
}