using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Squirrel;
using TumblRipper;
using TumblRipper.Common;

// Token: 0x0200001C RID: 28
public class JrcBnfGXvGUYjGSrFwAEBNgcnQSgA : Window, IComponentConnector
{
	// Token: 0x06000080 RID: 128 RVA: 0x00007194 File Offset: 0x00005394
	public JrcBnfGXvGUYjGSrFwAEBNgcnQSgA()
	{
		this.InitializeComponent();
		this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0 = (base.DataContext as poaKSmrhkvDnxmxPGEwHlirBIEdQ);
		Controller.Init();
		this.method_0();
	}

	// Token: 0x06000081 RID: 129 RVA: 0x000071CC File Offset: 0x000053CC
	private async void method_0()
	{
		using (UpdateManager updateManager = new UpdateManager(aqCGHAlAynJJkZcLStKmkcVsLDxH.string_0, null, null, null))
		{
			if ((await updateManager.CheckForUpdate(false, null)).ReleasesToApply.Count > 0)
			{
				new UslbEcRYgSFneHtlndGFNDQdJwtT().Show();
			}
		}
		UpdateManager updateManager = null;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00007200 File Offset: 0x00005400
	private void method_1(object sender, RoutedEventArgs e)
	{
		this.method_7();
		this.method_5();
	}

	// Token: 0x06000083 RID: 131 RVA: 0x0000721C File Offset: 0x0000541C
	private void method_2(object sender, RoutedEventArgs e)
	{
		if (!MySettings.Instance.IsLicensed() && MySettings.Instance.LoadWebsites().Count > 3)
		{
			MessageBox.Show("You need to donate to manage more than 3 websites");
			return;
		}
		new oRlPmRWLaokoYsRDYOEeIbefEtqN().ShowDialog();
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00007260 File Offset: 0x00005460
	private void method_3(object sender, RoutedEventArgs e)
	{
		new IyPBLLcXPJtYiTgBMkfKVnBzwqCL().Show();
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00007278 File Offset: 0x00005478
	private async void method_4(IEnumerable<IWebsite> ienumerable_0)
	{
		if (MySettings.Instance.IsLicensed())
		{
			this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.method_2();
			this.cancellationTokenSource_0 = new CancellationTokenSource();
			using (IEnumerator<IWebsite> enumerator = ienumerable_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TaskAwaiter taskAwaiter = Controller.Start(enumerator.Current, this.cancellationTokenSource_0.Token).GetAwaiter();
					if (!taskAwaiter.IsCompleted)
					{
						await taskAwaiter;
						TaskAwaiter taskAwaiter2;
						taskAwaiter = taskAwaiter2;
						taskAwaiter2 = default(TaskAwaiter);
					}
					taskAwaiter.GetResult();
					taskAwaiter = default(TaskAwaiter);
				}
			}
			IEnumerator<IWebsite> enumerator = null;
			this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.method_3();
		}
		else
		{
			MessageBox.Show("Sorry, This version is only for registered users");
			new vAjvxUmppEgfgfmhCaAbWUJYhvdGA().Show();
		}
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000072BC File Offset: 0x000054BC
	public void method_5()
	{
		Application.Current.Shutdown();
	}

	// Token: 0x06000087 RID: 135 RVA: 0x000072D4 File Offset: 0x000054D4
	private async void method_6(object sender, RoutedEventArgs e)
	{
		IEnumerable<Website> ienumerable_ = this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.Websites.Where(new Func<Website, bool>(JrcBnfGXvGUYjGSrFwAEBNgcnQSgA.Class6.<>9.method_0));
		this.method_4(ienumerable_);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00007310 File Offset: 0x00005510
	private void method_7()
	{
		foreach (Website w in this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.Websites)
		{
			MySettings.Instance.SaveWebsite(w);
		}
		if (this.cancellationTokenSource_0 == null)
		{
			return;
		}
		if (this.cancellationTokenSource_0.IsCancellationRequested)
		{
			return;
		}
		this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.method_1();
		this.cancellationTokenSource_0.Cancel();
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00007394 File Offset: 0x00005594
	private async void method_8(object sender, RoutedEventArgs e)
	{
		this.method_7();
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00007200 File Offset: 0x00005400
	private void method_9(object sender, EventArgs e)
	{
		this.method_7();
		this.method_5();
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000073D0 File Offset: 0x000055D0
	private void method_10(object sender, RoutedEventArgs e)
	{
		if (this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite == null)
		{
			return;
		}
		if (MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
		{
			return;
		}
		MySettings.Instance.RemoveWebsite(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite);
		this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.Websites.Remove(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite);
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00007430 File Offset: 0x00005630
	private void method_11(object sender, RoutedEventArgs e)
	{
		if (this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite == null)
		{
			return;
		}
		Process.Start(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite.LocalDir);
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00007464 File Offset: 0x00005664
	private void method_12(object sender, RoutedEventArgs e)
	{
		if (this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite == null)
		{
			return;
		}
		new oRlPmRWLaokoYsRDYOEeIbefEtqN(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite).ShowDialog();
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00007498 File Offset: 0x00005698
	private void method_13(object sender, RoutedEventArgs e)
	{
		new vAjvxUmppEgfgfmhCaAbWUJYhvdGA().ShowDialog();
	}

	// Token: 0x0600008F RID: 143 RVA: 0x000074B0 File Offset: 0x000056B0
	private void method_14(object sender, RoutedEventArgs e)
	{
		if (this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite == null)
		{
			return;
		}
		this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite.Enabled = true;
		this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.method_0();
		MySettings.Instance.SaveWebsite(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000074FC File Offset: 0x000056FC
	private void method_15(object sender, RoutedEventArgs e)
	{
		if (this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite == null)
		{
			return;
		}
		this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite.Enabled = false;
		this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.method_0();
		MySettings.Instance.SaveWebsite(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00007548 File Offset: 0x00005748
	private void method_16(object sender, RoutedEventArgs e)
	{
		if (this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite == null)
		{
			return;
		}
		if (MessageBox.Show("This will completely re-index the blog and download missing media (skipping existing files)", "Consolidate Missing Media ?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
		{
			if (File.Exists(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite.HistoryFilePath))
			{
				File.Delete(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite.HistoryFilePath);
			}
			if (File.Exists(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite.FailedFilePath))
			{
				File.Delete(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite.FailedFilePath);
			}
			if (File.Exists(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite.PendingFilePath))
			{
				File.Delete(this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite.PendingFilePath);
			}
			this.method_4(new List<IWebsite>
			{
				this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite
			});
			return;
		}
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0000761C File Offset: 0x0000581C
	private void method_17(object sender, RoutedEventArgs e)
	{
		this.method_4(new List<IWebsite>
		{
			this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite
		});
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00007648 File Offset: 0x00005848
	private void method_18(object sender, RoutedEventArgs e)
	{
		if (this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite == null)
		{
			return;
		}
		try
		{
			Process.Start("http://" + this.poaKSmrhkvDnxmxPGEwHlirBIEdQ_0.SelectedWebsite.Url);
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error opening website : " + ex.Message);
		}
	}

	// Token: 0x06000094 RID: 148 RVA: 0x000076B0 File Offset: 0x000058B0
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		Uri resourceLocator = new Uri("/TumblRipper;component/souzzwbzijpqaanphycmgfqqslo.xaml", UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x000076E0 File Offset: 0x000058E0
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			((JrcBnfGXvGUYjGSrFwAEBNgcnQSgA)target).Closed += this.method_9;
			return;
		case 2:
			((MenuItem)target).Click += this.method_2;
			return;
		case 3:
			((MenuItem)target).Click += this.method_3;
			return;
		case 4:
			((MenuItem)target).Click += this.method_1;
			return;
		case 5:
			((MenuItem)target).Click += this.method_13;
			return;
		case 6:
			((Button)target).Click += this.method_3;
			return;
		case 7:
			((Button)target).Click += this.method_6;
			return;
		case 8:
			((Button)target).Click += this.method_8;
			return;
		case 9:
			this.dataGrid_0 = (DataGrid)target;
			return;
		case 10:
			((MenuItem)target).Click += this.method_11;
			return;
		case 11:
			((MenuItem)target).Click += this.method_18;
			return;
		case 12:
			((MenuItem)target).Click += this.method_12;
			return;
		case 13:
			((MenuItem)target).Click += this.method_16;
			return;
		case 14:
			((MenuItem)target).Click += this.method_17;
			return;
		case 15:
			((MenuItem)target).Click += this.method_14;
			return;
		case 16:
			((MenuItem)target).Click += this.method_15;
			return;
		case 17:
			((MenuItem)target).Click += this.method_10;
			return;
		default:
			this.bool_0 = true;
			return;
		}
	}

	// Token: 0x04000059 RID: 89
	private readonly poaKSmrhkvDnxmxPGEwHlirBIEdQ poaKSmrhkvDnxmxPGEwHlirBIEdQ_0;

	// Token: 0x0400005A RID: 90
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400005B RID: 91
	internal DataGrid dataGrid_0;

	// Token: 0x0400005C RID: 92
	private bool bool_0;

	// Token: 0x0200001F RID: 31
	[CompilerGenerated]
	[Serializable]
	private sealed class Class6
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00007BC8 File Offset: 0x00005DC8
		internal bool method_0(Website website_0)
		{
			return website_0.Enabled;
		}

		// Token: 0x04000067 RID: 103
		public static readonly JrcBnfGXvGUYjGSrFwAEBNgcnQSgA.Class6 <>9 = new JrcBnfGXvGUYjGSrFwAEBNgcnQSgA.Class6();

		// Token: 0x04000068 RID: 104
		public static Func<Website, bool> <>9__9_0;
	}
}
