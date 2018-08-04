namespace UPnPForwarder.Network
{
    public class PortMapping
    {
        public int Port { get; set; }
        public MappingProtocol Protocol { get; set; }

        public override string ToString()
        {
            string protocol;

            if (Protocol.HasFlag(MappingProtocol.Tcp) && Protocol.HasFlag(MappingProtocol.Udp))
                protocol = "Both";
            else if (Protocol.HasFlag(MappingProtocol.Tcp))
                protocol = "TCP";
            else
                protocol = "UDP";

            return $"{Port} ({protocol})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetHashCode() != GetHashCode()) return false;
            if (obj.GetType() != typeof(PortMapping)) return false;

            PortMapping other = obj as PortMapping;
            return Equals(other);
        }

        protected bool Equals(PortMapping other)
        {
            return Port == other.Port && Protocol == other.Protocol;
        }

        public override int GetHashCode()
        {
            var hashCode = 17;
            hashCode = hashCode * 9 + Port.GetHashCode();
            hashCode = hashCode * 9 + Protocol.GetHashCode();
            return hashCode;
        }
    }
}
