// Decompiled with JetBrains decompiler
// Type: GAttribute27
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute27 : Attribute
{
  [GAttribute1]
  public string String_0 { get; }

  public GAttribute27([GAttribute1] string string_1)
  {
    // ISSUE: reference to a compiler-generated field
    this.string_0 = string_1;
  }
}
