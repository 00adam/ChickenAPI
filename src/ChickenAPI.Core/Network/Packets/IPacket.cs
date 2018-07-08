using System;

namespace ChickenAPI.Core.Network.Packets
{
    public interface IPacket
    {
        string Header { get; }
        Type PacketType { get; }

        string OriginalContent { get; set; }
    }
}