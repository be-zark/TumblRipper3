using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000027 RID: 39
internal class lrtZJolGKLWLWDEjbmnTyeodokHR : INotifyPropertyChanged
{
	// Token: 0x1700001C RID: 28
	// (get) Token: 0x060000E6 RID: 230 RVA: 0x000087D0 File Offset: 0x000069D0
	// (set) Token: 0x060000E7 RID: 231 RVA: 0x000087E4 File Offset: 0x000069E4
	public int Amount
	{
		get
		{
			return this.int_0;
		}
		set
		{
			if (value == this.int_0)
			{
				return;
			}
			this.int_0 = value;
			this.vmethod_0("Amount");
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x060000E8 RID: 232 RVA: 0x00008810 File Offset: 0x00006A10
	// (remove) Token: 0x060000E9 RID: 233 RVA: 0x0000884C File Offset: 0x00006A4C
	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00008884 File Offset: 0x00006A84
	[GAttribute8]
	protected virtual void vmethod_0([CallerMemberName] string string_0 = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
		if (propertyChangedEventHandler == null)
		{
			return;
		}
		propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_0));
	}

	// Token: 0x0400008D RID: 141
	private int int_0;

	// Token: 0x0400008E RID: 142
	[CompilerGenerated]
	private PropertyChangedEventHandler propertyChangedEventHandler_0;
}
