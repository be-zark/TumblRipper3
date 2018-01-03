using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using TumblRipper.Common.Annotations;

namespace TumblRipper
{
	// Token: 0x02000017 RID: 23
	[Serializable]
	public class Website : IWebsite, INotifyPropertyChanged
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000058CC File Offset: 0x00003ACC
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x000058E0 File Offset: 0x00003AE0
		public string Url { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000058F4 File Offset: 0x00003AF4
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00005908 File Offset: 0x00003B08
		public string Title { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000591C File Offset: 0x00003B1C
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00005930 File Offset: 0x00003B30
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				if (value == this._enabled)
				{
					return;
				}
				this._enabled = value;
				this.OnPropertyChanged("Enabled");
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000595C File Offset: 0x00003B5C
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00005970 File Offset: 0x00003B70
		public string PluginInName { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00005984 File Offset: 0x00003B84
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00005998 File Offset: 0x00003B98
		[XmlIgnore]
		public string LocalDir
		{
			get
			{
				return this._localDir;
			}
			private set
			{
				this._localDir = value;
				if (Directory.Exists(this.LocalSettingsDir))
				{
					this.Status.TotalPosts = MySettings.Instance.LoadHistoryFile(this.HistoryFilePath).Count;
					this.Status.FailedPosts = MySettings.Instance.LoadHistoryFile(this.FailedFilePath).Count;
					this.Status.PendingPosts = MySettings.Instance.LoadHistoryFile(this.PendingFilePath).Count;
					return;
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00005A1C File Offset: 0x00003C1C
		[XmlIgnore]
		public string LocalSettingsDir
		{
			get
			{
				return Path.Combine(this.LocalDir, ".tumblripper");
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005A3C File Offset: 0x00003C3C
		[XmlIgnore]
		public string HistoryFilePath
		{
			get
			{
				return Path.Combine(this.LocalSettingsDir, "History.txt");
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005A5C File Offset: 0x00003C5C
		[XmlIgnore]
		public string PendingFilePath
		{
			get
			{
				return Path.Combine(this.LocalSettingsDir, "Pending.txt");
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00005A7C File Offset: 0x00003C7C
		[XmlIgnore]
		public string FailedFilePath
		{
			get
			{
				return Path.Combine(this.LocalSettingsDir, "Failed.txt");
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00005A9C File Offset: 0x00003C9C
		[XmlIgnore]
		public string SettingsFilePath
		{
			get
			{
				return Path.Combine(this.LocalSettingsDir, "Settings.xml");
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005ABC File Offset: 0x00003CBC
		[XmlIgnore]
		public string PluginSettingsFilePath
		{
			get
			{
				return Path.Combine(this.LocalSettingsDir, "TRPluginSettings.xml");
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005ADC File Offset: 0x00003CDC
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[XmlIgnore]
		public StatusObject Status { get; set; }

		// Token: 0x060000D9 RID: 217 RVA: 0x00005B04 File Offset: 0x00003D04
		public Website()
		{
			this.Status = new StatusObject();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005B30 File Offset: 0x00003D30
		public void Init(string dir)
		{
			this._localDir = dir;
			if (!Directory.Exists(this.LocalDir))
			{
				Directory.CreateDirectory(this.LocalDir);
			}
			if (!Directory.Exists(this.LocalSettingsDir))
			{
				Directory.CreateDirectory(this.LocalSettingsDir);
			}
			new DirectoryInfo(this.LocalSettingsDir).Attributes |= FileAttributes.Hidden;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005B90 File Offset: 0x00003D90
		public void CreateAllDirectories()
		{
			if (!Directory.Exists(this.LocalDir))
			{
				Directory.CreateDirectory(this.LocalDir);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000DC RID: 220 RVA: 0x00005BB8 File Offset: 0x00003DB8
		// (remove) Token: 0x060000DD RID: 221 RVA: 0x00005BF0 File Offset: 0x00003DF0
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060000DE RID: 222 RVA: 0x00005C2C File Offset: 0x00003E2C
		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x04000059 RID: 89
		private string _localDir = string.Empty;

		// Token: 0x0400005A RID: 90
		private bool _enabled;
	}
}
