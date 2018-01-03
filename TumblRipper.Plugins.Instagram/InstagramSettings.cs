// Decompiled with JetBrains decompiler
// Type: TumblRipper.Plugins.Instagram.InstagramSettings
// Assembly: TumblRipper.Plugins.Instagram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 33A2707F-B533-4B14-88E0-4B68F738EE55
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Plugins.Instagram.dll

using System;

namespace TumblRipper.Plugins.Instagram
{
  [Serializable]
  public class InstagramSettings
  {
    public bool doPhotos { get; set; }

    public bool doVideos { get; set; }

    public InstagramSettings()
    {
      this.doPhotos = true;
      this.doVideos = true;
    }
  }
}
