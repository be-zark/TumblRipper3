using System;

namespace TumblRipper
{
	// Token: 0x02000011 RID: 17
	public interface IWebsite
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600007E RID: 126
		bool Enabled { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600007F RID: 127
		string PluginInName { get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000080 RID: 128
		string Title { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000081 RID: 129
		string Url { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000082 RID: 130
		string LocalDir { get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000083 RID: 131
		string LocalSettingsDir { get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000084 RID: 132
		string HistoryFilePath { get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000085 RID: 133
		string PendingFilePath { get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000086 RID: 134
		string FailedFilePath { get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000087 RID: 135
		string SettingsFilePath { get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000088 RID: 136
		string PluginSettingsFilePath { get; }
	}
}
