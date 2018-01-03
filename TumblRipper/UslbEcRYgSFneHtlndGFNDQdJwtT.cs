using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Squirrel;

// Token: 0x02000015 RID: 21
public class UslbEcRYgSFneHtlndGFNDQdJwtT : Window, IComponentConnector
{
	// Token: 0x06000063 RID: 99 RVA: 0x00006790 File Offset: 0x00004990
	public UslbEcRYgSFneHtlndGFNDQdJwtT()
	{
		this.InitializeComponent();
		this.bbhRWcwteLiOvNBZWnMVliuTDOio_0 = (base.DataContext as BBhRWcwteLiOvNBZWnMVliuTDOio);
		this.bbhRWcwteLiOvNBZWnMVliuTDOio_0.ShowProgressBar = Visibility.Collapsed;
		this.method_0();
	}

	// Token: 0x06000064 RID: 100 RVA: 0x000067CC File Offset: 0x000049CC
	public async void method_0()
	{
		using (UpdateManager updateManager = new UpdateManager(aqCGHAlAynJJkZcLStKmkcVsLDxH.string_0, null, null, null))
		{
			UpdateInfo updateInfo = await updateManager.CheckForUpdate(false, null);
			if (updateInfo.CurrentlyInstalledVersion != null)
			{
				this.bbhRWcwteLiOvNBZWnMVliuTDOio_0.CurrentVersion = updateInfo.CurrentlyInstalledVersion.Version.ToString();
			}
			if (updateInfo.FutureReleaseEntry != null)
			{
				this.bbhRWcwteLiOvNBZWnMVliuTDOio_0.LatestVersion = updateInfo.FutureReleaseEntry.Version.ToString();
			}
			updateInfo.FetchReleaseNotes();
			this.bbhRWcwteLiOvNBZWnMVliuTDOio_0.UpdateEnabled = true;
		}
		UpdateManager updateManager = null;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00006808 File Offset: 0x00004A08
	private async void method_1(object sender, RoutedEventArgs e)
	{
		this.bbhRWcwteLiOvNBZWnMVliuTDOio_0.ShowButtons = Visibility.Collapsed;
		this.bbhRWcwteLiOvNBZWnMVliuTDOio_0.ShowProgressBar = Visibility.Visible;
		using (UpdateManager updateManager = new UpdateManager(aqCGHAlAynJJkZcLStKmkcVsLDxH.string_0, null, null, null))
		{
			this.bbhRWcwteLiOvNBZWnMVliuTDOio_0.UpdateEnabled = false;
			await EasyModeMixin.UpdateApp(updateManager, null);
			MessageBox.Show("Update done. Please restart");
			this.Close();
		}
		UpdateManager updateManager = null;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00006844 File Offset: 0x00004A44
	private void method_2(object sender, RoutedEventArgs e)
	{
		base.Close();
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00006858 File Offset: 0x00004A58
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		Uri resourceLocator = new Uri("/TumblRipper;component/kgggosirjbwxbhmuqjggzwaufkjua.xaml", UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00006888 File Offset: 0x00004A88
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			((Button)target).Click += this.method_2;
			return;
		}
		if (connectionId == 2)
		{
			((Button)target).Click += this.method_1;
			return;
		}
		this.bool_0 = true;
	}

	// Token: 0x0400003E RID: 62
	private BBhRWcwteLiOvNBZWnMVliuTDOio bbhRWcwteLiOvNBZWnMVliuTDOio_0;

	// Token: 0x0400003F RID: 63
	private bool bool_0;
}
