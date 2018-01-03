// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.MySettings
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TumblRipper.PluginInterface;

namespace TumblRipper.Common
{
  public class MySettings
  {
    private static MySettings mySettings_0;

    public List<string> WebsiteFilePaths { get; set; }

    public MyAppSettings AppSettings { get; set; }

    public MyLicence Licence { get; set; }

    private string BasePath { get; }

    public static MySettings Instance
    {
      get
      {
        if (MySettings.mySettings_0 == null)
          MySettings.mySettings_0 = new MySettings();
        return MySettings.mySettings_0;
      }
    }

    public MySettings()
    {
      // ISSUE: reference to a compiler-generated field
      this.string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TumblRipper3");
      if (!Directory.Exists(this.BasePath))
        Directory.CreateDirectory(this.BasePath);
      this.AppSettings = this.LoadSettings();
      this.LoadWebsites();
      this.Licence = this.GetLicence();
      if (this.AppSettings.MachineID != null)
        return;
      this.AppSettings.MachineID = Guid.NewGuid().ToString();
      this.SaveSettings();
    }

    public MyLicence GetLicence()
    {
      string path = Path.Combine(this.BasePath, "licence.dat");
      MyLicence myLicence = (MyLicence) null;
      if (File.Exists(path))
        myLicence = MyLicence.LoadFromFile(path);
      return myLicence;
    }

    public void SetLicence(MyLicence lic)
    {
      string path = Path.Combine(this.BasePath, "licence.dat");
      if (lic == null)
        File.Delete(path);
      else
        MyLicence.SaveToFile(path, lic);
    }

    public bool IsLicensed()
    {
      return this.Licence != null;
    }

    public MyAppSettings LoadSettings()
    {
      string path = Path.Combine(this.BasePath, "settings.xml");
      if (!File.Exists(path))
        return new MyAppSettings();
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (MyAppSettings));
        FileStream fileStream1 = new FileStream(path, FileMode.Open);
        FileStream fileStream2 = fileStream1;
        MyAppSettings myAppSettings = xmlSerializer.Deserialize((Stream) fileStream2) as MyAppSettings;
        fileStream1.Close();
        return myAppSettings;
      }
      catch (Exception ex)
      {
        return new MyAppSettings();
      }
    }

    public void SaveSettings()
    {
      string path = Path.Combine(this.BasePath, "settings.xml");
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (MyAppSettings));
      FileStream fileStream1 = new FileStream(path, FileMode.Create);
      FileStream fileStream2 = fileStream1;
      MyAppSettings appSettings = this.AppSettings;
      xmlSerializer.Serialize((Stream) fileStream2, (object) appSettings);
      fileStream1.Close();
    }

    public List<string> LoadWebsites()
    {
      this.WebsiteFilePaths = this.method_0();
      if (this.WebsiteFilePaths == null)
        this.WebsiteFilePaths = new List<string>();
      return this.WebsiteFilePaths;
    }

    public void SaveWebsites()
    {
      this.method_1(this.WebsiteFilePaths);
    }

    public Website LoadWebsite(string path)
    {
      Website website1 = new Website();
      website1.Init(path);
      if (!File.Exists(website1.SettingsFilePath))
        return (Website) null;
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (Website));
        FileStream fileStream1 = new FileStream(website1.SettingsFilePath, FileMode.Open);
        FileStream fileStream2 = fileStream1;
        Website website2 = xmlSerializer.Deserialize((Stream) fileStream2) as Website;
        fileStream1.Close();
        string dir = path;
        website2.Init(dir);
        return website2;
      }
      catch (Exception ex)
      {
        return (Website) null;
      }
    }

    public void SaveWebsite(Website w)
    {
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (Website));
      FileStream fileStream1 = new FileStream(w.SettingsFilePath, FileMode.Create);
      FileStream fileStream2 = fileStream1;
      Website website = w;
      xmlSerializer.Serialize((Stream) fileStream2, (object) website);
      fileStream1.Close();
    }

    private List<string> method_0()
    {
      string path = Path.Combine(this.BasePath, "websites.xml");
      if (!File.Exists(path))
        return (List<string>) null;
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (List<string>));
        FileStream fileStream1 = new FileStream(path, FileMode.Open);
        FileStream fileStream2 = fileStream1;
        List<string> list = xmlSerializer.Deserialize((Stream) fileStream2) as List<string>;
        fileStream1.Close();
        return list;
      }
      catch (Exception ex)
      {
        return (List<string>) null;
      }
    }

    private void method_1(List<string> list_1)
    {
      string path = Path.Combine(this.BasePath, "websites.xml");
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (List<string>));
      FileStream fileStream1 = new FileStream(path, FileMode.Create);
      FileStream fileStream2 = fileStream1;
      List<string> list = list_1;
      xmlSerializer.Serialize((Stream) fileStream2, (object) list);
      fileStream1.Close();
    }

    public void SavePluginSettingsFiles(string settings, string path)
    {
      File.WriteAllText(path, settings);
    }

    public string LoadPluginSettingsFile(string path)
    {
      if (File.Exists(path))
        return File.ReadAllText(path);
      return (string) null;
    }

    public void SaveHistoryFile(IEnumerable<IFileToDownload> history, string path)
    {
      List<FileToDownload> list1 = new List<FileToDownload>();
      foreach (IFileToDownload fileToDownload in history)
        list1.Add((FileToDownload) fileToDownload);
      XmlSerializer xmlSerializer = new XmlSerializer(typeof (List<FileToDownload>));
      FileInfo fileInfo = new FileInfo(path);
      if (!fileInfo.Directory.Exists)
        Directory.CreateDirectory(fileInfo.Directory.FullName);
      FileStream fileStream1 = new FileStream(path, FileMode.Create);
      FileStream fileStream2 = fileStream1;
      List<FileToDownload> list2 = list1;
      xmlSerializer.Serialize((Stream) fileStream2, (object) list2);
      fileStream1.Close();
    }

    public IList<IFileToDownload> LoadHistoryFile(string path)
    {
      if (!File.Exists(path))
        return (IList<IFileToDownload>) new List<IFileToDownload>();
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (List<FileToDownload>));
        FileStream fileStream1 = new FileStream(path, FileMode.Open);
        FileStream fileStream2 = fileStream1;
        List<FileToDownload> list1 = (List<FileToDownload>) xmlSerializer.Deserialize((Stream) fileStream2);
        List<IFileToDownload> list2 = new List<IFileToDownload>();
        foreach (FileToDownload fileToDownload in list1)
          list2.Add((IFileToDownload) fileToDownload);
        fileStream1.Close();
        return (IList<IFileToDownload>) list2;
      }
      catch (Exception ex)
      {
        return (IList<IFileToDownload>) new List<IFileToDownload>();
      }
    }

    public void RemoveWebsite(Website viewSelectedWebsite)
    {
      this.WebsiteFilePaths.Remove(viewSelectedWebsite.LocalDir);
      this.SaveWebsites();
    }
  }
}
