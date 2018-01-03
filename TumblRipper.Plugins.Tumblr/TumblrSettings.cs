using System;
using System.Collections.Generic;

namespace TumblRipper.Plugins.Tumblr
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public class TumblrSettings
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000073FC File Offset: 0x000055FC
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00007410 File Offset: 0x00005610
		public bool DoPhotoSets { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00007424 File Offset: 0x00005624
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00007438 File Offset: 0x00005638
		public bool DoVideos { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000744C File Offset: 0x0000564C
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00007460 File Offset: 0x00005660
		public bool DoRename { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00007474 File Offset: 0x00005674
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00007488 File Offset: 0x00005688
		public bool DoReblogs { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000749C File Offset: 0x0000569C
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000074B0 File Offset: 0x000056B0
		public bool DoTags { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000074C4 File Offset: 0x000056C4
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000074D8 File Offset: 0x000056D8
		public string FilenameMask { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000074EC File Offset: 0x000056EC
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00007500 File Offset: 0x00005700
		public List<string> IgnoreExtensions { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00007514 File Offset: 0x00005714
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00007528 File Offset: 0x00005728
		public int LastTs { get; set; }

		// Token: 0x060000EF RID: 239 RVA: 0x0000753C File Offset: 0x0000573C
		public TumblrSettings()
		{
			this.IgnoreExtensions = new List<string>();
		}
	}
}
