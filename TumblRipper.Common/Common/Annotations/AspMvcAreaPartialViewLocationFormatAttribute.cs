using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000035 RID: 53
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcAreaPartialViewLocationFormatAttribute : Attribute
	{
		// Token: 0x0600012F RID: 303 RVA: 0x0000626C File Offset: 0x0000446C
		public AspMvcAreaPartialViewLocationFormatAttribute([NotNull] string string_1)
		{
			this.Format = string_1;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00006288 File Offset: 0x00004488
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0000629C File Offset: 0x0000449C
		[NotNull]
		public string Format { get; private set; }

		// Token: 0x0400007F RID: 127
		[CompilerGenerated]
		private string string_0;
	}
}
