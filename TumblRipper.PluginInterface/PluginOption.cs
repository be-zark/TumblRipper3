// Decompiled with JetBrains decompiler
// Type: TumblRipper.PluginInterface.PluginOption
// Assembly: TumblRipper.PluginInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E766857F-E220-474D-9A9B-64EE1BB1D7AF
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.PluginInterface.dll

namespace TumblRipper.PluginInterface
{
  public abstract class PluginOption
  {
    public string Label { get; set; }

    protected PluginOption(string string_1)
    {
      this.Label = string_1;
    }
  }
}
