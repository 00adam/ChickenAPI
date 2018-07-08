using System;
using System.Linq;

namespace ChickenAPI.Core.Network.Packets
{
    /// <summary>
    ///     Game Packets only
    /// </summary>
    public class GamePacketHandler
    {
        public GamePacketHandler(Action<IPacket, IGameSession> handler, Type packetType)
        {
            HandlerMethod = handler;

            PacketType = packetType;
            PacketHeader = PacketType.GetCustomAttributes(typeof(PacketHeaderAttribute), true).FirstOrDefault() as PacketHeaderAttribute;
            Identification = PacketHeader?.Identification;
            Authority = PacketHeader?.Authority ?? AuthorityType.User;
        }


        public Action<IPacket, IGameSession> HandlerMethod { get; }
        public PacketHeaderAttribute PacketHeader { get; set; }
        public AuthorityType Authority { get; }
        public string Identification { get; }
        public Type PacketType { get; }
    }
}