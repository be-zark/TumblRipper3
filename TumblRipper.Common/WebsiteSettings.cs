// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.WebsiteSettings
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;

namespace TumblRipper.Common
{
  [Serializable]
  public class WebsiteSettings
  {
    public string Url { get; set; }

    public string Title { get; set; }

    public bool Enabled { get; set; }

    public string PluginInName { get; set; }
  }
}
