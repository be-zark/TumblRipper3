using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace TumblRipper.BugReporter
{
	// Token: 0x02000003 RID: 3
	public partial class MainWindow : Window
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000020F0 File Offset: 0x000002F0
		public MainWindow()
		{
			this.InitializeComponent();
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			if (commandLineArgs.Length > 1)
			{
				using (StreamReader streamReader = File.OpenText(commandLineArgs[1]))
				{
					this.ErrorLog.Text = streamReader.ReadToEnd();
				}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000207E File Offset: 0x0000027E
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000214C File Offset: 0x0000034C
		private void btnSend(object sender, RoutedEventArgs e)
		{
			if (this.ErrorDescription.Text.Length < 10)
			{
				MessageBox.Show("Please describe what you were doing when the crash happened");
				return;
			}
			Button button = sender as Button;
			button.IsEnabled = false;
			try
			{
				NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(string.Empty);
				nameValueCollection.Add("reason", this.ErrorDescription.Text);
				nameValueCollection.Add("stacktrace", this.ErrorLog.Text);
				string s = nameValueCollection.ToString();
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.zark.be/software/debug.html?t=TumblRipper3");
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest.ContentLength = (long)bytes.Length;
				using (Stream requestStream = httpWebRequest.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
				}
				new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream()).ReadToEnd();
				MessageBox.Show("Bug Reported submitted. Thank you");
				base.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				button.IsEnabled = true;
			}
		}
	}
}
