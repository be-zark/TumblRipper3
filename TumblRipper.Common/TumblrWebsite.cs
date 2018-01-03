// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.TumblrWebsite
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.Collections.Generic;

namespace TumblRipper.Common
{
  [Serializable]
  public class TumblrWebsite : Website
  {
    public bool DoPhotoSets { get; set; }

    public bool DoVideos { get; set; }

    public bool DoRename { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public List<string> IgnoreExtensions { get; set; }

    public int LastTs { get; set; }

    public TumblrWebsite()
    {
      this.IgnoreExtensions = new List<string>();
    }
  }
}
