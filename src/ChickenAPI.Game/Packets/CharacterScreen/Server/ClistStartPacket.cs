using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.CharacterScreen.Server
{
    [PacketHeader("clist_start")]
    public class ClistStartPacket : Packet<ClistStartPacket>
    {
        #region Properties

        [PacketIndex(0)]
        public byte Type { get; set; }

        #endregion
    }
}