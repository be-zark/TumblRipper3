using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;

namespace TumblRipper
{
	// Token: 0x0200000E RID: 14
	public interface IRipper
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000058 RID: 88
		// (set) Token: 0x06000059 RID: 89
		List<IFileToDownload> FailedPosts { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600005A RID: 90
		// (set) Token: 0x0600005B RID: 91
		List<Thread> ActiveThreads { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005C RID: 92
		// (set) Token: 0x0600005D RID: 93
		List<IFileToDownload> History { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600005E RID: 94
		// (set) Token: 0x0600005F RID: 95
		Queue<IFileToDownload> PostsFound { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000060 RID: 96
		// (set) Token: 0x06000061 RID: 97
		IWebsite Website { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000062 RID: 98
		// (set) Token: 0x06000063 RID: 99
		int MaxThreads { get; set; }

		// Token: 0x06000064 RID: 100
		int DownloadFile(IFileToDownload myfile);

		// Token: 0x06000065 RID: 101
		string MakeValidFileName(string name);

		// Token: 0x06000066 RID: 102
		string GetWebPage(string url);

		// Token: 0x06000067 RID: 103
		string PostWebPage(string url, NameValueCollection param);

		// Token: 0x06000068 RID: 104
		void SaveFailed();

		// Token: 0x06000069 RID: 105
		void SaveHistory();

		// Token: 0x0600006A RID: 106
		void SavePostsFound();

		// Token: 0x0600006B RID: 107
		IFileToDownload NewDownloadFile(string url, string filename, string key);

		// Token: 0x0600006C RID: 108
		IFileToDownload NewDownloadFile(string url, string filename);

		// Token: 0x0600006D RID: 109
		void UpdateStatusTotalPosts(int val);

		// Token: 0x0600006E RID: 110
		void UpdateStatusPendingPosts(int val);

		// Token: 0x0600006F RID: 111
		void UpdateStatusFailedPosts(int val);

		// Token: 0x06000070 RID: 112
		void UpdateStatusText(string val);

		// Token: 0x06000071 RID: 113
		void UpdatePercentageComplete(int val);

		// Token: 0x06000072 RID: 114
		void UpdatePreviewImagePath(string val);

		// Token: 0x06000073 RID: 115
		void SaveSettings(string settings);
	}
}
