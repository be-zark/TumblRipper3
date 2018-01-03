using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000036 RID: 54
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcAreaViewLocationFormatAttribute : Attribute
	{
		// Token: 0x06000132 RID: 306 RVA: 0x000062B0 File Offset: 0x000044B0
		public AspMvcAreaViewLocationFormatAttribute([NotNull] string string_1)
		{
			this.Format = string_1;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000062CC File Offset: 0x000044CC
		// (set) Token: 0x06000134 RID: 308 RVA: 0x000062E0 File Offset: 0x000044E0
		[NotNull]
		public string Format { get; private set; }

		// Token: 0x04000080 RID: 128
		[CompilerGenerated]
		private string string_0;
	}
}
