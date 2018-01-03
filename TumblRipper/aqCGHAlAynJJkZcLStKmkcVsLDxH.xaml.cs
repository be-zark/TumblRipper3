using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Markup;

// Token: 0x0200001A RID: 26
public partial class aqCGHAlAynJJkZcLStKmkcVsLDxH : Application
{
	// Token: 0x06000078 RID: 120 RVA: 0x00006F60 File Offset: 0x00005160
	private async void aqCGHAlAynJJkZcLStKmkcVsLDxH_Startup(object sender, StartupEventArgs e)
	{
		FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
		Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
		aqCGHAlAynJJkZcLStKmkcVsLDxH.gclass1_0 = new GClass1();
		AppDomain.CurrentDomain.UnhandledException += this.method_0;
		new JrcBnfGXvGUYjGSrFwAEBNgcnQSgA().Show();
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00006F9C File Offset: 0x0000519C
	private void method_0(object sender, UnhandledExceptionEventArgs e)
	{
		try
		{
			Exception ex = (Exception)e.ExceptionObject;
			string arguments = aqCGHAlAynJJkZcLStKmkcVsLDxH.gclass1_0.method_0(ex);
			MessageBox.Show("Error:\n" + ex.Message, "Fatal Error", MessageBoxButton.OK, MessageBoxImage.Hand);
			new Process
			{
				EnableRaisingEvents = false,
				StartInfo = 
				{
					FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TumblRipper.BugReporter.exe"),
					Arguments = arguments
				}
			}.Start();
		}
		finally
		{
			Application.Current.Shutdown();
		}
	}

	// Token: 0x0600007A RID: 122 RVA: 0x0000703C File Offset: 0x0000523C
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void method_1()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		base.Startup += this.aqCGHAlAynJJkZcLStKmkcVsLDxH_Startup;
		Uri resourceLocator = new Uri("/TumblRipper;component/gmgxwkwvdtbybdjvsxozxbfmjijo.xaml", UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	// Token: 0x04000053 RID: 83
	internal static readonly string string_0 = "http://files.zark.be/tumblripper/3/beta";

	// Token: 0x04000054 RID: 84
	private static GClass1 gclass1_0;

	// Token: 0x04000055 RID: 85
	private bool bool_0;
}
