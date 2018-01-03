using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.WindowsAPICodePack.Dialogs;
using TumblRipper;

// Token: 0x02000013 RID: 19
public class IyPBLLcXPJtYiTgBMkfKVnBzwqCL : Window, IComponentConnector
{
	// Token: 0x06000058 RID: 88 RVA: 0x00006454 File Offset: 0x00004654
	public IyPBLLcXPJtYiTgBMkfKVnBzwqCL()
	{
		this.InitializeComponent();
		this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0 = (base.DataContext as UzxUpRgjihTmUehhicIKHTYfmqLZ);
		MyAppSettings appSettings = MySettings.Instance.AppSettings;
		this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.DefaultDirectory = appSettings.LocalDir;
		this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.ProxyPassword = appSettings.ProxyPassword;
		this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.ProxyURL = appSettings.ProxyUrl;
		this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.ProxyUsername = appSettings.ProxyUsername;
		this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.ProxyUse = appSettings.UseProxy;
		this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.StatsUsageAnonymous = appSettings.AnonymousUsage;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000064F0 File Offset: 0x000046F0
	private void method_0(object sender, RoutedEventArgs e)
	{
		CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
		commonOpenFileDialog.IsFolderPicker = true;
		if (commonOpenFileDialog.ShowDialog() == 1)
		{
			this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.DefaultDirectory = commonOpenFileDialog.FileName;
		}
		base.Topmost = true;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x0000652C File Offset: 0x0000472C
	private void method_1(object sender, RoutedEventArgs e)
	{
		MyAppSettings appSettings = MySettings.Instance.AppSettings;
		appSettings.LocalDir = this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.DefaultDirectory;
		appSettings.AnonymousUsage = this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.StatsUsageAnonymous;
		appSettings.ProxyPassword = this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.ProxyPassword;
		appSettings.ProxyUrl = this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.ProxyURL;
		appSettings.ProxyUsername = this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.ProxyUsername;
		appSettings.UseProxy = this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.ProxyUse;
		appSettings.ProxyUseAuth = this.uzxUpRgjihTmUehhicIKHTYfmqLZ_0.ProxyUseAuth;
		MySettings.Instance.SaveSettings();
		base.Close();
	}

	// Token: 0x0600005B RID: 91 RVA: 0x000065CC File Offset: 0x000047CC
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		Uri resourceLocator = new Uri("/TumblRipper;component/jkfovyncfzoxpegnhkwacydcjwwb.xaml", UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x000065FC File Offset: 0x000047FC
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			((Button)target).Click += this.method_0;
			return;
		}
		if (connectionId == 2)
		{
			((Button)target).Click += this.method_1;
			return;
		}
		this.bool_0 = true;
	}

	// Token: 0x04000038 RID: 56
	private UzxUpRgjihTmUehhicIKHTYfmqLZ uzxUpRgjihTmUehhicIKHTYfmqLZ_0;

	// Token: 0x04000039 RID: 57
	private bool bool_0;
}
