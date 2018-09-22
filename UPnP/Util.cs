using System.Net;
using System.Text.RegularExpressions;

namespace UPnP
{
	public static class Util
	{
		private const string ipv4pattern = "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){1}(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.){2}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
		public static string GetPublicIP()
		{
			using (var webclient = new WebClient())
			{
				var rawRes = webclient.DownloadString(@"http://www.3322.org/dyndns/getip");
				return Regex.Match(rawRes, ipv4pattern).Value;
			}
		}
	}
}
