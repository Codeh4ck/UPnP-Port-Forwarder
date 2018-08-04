using System;
using System.Drawing;
using System.Windows.Forms;
using UPnPForwarder.Network;

namespace UPnPForwarder.Forms
{
    public partial class FrmMain : Form
    {

        private readonly IPortForwarder _portForwarder;
        private readonly IPortChecker _portChecker;

        private string _publicIp;

        public FrmMain(IPortForwarder portForwarder, IPortChecker portChecker)
        {
            if (portForwarder == null) throw new ArgumentNullException(nameof(portForwarder));
            if (portChecker == null) throw new ArgumentNullException(nameof(portChecker));

            _portForwarder = portForwarder;
            _portChecker = portChecker;

            InitializeComponent();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            linkIp.Text = "Discovering...";
            labelStatus.Text = "Discovering NAT devices...";
            bool found = await _portForwarder.DiscoverDevices();

            labelStatus.Text = found ? "NAT device found. You may open ports now!" : "NAT devices not found!";
            _publicIp = _portForwarder.DiscoverPublicIpAddress();
            linkIp.Text = _publicIp;
        }

        private void cmdAdd_Click(object sender, System.EventArgs e)
        {
            PortMapping mapping = FrmAddPort.GetPortMapping(this);
            if (mapping == null) return;

            foreach (ListViewItem existingItem in listPorts.Items)
            {
                PortMapping addedMapping = (PortMapping)existingItem.Tag;

                if (!addedMapping.Equals(mapping)) continue;

                MessageBox.Show($"Port number {mapping.Port} is already added to the list.", "Port exists!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            ListViewItem item = new ListViewItem(mapping.ToString()) { Tag = mapping };
            listPorts.Items.Add(item);
        }

        private void cmdRemoveSelected_Click(object sender, System.EventArgs e)
        {
            foreach (ListViewItem selectedItem in listPorts.SelectedItems)
                listPorts.Items.Remove(selectedItem);
        }

        private void cmdClear_Click(object sender, System.EventArgs e)
        {
            listPorts.Items.Clear();
        }

        private void cmdForward_Click(object sender, System.EventArgs e)
        {
            if (listPorts.Items.Count == 0)
            {
                MessageBox.Show("You have selected no ports to forward!", "No ports selected!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            foreach (ListViewItem item in listPorts.Items)
            {
                PortMapping portMapping = (PortMapping)item.Tag;

                item.ForeColor =
                    _portForwarder.ForwardPort(portMapping.Protocol, portMapping.Port) ?
                    Color.Green :
                    Color.Red;
            }

            MessageBox.Show(
                "The selected ports have been forwarded through UPnP.\n\nPorts that were forwarded successfully are marked with green color whereas, ports that weren't forwarded are marked red.",
                "Forward successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdCheckPorts_Click(object sender, EventArgs e)
        {
            DialogResult understood = MessageBox.Show("Before you proceed, you must keep in mind that in order to determine if" +
                            " a port is truly open, you need to have a service listening to that port.\n\n" +
                            "If no service is running behind the port, then the checker will report it as " +
                            "closed no matter if it was forwarded correctly or not.\n\nClick \"Yes\" if you understand this to proceed.",
                "Information!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (understood == DialogResult.No) return;

            foreach(ListViewItem item in listPorts.Items)
            {
                PortMapping mapping = (PortMapping) item.Tag;

                if (_portChecker.CheckPort(mapping.Protocol, _publicIp, mapping.Port))
                    item.Text = mapping.ToString() + " - Open";
                else
                    item.Text = mapping.ToString() + " - Closed";
            }
        }

        private void linkIp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(linkIp.Text);
            MessageBox.Show("Your public IP address has been copied to your clipboard!", "Copied to clipboard!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
