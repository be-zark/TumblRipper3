// Decompiled with JetBrains decompiler
// Type: TumblRipper.PluginInterface.IRipper
// Assembly: TumblRipper.PluginInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E766857F-E220-474D-9A9B-64EE1BB1D7AF
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.PluginInterface.dll

using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Threading;

namespace TumblRipper.PluginInterface
{
  public interface IRipper
  {
    IList<IFileToDownloadFailed> FailedPosts { get; set; }

    IList<Thread> ActiveThreads { get; set; }

    IList<IFileToDownload> History { get; set; }

    Queue<IFileToDownload> PostsFound { get; set; }

    IWebsite Website { get; set; }

    int MaxThreads { get; set; }

    FileToDownloadStatusCodes DownloadFile(IFileToDownload myfile);

    string MakeValidFileName(string name);

    string GetWebPage(string url);

    string GetWebPage(string url, ref List<Cookie> cookie);

    string PostWebPage(string url, NameValueCollection param);

    string PostWebPage(string url, NameValueCollection param, ref List<Cookie> cookies);

    string PostWebPagePayload(string url, string payload, ref List<Cookie> cookies);

    void SaveFailed();

    void SaveHistory();

    void SavePostsFound();

    void DownloadPostsFound(CancellationToken _cancellationToken);

    IFileToDownload NewDownloadFile(string url, string filename, string key);

    IFileToDownload NewDownloadFile(string url, string filename);

    void UpdateStatusTotalPosts(int val);

    void UpdateStatusPendingPosts(int val);

    void UpdateStatusFailedPosts(int val);

    void UpdateStatusText(string val);

    void UpdatePercentageComplete(int val);

    void UpdatePreviewImagePath(string val);

    void SaveSettings(string settings);
  }
}
