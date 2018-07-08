﻿using ChickenAPI.Core.Network.Packets;
using ChickenAPI.Enums.Game.Character;

namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("gop")]
    public class CharacterOptionPacket : Packet<CharacterOptionPacket>
    {
        [PacketIndex(0)]
        public CharacterOption Option { get; set; }

        [PacketIndex(1)]
        public bool IsActive { get; set; }
    }
}