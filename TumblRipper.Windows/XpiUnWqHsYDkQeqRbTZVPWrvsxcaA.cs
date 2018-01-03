// Decompiled with JetBrains decompiler
// Type: XpiUnWqHsYDkQeqRbTZVPWrvsxcaA
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using MahApps.Metro.Controls;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using TumblRipper.Common;

public class XpiUnWqHsYDkQeqRbTZVPWrvsxcaA : MetroWindow, IComponentConnector
{
  private readonly GjlxBfbFBhVyzRvjTgktCYpbKcZP gjlxBfbFBhVyzRvjTgktCYpbKcZP_0;
  private bool bool_0;

  public XpiUnWqHsYDkQeqRbTZVPWrvsxcaA()
  {
    base.\u002Ector();
    this.InitializeComponent();
    this.gjlxBfbFBhVyzRvjTgktCYpbKcZP_0 = ((FrameworkElement) this).DataContext as GjlxBfbFBhVyzRvjTgktCYpbKcZP;
    this.method_0();
    if (this.gjlxBfbFBhVyzRvjTgktCYpbKcZP_0.IsRegistered)
      return;
    this.gjlxBfbFBhVyzRvjTgktCYpbKcZP_0.MyUserControl = (UserControl) new OqNSZsVHoOzMSxiDxujnNZLcaZYc((Window) this);
  }

  public void method_0()
  {
    if (MySettings.Instance.Licence == null)
    {
      this.gjlxBfbFBhVyzRvjTgktCYpbKcZP_0.IsRegistered = false;
    }
    else
    {
      this.gjlxBfbFBhVyzRvjTgktCYpbKcZP_0.IsRegistered = true;
      this.gjlxBfbFBhVyzRvjTgktCYpbKcZP_0.SerialNumber = MySettings.Instance.Licence.Serial;
      this.gjlxBfbFBhVyzRvjTgktCYpbKcZP_0.Email = MySettings.Instance.Licence.Email;
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this.bool_0)
      return;
    this.bool_0 = true;
    Application.LoadComponent((object) this, new Uri("/TumblRipper.Windows;component/spaooiehnjvdllqykhnnzjidsvjr.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    this.bool_0 = true;
  }
}
