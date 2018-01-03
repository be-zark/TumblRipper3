// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.Utils
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace TumblRipper.Common
{
  public class Utils
  {
    public static void OpenFolder(string path)
    {
      if (!Directory.Exists(path))
        return;
      if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        Process.Start(path);
      else
        Process.Start("open", path);
    }

    public static string PathCleaner(string path)
    {
      return string.Join("_", path.Split(Path.GetInvalidFileNameChars()));
    }

    public static IWebProxy GetProxy()
    {
      if (MySettings.Instance.AppSettings.Proxy == null)
      {
        MySettings.Instance.AppSettings.Proxy = (IWebProxy) new WebProxy(MySettings.Instance.AppSettings.ProxyUrl);
        if (MySettings.Instance.AppSettings.ProxyUsername != null)
          MySettings.Instance.AppSettings.Proxy.Credentials = (ICredentials) new NetworkCredential(MySettings.Instance.AppSettings.ProxyUsername, MySettings.Instance.AppSettings.ProxyPassword);
      }
      return MySettings.Instance.AppSettings.Proxy;
    }
  }
}
