using ChickenAPI.Core.Network.Packets;

namespace ChickenAPI.Packets.Game.Client
{
    [PacketHeader("say")]
    public class ClientSayPacket : PacketBase
    {

        [PacketIndex(0, SerializeToEnd = true)]
        public string Message { get; set; }
    }
}