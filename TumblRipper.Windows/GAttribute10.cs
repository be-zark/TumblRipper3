﻿// Decompiled with JetBrains decompiler
// Type: GAttribute10
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System;

[AttributeUsage(AttributeTargets.All)]
public sealed class GAttribute10 : Attribute
{
  public bool Boolean_0 { get; }

  public GAttribute10()
    : this(true)
  {
  }

  public GAttribute10(bool bool_1)
  {
    // ISSUE: reference to a compiler-generated field
    this.bool_0 = bool_1;
  }
}
