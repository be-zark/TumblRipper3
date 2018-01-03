// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.FileToDownload
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.Xml.Serialization;
using TumblRipper.PluginInterface;

namespace TumblRipper.Common
{
  [XmlInclude(typeof (FileToDownloadFailed))]
  [Serializable]
  public class FileToDownload : IEquatable<FileToDownload>, IFileToDownload
  {
    private string _filename;

    public string Key { get; set; }

    public string Url { get; set; }

    public string Filename
    {
      get
      {
        return this._filename;
      }
      set
      {
        this._filename = Utils.PathCleaner(value);
      }
    }

    public FileToDownload()
    {
    }

    public FileToDownload(string string_0, string string_1, string string_2)
    {
      this.Url = string_0;
      this.Filename = string_1;
      this.Key = string_2;
    }

    public FileToDownload(string string_0, string string_1)
    {
      this.Url = string_0;
      this.Filename = string_1;
      this.Key = string_0;
    }

    public bool Equals(FileToDownload obj)
    {
      return this.Key.Equals(obj.Key);
    }

    public override bool Equals(object obj)
    {
      return this.Equals(obj as FileToDownload);
    }

    public override int GetHashCode()
    {
      return this.Key.GetHashCode();
    }
  }
}
