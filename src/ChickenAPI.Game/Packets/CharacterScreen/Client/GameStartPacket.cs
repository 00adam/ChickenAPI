﻿using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.CharacterScreen.Client
{
    [PacketHeader("game_start")]
    public class GameStartPacket : Packet<GameStartPacket>
    {
    }
}