using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;

namespace TumblRipper
{
	// Token: 0x0200000E RID: 14
	public class LicenceValidation
	{
		// Token: 0x0600005E RID: 94 RVA: 0x0000485C File Offset: 0x00002A5C
		public static void PostDebugMessage(string t)
		{
			using (MyWebClient myWebClient = new MyWebClient())
			{
				myWebClient.Encoding = Encoding.UTF8;
				byte[] bytes = myWebClient.UploadValues("http://www.zark.be/software/debug.html?t=TumblRipper", "POST", new NameValueCollection
				{
					{
						"settings",
						t
					}
				});
				Encoding.UTF8.GetString(bytes);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000048C8 File Offset: 0x00002AC8
		public static void UpdateVisitWebsite(string version)
		{
			Process.Start("http://www.zark.be/software/TumblRipper.html");
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000048E0 File Offset: 0x00002AE0
		public static string CheckForUpdate()
		{
			return new MyWebClient
			{
				Encoding = Encoding.UTF8
			}.DownloadString(new Uri("http://www.zark.be/software/getFile.html?file=TumblRipperUpdate.txt")).Trim();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004914 File Offset: 0x00002B14
		public static bool ValidLicence(string e, string s)
		{
			bool result = false;
			try
			{
				string[] array = new MyWebClient
				{
					Encoding = Encoding.UTF8
				}.DownloadString(new Uri(string.Format("http://www.zark.be/software/backend.html?p=TumblRipper&e={0}&s={1}", e, s))).Split(new char[]
				{
					';'
				});
				bool flag = false;
				for (int i = 0; i < 3; i++)
				{
					double num = (double)long.Parse(array[i]) / 5479.0;
					flag = (Math.Floor(num) == num);
				}
				if (flag)
				{
					MySettings.Instance.Licence = new MyLicence(s, e);
					result = true;
				}
				else
				{
					MySettings.Instance.Licence = null;
				}
				MySettings.Instance.SetLicence(MySettings.Instance.Licence);
			}
			catch (Exception)
			{
			}
			return result;
		}
	}
}
