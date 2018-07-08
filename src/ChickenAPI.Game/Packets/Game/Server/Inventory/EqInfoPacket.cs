using ChickenAPI.Core.Network.Packets;
using ChickenAPI.Enums.Game.Items;

namespace ChickenAPI.Packets.Game.Server.Inventory
{

    [PacketHeader("eqinfo")]
    public class EquipmentInfoPacket : Packet<EquipmentInfoPacket>
    {
        #region Properties

        [PacketIndex(0)]
        public byte Type { get; set; } // todo more information

        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2)]
        public long? ShopOwnerId { get; set; }

        #endregion
    }
}