// Decompiled with JetBrains decompiler
// Type: TumblRipper.Plugins.Tumblr.Blogs.TumblrBlogRipper
// Assembly: TumblRipper.Plugins.Tumblr.Blogs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3DB69105-C82A-4CB2-808D-7DC45E27B2D7
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Plugins.Tumblr.Blogs.dll

using HtmlAgilityPack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using TumblRipper.PluginInterface;
using TumblRipper.Plugins.Tumblr.Common;

namespace TumblRipper.Plugins.Tumblr.Blogs
{
  public class TumblrBlogRipper
  {
    private List<Cookie> list_0 = new List<Cookie>();
    private TumblrWebsite tumblrWebsite_0;
    public string _url;
    private CancellationToken cancellationToken_0;

    public IRipper MyRipper { get; set; }

    public TumblrSettings Settings { get; set; }

    public TumblrBlogRipper(TumblrWebsite tumblrWebsite_1)
    {
      this.tumblrWebsite_0 = tumblrWebsite_1;
    }

    public void Start(CancellationToken _token)
    {
      this.method_2(_token);
    }

    private bool method_0(string string_0)
    {
      try
      {
        if (this.method_11(0).Contains("dashboard-context"))
          return true;
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    private bool method_1()
    {
      try
      {
        string str = this.method_11(0);
        if (str.Contains("dashboard-context"))
        {
          this.MyRipper.UpdateStatusText("Not rippable yet");
          return false;
        }
        if (str.Contains("data-status-code=\"404\""))
        {
          this.MyRipper.UpdateStatusText("Blog not found");
          return false;
        }
        if (str.Contains("safe_mode"))
        {
          this.MyRipper.UpdateStatusText("Need Login/Pass");
          return false;
        }
      }
      catch (Exception ex)
      {
        this.MyRipper.UpdateStatusText(ex.Message);
        return false;
      }
      return true;
    }

    private void method_2(CancellationToken cancellationToken_1)
    {
      if (this.MyRipper.History.Count == 0)
        this.Settings.LastTs = -1;
      this.cancellationToken_0 = cancellationToken_1;
      if (!string.IsNullOrWhiteSpace(this.Settings.Username))
      {
        this.MyRipper.UpdateStatusText("Login In progress with user " + this.Settings.Username);
        this.list_0 = new List<Cookie>((IEnumerable<Cookie>) TumblrLogin.Login(this.MyRipper, this.Settings.Username, this.Settings.Password));
      }
      this._url = this.MyRipper.Website.Url;
      this._url = this.method_12();
      if (!this.method_1())
        return;
      if (this.Settings.LastTs == -1)
        this.method_13();
      else
        this.method_14(this.Settings.LastTs, false);
      this.MyRipper.UpdateStatusText("Indexing done");
      this.MyRipper.SaveHistory();
      this.MyRipper.SavePostsFound();
      this.MyRipper.SaveSettings(this.tumblrWebsite_0.writeSettings(this.Settings));
      this.MyRipper.UpdateStatusText("Downloading ...");
      this.method_4();
      if (this.cancellationToken_0.IsCancellationRequested)
      {
        while (this.MyRipper.ActiveThreads.Count > 0)
        {
          this.MyRipper.UpdateStatusText(string.Format("Stopping ... {0} left", (object) this.MyRipper.ActiveThreads.Count));
          try
          {
            Thread.Sleep(500);
          }
          catch
          {
          }
        }
        this.MyRipper.SaveFailed();
        this.MyRipper.SavePostsFound();
        this.MyRipper.SaveHistory();
        this.MyRipper.UpdateStatusText("Cancelled");
      }
      else
      {
        int num = 0;
        while (this.MyRipper.FailedPosts.Count > 0 && num < 2)
        {
          this.MyRipper.UpdateStatusText(string.Format("Got {0} errors. Retrying {1}/3", (object) this.MyRipper.FailedPosts.Count, (object) (num + 1)));
          this.MyRipper.SaveFailed();
          this.method_17();
          this.MyRipper.SaveFailed();
          ++num;
          Thread.Sleep(1000);
        }
        if (this.MyRipper.FailedPosts.Count > 0)
          this.MyRipper.UpdateStatusText(string.Format("done with {0} errors", (object) this.MyRipper.FailedPosts.Count));
        else
          this.MyRipper.UpdateStatusText("done");
        this.MyRipper.SaveFailed();
        this.MyRipper.SavePostsFound();
      }
    }

    private List<KeyValuePair<string, string>> method_3(string string_0)
    {
      if (string_0 == null)
        return new List<KeyValuePair<string, string>>();
      HtmlDocument htmlDocument = new HtmlDocument();
      string str1 = string_0;
      htmlDocument.LoadHtml(str1);
      List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
      using (IEnumerator<HtmlNode> enumerator1 = ((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//div")).GetEnumerator())
      {
        while (((IEnumerator) enumerator1).MoveNext())
        {
          HtmlNode current1 = enumerator1.Current;
          if (current1.get_Attributes().Contains("class"))
          {
            string str2 = current1.get_Attributes().get_Item("class").get_Value();
            if (str2.Contains("post_micro") && (str2.Contains("is_photo") || str2.Contains("is_video")))
            {
              string key = "";
              using (IEnumerator<HtmlNode> enumerator2 = ((IEnumerable<HtmlNode>) current1.SelectNodes(".//a")).GetEnumerator())
              {
                while (((IEnumerator) enumerator2).MoveNext())
                {
                  HtmlNode current2 = enumerator2.Current;
                  if (current2.get_Attributes().Contains("class") && !(current2.get_Attributes().get_Item("class").get_Value() != "hover"))
                  {
                    key = current2.get_Attributes().get_Item("href").get_Value();
                    break;
                  }
                }
              }
              list.Add(new KeyValuePair<string, string>(key, key));
            }
          }
        }
      }
      return list;
    }

    private void method_4()
    {
      this.MyRipper.DownloadPostsFound(this.cancellationToken_0);
    }

    private List<IFileToDownload> method_5(string string_0)
    {
      if (string_0 == null)
        return new List<IFileToDownload>();
      HtmlDocument htmlDocument = new HtmlDocument();
      string str = string_0;
      htmlDocument.LoadHtml(str);
      List<IFileToDownload> list = new List<IFileToDownload>();
      using (IEnumerator<HtmlNode> enumerator1 = Enumerable.Where<HtmlNode>((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//div"), (Func<HtmlNode, bool>) (htmlNode_0 =>
      {
        if (htmlNode_0.get_Attributes().Contains("class"))
          return htmlNode_0.get_Attributes().get_Item("class").get_Value().Contains("post_micro");
        return false;
      })).GetEnumerator())
      {
        while (((IEnumerator) enumerator1).MoveNext())
        {
          HtmlNode current1 = enumerator1.Current;
          this.cancellationToken_0.ThrowIfCancellationRequested();
          if (current1.get_Attributes().Contains("class") && current1.get_Attributes().get_Item("class").get_Value().Contains("post_micro"))
          {
            using (IEnumerator<HtmlNode> enumerator2 = ((IEnumerable<HtmlNode>) current1.SelectNodes(".//a")).GetEnumerator())
            {
              while (((IEnumerator) enumerator2).MoveNext())
              {
                HtmlNode current2 = enumerator2.Current;
                if (current2.get_Attributes().Contains("class") && current2.get_Attributes().Contains("href"))
                {
                  string webPage = this.MyRipper.GetWebPage(current2.get_Attributes().get_Item("href").get_Value(), ref this.list_0);
                  list.AddRange((IEnumerable<IFileToDownload>) this.method_7(webPage));
                }
              }
            }
          }
        }
      }
      return list;
    }

    private List<string> method_6(string string_0)
    {
      List<string> list = new List<string>();
      if (string_0 == null)
        return (List<string>) null;
      HtmlDocument htmlDocument = new HtmlDocument();
      string str1 = string_0;
      htmlDocument.LoadHtml(str1);
      using (IEnumerator<HtmlNode> enumerator = Enumerable.Where<HtmlNode>((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//img"), (Func<HtmlNode, bool>) (htmlNode_0 => htmlNode_0.get_Attributes().Contains("src"))).GetEnumerator())
      {
        while (((IEnumerator) enumerator).MoveNext())
        {
          string str2 = enumerator.Current.get_Attributes().get_Item("src").get_Value();
          list.Add(str2);
        }
      }
      return list;
    }

    private List<IFileToDownload> method_7(string string_0)
    {
      List<IFileToDownload> list1 = new List<IFileToDownload>();
      HtmlDocument htmlDocument = new HtmlDocument();
      if (string_0 == null)
        return (List<IFileToDownload>) null;
      htmlDocument.LoadHtml(string_0);
      string str1 = "empty";
      string str2 = string.Empty;
      string str3 = string.Empty;
      using (IEnumerator<HtmlNode> enumerator = Enumerable.Where<HtmlNode>((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//meta"), (Func<HtmlNode, bool>) (htmlNode_0 =>
      {
        if (htmlNode_0.get_Attributes().Contains("property"))
          return htmlNode_0.get_Attributes().get_Item("property").get_Value().Contains("og:");
        return false;
      })).GetEnumerator())
      {
        while (((IEnumerator) enumerator).MoveNext())
        {
          HtmlNode current = enumerator.Current;
          string str4 = current.get_Attributes().get_Item("property").get_Value();
          string str5 = "og:type";
          if (str4.Contains(str5))
            str1 = current.get_Attributes().get_Item("content").get_Value().Replace("tumblr-feed:", "");
          string str6 = "og:title";
          if (str4.Contains(str6))
            str2 = WebUtility.HtmlDecode(current.get_Attributes().get_Item("content").get_Value());
          string str7 = "og:description";
          if (str4.Contains(str7))
            str2 = WebUtility.HtmlDecode(current.get_Attributes().get_Item("content").get_Value());
        }
      }
      if (str2.Length == 0)
        str2 = str3;
      if (str1.Equals("empty"))
        return (List<IFileToDownload>) null;
      if (str1.Equals("photoset"))
      {
        HtmlNode htmlNode = Enumerable.FirstOrDefault<HtmlNode>((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//iframe"));
        if (htmlNode == null)
          return (List<IFileToDownload>) null;
        if (!htmlNode.get_Attributes().Contains("src"))
          return (List<IFileToDownload>) null;
        string url = htmlNode.get_Attributes().get_Item("src").get_Value();
        if (!url.StartsWith("http"))
          url = "http://www.tumblr.com" + url;
        List<string> list2 = this.method_6(this.MyRipper.GetWebPage(url));
        int num = 0;
        foreach (string str4 in list2)
        {
          string filename = this.method_9(str4, str2 + (object) "_" + (string) (object) num++, "");
          list1.Add(this.MyRipper.NewDownloadFile(str4, filename));
        }
        this.MyRipper.UpdateStatusText("Photoset " + str2);
      }
      return list1;
    }

    private List<IFileToDownload> method_8(string string_0)
    {
      if (string_0 == null)
        return new List<IFileToDownload>();
      HtmlDocument htmlDocument = new HtmlDocument();
      string str1 = string_0;
      htmlDocument.LoadHtml(str1);
      List<IFileToDownload> list = new List<IFileToDownload>();
      using (IEnumerator<HtmlNode> enumerator1 = ((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//div")).GetEnumerator())
      {
        while (((IEnumerator) enumerator1).MoveNext())
        {
          HtmlNode current1 = enumerator1.Current;
          if (current1.get_Attributes().Contains("class"))
          {
            string string_1 = (string) null;
            string str2 = current1.get_Attributes().get_Item("class").get_Value();
            if (str2.Contains("post_micro"))
            {
              string str3;
              if (str2.Contains("is_photo"))
                str3 = "photo";
              else if (str2.Contains("is_video"))
                str3 = "video";
              else
                continue;
              if (this.Settings.DoReblogs || str2.Contains("is_original"))
              {
                string key = "";
                using (IEnumerator<HtmlNode> enumerator2 = ((IEnumerable<HtmlNode>) current1.SelectNodes(".//a")).GetEnumerator())
                {
                  while (((IEnumerator) enumerator2).MoveNext())
                  {
                    HtmlNode current2 = enumerator2.Current;
                    if (current2.get_Attributes().Contains("class") && !(current2.get_Attributes().get_Item("class").get_Value() != "hover"))
                    {
                      key = current2.get_Attributes().get_Item("href").get_Value();
                      string_1 = WebUtility.HtmlDecode(key.Substring(key.IndexOf("/post/", StringComparison.InvariantCultureIgnoreCase) + 6).Replace("/", " "));
                      break;
                    }
                  }
                }
                long num = long.Parse(current1.get_Attributes().get_Item("id").get_Value().Replace("post_micro_", ""));
                string str4 = string.Empty;
                string str5 = Enumerable.FirstOrDefault<string>(Enumerable.Select<HtmlNode, string>(Enumerable.Where<HtmlNode>((IEnumerable<HtmlNode>) current1.SelectNodes(".//span"), (Func<HtmlNode, bool>) (htmlNode_0 =>
                {
                  if (htmlNode_0.get_Attributes().Contains("class"))
                    return htmlNode_0.get_Attributes().get_Item("class").get_Value().Contains("tags");
                  return false;
                })), (Func<HtmlNode, string>) (htmlNode_0 => htmlNode_0.get_InnerText())));
                string string_2 = str5 == null ? string.Empty : WebUtility.HtmlDecode(str5.Trim().Replace("\r", "").Replace("\n", ""));
                if (str3 == "video" && this.Settings.DoVideos)
                {
                  if (current1.get_Attributes().get_Item("class").get_Value().Contains("is_direct_video"))
                  {
                    using (IEnumerator<HtmlNode> enumerator2 = ((IEnumerable<HtmlNode>) current1.SelectNodes(".//div")).GetEnumerator())
                    {
                      while (((IEnumerator) enumerator2).MoveNext())
                      {
                        HtmlNode current2 = enumerator2.Current;
                        if (current2.get_Attributes().get_Item("class").get_Value().Contains("has_imageurl"))
                        {
                          string str6 = current2.get_Attributes().get_Item("data-imageurl").get_Value();
                          if (str6.Length >= 1)
                          {
                            string[] strArray = str6.Split('/');
                            int index = strArray.Length - 1;
                            string str7 = strArray[index].Split('_')[1];
                            string str8 = string.Concat(new object[4]
                            {
                              (object) "http://www.tumblr.com/video_file/",
                              (object) num,
                              (object) "/tumblr_",
                              (object) str7
                            });
                            string str9 = this.method_9(str8, string_1, string_2);
                            list.Add(this.MyRipper.NewDownloadFile(str8, str9 + ".mp4", key));
                          }
                        }
                      }
                    }
                  }
                  else
                    continue;
                }
                if (str3 == "photo" && this.Settings.DoPhotos)
                {
                  using (IEnumerator<HtmlNode> enumerator2 = ((IEnumerable<HtmlNode>) current1.SelectNodes(".//div")).GetEnumerator())
                  {
                    while (((IEnumerator) enumerator2).MoveNext())
                    {
                      HtmlNode current2 = enumerator2.Current;
                      if (current2.get_Attributes().get_Item("class").get_Value().Contains("has_imageurl"))
                      {
                        string str6 = current2.get_Attributes().get_Item("data-imageurl").get_Value();
                        if (!str6.Contains("assets.tumblr.com"))
                        {
                          string str7 = str6.Replace("src=", "").Replace("\"", "").Trim().Replace("_250.", "_1280.");
                          if (this.Settings.DoPhotoRaw)
                          {
                            string str8 = str7.Replace("_1280.", "_raw.");
                            str7 = "http://" + str8.Substring(str8.IndexOf("media.tumblr.com"));
                          }
                          string filename = this.method_9(str7, string_1, string_2);
                          list.Add(this.MyRipper.NewDownloadFile(str7, filename, str7));
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
      return list;
    }

    private string method_9(string string_0, string string_1, string string_2)
    {
      string path = Path.GetFileName(new Uri(string_0).LocalPath);
      string extension = Path.GetExtension(path);
      if (this.Settings.DoRename && string_1.Length > 0)
      {
        string_1 = WebUtility.HtmlDecode(string_1);
        string_1 = string_1.Replace("-", " ");
        path = this.MyRipper.MakeValidFileName(string_1) + extension;
      }
      if (!this.Settings.DoTags)
        return path;
      if (string.IsNullOrWhiteSpace(extension))
        return path + " " + string_2;
      return path.Replace(extension, " " + string_2 + extension);
    }

    private void method_10(string string_0)
    {
      string str1 = (string) null;
      try
      {
        this.MyRipper.GetWebPage(string_0, ref this.list_0);
      }
      catch (WebException ex)
      {
        HtmlDocument htmlDocument = new HtmlDocument();
        if (str1 == null)
          return;
        htmlDocument.LoadHtml(str1);
        string[] strArray = string_0.Replace("http://", "").Split('/');
        string oldValue = "http://" + strArray[0] + "/video_file/" + strArray[2];
        string str2 = strArray[2];
        string name = (string) null;
        using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//meta")).GetEnumerator())
        {
          while (((IEnumerator) enumerator).MoveNext())
          {
            HtmlNode current = enumerator.Current;
            if (current.get_Attributes().Contains("name") && current.get_Attributes().get_Item("name").get_Value().Equals("description"))
            {
              name = current.get_Attributes().get_Item("content").get_Value();
              name = WebUtility.HtmlDecode(name);
              name = this.MyRipper.MakeValidFileName(name);
            }
          }
        }
        string str3 = name.Length <= 0 ? str2 : str2 + " - " + name;
        int startIndex = str1.IndexOf(oldValue);
        if (startIndex > -1)
        {
          int num = str1.IndexOf("\\x22", startIndex);
          string str4 = str1.Substring(startIndex, num - startIndex).Replace(oldValue, "http://vt.tumblr.com") + ".mp4";
        }
        htmlDocument.get_DocumentNode().SelectNodes("//iframe");
        bool flag = false;
        using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//meta")).GetEnumerator())
        {
          while (((IEnumerator) enumerator).MoveNext())
          {
            HtmlNode current = enumerator.Current;
            if (current.get_Attributes().Contains("property") && current.get_Attributes().get_Item("property").get_Value().Contains("og:image"))
            {
              Path.GetExtension(current.get_Attributes().get_Item("content").get_Value());
              flag = true;
            }
          }
        }
        HtmlNodeCollection htmlNodeCollection = htmlDocument.get_DocumentNode().SelectNodes("//div");
        if (htmlNodeCollection != null && !flag)
        {
          using (IEnumerator<HtmlNode> enumerator1 = ((IEnumerable<HtmlNode>) htmlNodeCollection).GetEnumerator())
          {
            while (((IEnumerator) enumerator1).MoveNext())
            {
              HtmlNode current1 = enumerator1.Current;
              if (current1.get_Attributes().Contains("class"))
              {
                string str4 = current1.get_Attributes().get_Item("class").get_Value();
                if (str4.Contains("photo") && str4.Contains("post"))
                {
                  using (IEnumerator<HtmlNode> enumerator2 = ((IEnumerable<HtmlNode>) current1.SelectNodes("//img")).GetEnumerator())
                  {
                    while (((IEnumerator) enumerator2).MoveNext())
                    {
                      HtmlNode current2 = enumerator2.Current;
                      if (current2.get_Attributes().Contains("src"))
                      {
                        Path.GetExtension(current2.get_Attributes().get_Item("src").get_Value());
                        break;
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }

    private string method_11(int int_0)
    {
      Console.WriteLine("Loading page : " + (object) int_0);
      string url = "http://" + this._url + "/archive";
      if (int_0 > 0)
        url = url + (object) "?before_time=" + (string) (object) int_0;
      return this.MyRipper.GetWebPage(url, ref this.list_0);
    }

    private string method_12()
    {
      try
      {
        string str1 = this.method_11(0);
        HtmlDocument htmlDocument = new HtmlDocument();
        string str2 = str1;
        htmlDocument.LoadHtml(str2);
        using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//frame")).GetEnumerator())
        {
          while (((IEnumerator) enumerator).MoveNext())
          {
            HtmlNode current = enumerator.Current;
            if (current.get_Attributes().Contains("name") && current.get_Attributes().get_Item("name").get_Value().Equals("redir"))
              return current.get_Attributes().get_Item("src").get_Value().Replace("http://", "").Replace("/archive", "").Replace("/", "");
          }
        }
      }
      catch (Exception ex)
      {
      }
      return this.MyRipper.Website.Url;
    }

    private void method_13()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      TumblrBlogRipper.Class11 class11 = new TumblrBlogRipper.Class11();
      // ISSUE: reference to a compiler-generated field
      class11.tumblrBlogRipper_0 = this;
      string string_0 = this.method_11(0);
      string webPage = this.MyRipper.GetWebPage("http://" + this._url + this.method_15(string_0), ref this.list_0);
      int num1 = this.method_16(string_0);
      int num2 = this.method_16(webPage);
      int num3 = (int) Math.Round((double) (num1 - num2) / 10.0);
      List<Task> list = new List<Task>();
      // ISSUE: reference to a compiler-generated field
      class11.int_0 = 0;
      // ISSUE: reference to a compiler-generated field
      this.MyRipper.UpdatePercentageComplete(class11.int_0);
      if (num3 > 0)
      {
        int num4 = num2;
        while (num4 <= num1 + num3)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          TumblrBlogRipper.Class12 class12 = new TumblrBlogRipper.Class12();
          // ISSUE: reference to a compiler-generated field
          class12.class11_0 = class11;
          Console.WriteLine("Threads : " + (object) list.Count);
          // ISSUE: reference to a compiler-generated field
          class12.int_0 = num4;
          // ISSUE: reference to a compiler-generated method
          list.Add(Task.Factory.StartNew(new Action(class12.method_0)));
          num4 += num3;
        }
      }
      Task.WaitAll(list.ToArray());
      this.cancellationToken_0.ThrowIfCancellationRequested();
      this.MyRipper.UpdatePercentageComplete(100);
      this.Settings.LastTs = num1;
      this.method_14(0, true);
    }

    private void method_14(int int_0, bool bool_0)
    {
      int num = 0;
      while (int_0 > -1)
      {
        this.cancellationToken_0.ThrowIfCancellationRequested();
        string string_0 = this.method_11(int_0);
        if (string_0 != null)
        {
          int_0 = this.method_16(string_0);
          List<IFileToDownload> list = !this.Settings.DoPhotoSets ? this.method_8(string_0) : this.method_5(string_0);
          bool flag = false;
          foreach (IFileToDownload fileToDownload in list)
          {
            IList<IFileToDownload> history = this.MyRipper.History;
            bool lockTaken1 = false;
            try
            {
              Monitor.Enter((object) history, ref lockTaken1);
              if (!this.MyRipper.History.Contains(fileToDownload))
              {
                System.Collections.Generic.Queue<IFileToDownload> postsFound = this.MyRipper.PostsFound;
                bool lockTaken2 = false;
                try
                {
                  Monitor.Enter((object) postsFound, ref lockTaken2);
                  this.MyRipper.PostsFound.Enqueue(fileToDownload);
                }
                finally
                {
                  if (lockTaken2)
                    Monitor.Exit((object) postsFound);
                }
                this.MyRipper.History.Add(fileToDownload);
              }
              else
                flag = true;
            }
            finally
            {
              if (lockTaken1)
                Monitor.Exit((object) history);
            }
          }
          this.MyRipper.UpdateStatusText("indexing ...");
          this.MyRipper.UpdateStatusTotalPosts(this.MyRipper.History.Count);
          if (bool_0 && this.MyRipper.History.Count - num > 500)
          {
            num = this.MyRipper.History.Count;
            this.Settings.LastTs = int_0;
            this.MyRipper.SaveSettings(this.tumblrWebsite_0.writeSettings(this.Settings));
            this.MyRipper.SaveHistory();
          }
          if (flag)
            break;
        }
      }
    }

    private string method_15(string string_0)
    {
      if (string_0 == null)
        return (string) null;
      int num1 = int.MaxValue;
      string str1 = (string) null;
      try
      {
        HtmlDocument htmlDocument = new HtmlDocument();
        string str2 = string_0;
        htmlDocument.LoadHtml(str2);
        using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectSingleNode("//div[@id='browse_months_widget']").SelectNodes("//a")).GetEnumerator())
        {
          while (((IEnumerator) enumerator).MoveNext())
          {
            HtmlNode current = enumerator.Current;
            if (current.get_Attributes().Contains("href"))
            {
              string str3 = current.get_Attributes().get_Item("href").get_Value();
              if (str3.Contains("/archive/"))
              {
                string[] strArray = str3.Replace("/archive/", "").Split('/');
                int index1 = 0;
                int num2 = int.Parse(strArray[index1]);
                int index2 = 1;
                int num3 = int.Parse(strArray[index2]);
                int num4 = num2 * 12 + num3;
                if (num4 < num1)
                {
                  str1 = str3;
                  num1 = num4;
                }
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
      }
      return str1;
    }

    private int method_16(string string_0)
    {
      if (string_0 == null)
        return -1;
      try
      {
        HtmlDocument htmlDocument = new HtmlDocument();
        string str = string_0;
        htmlDocument.LoadHtml(str);
        return int.Parse(htmlDocument.get_DocumentNode().SelectSingleNode("//a[@id='next_page_link']").get_Attributes().get_Item("href").get_Value().Split('?')[1].Replace("before_time=", ""));
      }
      catch (Exception ex)
      {
        return -1;
      }
    }

    private void method_17()
    {
      List<string> list = new List<string>()
      {
        "1280",
        "500",
        "400",
        "250"
      };
      foreach (IFileToDownloadFailed toDownloadFailed in (IEnumerable<IFileToDownloadFailed>) this.MyRipper.FailedPosts)
      {
        if (toDownloadFailed.ErrorCode == FileToDownloadStatusCodes.NotFound)
        {
          if (toDownloadFailed.Retry < list.Count)
          {
            toDownloadFailed.Url = toDownloadFailed.Key.Replace("_raw", "_" + list[toDownloadFailed.Retry]);
            this.MyRipper.PostsFound.Enqueue((IFileToDownload) toDownloadFailed);
          }
        }
        else if (toDownloadFailed.Retry < 5)
          this.MyRipper.PostsFound.Enqueue((IFileToDownload) toDownloadFailed);
        ++toDownloadFailed.Retry;
      }
      this.MyRipper.DownloadPostsFound(this.cancellationToken_0);
    }

    public string GetTitle(string url)
    {
      return this.method_18(url);
    }

    private string method_18(string string_0)
    {
      try
      {
        string str1 = string_0.Replace("www.", "").Split('.')[0];
        string webPage = this.MyRipper.GetWebPage("http://" + string_0 + "/archive", ref this.list_0);
        HtmlDocument htmlDocument = new HtmlDocument();
        string str2 = webPage;
        htmlDocument.LoadHtml(str2);
        using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//h1")).GetEnumerator())
        {
          while (((IEnumerator) enumerator).MoveNext())
          {
            HtmlNode current = enumerator.Current;
            if (current.get_Attributes().Contains("class") && current.get_Attributes().get_Item("class").get_Value() == "blog_title")
              return WebUtility.HtmlDecode(current.get_InnerText().Replace("&nbsp;", "").Trim());
          }
        }
        return str1;
      }
      catch (Exception ex)
      {
        return (string) null;
      }
    }
  }
}
