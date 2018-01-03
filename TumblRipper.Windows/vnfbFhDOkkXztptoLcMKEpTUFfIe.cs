// Decompiled with JetBrains decompiler
// Type: vnfbFhDOkkXztptoLcMKEpTUFfIe
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

public class vnfbFhDOkkXztptoLcMKEpTUFfIe : UserControl, IComponentConnector
{
  private bool bool_0;

  public vnfbFhDOkkXztptoLcMKEpTUFfIe()
  {
    this.InitializeComponent();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this.bool_0)
      return;
    this.bool_0 = true;
    Application.LoadComponent((object) this, new Uri("/TumblRipper.Windows;component/glunmqnmlicfjuvmjbrjsukoxiyg.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    this.bool_0 = true;
  }
}
