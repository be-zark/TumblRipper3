using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace TumblRipper
{
	// Token: 0x02000012 RID: 18
	public class MyWebClient : WebClient
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00005290 File Offset: 0x00003490
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000052A4 File Offset: 0x000034A4
		public CookieContainer cookies { get; set; }

		// Token: 0x06000099 RID: 153 RVA: 0x000052B8 File Offset: 0x000034B8
		protected override WebRequest GetWebRequest(Uri address)
		{
			this.httpWebRequest_0 = (HttpWebRequest)base.GetWebRequest(address);
			this.httpWebRequest_0.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
			this.httpWebRequest_0.Timeout = 10000;
			this.httpWebRequest_0.AllowAutoRedirect = true;
			if (this.cookies != null)
			{
				this.httpWebRequest_0.CookieContainer = this.cookies;
			}
			return this.httpWebRequest_0;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00005320 File Offset: 0x00003520
		public MyWebClient()
		{
			if (MySettings.Instance.AppSettings.UseProxy)
			{
				base.Proxy = Utils.GetProxy();
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005350 File Offset: 0x00003550
		public HttpStatusCode StatusCode()
		{
			if (this.httpWebRequest_0 == null)
			{
				throw new InvalidOperationException("Unable to retrieve the status code, maybe you haven't made a request yet.");
			}
			HttpWebResponse httpWebResponse = base.GetWebResponse(this.httpWebRequest_0) as HttpWebResponse;
			if (httpWebResponse == null)
			{
				throw new InvalidOperationException("Unable to retrieve the status code, maybe you haven't made a request yet.");
			}
			return httpWebResponse.StatusCode;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005398 File Offset: 0x00003598
		private void method_0(string string_0, string string_1, CookieContainer cookieContainer_1)
		{
			this.cookies = cookieContainer_1;
			base.DownloadFile(string_0, string_1);
		}

		// Token: 0x04000045 RID: 69
		[CompilerGenerated]
		private CookieContainer cookieContainer_0;

		// Token: 0x04000046 RID: 70
		private HttpWebRequest httpWebRequest_0;
	}
}
