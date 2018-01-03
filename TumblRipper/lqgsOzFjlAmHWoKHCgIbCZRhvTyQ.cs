using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using MaterialDesignThemes.Wpf;
using TumblRipper;

// Token: 0x02000012 RID: 18
public class lqgsOzFjlAmHWoKHCgIbCZRhvTyQ : UserControl, IComponentConnector
{
	// Token: 0x06000053 RID: 83 RVA: 0x000062F4 File Offset: 0x000044F4
	public lqgsOzFjlAmHWoKHCgIbCZRhvTyQ(Window window_1)
	{
		this.InitializeComponent();
		this.qyUGntmHBXqLyacewWyfWEpSHBZr_0 = (base.DataContext as qyUGntmHBXqLyacewWyfWEpSHBZr);
		this.window_0 = window_1;
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00006328 File Offset: 0x00004528
	private void method_0(object sender, RoutedEventArgs e)
	{
		this.dialogHost_0.IsOpen = true;
		bool flag = LicenceValidation.ValidLicence(this.qyUGntmHBXqLyacewWyfWEpSHBZr_0.Email, this.qyUGntmHBXqLyacewWyfWEpSHBZr_0.Licence);
		this.dialogHost_0.IsOpen = false;
		if (!flag)
		{
			this.qyUGntmHBXqLyacewWyfWEpSHBZr_0.StatusText = "Invalid Licence information.";
			return;
		}
		this.qyUGntmHBXqLyacewWyfWEpSHBZr_0.StatusText = "Advanced functions are now unlocked.";
		MessageBox.Show("Thank you");
		this.window_0.Close();
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000063A4 File Offset: 0x000045A4
	private void method_1(object sender, MouseButtonEventArgs e)
	{
		Process.Start("http://www.zark.be/software/download.html");
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000063BC File Offset: 0x000045BC
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		Uri resourceLocator = new Uri("/TumblRipper;component/xlpptzdqcweoncjryaclngktgusd.xaml", UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000063EC File Offset: 0x000045EC
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			this.dialogHost_0 = (DialogHost)target;
			return;
		case 2:
			((Button)target).Click += this.method_0;
			return;
		case 3:
			((Label)target).MouseDown += this.method_1;
			return;
		default:
			this.bool_0 = true;
			return;
		}
	}

	// Token: 0x04000034 RID: 52
	private qyUGntmHBXqLyacewWyfWEpSHBZr qyUGntmHBXqLyacewWyfWEpSHBZr_0;

	// Token: 0x04000035 RID: 53
	private Window window_0;

	// Token: 0x04000036 RID: 54
	internal DialogHost dialogHost_0;

	// Token: 0x04000037 RID: 55
	private bool bool_0;
}
