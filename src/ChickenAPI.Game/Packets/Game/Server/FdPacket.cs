using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.Game.Server
{

    [PacketHeader("fd")]
    public class FdPacket : Packet<>
    {
        #region Properties
        [PacketIndex(0)]
        public long Reput { get; set; }

        [PacketIndex(1)]
        public int ReputIcon { get; set; }

        [PacketIndex(2)]
        public int Dignity { get; set; }

        [PacketIndex(3)]
        public int DignityIcon { get; set; }

        #endregion
    }
}