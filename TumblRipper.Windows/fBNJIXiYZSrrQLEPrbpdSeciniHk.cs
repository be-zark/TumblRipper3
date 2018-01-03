// Decompiled with JetBrains decompiler
// Type: fBNJIXiYZSrrQLEPrbpdSeciniHk
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

internal class fBNJIXiYZSrrQLEPrbpdSeciniHk : INotifyPropertyChanged
{
  private string string_0;
  private string string_1;
  private Visibility visibility_0;
  private Visibility visibility_1;
  private bool bool_0;

  public Visibility ShowButtons
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
      this.vmethod_0("ShowButtons");
    }
  }

  public Visibility ShowProgressBar
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
      this.vmethod_0("ShowProgressBar");
    }
  }

  public bool UpdateEnabled
  {
    get
    {
      return this.bool_0;
    }
    set
    {
      if (value == this.bool_0)
        return;
      this.bool_0 = value;
      this.vmethod_0("UpdateEnabled");
    }
  }

  public string CurrentVersion
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
      this.vmethod_0("CurrentVersion");
    }
  }

  public string LatestVersion
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
      this.vmethod_0("LatestVersion");
    }
  }

  public event PropertyChangedEventHandler PropertyChanged;

  [GAttribute8]
  protected virtual void vmethod_0([CallerMemberName] string string_2 = null)
  {
    // ISSUE: reference to a compiler-generated field
    PropertyChangedEventHandler changedEventHandler = this.propertyChangedEventHandler_0;
    if (changedEventHandler == null)
      return;
    PropertyChangedEventArgs e = new PropertyChangedEventArgs(string_2);
    changedEventHandler((object) this, e);
  }
}
