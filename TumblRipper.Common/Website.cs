// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.Website
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using TumblRipper.PluginInterface;

namespace TumblRipper.Common
{
  [Serializable]
  public class Website : IWebsite, INotifyPropertyChanged
  {
    private string _localDir = string.Empty;
    private bool _enabled;
    private string _title;

    [XmlIgnore]
    public StatusObject Status { get; set; }

    public string Url { get; set; }

    public string Title
    {
      get
      {
        return this._title;
      }
      set
      {
        if (value == this._title)
          return;
        this._title = value;
        this.OnPropertyChanged("Title");
      }
    }

    public bool Enabled
    {
      get
      {
        return this._enabled;
      }
      set
      {
        if (value == this._enabled)
          return;
        this._enabled = value;
        this.OnPropertyChanged("Enabled");
      }
    }

    public string PluginInName { get; set; }

    [XmlIgnore]
    public string LocalDir
    {
      get
      {
        return this._localDir;
      }
      private set
      {
        this._localDir = value;
        if (!Directory.Exists(this.LocalSettingsDir))
          return;
        this.Status.TotalPosts = new int?(MySettings.Instance.LoadHistoryFile(this.HistoryFilePath).Count);
        this.Status.FailedPosts = new int?(MySettings.Instance.LoadHistoryFile(this.FailedFilePath).Count);
        this.Status.PendingPosts = new int?(MySettings.Instance.LoadHistoryFile(this.PendingFilePath).Count);
      }
    }

    [XmlIgnore]
    public string LocalSettingsDir
    {
      get
      {
        return Path.Combine(this.LocalDir, ".tumblripper");
      }
    }

    [XmlIgnore]
    public string HistoryFilePath
    {
      get
      {
        return Path.Combine(this.LocalSettingsDir, "History.txt");
      }
    }

    [XmlIgnore]
    public string PendingFilePath
    {
      get
      {
        return Path.Combine(this.LocalSettingsDir, "Pending.txt");
      }
    }

    [XmlIgnore]
    public string FailedFilePath
    {
      get
      {
        return Path.Combine(this.LocalSettingsDir, "Failed.txt");
      }
    }

    [XmlIgnore]
    public string SettingsFilePath
    {
      get
      {
        return Path.Combine(this.LocalSettingsDir, "Settings.xml");
      }
    }

    [XmlIgnore]
    public string PluginSettingsFilePath
    {
      get
      {
        return Path.Combine(this.LocalSettingsDir, "TRPluginSettings.xml");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public Website()
    {
      this.Status = new StatusObject();
    }

    public void Init(string dir)
    {
      this._localDir = dir;
      if (!Directory.Exists(this.LocalDir))
        Directory.CreateDirectory(this.LocalDir);
      if (!Directory.Exists(this.LocalSettingsDir))
        Directory.CreateDirectory(this.LocalSettingsDir);
      new DirectoryInfo(this.LocalSettingsDir).Attributes |= FileAttributes.Hidden;
    }

    public void CreateAllDirectories()
    {
      if (Directory.Exists(this.LocalDir))
        return;
      Directory.CreateDirectory(this.LocalDir);
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
      // ISSUE: reference to a compiler-generated field
      PropertyChangedEventHandler changedEventHandler = this.PropertyChanged;
      if (changedEventHandler == null)
        return;
      PropertyChangedEventArgs e = new PropertyChangedEventArgs(propertyName);
      changedEventHandler((object) this, e);
    }
  }
}
