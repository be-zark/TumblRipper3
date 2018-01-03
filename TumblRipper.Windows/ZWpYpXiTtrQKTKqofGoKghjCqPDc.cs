// Decompiled with JetBrains decompiler
// Type: ZWpYpXiTtrQKTKqofGoKghjCqPDc
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using MahApps.Metro.Controls;
using MaterialDesignThemes.Wpf;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using TumblRipper.Common;

public class ZWpYpXiTtrQKTKqofGoKghjCqPDc : MetroWindow, IComponentConnector
{
  public AevcykIBNFviTKdCmDfOwkCQxBom aevcykIBNFviTKdCmDfOwkCQxBom_0;
  internal ComboBox comboBox_0;
  internal DialogHost dialogHost_0;
  internal ContentControl contentControl_0;
  private bool bool_0;

  public ZWpYpXiTtrQKTKqofGoKghjCqPDc()
    : this(new Website())
  {
    string text = Clipboard.GetText();
    if (!text.StartsWith("http"))
      return;
    try
    {
      this.aevcykIBNFviTKdCmDfOwkCQxBom_0.Url = text;
    }
    catch (Exception ex)
    {
      this.aevcykIBNFviTKdCmDfOwkCQxBom_0.Url = "";
    }
  }

  public ZWpYpXiTtrQKTKqofGoKghjCqPDc(Website website_0)
  {
    base.\u002Ector();
    this.InitializeComponent();
    this.aevcykIBNFviTKdCmDfOwkCQxBom_0 = ((FrameworkElement) this).DataContext as AevcykIBNFviTKdCmDfOwkCQxBom;
    this.aevcykIBNFviTKdCmDfOwkCQxBom_0.method_5(website_0);
    this.comboBox_0.ItemsSource = (IEnumerable) PluginLoader.GetListPlugins();
  }

  private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs e)
  {
    int count = e.AddedItems.Count;
  }

  private void method_0(object sender, RoutedEventArgs e)
  {
    if (!this.aevcykIBNFviTKdCmDfOwkCQxBom_0.method_8())
      return;
    ((Window) this).Close();
  }

  private async void method_1(object sender, RoutedEventArgs e)
  {
    ZWpYpXiTtrQKTKqofGoKghjCqPDc qktKqofGoKghjCqPdc = this;
    if (qktKqofGoKghjCqPdc.aevcykIBNFviTKdCmDfOwkCQxBom_0.LoadedPlugin != null)
    {
      qktKqofGoKghjCqPdc.dialogHost_0.set_IsOpen(true);
      // ISSUE: reference to a compiler-generated method
      await Task.Factory.StartNew(new Action(qktKqofGoKghjCqPdc.method_3));
      qktKqofGoKghjCqPdc.dialogHost_0.set_IsOpen(false);
    }
  }

  private void method_2(object sender, RoutedEventArgs e)
  {
    CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
    commonOpenFileDialog.set_IsFolderPicker(true);
    if (((CommonFileDialog) commonOpenFileDialog).ShowDialog() != 1)
      return;
    this.aevcykIBNFviTKdCmDfOwkCQxBom_0.Path = ((CommonFileDialog) commonOpenFileDialog).get_FileName();
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  public void InitializeComponent()
  {
    if (this.bool_0)
      return;
    this.bool_0 = true;
    Application.LoadComponent((object) this, new Uri("/TumblRipper.Windows;component/oihqfqiuezppzpmavwbbqoifhblf.xaml", UriKind.Relative));
  }

  [DebuggerNonUserCode]
  [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Never)]
  void IComponentConnector.Connect(int connectionId, object target)
  {
    switch (connectionId)
    {
      case 1:
        this.comboBox_0 = (ComboBox) target;
        this.comboBox_0.SelectionChanged += new SelectionChangedEventHandler(this.comboBox_0_SelectionChanged);
        break;
      case 2:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.method_2);
        break;
      case 3:
        this.dialogHost_0 = (DialogHost) target;
        break;
      case 4:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.method_1);
        break;
      case 5:
        this.contentControl_0 = (ContentControl) target;
        break;
      case 6:
        ((ButtonBase) target).Click += new RoutedEventHandler(this.method_0);
        break;
      default:
        this.bool_0 = true;
        break;
    }
  }
}
