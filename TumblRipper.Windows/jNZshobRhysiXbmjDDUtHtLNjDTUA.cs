// Decompiled with JetBrains decompiler
// Type: jNZshobRhysiXbmjDDUtHtLNjDTUA
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System.ComponentModel;
using System.Runtime.CompilerServices;

public class jNZshobRhysiXbmjDDUtHtLNjDTUA : INotifyPropertyChanged
{
  private string string_2 = "Please enter your licence information";
  private string string_0;
  private string string_1;

  public string StatusText
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
      this.vmethod_0("StatusText");
    }
  }

  public string Licence
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
      this.vmethod_0("Licence");
    }
  }

  public string Email
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
      this.vmethod_0("Email");
    }
  }

  public event PropertyChangedEventHandler PropertyChanged;

  [GAttribute8]
  protected virtual void vmethod_0([CallerMemberName] string string_3 = null)
  {
    // ISSUE: reference to a compiler-generated field
    PropertyChangedEventHandler changedEventHandler = this.propertyChangedEventHandler_0;
    if (changedEventHandler == null)
      return;
    PropertyChangedEventArgs e = new PropertyChangedEventArgs(string_3);
    changedEventHandler((object) this, e);
  }
}
