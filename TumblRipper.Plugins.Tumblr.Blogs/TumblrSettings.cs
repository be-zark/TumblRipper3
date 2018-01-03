// Decompiled with JetBrains decompiler
// Type: TumblRipper.Plugins.Tumblr.Blogs.TumblrSettings
// Assembly: TumblRipper.Plugins.Tumblr.Blogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DB69105-C82A-4CB2-808D-7DC45E27B2D7
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Plugins.Tumblr.Blogs.dll

using System;
using System.Collections.Generic;

namespace TumblRipper.Plugins.Tumblr.Blogs
{
  [Serializable]
  public class TumblrSettings
  {
    public bool DoPhotos { get; set; }

    public bool DoPhotoRaw { get; set; }

    public bool DoPhotoSets { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public bool DoVideos { get; set; }

    public bool DoRename { get; set; }

    public bool DoReblogs { get; set; }

    public bool DoTags { get; set; }

    public string FilenameMask { get; set; }

    public List<string> IgnoreExtensions { get; set; }

    public int LastTs { get; set; }

    public TumblrSettings()
    {
      this.IgnoreExtensions = new List<string>();
      this.DoPhotos = true;
      this.DoReblogs = true;
    }
  }
}
