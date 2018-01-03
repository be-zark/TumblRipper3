using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace TumblRipper
{
	// Token: 0x02000011 RID: 17
	public class MySettings
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00004CA8 File Offset: 0x00002EA8
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00004CBC File Offset: 0x00002EBC
		public List<string> WebsiteFilePaths { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00004CD0 File Offset: 0x00002ED0
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00004CE4 File Offset: 0x00002EE4
		public MyAppSettings AppSettings { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00004CF8 File Offset: 0x00002EF8
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00004D0C File Offset: 0x00002F0C
		public MyLicence Licence { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00004D20 File Offset: 0x00002F20
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00004D34 File Offset: 0x00002F34
		private string BasePath { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00004D48 File Offset: 0x00002F48
		public static MySettings Instance
		{
			get
			{
				if (MySettings.mySettings_0 == null)
				{
					MySettings.mySettings_0 = new MySettings();
				}
				return MySettings.mySettings_0;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004D6C File Offset: 0x00002F6C
		public MySettings()
		{
			this.BasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TumblRipper3");
			if (!Directory.Exists(this.BasePath))
			{
				Directory.CreateDirectory(this.BasePath);
			}
			this.AppSettings = this.LoadSettings();
			this.LoadWebsites();
			this.Licence = this.GetLicence();
			if (this.AppSettings.MachineID == null)
			{
				this.AppSettings.MachineID = Guid.NewGuid().ToString();
				this.SaveSettings();
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004E00 File Offset: 0x00003000
		public MyLicence GetLicence()
		{
			string path = Path.Combine(this.BasePath, "licence.dat");
			MyLicence result = null;
			if (File.Exists(path))
			{
				result = MyLicence.LoadFromFile(path);
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004E30 File Offset: 0x00003030
		public void SetLicence(MyLicence lic)
		{
			string path = Path.Combine(this.BasePath, "licence.dat");
			if (lic == null)
			{
				File.Delete(path);
				return;
			}
			MyLicence.SaveToFile(path, lic);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004E60 File Offset: 0x00003060
		public bool IsLicensed()
		{
			return this.Licence != null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004E78 File Offset: 0x00003078
		public MyAppSettings LoadSettings()
		{
			string path = Path.Combine(this.BasePath, "settings.xml");
			if (!File.Exists(path))
			{
				return new MyAppSettings();
			}
			MyAppSettings result;
			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(MyAppSettings));
				FileStream fileStream = new FileStream(path, FileMode.Open);
				MyAppSettings myAppSettings = xmlSerializer.Deserialize(fileStream) as MyAppSettings;
				fileStream.Close();
				result = myAppSettings;
			}
			catch (Exception)
			{
				result = new MyAppSettings();
			}
			return result;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004EEC File Offset: 0x000030EC
		public void SaveSettings()
		{
			string path = Path.Combine(this.BasePath, "settings.xml");
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(MyAppSettings));
			FileStream fileStream = new FileStream(path, FileMode.Create);
			xmlSerializer.Serialize(fileStream, this.AppSettings);
			fileStream.Close();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004F34 File Offset: 0x00003134
		public List<string> LoadWebsites()
		{
			this.WebsiteFilePaths = this.method_0();
			if (this.WebsiteFilePaths == null)
			{
				this.WebsiteFilePaths = new List<string>();
			}
			return this.WebsiteFilePaths;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004F68 File Offset: 0x00003168
		public void SaveWebsites()
		{
			this.method_1(this.WebsiteFilePaths);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004F84 File Offset: 0x00003184
		public Website LoadWebsite(string path)
		{
			Website website = new Website();
			website.Init(path);
			if (!File.Exists(website.SettingsFilePath))
			{
				return null;
			}
			Website result;
			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(Website));
				FileStream fileStream = new FileStream(website.SettingsFilePath, FileMode.Open);
				Website website2 = xmlSerializer.Deserialize(fileStream) as Website;
				fileStream.Close();
				website2.Init(path);
				result = website2;
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004FFC File Offset: 0x000031FC
		public void SaveWebsite(Website w)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Website));
			FileStream fileStream = new FileStream(w.SettingsFilePath, FileMode.Create);
			xmlSerializer.Serialize(fileStream, w);
			fileStream.Close();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005034 File Offset: 0x00003234
		private List<string> method_0()
		{
			string path = Path.Combine(this.BasePath, "websites.xml");
			if (File.Exists(path))
			{
				List<string> result;
				try
				{
					XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));
					FileStream fileStream = new FileStream(path, FileMode.Open);
					List<string> list = xmlSerializer.Deserialize(fileStream) as List<string>;
					fileStream.Close();
					result = list;
				}
				catch (Exception)
				{
					result = null;
				}
				return result;
			}
			return null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000050A0 File Offset: 0x000032A0
		private void method_1(List<string> list_1)
		{
			string path = Path.Combine(this.BasePath, "websites.xml");
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));
			FileStream fileStream = new FileStream(path, FileMode.Create);
			xmlSerializer.Serialize(fileStream, list_1);
			fileStream.Close();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000050E4 File Offset: 0x000032E4
		public void SavePluginSettingsFiles(string settings, string path)
		{
			File.WriteAllText(path, settings);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000050F8 File Offset: 0x000032F8
		public string LoadPluginSettingsFile(string path)
		{
			if (File.Exists(path))
			{
				return File.ReadAllText(path);
			}
			return null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005118 File Offset: 0x00003318
		public void SaveHistoryFile(List<IFileToDownload> history, string path)
		{
			List<FileToDownload> list = new List<FileToDownload>();
			foreach (IFileToDownload fileToDownload in history)
			{
				list.Add(fileToDownload as FileToDownload);
			}
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<FileToDownload>));
			FileInfo fileInfo = new FileInfo(path);
			if (!fileInfo.Directory.Exists)
			{
				Directory.CreateDirectory(fileInfo.Directory.FullName);
			}
			FileStream fileStream = new FileStream(path, FileMode.Create);
			xmlSerializer.Serialize(fileStream, list);
			fileStream.Close();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000051C0 File Offset: 0x000033C0
		public List<IFileToDownload> LoadHistoryFile(string path)
		{
			if (!File.Exists(path))
			{
				return new List<IFileToDownload>();
			}
			List<IFileToDownload> result;
			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<FileToDownload>));
				FileStream fileStream = new FileStream(path, FileMode.Open);
				List<FileToDownload> list = (List<FileToDownload>)xmlSerializer.Deserialize(fileStream);
				List<IFileToDownload> list2 = new List<IFileToDownload>();
				foreach (FileToDownload item in list)
				{
					list2.Add(item);
				}
				fileStream.Close();
				result = list2;
			}
			catch (Exception)
			{
				result = new List<IFileToDownload>();
			}
			return result;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00005268 File Offset: 0x00003468
		public void RemoveWebsite(Website viewSelectedWebsite)
		{
			this.WebsiteFilePaths.Remove(viewSelectedWebsite.LocalDir);
			this.SaveWebsites();
		}

		// Token: 0x04000040 RID: 64
		[CompilerGenerated]
		private List<string> list_0;

		// Token: 0x04000041 RID: 65
		[CompilerGenerated]
		private MyAppSettings myAppSettings_0;

		// Token: 0x04000042 RID: 66
		[CompilerGenerated]
		private MyLicence myLicence_0;

		// Token: 0x04000043 RID: 67
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000044 RID: 68
		private static MySettings mySettings_0;
	}
}
