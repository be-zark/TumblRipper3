// Decompiled with JetBrains decompiler
// Type: bBRPkuYmGtxuOzRzcuXMrzPlvYrv
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System.ComponentModel;
using System.Runtime.CompilerServices;

internal class bBRPkuYmGtxuOzRzcuXMrzPlvYrv : INotifyPropertyChanged
{
  private int int_0;

  public int Amount
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
      this.vmethod_0("Amount");
    }
  }

  public event PropertyChangedEventHandler PropertyChanged;

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
