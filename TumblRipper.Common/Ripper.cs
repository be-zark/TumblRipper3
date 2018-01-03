using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace TumblRipper
{
	// Token: 0x0200000D RID: 13
	public class Ripper : IRipper
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000040EC File Offset: 0x000022EC
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00004100 File Offset: 0x00002300
		public List<IFileToDownload> FailedPosts { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00004114 File Offset: 0x00002314
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00004128 File Offset: 0x00002328
		public List<Thread> ActiveThreads { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000413C File Offset: 0x0000233C
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00004150 File Offset: 0x00002350
		public List<IFileToDownload> History { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00004164 File Offset: 0x00002364
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00004178 File Offset: 0x00002378
		public Queue<IFileToDownload> PostsFound { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000418C File Offset: 0x0000238C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000041A0 File Offset: 0x000023A0
		public IWebsite Website { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000041B4 File Offset: 0x000023B4
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000041C8 File Offset: 0x000023C8
		public int MaxThreads { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000041DC File Offset: 0x000023DC
		public int GetPostsFound
		{
			get
			{
				int result = 0;
				Queue<IFileToDownload> postsFound = this.PostsFound;
				lock (postsFound)
				{
					result = this.PostsFound.Count;
				}
				return result;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00004228 File Offset: 0x00002428
		public int GetActiveThreadCount
		{
			get
			{
				int result = 0;
				List<Thread> activeThreads = this.ActiveThreads;
				lock (activeThreads)
				{
					result = this.ActiveThreads.Count;
				}
				return result;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004274 File Offset: 0x00002474
		public int DownloadFile(IFileToDownload myfile)
		{
			string text = Path.Combine(this.string_0, myfile.Filename);
			MyWebClient myWebClient = new MyWebClient();
			int num = 200;
			try
			{
				myWebClient.DownloadFile(myfile.Url, text);
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				if (httpWebResponse != null)
				{
					if (httpWebResponse.StatusCode != HttpStatusCode.NotFound)
					{
						if (httpWebResponse.StatusCode != HttpStatusCode.Forbidden)
						{
							num = 99;
							goto IL_66;
						}
					}
					num = 404;
				}
				else
				{
					num = -1;
				}
				IL_66:;
			}
			catch (Exception)
			{
				num = 99;
			}
			if (!File.Exists(text))
			{
				return -1;
			}
			if (new FileInfo(text).Length < 1L)
			{
				num = -1;
			}
			if (num == 200)
			{
				WebHeaderCollection responseHeaders = myWebClient.ResponseHeaders;
				DateTime creationTime = DateTime.Now;
				for (int i = 0; i < responseHeaders.Count; i++)
				{
					if (responseHeaders.GetKey(i).Equals("Last-Modified"))
					{
						creationTime = DateTime.Parse(responseHeaders.Get(i));
					}
				}
				try
				{
					File.SetCreationTime(text, creationTime);
				}
				catch (Exception)
				{
				}
			}
			if (myWebClient != null)
			{
				myWebClient.Dispose();
			}
			return num;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000043A4 File Offset: 0x000025A4
		public Ripper(IWebsite iwebsite_1)
		{
			this.ActiveThreads = new List<Thread>();
			this.History = MySettings.Instance.LoadHistoryFile(iwebsite_1.HistoryFilePath);
			this.FailedPosts = MySettings.Instance.LoadHistoryFile(iwebsite_1.FailedFilePath);
			this.PostsFound = new Queue<IFileToDownload>(MySettings.Instance.LoadHistoryFile(iwebsite_1.PendingFilePath));
			this.string_0 = iwebsite_1.LocalDir;
			this.Website = iwebsite_1;
			this.MaxThreads = 20;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004424 File Offset: 0x00002624
		public string MakeValidFileName(string name)
		{
			string arg = Regex.Escape(new string(Path.GetInvalidFileNameChars()));
			string pattern = string.Format("([{0}]*\\.+$)|([{0}]+)", arg);
			return Regex.Replace(name, pattern, "_");
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000445C File Offset: 0x0000265C
		public string GetWebPage(string url)
		{
			string text = null;
			using (MyWebClient myWebClient = new MyWebClient())
			{
				try
				{
					byte[] bytes = myWebClient.DownloadData(url);
					text = Encoding.UTF8.GetString(bytes);
					myWebClient.StatusCode();
					if (text.Contains("Rate limit exceeded"))
					{
						throw new Exception("Rate limit exceeded !!!");
					}
				}
				catch (Exception)
				{
					text = null;
				}
			}
			return text;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000044D4 File Offset: 0x000026D4
		public string PostWebPage(string url, NameValueCollection param)
		{
			string result = null;
			using (MyWebClient myWebClient = new MyWebClient())
			{
				try
				{
					myWebClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
					byte[] bytes = myWebClient.UploadValues(url, "POST", param);
					myWebClient.StatusCode();
					WebHeaderCollection responseHeaders = myWebClient.ResponseHeaders;
					result = Encoding.UTF8.GetString(bytes);
				}
				catch (Exception)
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00004554 File Offset: 0x00002754
		public StatusObject Status
		{
			get
			{
				return ((Website)this.Website).Status;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004574 File Offset: 0x00002774
		public void SaveFailed()
		{
			MySettings.Instance.SaveHistoryFile(this.FailedPosts, this.Website.FailedFilePath);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000459C File Offset: 0x0000279C
		public void SaveHistory()
		{
			MySettings.Instance.SaveHistoryFile(this.History, this.Website.HistoryFilePath);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000045C4 File Offset: 0x000027C4
		public void SavePostsFound()
		{
			MySettings.Instance.SaveHistoryFile(new List<IFileToDownload>(this.PostsFound), this.Website.PendingFilePath);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000045F4 File Offset: 0x000027F4
		public IFileToDownload NewDownloadFile(string url, string filename, string key)
		{
			return new FileToDownload(url, filename, key);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000460C File Offset: 0x0000280C
		public IFileToDownload NewDownloadFile(string url, string filename)
		{
			return new FileToDownload(url, filename);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004620 File Offset: 0x00002820
		public void UpdateStatusTotalPosts(int val)
		{
			StatusObject status = this.Status;
			lock (status)
			{
				this.Status.TotalPosts = val;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004668 File Offset: 0x00002868
		public void UpdateStatusPendingPosts(int val)
		{
			StatusObject status = this.Status;
			lock (status)
			{
				this.Status.PendingPosts = val;
				int num = (int)Math.Round((double)val / (double)this.Status.TotalPosts * 100.0);
				this.UpdatePercentageComplete(100 - num);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000046D8 File Offset: 0x000028D8
		public void UpdateStatusFailedPosts(int val)
		{
			StatusObject status = this.Status;
			lock (status)
			{
				this.Status.FailedPosts = val;
			}
			this.MaxThreads = Math.Max(2, this.MaxThreads - 1);
			Console.WriteLine("Reducing to : " + this.MaxThreads + " Threads");
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004754 File Offset: 0x00002954
		public void UpdateStatusText(string val)
		{
			StatusObject status = this.Status;
			lock (status)
			{
				this.Status.DisplayStatus = val;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000479C File Offset: 0x0000299C
		public void UpdatePercentageComplete(int val)
		{
			StatusObject status = this.Status;
			lock (status)
			{
				this.Status.ProgressBar = val;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000047E4 File Offset: 0x000029E4
		public void UpdatePreviewImagePath(string val)
		{
			if (!val.EndsWith(".jpg"))
			{
				return;
			}
			StatusObject status = this.Status;
			lock (status)
			{
				this.Status.PreviewImageSource = val;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004838 File Offset: 0x00002A38
		public void SaveSettings(string settings)
		{
			MySettings.Instance.SavePluginSettingsFiles(settings, this.Website.PluginSettingsFilePath);
		}

		// Token: 0x0400002E RID: 46
		[CompilerGenerated]
		private List<IFileToDownload> list_0;

		// Token: 0x0400002F RID: 47
		[CompilerGenerated]
		private List<Thread> list_1;

		// Token: 0x04000030 RID: 48
		[CompilerGenerated]
		private List<IFileToDownload> list_2;

		// Token: 0x04000031 RID: 49
		[CompilerGenerated]
		private Queue<IFileToDownload> queue_0;

		// Token: 0x04000032 RID: 50
		[CompilerGenerated]
		private IWebsite iwebsite_0;

		// Token: 0x04000033 RID: 51
		private string string_0;

		// Token: 0x04000034 RID: 52
		[CompilerGenerated]
		private int int_0;
	}
}
