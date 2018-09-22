using NATUPNPLib;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace UPnP
{
	class UPnPClient
	{
		public readonly IPAddress InternalIP;
		public readonly int ExternalPort;
		public readonly int InternalPort;
		public readonly ProtocolType Type;
		public readonly string Description;

		private UPnPNAT UPnPnat;

		private IStaticPortMappingCollection Mappings => UPnPnat.StaticPortMappingCollection;
		private string Typestr => Type.ToString().ToUpper();

		public UPnPClient(IPAddress internalIp, int externalPort, int internalPort, ProtocolType type, string description) : this()
		{
			InternalIP = internalIp;
			ExternalPort = externalPort;
			InternalPort = internalPort;
			Type = type;
			Description = description;
		}

		public UPnPClient()
		{
			UPnPnat = new UPnPNAT();
		}

		public void Add()
		{
			if (Mappings == null)
			{
				Debug.WriteLine(@"无法连接到路由器，或者路由器关闭\不支持 UPnPClient。");
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

		public IEnumerable<MappingInfo> Get()
		{
			UPnPnat = new UPnPNAT();

			var portMappings = new List<MappingInfo>();

			var count = Mappings.Count;
			var enumerator = Mappings.GetEnumerator();
			enumerator.Reset();
			for (int i = 0; i < count; i++)
			{
				IStaticPortMapping mapping = null;
				try
				{
					if (enumerator.MoveNext())
						mapping = (IStaticPortMapping)enumerator.Current;
				}
				catch
				{
					//ignore
				}

				if (mapping != null)
				{
					var info = new MappingInfo
					{
						Description = mapping.Description,
						ExternalIPAddress = mapping.ExternalIPAddress,
						ExternalPort = mapping.ExternalPort,
						InternalClient = mapping.InternalClient,
						InternalPort = mapping.InternalPort,
						Protocol = mapping.Protocol,
					};
					portMappings.Add(info);
				}
			}

			var portMappingInfos = new MappingInfo[portMappings.Count];
			portMappings.CopyTo(portMappingInfos);
			return portMappingInfos;
		}
	}
}
