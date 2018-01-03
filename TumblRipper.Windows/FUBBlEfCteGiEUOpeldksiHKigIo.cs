// Decompiled with JetBrains decompiler
// Type: FUBBlEfCteGiEUOpeldksiHKigIo
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using MahApps.Metro.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using TumblRipper.Common;

public class FUBBlEfCteGiEUOpeldksiHKigIo : MetroWindow, IComponentConnector
{
  private readonly RskINpIpUjZYynMcjmeZRkGlmWbw rskINpIpUjZYynMcjmeZRkGlmWbw_0;
  private bool bool_0;

  public FUBBlEfCteGiEUOpeldksiHKigIo()
  {
    base.\u002Ector();
    this.InitializeComponent();
    this.rskINpIpUjZYynMcjmeZRkGlmWbw_0 = ((FrameworkElement) this).DataContext as RskINpIpUjZYynMcjmeZRkGlmWbw;
    MyAppSettings appSettings = MySettings.Instance.AppSettings;
    this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.DefaultDirectory = appSettings.LocalDir;
    this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.ProxyPassword = appSettings.ProxyPassword;
    this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.ProxyURL = appSettings.ProxyUrl;
    this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.ProxyUsername = appSettings.ProxyUsername;
    this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.ProxyUse = appSettings.UseProxy;
    this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.StatsUsageAnonymous = appSettings.AnonymousUsage;
  }

  private void method_0(object sender, RoutedEventArgs e)
  {
    CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
    commonOpenFileDialog.set_IsFolderPicker(true);
    if (((CommonFileDialog) commonOpenFileDialog).ShowDialog() == 1)
      this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.DefaultDirectory = ((CommonFileDialog) commonOpenFileDialog).get_FileName();
    ((Window) this).Topmost = true;
  }

  private void method_1(object sender, RoutedEventArgs e)
  {
    MyAppSettings appSettings = MySettings.Instance.AppSettings;
    string defaultDirectory = this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.DefaultDirectory;
    appSettings.LocalDir = defaultDirectory;
    int num1 = this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.StatsUsageAnonymous ? 1 : 0;
    appSettings.AnonymousUsage = num1 != 0;
    string proxyPassword = this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.ProxyPassword;
    appSettings.ProxyPassword = proxyPassword;
    string proxyUrl = this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.ProxyURL;
    appSettings.ProxyUrl = proxyUrl;
    string proxyUsername = this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.ProxyUsername;
    appSettings.ProxyUsername = proxyUsername;
    int num2 = this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.ProxyUse ? 1 : 0;
    appSettings.UseProxy = num2 != 0;
    int num3 = this.rskINpIpUjZYynMcjmeZRkGlmWbw_0.ProxyUseAuth ? 1 : 0;
    appSettings.ProxyUseAuth = num3 != 0;
    MySettings.Instance.SaveSettings();
    ((Window) this).Close();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this.bool_0)
      return;
    this.bool_0 = true;
    Application.LoadComponent((object) this, new Uri("/TumblRipper.Windows;component/kutbyidxbymlvuplynpohwivjqddb.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    if (connectionId != 1)
    {
      if (connectionId != 2)
        this.bool_0 = true;
      else
        ((ButtonBase) target).Click += new RoutedEventHandler(this.method_1);
    }
    else
      ((ButtonBase) target).Click += new RoutedEventHandler(this.method_0);
  }
}
