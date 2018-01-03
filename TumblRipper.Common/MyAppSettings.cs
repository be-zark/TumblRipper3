// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.MyAppSettings
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace TumblRipper.Common
{
  [Serializable]
  public class MyAppSettings
  {
    public string LocalDir { get; set; }

    public string MachineID { get; set; }

    public bool AnonymousUsage { get; set; }

    public bool UseProxy { get; set; }

    [XmlIgnore]
    public IWebProxy Proxy { get; set; }

    public string ProxyUrl { get; set; }

    public string ProxyUsername { get; set; }

    public string ProxyPassword { get; set; }

    public bool ProxyUseAuth { get; set; }

    public MyAppSettings()
    {
      this.LocalDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "TumblRipper");
    }
  }
}
