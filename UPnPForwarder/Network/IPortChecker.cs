namespace UPnPForwarder.Network
{
    public interface IPortChecker
    {
        bool CheckPort(MappingProtocol protocol, string ipAddress, int port);
    }
}