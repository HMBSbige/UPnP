using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPnP.Properties;
using Timer = System.Threading.Timer;

namespace UPnP
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			Icon = Resources.U;
		}

		private delegate void VoidMethod_Delegate();

		private Timer FlushTimer;
		private const int second = 1000;
		public int interval = 5 * second;

		private void MainForm_Load(object sender, EventArgs e)
		{
			BeginInvoke(new VoidMethod_Delegate(() => { Text += $@"- {Util.GetPublicIP()}"; }));
			textBox1.BeginInvoke(new VoidMethod_Delegate(() => { textBox1.Text = Dns.GetHostName(); }));
			comboBox1.BeginInvoke(new VoidMethod_Delegate(() =>
			{
				var ipv4 = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(i => i.AddressFamily == AddressFamily.InterNetwork).ToList();
				foreach (var ip in ipv4)
				{
					comboBox1.Items.Add(ip);
				}
				comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
			}));
			StartTimer();
		}

		private async void FlushList()
		{
			statusStrip1.Invoke(new VoidMethod_Delegate(() => { StatusLabel.Text = @"正在刷新列表..."; }));
			var mappings = new List<MappingInfo>();
			await Task.Run(() =>
			{
				var upnp = new UPnPClient();
				mappings = upnp.Get().ToList();
			});
			listView1.BeginInvoke(new VoidMethod_Delegate(() =>
			{
				listView1.Items.Clear();
				foreach (var mapping in mappings)
				{
					listView1.Items.Add(new ListViewItem
					{
						Text = mapping.Description,
						SubItems =
							{
									new ListViewItem.ListViewSubItem {Text = mapping.ExternalPort.ToString()},
									new ListViewItem.ListViewSubItem {Text = mapping.Protocol},
									new ListViewItem.ListViewSubItem {Text = mapping.InternalPort.ToString()},
									new ListViewItem.ListViewSubItem {Text = mapping.InternalClient},
									new ListViewItem.ListViewSubItem {Text = mapping.ExternalIPAddress}
							}
					});
				}
			}));
			statusStrip1.Invoke(new VoidMethod_Delegate(() => { StatusLabel.Text = @"列表刷新完成"; }));
		}

		private void StartCore(object state)
		{
			FlushList();
		}

		private void StartTimer()
		{
			FlushTimer?.Dispose();
			FlushTimer = new Timer(StartCore, null, 0, interval);
		}

		private void StopTimer()
		{
			FlushTimer?.Dispose();
		}

		private void RestartTimer()
		{
			StopTimer();
			StartTimer();
		}

		private void EnableControls()
		{
			comboBox1.Enabled = true;
			TCP_checkBox.Enabled = true;
			UDP_checkBox.Enabled = true;
			numericUpDown1.Enabled = true;
			numericUpDown2.Enabled = true;
			textBox1.Enabled = true;
		}

		private void DisableControls()
		{
			comboBox1.Enabled = false;
			TCP_checkBox.Enabled = false;
			UDP_checkBox.Enabled = false;
			numericUpDown1.Enabled = false;
			numericUpDown2.Enabled = false;
			textBox1.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				DisableControls();
				var t = new Task(() =>
				{
					BeginInvoke(new VoidMethod_Delegate(() =>
					{
						var ip = IPAddress.Parse(comboBox1.Text);
						var eport = Convert.ToInt32(numericUpDown1.Value);
						var iport = Convert.ToInt32(numericUpDown2.Value);
						var description = textBox1.Text;
						if (TCP_checkBox.Checked || UDP_checkBox.Checked)
						{
							if (TCP_checkBox.Checked)
							{
								var client = new UPnPClient(ip, eport, iport, ProtocolType.Tcp, description);
								client.Add();
							}

							if (UDP_checkBox.Checked)
							{
								var client = new UPnPClient(ip, eport, iport, ProtocolType.Udp, description);
								client.Add();
							}
						}
					}));
				});
				t.Start();
				t.ContinueWith(task =>
				{
					BeginInvoke(new VoidMethod_Delegate(() =>
					{
						EnableControls();
						RestartTimer();
					}));
				});

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void remove_MenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				var t = new Task(() =>
				{
					StopTimer();
					listView1.BeginInvoke(new VoidMethod_Delegate(() =>
					{
						var items = listView1.SelectedItems;
						for (var i = 0; i < items.Count; ++i)
						{

							var eport = Convert.ToInt32(items[i].SubItems[1].Text);
							ProtocolType type;
							if (items[i].SubItems[2].Text == @"TCP")
							{
								type = ProtocolType.Tcp;
							}
							else if (items[i].SubItems[2].Text == @"UDP")
							{
								type = ProtocolType.Udp;
							}
							else
							{
								throw new Exception();
							}

							UPnPClient.Remove(eport, type);
						}
					}));
				});
				t.Start();
				t.ContinueWith(task =>
				{
					RestartTimer();
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Flush_MenuItem_Click(object sender, EventArgs e)
		{
			RestartTimer();
		}
	}
}
