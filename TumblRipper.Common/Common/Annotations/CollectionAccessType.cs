using System;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200004C RID: 76
	[Flags]
	public enum CollectionAccessType
	{
		// Token: 0x0400008B RID: 139
		None = 0,
		// Token: 0x0400008C RID: 140
		Read = 1,
		// Token: 0x0400008D RID: 141
		ModifyExistingContent = 2,
		// Token: 0x0400008E RID: 142
		UpdatedContent = 6
	}
}
