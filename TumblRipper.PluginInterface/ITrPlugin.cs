// Decompiled with JetBrains decompiler
// Type: TumblRipper.PluginInterface.ITrPlugin
// Assembly: TumblRipper.PluginInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E766857F-E220-474D-9A9B-64EE1BB1D7AF
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.PluginInterface.dll

using System.Collections.Generic;
using System.Threading;

namespace TumblRipper.PluginInterface
{
  public interface ITrPlugin
  {
    string GetName();

    TrPluginConfiguration GetInfo();

    bool ValidateUrl(IRipper w, string url);

    string GetFriendlyUrlTitle(IRipper w, string url);

    void Init();

    ITrPlugin NewInstance(IRipper w, string config);

    void Start(CancellationToken _cancellationToken);

    string GetConfiguration(Dictionary<string, PluginOption> settings);

    Dictionary<string, PluginOption> GetControlPanel(string settings);
  }
}
