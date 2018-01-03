// Decompiled with JetBrains decompiler
// Type: GAttribute46
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
public sealed class GAttribute46 : Attribute
{
  public GEnum2 GEnum2_0 { get; }

  public GAttribute46(GEnum2 genum2_1)
  {
    // ISSUE: reference to a compiler-generated field
    this.genum2_0 = genum2_1;
  }
}
