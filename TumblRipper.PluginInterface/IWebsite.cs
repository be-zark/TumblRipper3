// Decompiled with JetBrains decompiler
// Type: TumblRipper.PluginInterface.IWebsite
// Assembly: TumblRipper.PluginInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E766857F-E220-474D-9A9B-64EE1BB1D7AF
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.PluginInterface.dll

namespace TumblRipper.PluginInterface
{
  public interface IWebsite
  {
    bool Enabled { get; }

    string PluginInName { get; }

    string Title { get; }

    string Url { get; }

    string LocalDir { get; }

    string LocalSettingsDir { get; }

    string HistoryFilePath { get; }

    string PendingFilePath { get; }

    string FailedFilePath { get; }

    string SettingsFilePath { get; }

    string PluginSettingsFilePath { get; }
  }
}
