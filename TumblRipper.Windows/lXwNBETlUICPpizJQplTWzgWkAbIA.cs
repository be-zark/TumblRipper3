// Decompiled with JetBrains decompiler
// Type: lXwNBETlUICPpizJQplTWzgWkAbIA
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using MahApps.Metro.Controls;
using Squirrel;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

public class lXwNBETlUICPpizJQplTWzgWkAbIA : MetroWindow, IComponentConnector
{
  private readonly fBNJIXiYZSrrQLEPrbpdSeciniHk fBNJIXiYZSrrQLEPrbpdSeciniHk_0;
  private bool bool_0;

  public lXwNBETlUICPpizJQplTWzgWkAbIA()
  {
    base.\u002Ector();
    this.InitializeComponent();
    this.fBNJIXiYZSrrQLEPrbpdSeciniHk_0 = ((FrameworkElement) this).DataContext as fBNJIXiYZSrrQLEPrbpdSeciniHk;
    this.fBNJIXiYZSrrQLEPrbpdSeciniHk_0.ShowProgressBar = Visibility.Collapsed;
    this.method_0();
  }

  public async void method_0()
  {
    lXwNBETlUICPpizJQplTWzgWkAbIA ppizJqplTwzgWkAbIa = this;
    UpdateManager updateManager = new UpdateManager(UjhNUECyvifOzVkmQlhIqhYWIGFh.string_0, (string) null, (string) null, (IFileDownloader) null);
    try
    {
      UpdateInfo updateInfo = await updateManager.CheckForUpdate(false, (Action<int>) null);
      if (updateInfo.get_CurrentlyInstalledVersion() != null)
        ppizJqplTwzgWkAbIa.fBNJIXiYZSrrQLEPrbpdSeciniHk_0.CurrentVersion = ((object) updateInfo.get_CurrentlyInstalledVersion().get_Version()).ToString();
      if (updateInfo.get_FutureReleaseEntry() != null)
        ppizJqplTwzgWkAbIa.fBNJIXiYZSrrQLEPrbpdSeciniHk_0.LatestVersion = ((object) updateInfo.get_FutureReleaseEntry().get_Version()).ToString();
      updateInfo.FetchReleaseNotes();
      ppizJqplTwzgWkAbIa.fBNJIXiYZSrrQLEPrbpdSeciniHk_0.UpdateEnabled = true;
    }
    finally
    {
      if (updateManager != null)
        ((IDisposable) updateManager).Dispose();
    }
    updateManager = (UpdateManager) null;
  }

  private async void method_1(object sender, RoutedEventArgs e)
  {
    lXwNBETlUICPpizJQplTWzgWkAbIA ppizJqplTwzgWkAbIa = this;
    ppizJqplTwzgWkAbIa.fBNJIXiYZSrrQLEPrbpdSeciniHk_0.ShowButtons = Visibility.Collapsed;
    ppizJqplTwzgWkAbIa.fBNJIXiYZSrrQLEPrbpdSeciniHk_0.ShowProgressBar = Visibility.Visible;
    UpdateManager updateManager = new UpdateManager(UjhNUECyvifOzVkmQlhIqhYWIGFh.string_0, (string) null, (string) null, (IFileDownloader) null);
    try
    {
      ppizJqplTwzgWkAbIa.fBNJIXiYZSrrQLEPrbpdSeciniHk_0.UpdateEnabled = false;
      ReleaseEntry releaseEntry = await EasyModeMixin.UpdateApp((IUpdateManager) updateManager, (Action<int>) null);
      int num = (int) MessageBox.Show("Update done. Please restart");
      ((Window) ppizJqplTwzgWkAbIa).Close();
    }
    finally
    {
      if (updateManager != null)
        ((IDisposable) updateManager).Dispose();
    }
    updateManager = (UpdateManager) null;
  }

  private void method_2(object sender, RoutedEventArgs e)
  {
    ((Window) this).Close();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this.bool_0)
      return;
    this.bool_0 = true;
    Application.LoadComponent((object) this, new Uri("/TumblRipper.Windows;component/mmocwitzrmexowdgabzycsxbisud.xaml", UriKind.Relative));
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
      ((ButtonBase) target).Click += new RoutedEventHandler(this.method_2);
  }
}
