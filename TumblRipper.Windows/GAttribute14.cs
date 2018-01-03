// Decompiled with JetBrains decompiler
// Type: GAttribute14
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
public sealed class GAttribute14 : Attribute
{
  [GAttribute13]
  public GEnum0 GEnum0_0 { get; private set; }

  [GAttribute13]
  public GEnum1 GEnum1_0 { get; private set; }

  public GAttribute14()
    : this(GEnum0.Default, GEnum1.Default)
  {
  }

  public GAttribute14(GEnum0 genum0_1)
    : this(genum0_1, GEnum1.Default)
  {
  }

  public GAttribute14(GEnum1 genum1_1)
    : this(GEnum0.Default, genum1_1)
  {
  }

  public GAttribute14(GEnum0 genum0_1, GEnum1 genum1_1)
  {
    this.GEnum0_0 = genum0_1;
    this.GEnum1_0 = genum1_1;
  }
}
