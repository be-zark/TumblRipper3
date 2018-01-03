using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000031 RID: 49
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class PathReferenceAttribute : Attribute
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00005D64 File Offset: 0x00003F64
		public PathReferenceAttribute()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000616C File Offset: 0x0000436C
		public PathReferenceAttribute([NotNull, PathReference] string string_1)
		{
			this.BasePath = string_1;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00006188 File Offset: 0x00004388
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000619C File Offset: 0x0000439C
		[CanBeNull]
		public string BasePath { get; private set; }

		// Token: 0x0400007A RID: 122
		[CompilerGenerated]
		private string string_0;
	}
}
