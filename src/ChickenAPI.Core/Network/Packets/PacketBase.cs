using System;

namespace ChickenAPI.Core.Network.Packets
{
    public abstract class PacketBase : IPacket
    {
        #region Properties

        public string Header { get; set; }
        public Type Type { get; protected set; }

        /// <summary>
        /// </summary>
        public string OriginalContent { get; set; }

        #endregion
    }
}