using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("in_ownable_subpacket")]
    public class InOwnableSubPacket : Packet<InOwnableSubPacket>
    {
        #region Properties
        [PacketIndex(0)]
        public short? Unknown { get; set; }

        [PacketIndex(1)]
        public long Owner { get; set; }

        #endregion
    }
}
