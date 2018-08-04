using System.Net.Sockets;

namespace UPnPForwarder.Network
{
    public class PortChecker : IPortChecker
    {
        public bool CheckPort(MappingProtocol protocol, string ipAddress, int port)
        {
            bool tcpPortOpen = true;
            bool udpPortOpen = true;

            if (protocol.HasFlag(MappingProtocol.Tcp))
            {
                using (TcpClient client = new TcpClient())
                {
                    try
                    {
                        client.Connect(ipAddress, port);
                        tcpPortOpen = true;
                    }
                    catch
                    {
                        tcpPortOpen = false;
                    }
                }
            }

            if (protocol.HasFlag(MappingProtocol.Udp))
            {
                using (UdpClient client = new UdpClient())
                {
                    try
                    {
                        client.Connect(ipAddress, port);
                        udpPortOpen = true;
                    }
                    catch
                    {
                        udpPortOpen = false;
                    }
                }
            }

            return udpPortOpen && tcpPortOpen;
        }
    }
}
