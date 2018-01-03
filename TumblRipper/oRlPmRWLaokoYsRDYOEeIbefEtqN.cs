using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using MaterialDesignThemes.Wpf;
using Microsoft.WindowsAPICodePack.Dialogs;
using TumblRipper;
using TumblRipper.Common.lib;

// Token: 0x02000018 RID: 24
public class oRlPmRWLaokoYsRDYOEeIbefEtqN : Window, IComponentConnector
{
	// Token: 0x0600006D RID: 109 RVA: 0x00006BDC File Offset: 0x00004DDC
	public oRlPmRWLaokoYsRDYOEeIbefEtqN() : this(new Website())
	{
		string text = Clipboard.GetText();
		if (text.Contains("http"))
		{
			this.lWEFWzGFOfCnCBncnJijKNECPRel_0.Url = text;
		}
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00006C14 File Offset: 0x00004E14
	public oRlPmRWLaokoYsRDYOEeIbefEtqN(Website website_0)
	{
		this.InitializeComponent();
		this.lWEFWzGFOfCnCBncnJijKNECPRel_0 = (base.DataContext as lWEFWzGFOfCnCBncnJijKNECPRel);
		this.lWEFWzGFOfCnCBncnJijKNECPRel_0.method_0(website_0);
		this.comboBox_0.ItemsSource = PluginLoader.GetListPlugins();
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00006C5C File Offset: 0x00004E5C
	private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		int count = e.AddedItems.Count;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00006C78 File Offset: 0x00004E78
	private void method_0(object sender, RoutedEventArgs e)
	{
		if (this.lWEFWzGFOfCnCBncnJijKNECPRel_0.method_3())
		{
			base.Close();
		}
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00006C98 File Offset: 0x00004E98
	private async void method_1(object sender, RoutedEventArgs e)
	{
		if (this.lWEFWzGFOfCnCBncnJijKNECPRel_0.LoadedPlugin != null)
		{
			this.dialogHost_0.IsOpen = true;
			await Task.Factory.StartNew(new Action(this.method_3));
			this.dialogHost_0.IsOpen = false;
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00006CD4 File Offset: 0x00004ED4
	private void method_2(object sender, RoutedEventArgs e)
	{
		CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
		commonOpenFileDialog.IsFolderPicker = true;
		if (commonOpenFileDialog.ShowDialog() == 1)
		{
			this.lWEFWzGFOfCnCBncnJijKNECPRel_0.Path = commonOpenFileDialog.FileName;
		}
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00006D08 File Offset: 0x00004F08
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		Uri resourceLocator = new Uri("/TumblRipper;component/itgduycpymkeyivxblggmwkjtcynb.xaml", UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00006D38 File Offset: 0x00004F38
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			this.comboBox_0 = (ComboBox)target;
			this.comboBox_0.SelectionChanged += this.comboBox_0_SelectionChanged;
			return;
		case 2:
			((Button)target).Click += this.method_2;
			return;
		case 3:
			this.dialogHost_0 = (DialogHost)target;
			return;
		case 4:
			((Button)target).Click += this.method_1;
			return;
		case 5:
			this.contentControl_0 = (ContentControl)target;
			return;
		case 6:
			((Button)target).Click += this.method_0;
			return;
		default:
			this.bool_0 = true;
			return;
		}
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00006DF4 File Offset: 0x00004FF4
	[CompilerGenerated]
	private void method_3()
	{
		string friendlyUrlTitle = this.lWEFWzGFOfCnCBncnJijKNECPRel_0.LoadedPlugin.GetFriendlyUrlTitle(new Ripper(new Website()), this.lWEFWzGFOfCnCBncnJijKNECPRel_0.Url);
		this.lWEFWzGFOfCnCBncnJijKNECPRel_0.Title = (string.IsNullOrWhiteSpace(friendlyUrlTitle) ? "No title" : friendlyUrlTitle);
	}

	// Token: 0x0400004A RID: 74
	public lWEFWzGFOfCnCBncnJijKNECPRel lWEFWzGFOfCnCBncnJijKNECPRel_0;

	// Token: 0x0400004B RID: 75
	internal ComboBox comboBox_0;

	// Token: 0x0400004C RID: 76
	internal DialogHost dialogHost_0;

	// Token: 0x0400004D RID: 77
	internal ContentControl contentControl_0;

	// Token: 0x0400004E RID: 78
	private bool bool_0;
}
