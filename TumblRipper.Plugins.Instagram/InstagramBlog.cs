// Decompiled with JetBrains decompiler
// Type: TumblRipper.Plugins.Instagram.InstagramBlog
// Assembly: TumblRipper.Plugins.Instagram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 33A2707F-B533-4B14-88E0-4B68F738EE55
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Plugins.Instagram.dll

using HtmlAgilityPack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml.Serialization;
using TumblRipper.PluginInterface;

namespace TumblRipper.Plugins.Instagram
{
  public class InstagramBlog : ITrPlugin
  {
    public InstagramSettings TumblrSettings { get; set; }

    public InstagramRipper BlogRipper { get; set; }

    public string GetName()
    {
      return "InstaGram";
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
      return url.Contains("instagram.com");
    }

    public string GetFriendlyUrlTitle(IRipper w, string url)
    {
      try
      {
        string webPage = w.GetWebPage("http://" + url);
        HtmlDocument htmlDocument = new HtmlDocument();
        string str = webPage;
        htmlDocument.LoadHtml(str);
        using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//meta")).GetEnumerator())
        {
          while (((IEnumerator) enumerator).MoveNext())
          {
            HtmlNode current = enumerator.Current;
            if (current.get_Attributes().Contains("property") && !(current.get_Attributes().get_Item("property").get_Value() != "og:title"))
              return current.get_Attributes().get_Item("content").get_Value().Trim().Replace(" • Instagram photos and videos", "");
          }
        }
        return (string) null;
      }
      catch (Exception ex)
      {
        return url;
      }
    }

    public void Init()
    {
    }

    public ITrPlugin NewInstance(IRipper w, string config)
    {
      InstagramBlog instagramBlog = new InstagramBlog();
      this.TumblrSettings = this.readSettings(config);
      InstagramRipper instagramRipper = new InstagramRipper(this);
      instagramRipper.MyRipper = w;
      InstagramSettings tumblrSettings = this.TumblrSettings;
      instagramRipper.Settings = tumblrSettings;
      this.BlogRipper = instagramRipper;
      return (ITrPlugin) instagramBlog;
    }

    public void Start(CancellationToken _cancellationToken)
    {
      this.BlogRipper.Start(_cancellationToken);
    }

    public string GetConfiguration(Dictionary<string, PluginOption> settings)
    {
      return "";
    }

    public Dictionary<string, PluginOption> GetControlPanel(string s)
    {
      InstagramSettings instagramSettings = this.readSettings(s);
      return new Dictionary<string, PluginOption>()
      {
        {
          "Photos",
          (PluginOption) new PluginOptionBoolean("Get Photos", instagramSettings.doPhotos)
        },
        {
          "Videos",
          (PluginOption) new PluginOptionBoolean("Get Videos", instagramSettings.doVideos)
        }
      };
    }

    public InstagramSettings readSettings(string config)
    {
      try
      {
        using (StringReader stringReader = new StringReader(config))
          return new XmlSerializer(typeof (InstagramSettings)).Deserialize((TextReader) stringReader) as InstagramSettings;
      }
      catch (Exception ex)
      {
        return new InstagramSettings();
      }
    }

    public string writeSettings(InstagramSettings settings)
    {
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (InstagramSettings));
      StringWriter stringWriter1 = new StringWriter();
      StringWriter stringWriter2 = stringWriter1;
      InstagramSettings instagramSettings = settings;
      xmlSerializer.Serialize((TextWriter) stringWriter2, (object) instagramSettings);
      stringWriter1.Close();
      return stringWriter1.ToString();
    }
  }
}
