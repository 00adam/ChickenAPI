using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("compl")]
    public class ComplimentPacket : Packet<ComplimentPacket>
    {
        #region Properties

        [PacketIndex(1)]
        public long CharacterId { get; set; }

        #endregion
    }
}