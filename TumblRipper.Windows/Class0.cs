// Decompiled with JetBrains decompiler
// Type: Class0
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;

internal sealed class Class0 : IDisposable
{
  private readonly Mutex mutex_0 = Class0.smethod_0();
  private const string string_0 = "Local\\{3B3E9CC1-3730-4BC9-A156-4537ABB51E27}";
  private bool bool_0;
  private bool bool_1;

  void IDisposable.Dispose()
  {
    this.method_1(true);
    GC.SuppressFinalize((object) this);
  }

  void object.Finalize()
  {
    try
    {
      this.method_1(false);
    }
    finally
    {
      // ISSUE: explicit finalizer call
      // ISSUE: explicit non-virtual call
      __nonvirtual (((object) this).Finalize());
    }
  }

  public bool method_0()
  {
    try
    {
      if (!this.mutex_0.WaitOne(1000, false))
        return false;
    }
    catch (AbandonedMutexException ex)
    {
    }
    this.bool_0 = true;
    return true;
  }

  private void method_1(bool bool_2)
  {
    if (!bool_2 || this.bool_1)
      return;
    if (this.mutex_0 == null)
      return;
    try
    {
      if (this.bool_0)
        this.mutex_0.ReleaseMutex();
      this.mutex_0.Dispose();
    }
    finally
    {
      this.bool_1 = true;
    }
  }

  private static Mutex smethod_0()
  {
    MutexAccessRule rule = new MutexAccessRule((IdentityReference) new SecurityIdentifier(WellKnownSidType.WorldSid, (SecurityIdentifier) null), MutexRights.FullControl, AccessControlType.Allow);
    MutexSecurity mutexSecurity1 = new MutexSecurity();
    mutexSecurity1.AddAccessRule(rule);
    Mutex mutex = new Mutex(false, "Local\\{3B3E9CC1-3730-4BC9-A156-4537ABB51E27}");
    MutexSecurity mutexSecurity2 = mutexSecurity1;
    mutex.SetAccessControl(mutexSecurity2);
    return mutex;
  }
}
