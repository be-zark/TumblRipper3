// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.FileToDownloadFailed
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using TumblRipper.PluginInterface;

namespace TumblRipper.Common
{
  [Serializable]
  public class FileToDownloadFailed : FileToDownload, IFileToDownload, IFileToDownloadFailed
  {
    public FileToDownloadStatusCodes ErrorCode { get; set; }

    public int Retry { get; set; }

    public FileToDownloadFailed()
    {
    }

    public FileToDownloadFailed(IFileToDownload ifileToDownload_0, FileToDownloadStatusCodes fileToDownloadStatusCodes_0)
      : base(ifileToDownload_0.Url, ifileToDownload_0.Filename, ifileToDownload_0.Key)
    {
      this.ErrorCode = fileToDownloadStatusCodes_0;
    }
  }
}
