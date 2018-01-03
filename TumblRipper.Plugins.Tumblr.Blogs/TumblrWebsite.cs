// Decompiled with JetBrains decompiler
// Type: TumblRipper.Plugins.Tumblr.Blogs.TumblrWebsite
// Assembly: TumblRipper.Plugins.Tumblr.Blogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DB69105-C82A-4CB2-808D-7DC45E27B2D7
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Plugins.Tumblr.Blogs.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml.Serialization;
using TumblRipper.PluginInterface;

namespace TumblRipper.Plugins.Tumblr.Blogs
{
  public class TumblrWebsite : ITrPlugin
  {
    public TumblrSettings TumblrSettings { get; set; }

    public TumblrBlogRipper BlogRipper { get; set; }

    public TumblrWebsite()
    {
      this.TumblrSettings = new TumblrSettings();
    }

    public string GetName()
    {
      return "Tumblr";
    }

    public TrPluginConfiguration GetInfo()
    {
      return new TrPluginConfiguration()
      {
        HasExtraConfiguration = true,
        Version = 1,
        Author = "ZARk",
        AuthorWebsite = "http://www.zark.be/"
      };
    }

    public bool ValidateUrl(IRipper w, string url)
    {
      return true;
    }

    public string GetFriendlyUrlTitle(IRipper w, string url)
    {
      url.Replace("www.", "");
      try
      {
        TumblrBlogRipper tumblrBlogRipper = new TumblrBlogRipper(this);
        tumblrBlogRipper.MyRipper = w;
        string url1 = url;
        return tumblrBlogRipper.GetTitle(url1);
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    public void Init()
    {
    }

    private TumblrSettings method_0(string string_0)
    {
      try
      {
        using (StringReader stringReader = new StringReader(string_0))
          return new XmlSerializer(typeof (TumblrSettings)).Deserialize((TextReader) stringReader) as TumblrSettings;
      }
      catch (Exception ex)
      {
        return new TumblrSettings();
      }
    }

    public string writeSettings(TumblrSettings settings)
    {
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (TumblrSettings));
      StringWriter stringWriter1 = new StringWriter();
      StringWriter stringWriter2 = stringWriter1;
      TumblrSettings tumblrSettings = settings;
      xmlSerializer.Serialize((TextWriter) stringWriter2, (object) tumblrSettings);
      stringWriter1.Close();
      return stringWriter1.ToString();
    }

    public ITrPlugin NewInstance(IRipper w, string xmlConfig)
    {
      TumblrWebsite tumblrWebsite = new TumblrWebsite();
      this.TumblrSettings = this.method_0(xmlConfig);
      TumblrBlogRipper tumblrBlogRipper = new TumblrBlogRipper(this);
      tumblrBlogRipper.MyRipper = w;
      TumblrSettings tumblrSettings = this.TumblrSettings;
      tumblrBlogRipper.Settings = tumblrSettings;
      this.BlogRipper = tumblrBlogRipper;
      return (ITrPlugin) tumblrWebsite;
    }

    public void Start(CancellationToken _cancellationToken)
    {
      this.BlogRipper.Start(_cancellationToken);
    }

    public Dictionary<string, PluginOption> GetControlPanel(string s)
    {
      Dictionary<string, PluginOption> dictionary = new Dictionary<string, PluginOption>();
      TumblrSettings tumblrSettings = this.method_0(s);
      string key1 = "Photos";
      PluginOptionBoolean pluginOptionBoolean1 = new PluginOptionBoolean("Download Photos", tumblrSettings.DoPhotos);
      dictionary.Add(key1, (PluginOption) pluginOptionBoolean1);
      string key2 = "Videos";
      PluginOptionBoolean pluginOptionBoolean2 = new PluginOptionBoolean("Download Videos", tumblrSettings.DoVideos);
      dictionary.Add(key2, (PluginOption) pluginOptionBoolean2);
      string key3 = "PhotoRaw";
      PluginOptionBoolean pluginOptionBoolean3 = new PluginOptionBoolean("Download Original Photos (Slower)", tumblrSettings.DoPhotoRaw);
      dictionary.Add(key3, (PluginOption) pluginOptionBoolean3);
      string key4 = "OriginalContent";
      PluginOptionBoolean pluginOptionBoolean4 = new PluginOptionBoolean("Download Only Original Content", !tumblrSettings.DoReblogs);
      dictionary.Add(key4, (PluginOption) pluginOptionBoolean4);
      string key5 = "Rename";
      PluginOptionBoolean pluginOptionBoolean5 = new PluginOptionBoolean("Rename files using Post title", tumblrSettings.DoRename);
      dictionary.Add(key5, (PluginOption) pluginOptionBoolean5);
      string key6 = "Tags";
      PluginOptionBoolean pluginOptionBoolean6 = new PluginOptionBoolean("Include Tags in filename", tumblrSettings.DoTags);
      dictionary.Add(key6, (PluginOption) pluginOptionBoolean6);
      string key7 = "Username";
      PluginOptionText pluginOptionText1 = new PluginOptionText("Username", tumblrSettings.Username);
      dictionary.Add(key7, (PluginOption) pluginOptionText1);
      string key8 = "Password";
      PluginOptionText pluginOptionText2 = new PluginOptionText("Password", tumblrSettings.Password);
      dictionary.Add(key8, (PluginOption) pluginOptionText2);
      return dictionary;
    }

    public string GetConfiguration(Dictionary<string, PluginOption> s)
    {
      PluginOptionBoolean pluginOptionBoolean1 = s["Videos"] as PluginOptionBoolean;
      PluginOptionBoolean pluginOptionBoolean2 = s["Rename"] as PluginOptionBoolean;
      PluginOptionBoolean pluginOptionBoolean3 = s["OriginalContent"] as PluginOptionBoolean;
      PluginOptionBoolean pluginOptionBoolean4 = s["Tags"] as PluginOptionBoolean;
      PluginOptionBoolean pluginOptionBoolean5 = s["PhotoRaw"] as PluginOptionBoolean;
      PluginOptionBoolean pluginOptionBoolean6 = s["Photos"] as PluginOptionBoolean;
      PluginOptionText pluginOptionText1 = s["Username"] as PluginOptionText;
      PluginOptionText pluginOptionText2 = s["Password"] as PluginOptionText;
      TumblrSettings tumblrSettings = new TumblrSettings();
      int num1 = pluginOptionBoolean6.Value ? 1 : 0;
      tumblrSettings.DoPhotos = num1 != 0;
      int num2 = 0;
      tumblrSettings.DoPhotoSets = num2 != 0;
      int num3 = pluginOptionBoolean1.Value ? 1 : 0;
      tumblrSettings.DoVideos = num3 != 0;
      int num4 = pluginOptionBoolean2.Value ? 1 : 0;
      tumblrSettings.DoRename = num4 != 0;
      int num5 = !pluginOptionBoolean3.Value ? 1 : 0;
      tumblrSettings.DoReblogs = num5 != 0;
      int num6 = pluginOptionBoolean4.Value ? 1 : 0;
      tumblrSettings.DoTags = num6 != 0;
      string str = "";
      tumblrSettings.FilenameMask = str;
      int num7 = pluginOptionBoolean5.Value ? 1 : 0;
      tumblrSettings.DoPhotoRaw = num7 != 0;
      TumblrSettings settings = tumblrSettings;
      settings.Username = pluginOptionText1.Value;
      settings.Password = pluginOptionText2.Value;
      return this.writeSettings(settings);
    }
  }
}
