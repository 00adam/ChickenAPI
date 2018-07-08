using System;
using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.CharacterScreen.Client
{
    [PacketHeader("Char_DEL", false)]
    public class CharacterDeletePacket : Packet<CharacterDeletePacket>
    {
        [PacketIndex(0)]
        public byte Slot { get; set; }

        [PacketIndex(1)]
        public string Password { get; set; }
    }
}