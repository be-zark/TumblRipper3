// Decompiled with JetBrains decompiler
// Type: TumblRipper.PluginInterface.PluginOptionDropDown
// Assembly: TumblRipper.PluginInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E766857F-E220-474D-9A9B-64EE1BB1D7AF
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.PluginInterface.dll

using System.Collections.Generic;

namespace TumblRipper.PluginInterface
{
  public class PluginOptionDropDown : PluginOption
  {
    public string Value { get; set; }

    public IEnumerable<string> Choices { get; set; }

    public PluginOptionDropDown(string string_2, string string_3, IEnumerable<string> ienumerable_1)
      : base(string_2)
    {
      this.Value = string_3;
      this.Choices = ienumerable_1;
    }
  }
}
