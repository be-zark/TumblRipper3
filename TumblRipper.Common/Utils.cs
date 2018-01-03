using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace TumblRipper
{
	// Token: 0x02000014 RID: 20
	public class Utils
	{
		// Token: 0x060000AE RID: 174 RVA: 0x000055F8 File Offset: 0x000037F8
		public static void OpenFolder(string path)
		{
			if (!Directory.Exists(path))
			{
				return;
			}
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				Process.Start("open", path);
				return;
			}
			Process.Start(path);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005630 File Offset: 0x00003830
		public static IWebProxy GetProxy()
		{
			if (MySettings.Instance.AppSettings.Proxy == null)
			{
				MySettings.Instance.AppSettings.Proxy = new WebProxy(MySettings.Instance.AppSettings.ProxyUrl);
				if (MySettings.Instance.AppSettings.ProxyUsername != null)
				{
					MySettings.Instance.AppSettings.Proxy.Credentials = new NetworkCredential(MySettings.Instance.AppSettings.ProxyUsername, MySettings.Instance.AppSettings.ProxyPassword);
				}
			}
			return MySettings.Instance.AppSettings.Proxy;
		}
	}
}
