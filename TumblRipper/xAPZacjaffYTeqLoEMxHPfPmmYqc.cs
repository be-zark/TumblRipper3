using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using TumblRipper;

// Token: 0x02000026 RID: 38
public class xAPZacjaffYTeqLoEMxHPfPmmYqc : INotifyPropertyChanged
{
	// Token: 0x14000003 RID: 3
	// (add) Token: 0x060000D3 RID: 211 RVA: 0x00008528 File Offset: 0x00006728
	// (remove) Token: 0x060000D4 RID: 212 RVA: 0x00008560 File Offset: 0x00006760
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

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000D5 RID: 213 RVA: 0x00008598 File Offset: 0x00006798
	// (set) Token: 0x060000D6 RID: 214 RVA: 0x000085AC File Offset: 0x000067AC
	public string URL
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
			this.vmethod_0("URL");
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060000D7 RID: 215 RVA: 0x000085DC File Offset: 0x000067DC
	// (set) Token: 0x060000D8 RID: 216 RVA: 0x000085F0 File Offset: 0x000067F0
	public string Name
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
			this.vmethod_0("Name");
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000D9 RID: 217 RVA: 0x00008620 File Offset: 0x00006820
	// (set) Token: 0x060000DA RID: 218 RVA: 0x00008634 File Offset: 0x00006834
	public string Folder
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
			this.vmethod_0("Folder");
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x060000DB RID: 219 RVA: 0x00008664 File Offset: 0x00006864
	// (set) Token: 0x060000DC RID: 220 RVA: 0x00008678 File Offset: 0x00006878
	public bool Enabled
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
			this.vmethod_0("Enabled");
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060000DD RID: 221 RVA: 0x000086A4 File Offset: 0x000068A4
	// (set) Token: 0x060000DE RID: 222 RVA: 0x000086B8 File Offset: 0x000068B8
	public bool DoVideos
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
			this.vmethod_0("DoVideos");
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060000DF RID: 223 RVA: 0x000086E4 File Offset: 0x000068E4
	// (set) Token: 0x060000E0 RID: 224 RVA: 0x000086F8 File Offset: 0x000068F8
	public bool DoPhotoSets
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
			this.vmethod_0("DoPhotoSets");
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060000E1 RID: 225 RVA: 0x00008724 File Offset: 0x00006924
	// (set) Token: 0x060000E2 RID: 226 RVA: 0x00008738 File Offset: 0x00006938
	public bool RenameFiles
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			if (value == this.bool_3)
			{
				return;
			}
			this.bool_3 = value;
			this.vmethod_0("RenameFiles");
		}
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00008764 File Offset: 0x00006964
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

	// Token: 0x060000E4 RID: 228 RVA: 0x00008788 File Offset: 0x00006988
	public void method_0()
	{
		TumblrWebsite item = new TumblrWebsite
		{
			Enabled = this.Enabled,
			Title = this.Name,
			Url = this.URL
		};
		poaKSmrhkvDnxmxPGEwHlirBIEdQ.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.Websites.Add(item);
	}

	// Token: 0x04000085 RID: 133
	private string string_0;

	// Token: 0x04000086 RID: 134
	private string string_1;

	// Token: 0x04000087 RID: 135
	private string string_2;

	// Token: 0x04000088 RID: 136
	private bool bool_0;

	// Token: 0x04000089 RID: 137
	private bool bool_1;

	// Token: 0x0400008A RID: 138
	private bool bool_2;

	// Token: 0x0400008B RID: 139
	private bool bool_3;

	// Token: 0x0400008C RID: 140
	[CompilerGenerated]
	private PropertyChangedEventHandler propertyChangedEventHandler_0;
}
