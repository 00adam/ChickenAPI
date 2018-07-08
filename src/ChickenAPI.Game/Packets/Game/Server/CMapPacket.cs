﻿using System;
using ChickenAPI.Core.Network.Packets;
using ChickenAPI.Game.Maps;

namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("c_map")]
    public class CMapPacket : Packet<CMapPacket>
    {
        public CMapPacket(IMap map)
        {
            Type = 0;
            Id = Convert.ToInt16(map.Id);
            MapType = 1;
        }

        public CMapPacket(byte type, short id, byte mapType)
        {
            Type = type;
            Id = id;
            MapType = mapType;
        }

        #region Properties
        
        [PacketIndex(0)]
        public byte Type { get; set; } // Seems to be always equal to 0

        [PacketIndex(1)]
        public short Id { get; set; }
        
        [PacketIndex(2)]
        public byte MapType { get; set; } // depends on the maptype (1 = base & 0 = instanciated I think)

        #endregion
    }
}