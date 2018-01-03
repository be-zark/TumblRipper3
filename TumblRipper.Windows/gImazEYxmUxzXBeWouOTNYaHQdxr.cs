// Decompiled with JetBrains decompiler
// Type: gImazEYxmUxzXBeWouOTNYaHQdxr
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using TumblRipper.Common;

public class gImazEYxmUxzXBeWouOTNYaHQdxr : INotifyPropertyChanged
{
  public static gImazEYxmUxzXBeWouOTNYaHQdxr gImazEYxmUxzXBeWouOTNYaHQdxr_0;
  private Visibility visibility_0;
  private Visibility visibility_1;
  private Visibility visibility_2;
  private Visibility visibility_3;
  private Website website_0;

  public Visibility IsButtonStartVisible
  {
    get
    {
      return this.visibility_2;
    }
    set
    {
      if (value == this.visibility_2)
        return;
      this.visibility_2 = value;
      this.vmethod_0("IsButtonStartVisible");
    }
  }

  public Visibility IsButtonStopVisible
  {
    get
    {
      return this.visibility_3;
    }
    set
    {
      if (value == this.visibility_3)
        return;
      this.visibility_3 = value;
      this.vmethod_0("IsButtonStopVisible");
    }
  }

  public ObservableCollection<Website> Websites { get; set; }

  public Visibility BlogDisableButton
  {
    get
    {
      return this.visibility_0;
    }
    set
    {
      if (value == this.visibility_0)
        return;
      this.visibility_0 = value;
      this.vmethod_0("BlogDisableButton");
    }
  }

  public Visibility BlogEnableButton
  {
    get
    {
      return this.visibility_1;
    }
    set
    {
      if (value == this.visibility_1)
        return;
      this.visibility_1 = value;
      this.vmethod_0("BlogEnableButton");
    }
  }

  public Website SelectedWebsite
  {
    get
    {
      return this.website_0;
    }
    set
    {
      this.website_0 = value;
      this.method_0();
      this.vmethod_0("SelectedWebsite");
    }
  }

  public event PropertyChangedEventHandler PropertyChanged;

  public gImazEYxmUxzXBeWouOTNYaHQdxr()
  {
    gImazEYxmUxzXBeWouOTNYaHQdxr.gImazEYxmUxzXBeWouOTNYaHQdxr_0 = this;
    this.Websites = new ObservableCollection<Website>();
    int num1 = 999;
    if (!MySettings.Instance.IsLicensed())
      num1 = 3;
    int num2 = 0;
    foreach (string path in MySettings.Instance.WebsiteFilePaths)
    {
      Website website = MySettings.Instance.LoadWebsite(path);
      if (website != null && num2++ < num1)
        this.Websites.Add(website);
    }
    (CollectionViewSource.GetDefaultView((object) this.Websites) as ICollectionViewLiveShaping).IsLiveSorting = new bool?(true);
    this.method_3();
  }

  public void method_0()
  {
    if (this.website_0 == null)
      return;
    if (this.website_0.Enabled)
    {
      this.BlogDisableButton = Visibility.Visible;
      this.BlogEnableButton = Visibility.Collapsed;
    }
    else
    {
      this.BlogDisableButton = Visibility.Collapsed;
      this.BlogEnableButton = Visibility.Visible;
    }
  }

  public void method_1()
  {
    this.IsButtonStartVisible = Visibility.Hidden;
    this.IsButtonStopVisible = Visibility.Hidden;
  }

  public void method_2()
  {
    this.IsButtonStartVisible = Visibility.Hidden;
    this.IsButtonStopVisible = Visibility.Visible;
  }

  public void method_3()
  {
    this.IsButtonStartVisible = Visibility.Visible;
    this.IsButtonStopVisible = Visibility.Hidden;
  }

  [GAttribute8]
  protected virtual void vmethod_0([CallerMemberName] string string_0 = null)
  {
    // ISSUE: reference to a compiler-generated field
    PropertyChangedEventHandler changedEventHandler = this.propertyChangedEventHandler_0;
    if (changedEventHandler == null)
      return;
    PropertyChangedEventArgs e = new PropertyChangedEventArgs(string_0);
    changedEventHandler((object) this, e);
  }
}
