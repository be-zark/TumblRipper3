// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.Ripper
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using TumblRipper.PluginInterface;

namespace TumblRipper.Common
{
  public class Ripper : IRipper
  {
    private readonly string string_0;

    public int GetPostsFound
    {
      get
      {
        System.Collections.Generic.Queue<IFileToDownload> postsFound = this.PostsFound;
        bool lockTaken = false;
        try
        {
          Monitor.Enter((object) postsFound, ref lockTaken);
          return this.PostsFound.Count;
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit((object) postsFound);
        }
      }
    }

    public int GetActiveThreadCount
    {
      get
      {
        IList<Thread> activeThreads = this.ActiveThreads;
        bool lockTaken = false;
        try
        {
          Monitor.Enter((object) activeThreads, ref lockTaken);
          return this.ActiveThreads.Count;
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit((object) activeThreads);
        }
      }
    }

    public StatusObject Status
    {
      get
      {
        return ((TumblRipper.Common.Website) this.Website).Status;
      }
    }

    public IList<IFileToDownloadFailed> FailedPosts { get; set; }

    public IList<Thread> ActiveThreads { get; set; }

    public IList<IFileToDownload> History { get; set; }

    public System.Collections.Generic.Queue<IFileToDownload> PostsFound { get; set; }

    public IWebsite Website { get; set; }

    public int MaxThreads { get; set; }

    public Ripper(IWebsite iwebsite_1)
    {
      this.ActiveThreads = (IList<Thread>) new List<Thread>();
      this.History = MySettings.Instance.LoadHistoryFile(iwebsite_1.HistoryFilePath);
      this.FailedPosts = (IList<IFileToDownloadFailed>) Enumerable.ToList<IFileToDownloadFailed>(Enumerable.Cast<IFileToDownloadFailed>((IEnumerable) MySettings.Instance.LoadHistoryFile(iwebsite_1.FailedFilePath)));
      this.PostsFound = new System.Collections.Generic.Queue<IFileToDownload>((IEnumerable<IFileToDownload>) MySettings.Instance.LoadHistoryFile(iwebsite_1.PendingFilePath));
      this.string_0 = iwebsite_1.LocalDir;
      this.Website = iwebsite_1;
      this.MaxThreads = 15;
      this.UpdateStatusTotalPosts(this.History.Count);
      this.UpdateStatusPendingPosts(this.PostsFound.Count);
      this.UpdateStatusFailedPosts(this.FailedPosts.Count);
    }

    public FileToDownloadStatusCodes DownloadFile(IFileToDownload myfile)
    {
      string str = Path.Combine(this.string_0, myfile.Filename);
      MyWebClient myWebClient = new MyWebClient();
      FileToDownloadStatusCodes downloadStatusCodes = FileToDownloadStatusCodes.OK;
      try
      {
        myWebClient.AllowAutoRedirect = true;
        myWebClient.DownloadFile(myfile.Url, str);
      }
      catch (WebException ex)
      {
        HttpWebResponse httpWebResponse = (HttpWebResponse) ex.Response;
        downloadStatusCodes = httpWebResponse != null ? (FileToDownloadStatusCodes) httpWebResponse.StatusCode : FileToDownloadStatusCodes.UnknownError;
      }
      catch (Exception ex)
      {
        downloadStatusCodes = FileToDownloadStatusCodes.UnknownError;
      }
      if (downloadStatusCodes == FileToDownloadStatusCodes.OK)
      {
        if (!System.IO.File.Exists(str))
          return FileToDownloadStatusCodes.FileNotDownloaded;
        try
        {
          if (new FileInfo(str).Length < 1L)
            downloadStatusCodes = FileToDownloadStatusCodes.FileDownloadedButEmpty;
        }
        catch (Exception ex)
        {
          downloadStatusCodes = FileToDownloadStatusCodes.FileUnknownError;
        }
        WebHeaderCollection responseHeaders = myWebClient.ResponseHeaders;
        DateTime creationTime = DateTime.Now;
        for (int index = 0; index < responseHeaders.Count; ++index)
        {
          if (responseHeaders.GetKey(index).Equals("Last-Modified"))
            creationTime = DateTime.Parse(responseHeaders.Get(index));
        }
        try
        {
          System.IO.File.SetCreationTime(str, creationTime);
        }
        catch (Exception ex)
        {
        }
      }
      if (myWebClient != null)
        myWebClient.Dispose();
      return downloadStatusCodes;
    }

    public string MakeValidFileName(string name)
    {
      string pattern = string.Format("([{0}]*\\.+$)|([{0}]+)", (object) Regex.Escape(new string(Path.GetInvalidFileNameChars())));
      return Regex.Replace(name, pattern, "_");
    }

    public string GetWebPage(string url)
    {
      List<Cookie> cookies = new List<Cookie>();
      return this.GetWebPage(url, ref cookies);
    }

    public string GetWebPage(string url, ref List<Cookie> cookies)
    {
      string str = (string) null;
      using (MyWebClient myWebClient = new MyWebClient())
      {
        myWebClient.AllowAutoRedirect = true;
        myWebClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36");
        if (cookies != null && cookies.Count > 0)
        {
          myWebClient.cookies = new CookieContainer(cookies.Count);
          foreach (Cookie cookie in cookies)
            myWebClient.cookies.Add(cookie);
        }
        try
        {
          byte[] bytes = myWebClient.DownloadData(url);
          if (cookies != null)
          {
            foreach (Cookie cookie in myWebClient.ResponseCookies)
              cookies.Add(cookie);
          }
          str = Encoding.UTF8.GetString(bytes);
          int num = (int) myWebClient.StatusCode();
          if (str.Contains("Rate limit exceeded"))
            throw new Exception("Rate limit exceeded !!!");
        }
        catch (Exception ex)
        {
          str = (string) null;
        }
      }
      return str;
    }

    public string PostWebPage(string url, NameValueCollection param)
    {
      List<Cookie> cookies = new List<Cookie>();
      return this.PostWebPage(url, param, ref cookies);
    }

    public string PostWebPagePayload(string url, string payload, ref List<Cookie> cookies)
    {
      using (MyWebClient myWebClient = new MyWebClient())
      {
        try
        {
          myWebClient.Headers.Add("Content-Type", "text/plain;charset=UTF-8");
          myWebClient.Headers.Add("Referer", "https://www.tumblr.com/login");
          myWebClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36");
          myWebClient.Headers.Add("Origin", "https://www.tumblr.com");
          if (cookies != null && cookies.Count > 0)
          {
            myWebClient.cookies = new CookieContainer(cookies.Count);
            foreach (Cookie cookie in cookies)
              myWebClient.cookies.Add(cookie);
          }
          byte[] bytes = myWebClient.UploadData(url, Encoding.UTF8.GetBytes(payload));
          myWebClient.ResponseHeaders.ToString();
          int num = (int) myWebClient.StatusCode();
          WebHeaderCollection responseHeaders = myWebClient.ResponseHeaders;
          CookieCollection responseCookies = myWebClient.ResponseCookies;
          if (cookies != null)
          {
            foreach (Cookie cookie in myWebClient.ResponseCookies)
              cookies.Add(cookie);
          }
          return Encoding.UTF8.GetString(bytes);
        }
        catch (Exception ex)
        {
          return (string) null;
        }
      }
    }

    public string PostWebPage(string url, NameValueCollection param, ref List<Cookie> cookies)
    {
      using (MyWebClient myWebClient = new MyWebClient())
      {
        try
        {
          myWebClient.AllowAutoRedirect = false;
          myWebClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
          myWebClient.Headers.Add("Referer", "https://www.tumblr.com/login");
          myWebClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36");
          myWebClient.Headers.Add("Origin", "https://www.tumblr.com");
          if (cookies != null && cookies.Count > 0)
          {
            myWebClient.cookies = new CookieContainer(cookies.Count);
            foreach (Cookie cookie in cookies)
              myWebClient.cookies.Add(cookie);
          }
          byte[] bytes = myWebClient.UploadValues(url, "POST", param);
          myWebClient.ResponseHeaders.ToString();
          int num = (int) myWebClient.StatusCode();
          WebHeaderCollection responseHeaders = myWebClient.ResponseHeaders;
          CookieCollection responseCookies = myWebClient.ResponseCookies;
          if (cookies != null)
          {
            foreach (Cookie cookie in myWebClient.ResponseCookies)
              cookies.Add(cookie);
          }
          return Encoding.UTF8.GetString(bytes);
        }
        catch (Exception ex)
        {
          return (string) null;
        }
      }
    }

    public void SaveFailed()
    {
      MySettings.Instance.SaveHistoryFile((IEnumerable<IFileToDownload>) this.FailedPosts, this.Website.FailedFilePath);
    }

    public void SaveHistory()
    {
      MySettings.Instance.SaveHistoryFile((IEnumerable<IFileToDownload>) this.History, this.Website.HistoryFilePath);
    }

    public void SavePostsFound()
    {
      MySettings.Instance.SaveHistoryFile((IEnumerable<IFileToDownload>) new List<IFileToDownload>((IEnumerable<IFileToDownload>) this.PostsFound), this.Website.PendingFilePath);
    }

    public IFileToDownload NewDownloadFile(string url, string filename, string key)
    {
      return (IFileToDownload) new FileToDownload(url, filename, key);
    }

    public IFileToDownload NewDownloadFile(string url, string filename)
    {
      return (IFileToDownload) new FileToDownload(url, filename);
    }

    public void UpdateStatusTotalPosts(int val)
    {
      StatusObject status = this.Status;
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) status, ref lockTaken);
        this.Status.TotalPosts = new int?(val);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) status);
      }
    }

    public void UpdateStatusPendingPosts(int val)
    {
      StatusObject status = this.Status;
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) status, ref lockTaken);
        this.Status.PendingPosts = new int?(val);
        this.UpdatePercentageComplete(100 - (int) Math.Round((double) val / (double) this.Status.TotalPosts.Value * 100.0));
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) status);
      }
    }

    public void UpdateStatusFailedPosts(int val)
    {
      StatusObject status = this.Status;
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) status, ref lockTaken);
        this.Status.FailedPosts = new int?(val);
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) status);
      }
      this.MaxThreads = Math.Max(2, this.MaxThreads - 1);
      Console.WriteLine("Reducing to : " + (object) this.MaxThreads + " Threads");
    }

    public void UpdateStatusText(string val)
    {
      StatusObject status = this.Status;
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) status, ref lockTaken);
        this.Status.DisplayStatus = val;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) status);
      }
    }

    public void UpdatePercentageComplete(int val)
    {
      StatusObject status = this.Status;
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) status, ref lockTaken);
        this.Status.ProgressBar = val;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) status);
      }
    }

    public void UpdatePreviewImagePath(string val)
    {
      if (!val.EndsWith(".jpg") || !System.IO.File.Exists(val))
        return;
      StatusObject status = this.Status;
      bool lockTaken = false;
      try
      {
        Monitor.Enter((object) status, ref lockTaken);
        this.Status.PreviewImageSource = val;
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit((object) status);
      }
    }

    public void SaveSettings(string settings)
    {
      MySettings.Instance.SavePluginSettingsFiles(settings, this.Website.PluginSettingsFilePath);
    }

    public void DownloadPostsFound(CancellationToken _cancellationToken)
    {
      List<IFileToDownload> list = new List<IFileToDownload>((IEnumerable<IFileToDownload>) this.PostsFound);
      int num = 0;
      foreach (string str in Enumerable.ToList<string>(Enumerable.Select<string, string>(Directory.EnumerateFiles(this.Website.LocalDir), new Func<string, string>(Path.GetFileName))))
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Ripper.Class3 class3 = new Ripper.Class3();
        // ISSUE: reference to a compiler-generated field
        class3.string_0 = str;
        // ISSUE: reference to a compiler-generated method
        IFileToDownload fileToDownload = Enumerable.FirstOrDefault<IFileToDownload>((IEnumerable<IFileToDownload>) list, new Func<IFileToDownload, bool>(class3.method_0));
        // ISSUE: reference to a compiler-generated field
        if (fileToDownload != null && new FileInfo(Path.Combine(this.Website.LocalDir, class3.string_0)).Length > 0L)
          list.Remove(fileToDownload);
      }
      this.PostsFound = new System.Collections.Generic.Queue<IFileToDownload>((IEnumerable<IFileToDownload>) list);
      list.Clear();
      this.UpdateStatusPendingPosts(this.PostsFound.Count);
      while (!_cancellationToken.IsCancellationRequested)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        Ripper.Class4 class4 = new Ripper.Class4();
        // ISSUE: reference to a compiler-generated field
        class4.ripper_0 = this;
        while (this.ActiveThreads.Count > this.MaxThreads)
        {
          try
          {
            Thread.Sleep(50);
          }
          catch (Exception ex)
          {
          }
        }
        // ISSUE: reference to a compiler-generated field
        class4.ifileToDownload_0 = (IFileToDownload) null;
        System.Collections.Generic.Queue<IFileToDownload> postsFound = this.PostsFound;
        bool lockTaken = false;
        try
        {
          Monitor.Enter((object) postsFound, ref lockTaken);
          if (num++ == 50)
          {
            num = 0;
            this.SaveHistory();
            this.MaxThreads = Math.Min(this.MaxThreads + 1, 10);
          }
          if (this.PostsFound.Count == 0)
          {
            this.SaveHistory();
            Console.WriteLine("Queue is empty, but still have ongoing threads");
            while (this.ActiveThreads.Count > 0)
              Thread.Sleep(50);
            break;
          }
          // ISSUE: reference to a compiler-generated field
          class4.ifileToDownload_0 = this.PostsFound.Dequeue();
          this.UpdateStatusPendingPosts(this.PostsFound.Count);
          // ISSUE: reference to a compiler-generated field
          string url = class4.ifileToDownload_0.Url;
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit((object) postsFound);
        }
        // ISSUE: reference to a compiler-generated method
        Thread thread = new Thread(new ThreadStart(class4.method_0));
        // ISSUE: reference to a compiler-generated field
        thread.Name = class4.ifileToDownload_0.Filename;
        this.ActiveThreads.Add(thread);
        thread.Start();
      }
      while (true)
      {
        IList<Thread> activeThreads = this.ActiveThreads;
        bool lockTaken = false;
        try
        {
          Monitor.Enter((object) activeThreads, ref lockTaken);
          if (this.ActiveThreads.Count == 0)
            break;
        }
        finally
        {
          if (lockTaken)
            Monitor.Exit((object) activeThreads);
        }
        Thread.Sleep(1000);
      }
    }
  }
}
