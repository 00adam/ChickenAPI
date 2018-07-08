using System;
using System.Linq;
using ChickenAPI.Core.Network.Handling;

namespace ChickenAPI.Core.Network.Packets
{
    /// <summary>
    ///     Game Packets only
    /// </summary>
    public class GamePacketHandler : IPacketHandler
    {
        public GamePacketHandler(Action<IPacket, ISession> handler, Type packetType)
        {
            Method = handler;
            PacketType = packetType;
            PacketHeader = PacketType.GetCustomAttributes(typeof(PacketHeaderAttribute), true).FirstOrDefault() as PacketHeaderAttribute;
            Identification = PacketHeader?.Identification;
            Authority = PacketHeader?.Authority ?? AuthorityType.User;
        }


        public Action<IPacket, ISession> Method { get; }
        public PacketHeaderAttribute PacketHeader { get; set; }
        public AuthorityType Authority { get; }
        public string Identification { get; }
        public Type PacketType { get; }
        public bool NeedCharacter => true;
    }
}