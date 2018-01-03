using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

// Token: 0x0200000F RID: 15
public class eTtgCKFUIOPobFBQhQNdEUBgGyxtc : Window, IComponentConnector
{
	// Token: 0x06000047 RID: 71 RVA: 0x00005D1C File Offset: 0x00003F1C
	public eTtgCKFUIOPobFBQhQNdEUBgGyxtc()
	{
		this.InitializeComponent();
		this.xAPZacjaffYTeqLoEMxHPfPmmYqc_0 = (base.DataContext as xAPZacjaffYTeqLoEMxHPfPmmYqc);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00005D48 File Offset: 0x00003F48
	private void method_0(object sender, RoutedEventArgs e)
	{
		this.xAPZacjaffYTeqLoEMxHPfPmmYqc_0.method_0();
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00005D60 File Offset: 0x00003F60
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		Uri resourceLocator = new Uri("/TumblRipper;component/lfaubkfkadwjiwzhkezwmfwgpdoq.xaml", UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00005D90 File Offset: 0x00003F90
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			((Button)target).Click += this.method_0;
			return;
		}
		this.bool_0 = true;
	}

	// Token: 0x04000030 RID: 48
	private xAPZacjaffYTeqLoEMxHPfPmmYqc xAPZacjaffYTeqLoEMxHPfPmmYqc_0;

	// Token: 0x04000031 RID: 49
	private bool bool_0;
}
