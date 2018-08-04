using System.Threading.Tasks;

namespace UPnPForwarder.Network
{
    public interface IPortForwarder
    {
        string DiscoverPublicIpAddress();
        Task<bool> DiscoverDevices();
        bool ForwardPort(MappingProtocol protocol, int port);
    }
}