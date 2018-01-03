// Decompiled with JetBrains decompiler
// Type: UjdRFFDoJgqmuTOlkrKxGSuThRuO
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using MahApps.Metro.Controls;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using TumblRipper.Common;
using TumblRipper.PluginInterface;

public class UjdRFFDoJgqmuTOlkrKxGSuThRuO : MetroWindow, IComponentConnector
{
  private readonly gImazEYxmUxzXBeWouOTNYaHQdxr gImazEYxmUxzXBeWouOTNYaHQdxr_0;
  private CancellationTokenSource cancellationTokenSource_0;
  internal DataGrid dataGrid_0;
  private bool bool_0;

  public UjdRFFDoJgqmuTOlkrKxGSuThRuO()
  {
    base.\u002Ector();
    this.InitializeComponent();
    this.gImazEYxmUxzXBeWouOTNYaHQdxr_0 = ((FrameworkElement) this).DataContext as gImazEYxmUxzXBeWouOTNYaHQdxr;
  }

  void Window.OnContentRendered(EventArgs e)
  {
    // ISSUE: explicit non-virtual call
    __nonvirtual (((Window) this).OnContentRendered(e));
    Controller.Init();
    this.method_0();
  }

  private void method_0()
  {
    // ISSUE: variable of a compiler-generated type
    UjdRFFDoJgqmuTOlkrKxGSuThRuO.Struct4 stateMachine;
    // ISSUE: reference to a compiler-generated field
    stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
    // ISSUE: reference to a compiler-generated field
    stateMachine.int_0 = -1;
    // ISSUE: reference to a compiler-generated field
    stateMachine.asyncVoidMethodBuilder_0.Start<UjdRFFDoJgqmuTOlkrKxGSuThRuO.Struct4>(ref stateMachine);
  }

  private void method_1(object sender, RoutedEventArgs e)
  {
    this.method_7();
    this.method_5();
  }

  private void method_2(object sender, RoutedEventArgs e)
  {
    if (!MySettings.Instance.IsLicensed() && gImazEYxmUxzXBeWouOTNYaHQdxr.gImazEYxmUxzXBeWouOTNYaHQdxr_0.Websites.Count > 3)
    {
      int num = (int) MessageBox.Show("You need to donate to manage more than 3 websites");
    }
    else
      ((Window) new ZWpYpXiTtrQKTKqofGoKghjCqPDc()).ShowDialog();
  }

  private void method_3(object sender, RoutedEventArgs e)
  {
    ((Window) new FUBBlEfCteGiEUOpeldksiHKigIo()).Show();
  }

  private async Task method_4(IEnumerable<IWebsite> ienumerable_0)
  {
    UjdRFFDoJgqmuTOlkrKxGSuThRuO jgqmuTolkrKxGsuThRuO = this;
    if (!MySettings.Instance.IsLicensed())
    {
      int num = (int) MessageBox.Show("Sorry, This version is only for registered users");
      ((Window) new XpiUnWqHsYDkQeqRbTZVPWrvsxcaA()).Show();
    }
    else
    {
      jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.method_2();
      jgqmuTolkrKxGsuThRuO.cancellationTokenSource_0 = new CancellationTokenSource();
      foreach (IWebsite w in ienumerable_0)
      {
        if (!jgqmuTolkrKxGsuThRuO.cancellationTokenSource_0.IsCancellationRequested)
        {
          try
          {
            await Controller.Start(w, jgqmuTolkrKxGsuThRuO.cancellationTokenSource_0.Token);
          }
          catch (Exception ex)
          {
          }
        }
        else
          break;
      }
      jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.method_3();
    }
  }

  public void method_5()
  {
    Application.Current.Shutdown();
  }

  private async void method_6(object sender, RoutedEventArgs e)
  {
    UjdRFFDoJgqmuTOlkrKxGSuThRuO jgqmuTolkrKxGsuThRuO = this;
    List<Website> list = Enumerable.ToList<Website>(Enumerable.Where<Website>((IEnumerable<Website>) jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.Websites, (Func<Website, bool>) (website_0 => website_0.Enabled)));
    await jgqmuTolkrKxGsuThRuO.method_4((IEnumerable<IWebsite>) list);
  }

  private void method_7()
  {
    if (this.cancellationTokenSource_0 == null || this.cancellationTokenSource_0.IsCancellationRequested)
      return;
    this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.method_1();
    try
    {
      this.cancellationTokenSource_0.Cancel();
    }
    catch (Exception ex)
    {
    }
  }

  private async void method_8(object sender, RoutedEventArgs e)
  {
    this.method_7();
  }

  private void method_9(object sender, EventArgs e)
  {
    this.method_7();
    this.method_5();
  }

  private void method_10(object sender, RoutedEventArgs e)
  {
    // ISSUE: unable to decompile the method.
  }

  private void method_11(object sender, RoutedEventArgs e)
  {
    if (this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite == null)
      return;
    Process.Start(this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite.LocalDir);
  }

  private void method_12(object sender, RoutedEventArgs e)
  {
    if (this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite == null)
      return;
    ((Window) new ZWpYpXiTtrQKTKqofGoKghjCqPDc(this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite)).ShowDialog();
  }

  private void method_13(object sender, RoutedEventArgs e)
  {
    ((Window) new XpiUnWqHsYDkQeqRbTZVPWrvsxcaA()).ShowDialog();
  }

  private void method_14(object sender, RoutedEventArgs e)
  {
    if (this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite == null)
      return;
    this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite.Enabled = true;
    this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.method_0();
    MySettings.Instance.SaveWebsite(this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite);
  }

  private void method_15(object sender, RoutedEventArgs e)
  {
    if (this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite == null)
      return;
    this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite.Enabled = false;
    this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.method_0();
    MySettings.Instance.SaveWebsite(this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite);
  }

  private async void method_16(object sender, RoutedEventArgs e)
  {
    UjdRFFDoJgqmuTOlkrKxGSuThRuO jgqmuTolkrKxGsuThRuO = this;
    if (jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite != null && MessageBox.Show("This will completely re-index the blog and download missing media (skipping existing files)", "Consolidate Missing Media ?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
    {
      if (File.Exists(jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite.HistoryFilePath))
        File.Delete(jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite.HistoryFilePath);
      if (File.Exists(jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite.FailedFilePath))
        File.Delete(jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite.FailedFilePath);
      if (File.Exists(jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite.PendingFilePath))
        File.Delete(jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite.PendingFilePath);
      await jgqmuTolkrKxGsuThRuO.method_4((IEnumerable<IWebsite>) new List<IWebsite>()
      {
        (IWebsite) jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite
      });
    }
  }

  private async void method_17(object sender, RoutedEventArgs e)
  {
    UjdRFFDoJgqmuTOlkrKxGSuThRuO jgqmuTolkrKxGsuThRuO = this;
    await jgqmuTolkrKxGsuThRuO.method_4((IEnumerable<IWebsite>) new List<IWebsite>()
    {
      (IWebsite) jgqmuTolkrKxGsuThRuO.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite
    });
  }

  private void method_18(object sender, RoutedEventArgs e)
  {
    if (this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite == null)
      return;
    try
    {
      Process.Start("http://" + this.gImazEYxmUxzXBeWouOTNYaHQdxr_0.SelectedWebsite.Url);
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show("Error opening website : " + ex.Message);
    }
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this.bool_0)
      return;
    this.bool_0 = true;
    Application.LoadComponent((object) this, new Uri("/TumblRipper.Windows;component/nashmtaovnyxckvwwxtnhbeyvzbj.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        ((Window) target).Closed += new EventHandler(this.method_9);
        break;
      case 2:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_2);
        break;
      case 3:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_3);
        break;
      case 4:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_1);
        break;
      case 5:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_13);
        break;
      case 6:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.method_2);
        break;
      case 7:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.method_3);
        break;
      case 8:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.method_6);
        break;
      case 9:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.method_8);
        break;
      case 10:
        this.dataGrid_0 = (DataGrid) target;
        break;
      case 11:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_11);
        break;
      case 12:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_18);
        break;
      case 13:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_12);
        break;
      case 14:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_16);
        break;
      case 15:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_17);
        break;
      case 16:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_14);
        break;
      case 17:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_15);
        break;
      case 18:
        ((MenuItem) target).Click += new RoutedEventHandler(this.method_10);
        break;
      default:
        this.bool_0 = true;
        break;
    }
  }
}
