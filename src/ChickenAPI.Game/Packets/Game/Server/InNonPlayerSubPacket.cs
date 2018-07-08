using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.Game.Server
{
    [PacketHeader("in_non_player_subpacket")]
    public class InNonPlayerSubPacket : Packet<InNonPlayerSubPacket>
    {
        #region Properties
        [PacketIndex(0)]
        public short Dialog { get; set; }

        [PacketIndex(1)]
        public byte Unknown { get; set; }

        #endregion
    }
}
