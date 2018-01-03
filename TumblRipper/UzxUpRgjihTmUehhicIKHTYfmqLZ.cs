using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x0200002A RID: 42
public class UzxUpRgjihTmUehhicIKHTYfmqLZ : INotifyPropertyChanged
{
	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600010A RID: 266 RVA: 0x00008D4C File Offset: 0x00006F4C
	// (set) Token: 0x0600010B RID: 267 RVA: 0x00008D60 File Offset: 0x00006F60
	public bool ProxyUse
	{
		get
		{
			return this.bool_2;
		}
		set
		{
			if (value == this.bool_2)
			{
				return;
			}
			this.bool_2 = value;
			this.vmethod_0("ProxyUse");
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600010C RID: 268 RVA: 0x00008D8C File Offset: 0x00006F8C
	// (set) Token: 0x0600010D RID: 269 RVA: 0x00008DA0 File Offset: 0x00006FA0
	public bool StatsUsageAnonymous
	{
		get
		{
			return this.bool_1;
		}
		set
		{
			if (value == this.bool_1)
			{
				return;
			}
			this.bool_1 = value;
			this.vmethod_0("StatsUsageAnonymous");
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600010E RID: 270 RVA: 0x00008DCC File Offset: 0x00006FCC
	// (set) Token: 0x0600010F RID: 271 RVA: 0x00008DE0 File Offset: 0x00006FE0
	public bool ProxyUseAuth
	{
		get
		{
			return this.bool_0;
		}
		set
		{
			if (value == this.bool_0)
			{
				return;
			}
			this.bool_0 = value;
			this.vmethod_0("ProxyUseAuth");
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000110 RID: 272 RVA: 0x00008E0C File Offset: 0x0000700C
	// (set) Token: 0x06000111 RID: 273 RVA: 0x00008E20 File Offset: 0x00007020
	public string DefaultDirectory
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
			this.vmethod_0("DefaultDirectory");
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000112 RID: 274 RVA: 0x00008E50 File Offset: 0x00007050
	// (set) Token: 0x06000113 RID: 275 RVA: 0x00008E64 File Offset: 0x00007064
	public string ProxyUsername
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
			this.vmethod_0("ProxyUsername");
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000114 RID: 276 RVA: 0x00008E94 File Offset: 0x00007094
	// (set) Token: 0x06000115 RID: 277 RVA: 0x00008EA8 File Offset: 0x000070A8
	public string ProxyPassword
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
			this.vmethod_0("ProxyPassword");
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000116 RID: 278 RVA: 0x00008ED8 File Offset: 0x000070D8
	// (set) Token: 0x06000117 RID: 279 RVA: 0x00008EEC File Offset: 0x000070EC
	public string ProxyURL
	{
		get
		{
			return this.string_3;
		}
		set
		{
			if (value == this.string_3)
			{
				return;
			}
			this.string_3 = value;
			this.vmethod_0("ProxyURL");
		}
	}

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x06000118 RID: 280 RVA: 0x00008F1C File Offset: 0x0000711C
	// (remove) Token: 0x06000119 RID: 281 RVA: 0x00008F54 File Offset: 0x00007154
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

	// Token: 0x0600011A RID: 282 RVA: 0x00008F8C File Offset: 0x0000718C
	[GAttribute8]
	protected virtual void vmethod_0([CallerMemberName] string string_4 = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
		if (propertyChangedEventHandler == null)
		{
			return;
		}
		propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_4));
	}

	// Token: 0x0400009B RID: 155
	private string string_0;

	// Token: 0x0400009C RID: 156
	private string string_1;

	// Token: 0x0400009D RID: 157
	private string string_2;

	// Token: 0x0400009E RID: 158
	private string string_3;

	// Token: 0x0400009F RID: 159
	private bool bool_0;

	// Token: 0x040000A0 RID: 160
	private bool bool_1;

	// Token: 0x040000A1 RID: 161
	private bool bool_2;

	// Token: 0x040000A2 RID: 162
	[CompilerGenerated]
	private PropertyChangedEventHandler propertyChangedEventHandler_0;
}
