using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using TumblRipper;

// Token: 0x0200000E RID: 14
public class vAjvxUmppEgfgfmhCaAbWUJYhvdGA : Window, IComponentConnector
{
	// Token: 0x06000043 RID: 67 RVA: 0x00005C20 File Offset: 0x00003E20
	public vAjvxUmppEgfgfmhCaAbWUJYhvdGA()
	{
		this.InitializeComponent();
		this.zkjTPchqTBMrOBOewBJAKQQEdPgVA_0 = (base.DataContext as ZkjTPchqTBMrOBOewBJAKQQEdPgVA);
		this.method_0();
		if (!this.zkjTPchqTBMrOBOewBJAKQQEdPgVA_0.IsRegistered)
		{
			this.zkjTPchqTBMrOBOewBJAKQQEdPgVA_0.MyUserControl = new lqgsOzFjlAmHWoKHCgIbCZRhvTyQ(this);
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00005C70 File Offset: 0x00003E70
	public void method_0()
	{
		if (MySettings.Instance.Licence == null)
		{
			this.zkjTPchqTBMrOBOewBJAKQQEdPgVA_0.IsRegistered = false;
			return;
		}
		this.zkjTPchqTBMrOBOewBJAKQQEdPgVA_0.IsRegistered = true;
		this.zkjTPchqTBMrOBOewBJAKQQEdPgVA_0.SerialNumber = MySettings.Instance.Licence.Serial;
		this.zkjTPchqTBMrOBOewBJAKQQEdPgVA_0.Email = MySettings.Instance.Licence.Email;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00005CD8 File Offset: 0x00003ED8
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		Uri resourceLocator = new Uri("/TumblRipper;component/gynkwzqrkxpkbubktitopthsfszja.xaml", UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00005D08 File Offset: 0x00003F08
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		this.bool_0 = true;
	}

	// Token: 0x0400002E RID: 46
	private ZkjTPchqTBMrOBOewBJAKQQEdPgVA zkjTPchqTBMrOBOewBJAKQQEdPgVA_0;

	// Token: 0x0400002F RID: 47
	private bool bool_0;
}
