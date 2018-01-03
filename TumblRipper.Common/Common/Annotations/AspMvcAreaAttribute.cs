using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200003B RID: 59
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AspMvcAreaAttribute : Attribute
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00005D64 File Offset: 0x00003F64
		public AspMvcAreaAttribute()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006404 File Offset: 0x00004604
		public AspMvcAreaAttribute([NotNull] string string_1)
		{
			this.AnonymousProperty = string_1;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00006420 File Offset: 0x00004620
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00006434 File Offset: 0x00004634
		[CanBeNull]
		public string AnonymousProperty { get; private set; }

		// Token: 0x04000085 RID: 133
		[CompilerGenerated]
		private string string_0;
	}
}
