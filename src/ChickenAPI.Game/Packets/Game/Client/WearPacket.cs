﻿using ChickenAPI.Core.Network.Packets;
using ChickenAPI.Enums.Game.Items;

namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("wear")]
    public class WearPacket : Packet<>
    {
        [PacketIndex(0)]
        public InventoryType InventoryType { get; set; }

        [PacketIndex(1)]
        public short WearType { get; set; }
    }
}
