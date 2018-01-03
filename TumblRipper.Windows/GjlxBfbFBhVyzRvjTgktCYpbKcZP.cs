// Decompiled with JetBrains decompiler
// Type: GjlxBfbFBhVyzRvjTgktCYpbKcZP
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

internal class GjlxBfbFBhVyzRvjTgktCYpbKcZP : INotifyPropertyChanged
{
  private string string_0;
  private string string_1;
  private bool bool_0;
  private bool bool_1;
  private string string_2;
  private UserControl userControl_0;
  private string string_3;

  public UserControl MyUserControl
  {
    get
    {
      return this.userControl_0;
    }
    set
    {
      if (object.Equals((object) value, (object) this.userControl_0))
        return;
      this.userControl_0 = value;
      this.vmethod_0("MyUserControl");
    }
  }

  public string SerialNumber
  {
    get
    {
      return this.string_3;
    }
    set
    {
      if (value == this.string_3)
        return;
      this.string_3 = value;
      this.vmethod_0("SerialNumber");
    }
  }

  public string Email
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
      this.vmethod_0("Email");
    }
  }

  public bool IsRegistered
  {
    get
    {
      return this.bool_1;
    }
    set
    {
      if (value == this.bool_1)
        return;
      this.bool_1 = value;
      this.vmethod_0("IsRegistered");
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
      return this.string_2;
    }
    set
    {
      if (value == this.string_2)
        return;
      this.string_2 = value;
      this.vmethod_0("LatestVersion");
    }
  }

  public bool HasNewVersion
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
      this.vmethod_0("HasNewVersion");
    }
  }

  public event PropertyChangedEventHandler PropertyChanged;

  public GjlxBfbFBhVyzRvjTgktCYpbKcZP()
  {
    this.CurrentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
  }

  [GAttribute8]
  protected virtual void vmethod_0([CallerMemberName] string string_4 = null)
  {
    // ISSUE: reference to a compiler-generated field
    PropertyChangedEventHandler changedEventHandler = this.propertyChangedEventHandler_0;
    if (changedEventHandler == null)
      return;
    PropertyChangedEventArgs e = new PropertyChangedEventArgs(string_4);
    changedEventHandler((object) this, e);
  }
}
