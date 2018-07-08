using System;

namespace ChickenAPI.Core.Network.Packets.Attributes
{
    /// <summary>
    /// This attribute is used by <see cref="IPacketFactory"/> to identify nested packets that does not have a header
    /// </summary>
    public class PacketNestedAttribute : Attribute
    {
        
    }
}