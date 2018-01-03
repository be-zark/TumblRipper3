using System;

namespace TumblRipper.Common.models
{
	// Token: 0x02000065 RID: 101
	[Serializable]
	public class WebsiteSettings
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00006794 File Offset: 0x00004994
		// (set) Token: 0x0600018A RID: 394 RVA: 0x000067A8 File Offset: 0x000049A8
		public string Url { get; set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000067BC File Offset: 0x000049BC
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000067D0 File Offset: 0x000049D0
		public string Title { get; set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000067E4 File Offset: 0x000049E4
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000067F8 File Offset: 0x000049F8
		public bool Enabled { get; set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000680C File Offset: 0x00004A0C
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00006820 File Offset: 0x00004A20
		public string PluginInName { get; set; }
	}
}
