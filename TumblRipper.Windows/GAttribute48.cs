// Decompiled with JetBrains decompiler
// Type: GAttribute48
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class GAttribute48 : Attribute
{
  public GEnum3 GEnum3_0 { get; }

  public GAttribute48(GEnum3 genum3_1)
  {
    // ISSUE: reference to a compiler-generated field
    this.genum3_0 = genum3_1;
  }
}
