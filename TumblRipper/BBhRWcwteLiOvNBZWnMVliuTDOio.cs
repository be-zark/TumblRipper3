using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;

// Token: 0x0200002B RID: 43
internal class BBhRWcwteLiOvNBZWnMVliuTDOio : INotifyPropertyChanged
{
	// Token: 0x1700002D RID: 45
	// (get) Token: 0x0600011C RID: 284 RVA: 0x00008FB0 File Offset: 0x000071B0
	// (set) Token: 0x0600011D RID: 285 RVA: 0x00008FC4 File Offset: 0x000071C4
	public Visibility ShowButtons
	{
		get
		{
			return this.visibility_0;
		}
		set
		{
			if (value == this.visibility_0)
			{
				return;
			}
			this.visibility_0 = value;
			this.vmethod_0("ShowButtons");
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x0600011E RID: 286 RVA: 0x00008FF0 File Offset: 0x000071F0
	// (set) Token: 0x0600011F RID: 287 RVA: 0x00009004 File Offset: 0x00007204
	public Visibility ShowProgressBar
	{
		get
		{
			return this.visibility_1;
		}
		set
		{
			if (value == this.visibility_1)
			{
				return;
			}
			this.visibility_1 = value;
			this.vmethod_0("ShowProgressBar");
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000120 RID: 288 RVA: 0x00009030 File Offset: 0x00007230
	// (set) Token: 0x06000121 RID: 289 RVA: 0x00009044 File Offset: 0x00007244
	public bool UpdateEnabled
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
			this.vmethod_0("UpdateEnabled");
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000122 RID: 290 RVA: 0x00009070 File Offset: 0x00007270
	// (set) Token: 0x06000123 RID: 291 RVA: 0x00009084 File Offset: 0x00007284
	public string CurrentVersion
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
			this.vmethod_0("CurrentVersion");
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000124 RID: 292 RVA: 0x000090B4 File Offset: 0x000072B4
	// (set) Token: 0x06000125 RID: 293 RVA: 0x000090C8 File Offset: 0x000072C8
	public string LatestVersion
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
			this.vmethod_0("LatestVersion");
		}
	}

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x06000126 RID: 294 RVA: 0x000090F8 File Offset: 0x000072F8
	// (remove) Token: 0x06000127 RID: 295 RVA: 0x00009130 File Offset: 0x00007330
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

	// Token: 0x06000128 RID: 296 RVA: 0x0000916C File Offset: 0x0000736C
	[GAttribute8]
	protected virtual void vmethod_0([CallerMemberName] string string_2 = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
		if (propertyChangedEventHandler == null)
		{
			return;
		}
		propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_2));
	}

	// Token: 0x040000A3 RID: 163
	private string string_0;

	// Token: 0x040000A4 RID: 164
	private string string_1;

	// Token: 0x040000A5 RID: 165
	private bool bool_0;

	// Token: 0x040000A6 RID: 166
	private Visibility visibility_0;

	// Token: 0x040000A7 RID: 167
	private Visibility visibility_1;

	// Token: 0x040000A8 RID: 168
	[CompilerGenerated]
	private PropertyChangedEventHandler propertyChangedEventHandler_0;
}
