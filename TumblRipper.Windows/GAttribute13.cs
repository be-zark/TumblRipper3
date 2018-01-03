// Decompiled with JetBrains decompiler
// Type: GAttribute13
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System;

[AttributeUsage(AttributeTargets.All)]
public sealed class GAttribute13 : Attribute
{
  public GEnum0 GEnum0_0 { get; }

  public GEnum1 GEnum1_0 { get; }

  public GAttribute13()
    : this(GEnum0.Default, GEnum1.Default)
  {
  }

  public GAttribute13(GEnum0 genum0_1)
    : this(genum0_1, GEnum1.Default)
  {
  }

  public GAttribute13(GEnum1 genum1_1)
    : this(GEnum0.Default, genum1_1)
  {
  }

  public GAttribute13(GEnum0 genum0_1, GEnum1 genum1_1)
  {
    // ISSUE: reference to a compiler-generated field
    this.genum0_0 = genum0_1;
    // ISSUE: reference to a compiler-generated field
    this.genum1_0 = genum1_1;
  }
}
