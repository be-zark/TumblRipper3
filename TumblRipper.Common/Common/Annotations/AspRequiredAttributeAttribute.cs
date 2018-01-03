using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200005A RID: 90
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class AspRequiredAttributeAttribute : Attribute
	{
		// Token: 0x06000172 RID: 370 RVA: 0x00006610 File Offset: 0x00004810
		public AspRequiredAttributeAttribute([NotNull] string string_1)
		{
			this.Attribute = string_1;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000662C File Offset: 0x0000482C
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00006640 File Offset: 0x00004840
		[NotNull]
		public string Attribute { get; private set; }

		// Token: 0x04000097 RID: 151
		[CompilerGenerated]
		private string string_0;
	}
}
