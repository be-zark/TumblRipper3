using System;

namespace TumblRipper
{
	// Token: 0x0200000D RID: 13
	public interface IFileToDownload
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000052 RID: 82
		// (set) Token: 0x06000053 RID: 83
		string Key { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000054 RID: 84
		// (set) Token: 0x06000055 RID: 85
		string Url { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000056 RID: 86
		// (set) Token: 0x06000057 RID: 87
		string Filename { get; set; }
	}
}
