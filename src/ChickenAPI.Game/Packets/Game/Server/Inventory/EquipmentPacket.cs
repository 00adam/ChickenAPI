using System.Collections.Generic;
using ChickenAPI.Core.Network.Packets;
using ChickenAPI.Game.Entities.Player;

namespace ChickenAPI.Packets.Game.Server.Inventory
{
    [PacketHeader("equip")]
    public class EquipmentPacket : Packet<EquipmentPacket>
    {
        public EquipmentPacket(IPlayerEntity playerEntity)
        {
            EqRare = new EqRareInfo(playerEntity.Inventory);
            EqList = new List<EquipmentInfoPacket>();
        }

        [PacketIndex(0)]
        public EqRareInfo EqRare { get; set; }

        [PacketIndex(1, SeparatorNestedElements = " ")]
        public List<EquipmentInfoPacket> EqList { get; set; }
    }
}