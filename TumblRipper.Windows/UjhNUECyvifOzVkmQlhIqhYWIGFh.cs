// Decompiled with JetBrains decompiler
// Type: UjhNUECyvifOzVkmQlhIqhYWIGFh
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

public class UjhNUECyvifOzVkmQlhIqhYWIGFh : Application
{
  internal static readonly string string_0 = "http://files.zark.be/tumblripper/3/beta";
  private static GClass1 gclass1_0;
  private bool bool_0;

  private void UjhNUECyvifOzVkmQlhIqhYWIGFh_Startup(object sender, StartupEventArgs e)
  {
    // ISSUE: variable of a compiler-generated type
    UjhNUECyvifOzVkmQlhIqhYWIGFh.Struct3 stateMachine;
    // ISSUE: reference to a compiler-generated field
    stateMachine.ujhNUECyvifOzVkmQlhIqhYWIGFh_0 = this;
    // ISSUE: reference to a compiler-generated field
    stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
    // ISSUE: reference to a compiler-generated field
    stateMachine.int_0 = -1;
    // ISSUE: reference to a compiler-generated field
    stateMachine.asyncVoidMethodBuilder_0.Start<UjhNUECyvifOzVkmQlhIqhYWIGFh.Struct3>(ref stateMachine);
  }

  private void method_0(object sender, UnhandledExceptionEventArgs e)
  {
    try
    {
      Exception exception_0 = (Exception) e.ExceptionObject;
      string str = UjhNUECyvifOzVkmQlhIqhYWIGFh.gclass1_0.method_0(exception_0);
      int num = (int) MessageBox.Show("Error:\n" + exception_0.Message, "Fatal Error", MessageBoxButton.OK, MessageBoxImage.Hand);
      new Process()
      {
        EnableRaisingEvents = false,
        StartInfo = {
          FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TumblRipper.BugReporter.exe"),
          Arguments = str
        }
      }.Start();
    }
    finally
    {
      Application.Current.Shutdown();
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void method_1()
  {
    if (this.bool_0)
      return;
    this.bool_0 = true;
    this.Startup += new StartupEventHandler(this.UjhNUECyvifOzVkmQlhIqhYWIGFh_Startup);
    Application.LoadComponent((object) this, new Uri("/TumblRipper.Windows;component/uibwtbuuhwcsudwpsgkdaasxknnw.xaml", UriKind.Relative));
  }

  [STAThread]
  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public static void Main()
  {
    UjhNUECyvifOzVkmQlhIqhYWIGFh ozVkmQlhIqhYwigFh = new UjhNUECyvifOzVkmQlhIqhYWIGFh();
    ozVkmQlhIqhYwigFh.method_1();
    ozVkmQlhIqhYwigFh.Run();
  }
}
