using System;
using System.Windows.Forms;
using UPnPForwarder.Network;

namespace UPnPForwarder.Forms
{
    public partial class FrmAddPort : Form
    {
        public FrmAddPort()
        {
            InitializeComponent();
        }

        public static PortMapping GetPortMapping(Form parent)
        {
            FrmAddPort addPort = new FrmAddPort();

            if (addPort.ShowDialog(parent) == DialogResult.OK)
            {
                MappingProtocol protocol = MappingProtocol.Tcp;

                if (addPort.rbUdp.Checked)
                    protocol = MappingProtocol.Udp;
                else if (addPort.rbTcpUdp.Checked)
                    protocol = MappingProtocol.Both;

                return new PortMapping()
                {
                    Port = Convert.ToInt32(addPort.numPort.Value),
                    Protocol = protocol
                };
            }

            return null;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
