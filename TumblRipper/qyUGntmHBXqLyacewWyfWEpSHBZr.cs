using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000028 RID: 40
public class qyUGntmHBXqLyacewWyfWEpSHBZr : INotifyPropertyChanged
{
	// Token: 0x1700001D RID: 29
	// (get) Token: 0x060000EC RID: 236 RVA: 0x000088A8 File Offset: 0x00006AA8
	// (set) Token: 0x060000ED RID: 237 RVA: 0x000088BC File Offset: 0x00006ABC
	public string StatusText
	{
		get
		{
			return this.string_2;
		}
		set
		{
			if (value == this.string_2)
			{
				return;
			}
			this.string_2 = value;
			this.vmethod_0("StatusText");
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x060000EE RID: 238 RVA: 0x000088EC File Offset: 0x00006AEC
	// (set) Token: 0x060000EF RID: 239 RVA: 0x00008900 File Offset: 0x00006B00
	public string Licence
	{
		get
		{
			return this.string_0;
		}
		set
		{
			if (value == this.string_0)
			{
				return;
			}
			this.string_0 = value;
			this.vmethod_0("Licence");
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x060000F0 RID: 240 RVA: 0x00008930 File Offset: 0x00006B30
	// (set) Token: 0x060000F1 RID: 241 RVA: 0x00008944 File Offset: 0x00006B44
	public string Email
	{
		get
		{
			return this.string_1;
		}
		set
		{
			if (value == this.string_1)
			{
				return;
			}
			this.string_1 = value;
			this.vmethod_0("Email");
		}
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x060000F2 RID: 242 RVA: 0x00008974 File Offset: 0x00006B74
	// (remove) Token: 0x060000F3 RID: 243 RVA: 0x000089B0 File Offset: 0x00006BB0
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

	// Token: 0x060000F4 RID: 244 RVA: 0x000089E8 File Offset: 0x00006BE8
	[GAttribute8]
	protected virtual void vmethod_0([CallerMemberName] string string_3 = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
		if (propertyChangedEventHandler == null)
		{
			return;
		}
		propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_3));
	}

	// Token: 0x0400008F RID: 143
	private string string_0;

	// Token: 0x04000090 RID: 144
	private string string_1;

	// Token: 0x04000091 RID: 145
	private string string_2 = "Please enter your licence information";

	// Token: 0x04000092 RID: 146
	[CompilerGenerated]
	private PropertyChangedEventHandler propertyChangedEventHandler_0;
}
