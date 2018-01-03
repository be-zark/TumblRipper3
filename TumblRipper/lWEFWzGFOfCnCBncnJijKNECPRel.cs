using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using TumblRipper;
using TumblRipper.Common.lib;

// Token: 0x02000025 RID: 37
public class lWEFWzGFOfCnCBncnJijKNECPRel : INotifyPropertyChanged
{
	// Token: 0x060000BA RID: 186 RVA: 0x00008038 File Offset: 0x00006238
	public void method_0(Website website_1)
	{
		this.website_0 = website_1;
		this.Title = website_1.Title;
		this.Path = website_1.LocalDir;
		this.Url = website_1.Url;
		this.string_4 = MySettings.Instance.LoadPluginSettingsFile(website_1.PluginSettingsFilePath);
		this.Plugin = website_1.PluginInName;
		this.Enabled = website_1.Enabled;
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060000BB RID: 187 RVA: 0x000080A0 File Offset: 0x000062A0
	// (set) Token: 0x060000BC RID: 188 RVA: 0x000080B4 File Offset: 0x000062B4
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

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000BD RID: 189 RVA: 0x000080E0 File Offset: 0x000062E0
	public Visibility PluginSelected
	{
		get
		{
			if (!string.IsNullOrEmpty(this.Plugin))
			{
				return Visibility.Visible;
			}
			return Visibility.Hidden;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060000BE RID: 190 RVA: 0x00008100 File Offset: 0x00006300
	// (set) Token: 0x060000BF RID: 191 RVA: 0x00008114 File Offset: 0x00006314
	public string Title
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
			this.vmethod_0("Title");
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x060000C0 RID: 192 RVA: 0x00008144 File Offset: 0x00006344
	// (set) Token: 0x060000C1 RID: 193 RVA: 0x00008158 File Offset: 0x00006358
	public string Url
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
			this.string_0 = this.method_2(value);
			if (string.IsNullOrEmpty(this.Path))
			{
				this.Path = System.IO.Path.Combine(MySettings.Instance.AppSettings.LocalDir, this.string_0.Replace("www.", "").Replace("/", ""));
			}
			this.vmethod_0("Url");
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x060000C2 RID: 194 RVA: 0x000081D8 File Offset: 0x000063D8
	// (set) Token: 0x060000C3 RID: 195 RVA: 0x000081EC File Offset: 0x000063EC
	public string Path
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
			this.vmethod_0("Path");
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000821C File Offset: 0x0000641C
	// (set) Token: 0x060000C5 RID: 197 RVA: 0x00008230 File Offset: 0x00006430
	public string Plugin
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
			this.vmethod_0("Plugin");
			this.method_1();
			this.vmethod_0("PluginSelected");
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x00008270 File Offset: 0x00006470
	// (set) Token: 0x060000C7 RID: 199 RVA: 0x00008284 File Offset: 0x00006484
	public List<string> AvailablePlugins
	{
		get
		{
			return this.list_0;
		}
		set
		{
			if (object.Equals(value, this.list_0))
			{
				return;
			}
			this.list_0 = value;
			this.vmethod_0("AvailablePlugins");
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x000082B4 File Offset: 0x000064B4
	// (set) Token: 0x060000C9 RID: 201 RVA: 0x000082C8 File Offset: 0x000064C8
	public ITrPlugin LoadedPlugin
	{
		get
		{
			return this.itrPlugin_0;
		}
		set
		{
			if (object.Equals(value, this.itrPlugin_0))
			{
				return;
			}
			this.itrPlugin_0 = value;
			this.vmethod_0("LoadedPlugin");
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000CA RID: 202 RVA: 0x000082F8 File Offset: 0x000064F8
	// (set) Token: 0x060000CB RID: 203 RVA: 0x0000830C File Offset: 0x0000650C
	public UserControl ExtraPanel
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
			this.vmethod_0("ExtraPanel");
		}
	}

	// Token: 0x060000CC RID: 204 RVA: 0x0000833C File Offset: 0x0000653C
	public void method_1()
	{
		this.LoadedPlugin = PluginLoader.GetPlugin(this.Plugin);
		this.ExtraPanel = this.LoadedPlugin.GetControlPanel(this.string_4);
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x060000CD RID: 205 RVA: 0x00008374 File Offset: 0x00006574
	// (remove) Token: 0x060000CE RID: 206 RVA: 0x000083AC File Offset: 0x000065AC
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

	// Token: 0x060000CF RID: 207 RVA: 0x000083E8 File Offset: 0x000065E8
	[GAttribute8]
	protected virtual void vmethod_0([CallerMemberName] string string_5 = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
		if (propertyChangedEventHandler == null)
		{
			return;
		}
		propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_5));
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0000840C File Offset: 0x0000660C
	private string method_2(string string_5)
	{
		string_5 = string_5.Replace("http://", "");
		string_5 = string_5.Replace("https://", "");
		string_5 = string_5.TrimEnd(new char[]
		{
			'/'
		});
		return string_5;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00008454 File Offset: 0x00006654
	public bool method_3()
	{
		if (this.itrPlugin_0 == null)
		{
			return false;
		}
		this.Enabled = true;
		string configuration = this.itrPlugin_0.GetConfiguration();
		Website website = new Website
		{
			Enabled = this.Enabled,
			Url = this.Url,
			PluginInName = this.itrPlugin_0.GetName(),
			Title = this.Title
		};
		website.Init(this.Path);
		MySettings.Instance.SaveWebsite(website);
		MySettings.Instance.SavePluginSettingsFiles(configuration, website.PluginSettingsFilePath);
		if (!MySettings.Instance.WebsiteFilePaths.Contains(website.LocalDir))
		{
			MySettings.Instance.WebsiteFilePaths.Add(website.LocalDir);
			MySettings.Instance.SaveWebsites();
			poaKSmrhkvDnxmxPGEwHlirBIEdQ.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.Websites.Add(website);
		}
		return true;
	}

	// Token: 0x0400007A RID: 122
	private string string_0;

	// Token: 0x0400007B RID: 123
	private string string_1;

	// Token: 0x0400007C RID: 124
	private string string_2;

	// Token: 0x0400007D RID: 125
	private List<string> list_0;

	// Token: 0x0400007E RID: 126
	private ITrPlugin itrPlugin_0;

	// Token: 0x0400007F RID: 127
	private UserControl userControl_0;

	// Token: 0x04000080 RID: 128
	private string string_3;

	// Token: 0x04000081 RID: 129
	private string string_4;

	// Token: 0x04000082 RID: 130
	private bool bool_0;

	// Token: 0x04000083 RID: 131
	private Website website_0;

	// Token: 0x04000084 RID: 132
	[CompilerGenerated]
	private PropertyChangedEventHandler propertyChangedEventHandler_0;
}
