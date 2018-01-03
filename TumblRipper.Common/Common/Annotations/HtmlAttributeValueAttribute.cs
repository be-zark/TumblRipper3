using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000049 RID: 73
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class HtmlAttributeValueAttribute : Attribute
	{
		// Token: 0x06000159 RID: 345 RVA: 0x000064D0 File Offset: 0x000046D0
		public HtmlAttributeValueAttribute([NotNull] string string_1)
		{
			this.Name = string_1;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000064EC File Offset: 0x000046EC
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00006500 File Offset: 0x00004700
		[NotNull]
		public string Name { get; private set; }

		// Token: 0x04000088 RID: 136
		[CompilerGenerated]
		private string string_0;
	}
}
