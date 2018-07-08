using System;
using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Core.Network.Handling
{
    public interface IPacketHandler
    {
        PacketHeaderAttribute PacketHeader { get; }
        Action<IPacket, ISession> Method { get; }
        AuthorityType Authority { get; }
        Type PacketType { get; }
        bool NeedCharacter { get; }
    }
}