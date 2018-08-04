using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Mono.Nat;

namespace UPnPForwarder.Network
{
    public class PortForwarder : IPortForwarder
    {
        private INatDevice _natDevice;

        public PortForwarder()
        {
            NatUtility.DeviceFound += NatUtility_DeviceFound;
            NatUtility.DeviceLost += NatUtility_DeviceLost;
        }

        private void NatUtility_DeviceFound(object sender, DeviceEventArgs e)
        {
            _natDevice = e.Device;
        }

        private void NatUtility_DeviceLost(object sender, DeviceEventArgs e)
        {
            _natDevice = null;
        }

        public string DiscoverPublicIpAddress()
        {
            IPAddress address = _natDevice.GetExternalIP();
            return address.ToString();
        }

        public async Task<bool> DiscoverDevices()
        {
            NatUtility.StartDiscovery();

            int msWaited = 0;

            // We don't want to check more than 10 seconds.
            while (_natDevice == null && msWaited < 10000)
            {
                msWaited += 100;
                await Task.Delay(100);
            }

            return _natDevice != null;
        }

        public bool ForwardPort(MappingProtocol protocol, int port)
        {
            List<Mapping> mappingsToForward = new List<Mapping>(2);

            if (protocol.HasFlag(MappingProtocol.Tcp))
                mappingsToForward.Add(new Mapping(Protocol.Tcp, port, port));

            if (protocol.HasFlag(MappingProtocol.Udp))
                mappingsToForward.Add(new Mapping(Protocol.Udp, port, port));

            try
            {
                foreach (Mapping mapping in mappingsToForward)
                    _natDevice.CreatePortMap(mapping);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
