using System;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;

// Token: 0x02000014 RID: 20
internal sealed class Class5 : IDisposable
{
	// Token: 0x0600005D RID: 93 RVA: 0x00006648 File Offset: 0x00004848
	~Class5()
	{
		this.method_1(false);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00006678 File Offset: 0x00004878
	void IDisposable.Dispose()
	{
		this.method_1(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00006694 File Offset: 0x00004894
	public bool method_0()
	{
		try
		{
			if (!this.mutex_0.WaitOne(1000, false))
			{
				return false;
			}
		}
		catch (AbandonedMutexException)
		{
		}
		this.bool_0 = true;
		return true;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000066D8 File Offset: 0x000048D8
	private void method_1(bool bool_2)
	{
		if (bool_2 && !this.bool_1 && this.mutex_0 != null)
		{
			try
			{
				if (this.bool_0)
				{
					this.mutex_0.ReleaseMutex();
				}
				this.mutex_0.Dispose();
			}
			finally
			{
				this.bool_1 = true;
			}
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00006730 File Offset: 0x00004930
	private static Mutex smethod_0()
	{
		MutexAccessRule rule = new MutexAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), MutexRights.FullControl, AccessControlType.Allow);
		MutexSecurity mutexSecurity = new MutexSecurity();
		mutexSecurity.AddAccessRule(rule);
		Mutex mutex = new Mutex(false, "Local\\{3B3E9CC1-3730-4BC9-A156-4537ABB51E27}");
		mutex.SetAccessControl(mutexSecurity);
		return mutex;
	}

	// Token: 0x0400003A RID: 58
	private const string string_0 = "Local\\{3B3E9CC1-3730-4BC9-A156-4537ABB51E27}";

	// Token: 0x0400003B RID: 59
	private readonly Mutex mutex_0 = Class5.smethod_0();

	// Token: 0x0400003C RID: 60
	private bool bool_0;

	// Token: 0x0400003D RID: 61
	private bool bool_1;
}
