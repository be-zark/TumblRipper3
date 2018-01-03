using System;
using System.Collections.Generic;

namespace TumblRipper
{
	// Token: 0x02000016 RID: 22
	[Serializable]
	public class TumblrWebsite : Website
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000057E4 File Offset: 0x000039E4
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000057F8 File Offset: 0x000039F8
		public bool DoPhotoSets { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000580C File Offset: 0x00003A0C
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00005820 File Offset: 0x00003A20
		public bool DoVideos { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00005834 File Offset: 0x00003A34
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00005848 File Offset: 0x00003A48
		public bool DoRename { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000585C File Offset: 0x00003A5C
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00005870 File Offset: 0x00003A70
		public List<string> IgnoreExtensions { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00005884 File Offset: 0x00003A84
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00005898 File Offset: 0x00003A98
		public int LastTs { get; set; }

		// Token: 0x060000C6 RID: 198 RVA: 0x000058AC File Offset: 0x00003AAC
		public TumblrWebsite()
		{
			this.IgnoreExtensions = new List<string>();
		}
	}
}
