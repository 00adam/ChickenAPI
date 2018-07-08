namespace ChickenAPI.Core.Network.Packets
{
    public interface IBroadcastable
    {
        #region Packets

        /// <summary>
        /// Broadcast a packet to every entities in the context
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="packet"></param>
        void Broadcast<T>(T packet) where T : IPacket;

        void Broadcast<T>(ISession sender, T packet) where T : IPacket;

        void Broadcast(ISession sender, IPacket packet);

        #endregion
    }
}