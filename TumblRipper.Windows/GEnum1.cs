// Decompiled with JetBrains decompiler
// Type: GEnum1
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System;

[Flags]
public enum GEnum1
{
  Default = 1,
  Itself = Default,
  Members = 2,
  WithMembers = Members | Itself,
}
