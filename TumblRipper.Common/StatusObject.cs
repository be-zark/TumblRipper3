// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.StatusObject
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System.ComponentModel;

namespace TumblRipper.Common
{
  public class StatusObject : INotifyPropertyChanged
  {
    private string string_0;
    private int? nullable_0;
    private int? nullable_1;
    private string string_1;
    private int int_0;
    private int? nullable_2;

    public string PreviewImageSource
    {
      get
      {
        return this.string_1;
      }
      set
      {
        if (value == this.string_1)
          return;
        this.string_1 = value;
        this.OnPropertyChanged("PreviewImageSource");
      }
    }

    public int ProgressBar
    {
      get
      {
        return this.int_0;
      }
      set
      {
        if (value == this.int_0)
          return;
        this.int_0 = value;
        this.OnPropertyChanged("ProgressBar");
      }
    }

    public int? TotalPosts
    {
      get
      {
        return this.nullable_2;
      }
      set
      {
        int? nullable1 = value;
        int? nullable2 = this.nullable_2;
        if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue == nullable2.HasValue ? 1 : 0) : 0) != 0)
          return;
        this.nullable_2 = value;
        this.OnPropertyChanged("TotalPosts");
      }
    }

    public int? PendingPosts
    {
      get
      {
        return this.nullable_1;
      }
      set
      {
        int? nullable1 = value;
        int? nullable2 = this.nullable_1;
        if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue == nullable2.HasValue ? 1 : 0) : 0) != 0)
          return;
        this.nullable_1 = value;
        this.OnPropertyChanged("PendingPosts");
      }
    }

    public int? FailedPosts
    {
      get
      {
        return this.nullable_0;
      }
      set
      {
        int? nullable1 = value;
        int? nullable2 = this.nullable_0;
        if ((nullable1.GetValueOrDefault() == nullable2.GetValueOrDefault() ? (nullable1.HasValue == nullable2.HasValue ? 1 : 0) : 0) != 0)
          return;
        this.nullable_0 = value;
        this.OnPropertyChanged("FailedPosts");
      }
    }

    public string DisplayStatus
    {
      get
      {
        return this.string_0;
      }
      set
      {
        if (value == this.string_0)
          return;
        this.string_0 = value;
        this.OnPropertyChanged("DisplayStatus");
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public StatusObject()
    {
      this.DisplayStatus = string.Empty;
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
      // ISSUE: reference to a compiler-generated field
      PropertyChangedEventHandler changedEventHandler = this.propertyChangedEventHandler_0;
      if (changedEventHandler == null)
        return;
      PropertyChangedEventArgs e = new PropertyChangedEventArgs(propertyName);
      changedEventHandler((object) this, e);
    }
  }
}
