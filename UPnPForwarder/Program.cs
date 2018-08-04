using System;
using System.Windows.Forms;
using UPnPForwarder.Forms;
using UPnPForwarder.Network;

namespace UPnPForwarder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IPortForwarder portForwarder = new PortForwarder();
            IPortChecker portChecker = new PortChecker();

            Application.Run(new FrmMain(portForwarder, portChecker));
        }
    }
}
