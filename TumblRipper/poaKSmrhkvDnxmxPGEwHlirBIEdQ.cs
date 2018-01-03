using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using TumblRipper;

// Token: 0x02000029 RID: 41
public class poaKSmrhkvDnxmxPGEwHlirBIEdQ : INotifyPropertyChanged
{
	// Token: 0x17000020 RID: 32
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x00008A2C File Offset: 0x00006C2C
	// (set) Token: 0x060000F7 RID: 247 RVA: 0x00008A40 File Offset: 0x00006C40
	public Visibility IsButtonStartVisible
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
			this.vmethod_0("IsButtonStartVisible");
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x060000F8 RID: 248 RVA: 0x00008A6C File Offset: 0x00006C6C
	// (set) Token: 0x060000F9 RID: 249 RVA: 0x00008A80 File Offset: 0x00006C80
	public Visibility IsButtonStopVisible
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
			this.vmethod_0("IsButtonStopVisible");
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060000FA RID: 250 RVA: 0x00008AAC File Offset: 0x00006CAC
	// (set) Token: 0x060000FB RID: 251 RVA: 0x00008AC0 File Offset: 0x00006CC0
	public ObservableCollection<Website> Websites { get; set; }

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060000FC RID: 252 RVA: 0x00008AD4 File Offset: 0x00006CD4
	// (set) Token: 0x060000FD RID: 253 RVA: 0x00008AE8 File Offset: 0x00006CE8
	public Visibility BlogDisableButton
	{
		get
		{
			return this.visibility_2;
		}
		set
		{
			if (value == this.visibility_2)
			{
				return;
			}
			this.visibility_2 = value;
			this.vmethod_0("BlogDisableButton");
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x060000FE RID: 254 RVA: 0x00008B14 File Offset: 0x00006D14
	// (set) Token: 0x060000FF RID: 255 RVA: 0x00008B28 File Offset: 0x00006D28
	public Visibility BlogEnableButton
	{
		get
		{
			return this.visibility_3;
		}
		set
		{
			if (value == this.visibility_3)
			{
				return;
			}
			this.visibility_3 = value;
			this.vmethod_0("BlogEnableButton");
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000100 RID: 256 RVA: 0x00008B54 File Offset: 0x00006D54
	// (set) Token: 0x06000101 RID: 257 RVA: 0x00008B68 File Offset: 0x00006D68
	public Website SelectedWebsite
	{
		get
		{
			return this.website_0;
		}
		set
		{
			this.website_0 = value;
			this.method_0();
			this.vmethod_0("SelectedWebsite");
		}
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00008B90 File Offset: 0x00006D90
	public void method_0()
	{
		if (this.website_0 == null)
		{
			return;
		}
		if (!this.website_0.Enabled)
		{
			this.BlogDisableButton = Visibility.Collapsed;
			this.BlogEnableButton = Visibility.Visible;
			return;
		}
		this.BlogDisableButton = Visibility.Visible;
		this.BlogEnableButton = Visibility.Collapsed;
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00008BD0 File Offset: 0x00006DD0
	public void method_1()
	{
		this.IsButtonStartVisible = Visibility.Hidden;
		this.IsButtonStopVisible = Visibility.Hidden;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00008BEC File Offset: 0x00006DEC
	public void method_2()
	{
		this.IsButtonStartVisible = Visibility.Hidden;
		this.IsButtonStopVisible = Visibility.Visible;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00008C08 File Offset: 0x00006E08
	public void method_3()
	{
		this.IsButtonStartVisible = Visibility.Visible;
		this.IsButtonStopVisible = Visibility.Hidden;
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00008C24 File Offset: 0x00006E24
	public poaKSmrhkvDnxmxPGEwHlirBIEdQ()
	{
		poaKSmrhkvDnxmxPGEwHlirBIEdQ.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0 = this;
		this.Websites = new ObservableCollection<Website>();
		foreach (string path in MySettings.Instance.WebsiteFilePaths)
		{
			Website website = MySettings.Instance.LoadWebsite(path);
			if (website != null)
			{
				this.Websites.Add(website);
			}
		}
		this.method_3();
	}

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x06000107 RID: 263 RVA: 0x00008CB0 File Offset: 0x00006EB0
	// (remove) Token: 0x06000108 RID: 264 RVA: 0x00008CEC File Offset: 0x00006EEC
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

	// Token: 0x06000109 RID: 265 RVA: 0x00008D28 File Offset: 0x00006F28
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

	// Token: 0x04000093 RID: 147
	public static poaKSmrhkvDnxmxPGEwHlirBIEdQ poaKSmrhkvDnxmxPGEwHlirBIEdQ_0;

	// Token: 0x04000094 RID: 148
	private Visibility visibility_0;

	// Token: 0x04000095 RID: 149
	private Visibility visibility_1;

	// Token: 0x04000096 RID: 150
	private Website website_0;

	// Token: 0x04000097 RID: 151
	private Visibility visibility_2;

	// Token: 0x04000098 RID: 152
	private Visibility visibility_3;

	// Token: 0x04000099 RID: 153
	[CompilerGenerated]
	private ObservableCollection<Website> observableCollection_0;

	// Token: 0x0400009A RID: 154
	[CompilerGenerated]
	private PropertyChangedEventHandler propertyChangedEventHandler_0;
}
