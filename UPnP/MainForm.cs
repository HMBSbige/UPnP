using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace UPnP
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			var client = new UPnP(IPAddress.Parse(@"192.168.199.212"), 4489, 1551, ProtocolType.Udp, @"UPnP测试");
			client.Add();
			Thread.Sleep(10000);
			client.Remove();
		}
	}
}
