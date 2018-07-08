using System;
using ChickenAPI.Core.Network.Handling;

namespace ChickenAPI.Core.Network.Packets
{
    public interface IPacketHandlerContainer
    {
        void Register(IPacketHandler handler);

        void Unregister(Type packetType);
        void Unregsiter(string header);

        /// <summary>
        ///     Handle the CharacterScreen packet
        /// </summary>
        /// <param name="handlingInfo"></param>
        void Handle((IPacket, ISession) handlingInfo);
    }
}