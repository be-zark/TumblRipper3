using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200005E RID: 94
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RazorDirectiveAttribute : Attribute
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00006750 File Offset: 0x00004950
		public RazorDirectiveAttribute([NotNull] string string_1)
		{
			this.Directive = string_1;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000676C File Offset: 0x0000496C
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00006780 File Offset: 0x00004980
		[NotNull]
		public string Directive { get; private set; }

		// Token: 0x0400009C RID: 156
		[CompilerGenerated]
		private string string_0;
	}
}
