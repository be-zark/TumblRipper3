// Decompiled with JetBrains decompiler
// Type: OqNSZsVHoOzMSxiDxujnNZLcaZYc
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using MaterialDesignThemes.Wpf;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using TumblRipper.Common;

public class OqNSZsVHoOzMSxiDxujnNZLcaZYc : UserControl, IComponentConnector
{
  private readonly Window window_0;
  private readonly jNZshobRhysiXbmjDDUtHtLNjDTUA jNZshobRhysiXbmjDDUtHtLNjDTUA_0;
  internal DialogHost dialogHost_0;
  private bool bool_0;

  public OqNSZsVHoOzMSxiDxujnNZLcaZYc(Window window_1)
  {
    this.InitializeComponent();
    this.jNZshobRhysiXbmjDDUtHtLNjDTUA_0 = this.DataContext as jNZshobRhysiXbmjDDUtHtLNjDTUA;
    this.window_0 = window_1;
  }

  private void method_0(object sender, RoutedEventArgs e)
  {
    this.dialogHost_0.set_IsOpen(true);
    int num1 = LicenceValidation.ValidLicence(this.jNZshobRhysiXbmjDDUtHtLNjDTUA_0.Email, this.jNZshobRhysiXbmjDDUtHtLNjDTUA_0.Licence) ? 1 : 0;
    this.dialogHost_0.set_IsOpen(false);
    if (num1 != 0)
    {
      this.jNZshobRhysiXbmjDDUtHtLNjDTUA_0.StatusText = "Advanced functions are now unlocked.";
      int num2 = (int) MessageBox.Show("Thank you");
      this.window_0.Close();
    }
    else
      this.jNZshobRhysiXbmjDDUtHtLNjDTUA_0.StatusText = "Invalid Licence information.";
  }

  private void method_1(object sender, MouseButtonEventArgs e)
  {
    Process.Start("http://www.zark.be/software/download.html");
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this.bool_0)
      return;
    this.bool_0 = true;
    Application.LoadComponent((object) this, new Uri("/TumblRipper.Windows;component/fnkjjjxfdphemdrvutjbmjbwwxeja.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.dialogHost_0 = (DialogHost) target;
        break;
      case 2:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.method_0);
        break;
      case 3:
        ((UIElement) target).MouseDown += new MouseButtonEventHandler(this.method_1);
        break;
      default:
        this.bool_0 = true;
        break;
    }
  }
}
