using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000039 RID: 57
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcViewLocationFormatAttribute : Attribute
	{
		// Token: 0x0600013B RID: 315 RVA: 0x0000637C File Offset: 0x0000457C
		public AspMvcViewLocationFormatAttribute([NotNull] string string_1)
		{
			this.Format = string_1;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00006398 File Offset: 0x00004598
		// (set) Token: 0x0600013D RID: 317 RVA: 0x000063AC File Offset: 0x000045AC
		[NotNull]
		public string Format { get; private set; }

		// Token: 0x04000083 RID: 131
		[CompilerGenerated]
		private string string_0;
	}
}
