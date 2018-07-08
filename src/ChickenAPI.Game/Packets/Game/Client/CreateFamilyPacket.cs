using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("glmk")]
    public class CreateFamilyPacket : Packet<CreateFamilyPacket>
    {
        #region Properties

        [PacketIndex(0)]
        public string Name { get; set; }

        #endregion
    }
}