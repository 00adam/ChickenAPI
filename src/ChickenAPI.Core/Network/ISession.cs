using System.Collections.Generic;
using System.Net;
using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Core.Network
{
    public interface ISession
    {
        int SessionId { get; }

        IPEndPoint Ip { get; }

        void SendPacket<T>(T packet) where T : IPacket;

        void SendPackets<T>(IEnumerable<T> packets) where T : IPacket;
        void SendPackets(IEnumerable<IPacket> packets);
        void Disconnect();
    }
}