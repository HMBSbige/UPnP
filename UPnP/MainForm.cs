using System.Net;
using System.Net.Sockets;
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
			var client = new UPnP(IPAddress.Parse(@"192.168.199.212"), 1151, 1551, ProtocolType.Udp, @"UPnP测试");
			client.Add();
			MessageBox.Show(@"Success");
			client.Remove();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{

		}
	}
}
