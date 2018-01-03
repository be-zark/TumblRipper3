// Decompiled with JetBrains decompiler
// Type: TumblRipper.Plugins.Instagram.Tags.InstagramSettings
// Assembly: TumblRipper.Plugins.Instagram.Tags, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D4F8FF57-A2A7-4211-89CA-7281C1691C10
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Plugins.Instagram.Tags.dll

using System;

namespace TumblRipper.Plugins.Instagram.Tags
{
  [Serializable]
  public class InstagramSettings
  {
    public bool doPhotos { get; set; }

    public bool doVideos { get; set; }

    public string Tag { get; set; }

    public int LimitItems { get; set; }

    public InstagramSettings()
    {
      this.doPhotos = true;
      this.doVideos = true;
      this.Tag = string.Empty;
      this.LimitItems = 1000;
    }
  }
}
