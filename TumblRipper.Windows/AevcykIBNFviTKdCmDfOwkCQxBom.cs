// Decompiled with JetBrains decompiler
// Type: AevcykIBNFviTKdCmDfOwkCQxBom
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using TumblRipper.Common;
using TumblRipper.PluginInterface;

public class AevcykIBNFviTKdCmDfOwkCQxBom : INotifyPropertyChanged
{
  private List<string> list_0;
  private bool bool_0;
  private ITrPlugin itrPlugin_0;
  private string string_0;
  private string string_1;
  private string string_2;
  private string string_3;
  private Dictionary<string, PluginOption> dictionary_1;
  private Website website_0;
  private UserControl userControl_0;

  private Dictionary<string, FrameworkElement> _pluginConfigPanel { get; set; }

  public UserControl ExtraPanel
  {
    get
    {
      return this.userControl_0;
    }
    set
    {
      this.userControl_0 = value;
      this.vmethod_0("ExtraPanel");
    }
  }

  public bool Enabled
  {
    get
    {
      return this.bool_0;
    }
    set
    {
      if (value == this.bool_0)
        return;
      this.bool_0 = value;
      this.vmethod_0("Enabled");
    }
  }

  public Visibility PluginSelected
  {
    get
    {
      return !string.IsNullOrEmpty(this.Plugin) ? Visibility.Visible : Visibility.Hidden;
    }
  }

  public string Title
  {
    get
    {
      return this.string_2;
    }
    set
    {
      if (value == this.string_2)
        return;
      this.string_2 = value;
      this.vmethod_0("Title");
    }
  }

  public string Url
  {
    get
    {
      return this.string_3;
    }
    set
    {
      if (value == this.string_3)
        return;
      this.string_3 = this.method_7(value);
      if (string.IsNullOrEmpty(this.Path))
        this.Path = System.IO.Path.Combine(MySettings.Instance.AppSettings.LocalDir, Utils.PathCleaner(this.string_3.Replace("www.", "").Replace("/", "")));
      this.vmethod_0("Url");
    }
  }

  public string Path
  {
    get
    {
      return this.string_0;
    }
    set
    {
      if (value == this.string_0)
        return;
      this.string_0 = value;
      this.vmethod_0("Path");
    }
  }

  public string Plugin
  {
    get
    {
      return this.string_1;
    }
    set
    {
      if (value == this.string_1)
        return;
      this.string_1 = value;
      this.vmethod_0("Plugin");
      this.method_6();
      this.vmethod_0("PluginSelected");
    }
  }

  public List<string> AvailablePlugins
  {
    get
    {
      return this.list_0;
    }
    set
    {
      if (object.Equals((object) value, (object) this.list_0))
        return;
      this.list_0 = value;
      this.vmethod_0("AvailablePlugins");
    }
  }

  public ITrPlugin LoadedPlugin
  {
    get
    {
      return this.itrPlugin_0;
    }
    set
    {
      if (object.Equals((object) value, (object) this.itrPlugin_0))
        return;
      this.itrPlugin_0 = value;
      this.vmethod_0("LoadedPlugin");
    }
  }

  public event PropertyChangedEventHandler PropertyChanged;

  public AevcykIBNFviTKdCmDfOwkCQxBom()
  {
    this.website_0 = new Website();
  }

  public FrameworkElement method_0(string string_4, PluginOptionText pluginOptionText_0)
  {
    StackPanel stackPanel = new StackPanel();
    TextBox textBox = new TextBox();
    textBox.Text = pluginOptionText_0.Value;
    textBox.Name = string_4;
    this._pluginConfigPanel.Add(string_4, (FrameworkElement) textBox);
    stackPanel.Children.Add((UIElement) new TextBlock()
    {
      Text = pluginOptionText_0.Label
    });
    stackPanel.Children.Add((UIElement) textBox);
    return (FrameworkElement) stackPanel;
  }

  public FrameworkElement method_1(string string_4, PluginOptionBoolean pluginOptionBoolean_0)
  {
    CheckBox checkBox = new CheckBox();
    checkBox.Content = (object) pluginOptionBoolean_0.Label;
    checkBox.Name = string_4;
    this._pluginConfigPanel.Add(string_4, (FrameworkElement) checkBox);
    checkBox.IsChecked = new bool?(pluginOptionBoolean_0.Value);
    return (FrameworkElement) checkBox;
  }

  private UIElement method_2(string string_4, PluginOption pluginOption_0)
  {
    if (pluginOption_0 is PluginOptionBoolean)
      return (UIElement) this.method_1(string_4, pluginOption_0 as PluginOptionBoolean);
    if (pluginOption_0 is PluginOptionText)
      return (UIElement) this.method_0(string_4, pluginOption_0 as PluginOptionText);
    return (UIElement) null;
  }

  public UserControl method_3(ITrPlugin itrPlugin_1)
  {
    UserControl userControl = new UserControl();
    StackPanel stackPanel = new StackPanel();
    foreach (KeyValuePair<string, PluginOption> keyValuePair in this.dictionary_1)
      stackPanel.Children.Add(this.method_2(keyValuePair.Key, keyValuePair.Value));
    userControl.Content = (object) stackPanel;
    return userControl;
  }

  public Dictionary<string, PluginOption> method_4(UserControl userControl_1)
  {
    foreach (KeyValuePair<string, PluginOption> keyValuePair in this.dictionary_1)
    {
      FrameworkElement frameworkElement = this._pluginConfigPanel[keyValuePair.Key];
      if (frameworkElement is CheckBox)
        (keyValuePair.Value as PluginOptionBoolean).Value = (frameworkElement as CheckBox).IsChecked.Value;
      if (frameworkElement is TextBox)
        (keyValuePair.Value as PluginOptionText).Value = (frameworkElement as TextBox).Text;
    }
    return this.dictionary_1;
  }

  public void method_5(Website website_1)
  {
    this.website_0 = website_1;
    this.Title = website_1.Title;
    this.Path = website_1.LocalDir;
    this.Url = website_1.Url;
    this.Plugin = website_1.PluginInName;
    this.Enabled = website_1.Enabled;
  }

  public void method_6()
  {
    this._pluginConfigPanel = new Dictionary<string, FrameworkElement>();
    this.LoadedPlugin = PluginLoader.GetPlugin(this.Plugin);
    this.dictionary_1 = this.LoadedPlugin.GetControlPanel(MySettings.Instance.LoadPluginSettingsFile(this.website_0.PluginSettingsFilePath));
    this.ExtraPanel = this.method_3(this.LoadedPlugin);
  }

  [GAttribute8]
  protected virtual void vmethod_0([CallerMemberName] string string_4 = null)
  {
    // ISSUE: reference to a compiler-generated field
    PropertyChangedEventHandler changedEventHandler = this.propertyChangedEventHandler_0;
    if (changedEventHandler == null)
      return;
    PropertyChangedEventArgs e = new PropertyChangedEventArgs(string_4);
    changedEventHandler((object) this, e);
  }

  private string method_7(string string_4)
  {
    string_4 = string_4.Replace("http://", "");
    string_4 = string_4.Replace("https://", "");
    string_4 = string_4.TrimEnd('/');
    return string_4;
  }

  public bool method_8()
  {
    if (this.itrPlugin_0 == null)
      return false;
    this.Enabled = true;
    this.website_0.Enabled = this.Enabled;
    this.website_0.Url = this.Url;
    this.website_0.PluginInName = this.itrPlugin_0.GetName();
    this.website_0.Title = this.Title;
    this.website_0.Init(this.Path);
    MySettings.Instance.SaveWebsite(this.website_0);
    MySettings.Instance.SavePluginSettingsFiles(this.itrPlugin_0.GetConfiguration(this.method_4(this.ExtraPanel)), this.website_0.PluginSettingsFilePath);
    if (!MySettings.Instance.WebsiteFilePaths.Contains(this.website_0.LocalDir))
    {
      MySettings.Instance.WebsiteFilePaths.Add(this.website_0.LocalDir);
      MySettings.Instance.SaveWebsites();
      gImazEYxmUxzXBeWouOTNYaHQdxr.gImazEYxmUxzXBeWouOTNYaHQdxr_0.Websites.Add(this.website_0);
    }
    return true;
  }
}
