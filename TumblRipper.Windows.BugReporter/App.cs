// Decompiled with JetBrains decompiler
// Type: TumblRipper.Windows.BugReporter.App
// Assembly: TumblRipper.Windows.BugReporter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C75CF5A0-EC3C-4BEC-917A-39F03D091D88
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.BugReporter.exe

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace TumblRipper.Windows.BugReporter
{
  public class App : Application
  {
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [STAThread]
    [DebuggerNonUserCode]
    public static void Main()
    {
      App app = new App();
      app.InitializeComponent();
      app.Run();
    }
  }
}
