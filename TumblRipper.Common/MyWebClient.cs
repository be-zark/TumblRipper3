// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.MyWebClient
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.Net;
using System.Net.Security;

namespace TumblRipper.Common
{
  public class MyWebClient : WebClient
  {
    private HttpWebRequest httpWebRequest_0;

    public CookieContainer cookies { get; set; }

    public CookieCollection ResponseCookies { get; set; }

    public bool AllowAutoRedirect { get; set; }

    public MyWebClient()
    {
      if (MySettings.Instance.AppSettings.UseProxy)
        this.Proxy = Utils.GetProxy();
      this.cookies = new CookieContainer();
    }

    protected override WebRequest GetWebRequest(Uri address)
    {
      this.httpWebRequest_0 = (HttpWebRequest) base.GetWebRequest(address);
      this.httpWebRequest_0.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
      this.httpWebRequest_0.Timeout = 10000;
      this.httpWebRequest_0.AllowAutoRedirect = this.AllowAutoRedirect;
      this.httpWebRequest_0.CookieContainer = this.cookies;
      return (WebRequest) this.httpWebRequest_0;
    }

    protected override WebResponse GetWebResponse(WebRequest request)
    {
      ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback) ((object_0, x509Certificate_0, x509Chain_0, sslPolicyErrors_0) => true);
      HttpWebResponse httpWebResponse = (HttpWebResponse) base.GetWebResponse(request);
      this.ResponseCookies = httpWebResponse.Cookies;
      return (WebResponse) httpWebResponse;
    }

    public HttpStatusCode StatusCode()
    {
      if (this.httpWebRequest_0 == null)
        throw new InvalidOperationException("Unable to retrieve the status code, maybe you haven't made a request yet.");
      HttpWebResponse httpWebResponse = base.GetWebResponse((WebRequest) this.httpWebRequest_0) as HttpWebResponse;
      if (httpWebResponse == null)
        throw new InvalidOperationException("Unable to retrieve the status code, maybe you haven't made a request yet.");
      return httpWebResponse.StatusCode;
    }

    private void method_0(string string_0, string string_1, CookieContainer cookieContainer_1)
    {
      this.cookies = cookieContainer_1;
      this.DownloadFile(string_0, string_1);
    }
  }
}
