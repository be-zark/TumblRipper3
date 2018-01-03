using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000038 RID: 56
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcPartialViewLocationFormatAttribute : Attribute
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00006338 File Offset: 0x00004538
		public AspMvcPartialViewLocationFormatAttribute([NotNull] string string_1)
		{
			this.Format = string_1;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00006354 File Offset: 0x00004554
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00006368 File Offset: 0x00004568
		[NotNull]
		public string Format { get; private set; }

		// Token: 0x04000082 RID: 130
		[CompilerGenerated]
		private string string_0;
	}
}
