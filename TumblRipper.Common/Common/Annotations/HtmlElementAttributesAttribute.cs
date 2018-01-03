using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000048 RID: 72
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class HtmlElementAttributesAttribute : Attribute
	{
		// Token: 0x06000155 RID: 341 RVA: 0x00005D64 File Offset: 0x00003F64
		public HtmlElementAttributesAttribute()
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000648C File Offset: 0x0000468C
		public HtmlElementAttributesAttribute([NotNull] string string_1)
		{
			this.Name = string_1;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000064A8 File Offset: 0x000046A8
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000064BC File Offset: 0x000046BC
		[CanBeNull]
		public string Name { get; private set; }

		// Token: 0x04000087 RID: 135
		[CompilerGenerated]
		private string string_0;
	}
}
