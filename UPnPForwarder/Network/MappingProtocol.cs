using System;

namespace UPnPForwarder.Network
{
    [Flags]
    public enum MappingProtocol : byte
    {
        Tcp = 1,
        Udp = 2,
        Both = Tcp | Udp
    }
}
