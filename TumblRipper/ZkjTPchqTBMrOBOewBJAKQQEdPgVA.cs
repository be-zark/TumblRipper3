using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Controls;

// Token: 0x02000024 RID: 36
internal class ZkjTPchqTBMrOBOewBJAKQQEdPgVA : INotifyPropertyChanged
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x060000A8 RID: 168 RVA: 0x00007DA0 File Offset: 0x00005FA0
	// (set) Token: 0x060000A9 RID: 169 RVA: 0x00007DB4 File Offset: 0x00005FB4
	public UserControl MyUserControl
	{
		get
		{
			return this.userControl_0;
		}
		set
		{
			if (object.Equals(value, this.userControl_0))
			{
				return;
			}
			this.userControl_0 = value;
			this.vmethod_0("MyUserControl");
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x060000AA RID: 170 RVA: 0x00007DE4 File Offset: 0x00005FE4
	// (set) Token: 0x060000AB RID: 171 RVA: 0x00007DF8 File Offset: 0x00005FF8
	public string SerialNumber
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
			this.vmethod_0("SerialNumber");
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x060000AC RID: 172 RVA: 0x00007E28 File Offset: 0x00006028
	// (set) Token: 0x060000AD RID: 173 RVA: 0x00007E3C File Offset: 0x0000603C
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

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x060000AE RID: 174 RVA: 0x00007E6C File Offset: 0x0000606C
	// (set) Token: 0x060000AF RID: 175 RVA: 0x00007E80 File Offset: 0x00006080
	public bool IsRegistered
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
			this.vmethod_0("IsRegistered");
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x060000B0 RID: 176 RVA: 0x00007EAC File Offset: 0x000060AC
	// (set) Token: 0x060000B1 RID: 177 RVA: 0x00007EC0 File Offset: 0x000060C0
	public string CurrentVersion
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
			this.vmethod_0("CurrentVersion");
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060000B2 RID: 178 RVA: 0x00007EF0 File Offset: 0x000060F0
	// (set) Token: 0x060000B3 RID: 179 RVA: 0x00007F04 File Offset: 0x00006104
	public string LatestVersion
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
			this.vmethod_0("LatestVersion");
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x00007F34 File Offset: 0x00006134
	// (set) Token: 0x060000B5 RID: 181 RVA: 0x00007F48 File Offset: 0x00006148
	public bool HasNewVersion
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
			this.vmethod_0("HasNewVersion");
		}
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00007F74 File Offset: 0x00006174
	public ZkjTPchqTBMrOBOewBJAKQQEdPgVA()
	{
		this.CurrentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x060000B7 RID: 183 RVA: 0x00007FA4 File Offset: 0x000061A4
	// (remove) Token: 0x060000B8 RID: 184 RVA: 0x00007FDC File Offset: 0x000061DC
	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
			PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
			propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			if (propertyChangedEventHandler == propertyChangedEventHandler2)
			{
			}
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

	// Token: 0x060000B9 RID: 185 RVA: 0x00008014 File Offset: 0x00006214
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

	// Token: 0x04000072 RID: 114
	private string string_0;

	// Token: 0x04000073 RID: 115
	private string string_1;

	// Token: 0x04000074 RID: 116
	private bool bool_0;

	// Token: 0x04000075 RID: 117
	private string string_2;

	// Token: 0x04000076 RID: 118
	private string string_3;

	// Token: 0x04000077 RID: 119
	private bool bool_1;

	// Token: 0x04000078 RID: 120
	private UserControl userControl_0;

	// Token: 0x04000079 RID: 121
	[CompilerGenerated]
	private PropertyChangedEventHandler propertyChangedEventHandler_0;
}
