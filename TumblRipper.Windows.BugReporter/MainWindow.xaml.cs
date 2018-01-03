// Decompiled with JetBrains decompiler
// Type: TumblRipper.Windows.BugReporter.MainWindow
// Assembly: TumblRipper.Windows.BugReporter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C75CF5A0-EC3C-4BEC-917A-39F03D091D88
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.BugReporter.exe

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
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace TumblRipper.Windows.BugReporter
{
  public partial class MainWindow : Window, IComponentConnector
  {
    internal TextBox ErrorDescription;
    internal TextBox ErrorLog;
    private bool _contentLoaded;

    public MainWindow()
    {
      this.InitializeComponent();
      string[] commandLineArgs = Environment.GetCommandLineArgs();
      if (commandLineArgs.Length <= 1)
        return;
      using (StreamReader streamReader = System.IO.File.OpenText(commandLineArgs[1]))
        this.ErrorLog.Text = streamReader.ReadToEnd();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }

    private void btnSend(object sender, RoutedEventArgs e)
    {
      if (this.ErrorDescription.Text.Length < 10)
      {
        int num1 = (int) MessageBox.Show("Please describe what you were doing when the crash happened");
      }
      else
      {
        Button button = sender as Button;
        button.IsEnabled = false;
        try
        {
          NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(string.Empty);
          string name1 = "reason";
          string text1 = this.ErrorDescription.Text;
          nameValueCollection.Add(name1, text1);
          string name2 = "stacktrace";
          string text2 = this.ErrorLog.Text;
          nameValueCollection.Add(name2, text2);
          string s = nameValueCollection.ToString();
          HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create("http://www.zark.be/software/debug.html?t=TumblRipper3");
          byte[] bytes = Encoding.UTF8.GetBytes(s);
          httpWebRequest.Method = "POST";
          httpWebRequest.ContentType = "application/x-www-form-urlencoded";
          httpWebRequest.ContentLength = (long) bytes.Length;
          using (Stream requestStream = httpWebRequest.GetRequestStream())
            requestStream.Write(bytes, 0, bytes.Length);
          new StreamReader(httpWebRequest.GetResponse().GetResponseStream()).ReadToEnd();
          int num2 = (int) MessageBox.Show("Bug Reported submitted. Thank you");
          this.Close();
        }
        catch (Exception ex)
        {
          int num2 = (int) MessageBox.Show(ex.Message);
        }
        finally
        {
          button.IsEnabled = true;
        }
      }
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/TumblRipper.Windows.BugReporter;component/mainwindow.xaml", UriKind.Relative));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          this.ErrorDescription = (TextBox) target;
          break;
        case 2:
          this.ErrorLog = (TextBox) target;
          break;
        case 3:
          ((ButtonBase) target).Click += new RoutedEventHandler(this.btnSend);
          break;
        case 4:
          ((ButtonBase) target).Click += new RoutedEventHandler(this.Button_Click);
          break;
        default:
          this._contentLoaded = true;
          break;
      }
    }
  }
}
