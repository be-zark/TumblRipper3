using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200005D RID: 93
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RazorInjectionAttribute : Attribute
	{
		// Token: 0x0600017B RID: 379 RVA: 0x000066DC File Offset: 0x000048DC
		public RazorInjectionAttribute([NotNull] string string_2, [NotNull] string string_3)
		{
			this.Type = string_2;
			this.FieldName = string_3;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00006700 File Offset: 0x00004900
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00006714 File Offset: 0x00004914
		[NotNull]
		public string Type { get; private set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00006728 File Offset: 0x00004928
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0000673C File Offset: 0x0000493C
		[NotNull]
		public string FieldName { get; private set; }

		// Token: 0x0400009A RID: 154
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400009B RID: 155
		[CompilerGenerated]
		private string string_1;
	}
}
