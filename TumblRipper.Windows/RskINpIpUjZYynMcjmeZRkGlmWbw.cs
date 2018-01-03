// Decompiled with JetBrains decompiler
// Type: RskINpIpUjZYynMcjmeZRkGlmWbw
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System.ComponentModel;
using System.Runtime.CompilerServices;

public class RskINpIpUjZYynMcjmeZRkGlmWbw : INotifyPropertyChanged
{
  private string string_0;
  private string string_1;
  private string string_2;
  private bool bool_0;
  private bool bool_1;
  private string string_3;
  private bool bool_2;

  public bool ProxyUse
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
      this.vmethod_0("ProxyUse");
    }
  }

  public bool StatsUsageAnonymous
  {
    get
    {
      return this.bool_2;
    }
    set
    {
      if (value == this.bool_2)
        return;
      this.bool_2 = value;
      this.vmethod_0("StatsUsageAnonymous");
    }
  }

  public bool ProxyUseAuth
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
      this.vmethod_0("ProxyUseAuth");
    }
  }

  public string DefaultDirectory
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
      this.vmethod_0("DefaultDirectory");
    }
  }

  public string ProxyUsername
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
      this.vmethod_0("ProxyUsername");
    }
  }

  public string ProxyPassword
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
      this.vmethod_0("ProxyPassword");
    }
  }

  public string ProxyURL
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
      this.vmethod_0("ProxyURL");
    }
  }

  public event PropertyChangedEventHandler PropertyChanged;

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
