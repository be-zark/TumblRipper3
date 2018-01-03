using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200003A RID: 58
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	public sealed class AspMvcActionAttribute : Attribute
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00005D64 File Offset: 0x00003F64
		public AspMvcActionAttribute()
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000063C0 File Offset: 0x000045C0
		public AspMvcActionAttribute([NotNull] string string_1)
		{
			this.AnonymousProperty = string_1;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000063DC File Offset: 0x000045DC
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000063F0 File Offset: 0x000045F0
		[CanBeNull]
		public string AnonymousProperty { get; private set; }

		// Token: 0x04000084 RID: 132
		[CompilerGenerated]
		private string string_0;
	}
}
