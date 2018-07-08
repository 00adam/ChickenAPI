using System;

namespace ChickenAPI.Core.Network.Packets
{
    public abstract class Packet<T> : IPacket
    {
        #region Properties

        public string Header { get; set; }
        public Type PacketType => typeof(T);

        /// <summary>
        /// </summary>
        public string OriginalContent { get; set; }

        #endregion
    }
}