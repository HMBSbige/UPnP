using NATUPNPLib;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace UPnP
{
	class UPnP
	{
		public readonly IPAddress InternalIP;
		public readonly int ExternalPort;
		public readonly int InternalPort;
		public readonly ProtocolType Type;
		public readonly string Description;

		private readonly UPnPNAT UPnPnat;

		private IStaticPortMappingCollection Mappings => UPnPnat.StaticPortMappingCollection;
		private string Typestr => Type.ToString().ToUpper();

		public UPnP(IPAddress internalIp, int externalPort, int internalPort, ProtocolType type, string description)
		{
			UPnPnat = new UPnPNAT();

			InternalIP = internalIp;
			ExternalPort = externalPort;
			InternalPort = internalPort;
			Type = type;
			Description = description;
		}

		public void Add()
		{
			if (Mappings == null)
			{
				Debug.WriteLine(@"无法连接到路由器，或者路由器关闭\不支持 UPnP。");
				return;
			}

			//添加之前的ipv4变量（内网IP），内部端口，和外部端口
			Mappings.Add(ExternalPort, Typestr, InternalPort, InternalIP.ToString(), true, Description);
		}

		public void Remove()
		{
			Mappings.Remove(ExternalPort, Typestr);
		}

		public static void Remove(int eport, ProtocolType type)
		{
			var mapping = new UPnPNAT().StaticPortMappingCollection;
			mapping.Remove(eport, type.ToString().ToUpper());
		}
	}
}
