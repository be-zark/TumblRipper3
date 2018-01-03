using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200003C RID: 60
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	public sealed class AspMvcControllerAttribute : Attribute
	{
		// Token: 0x06000146 RID: 326 RVA: 0x00005D64 File Offset: 0x00003F64
		public AspMvcControllerAttribute()
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006448 File Offset: 0x00004648
		public AspMvcControllerAttribute([NotNull] string string_1)
		{
			this.AnonymousProperty = string_1;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00006464 File Offset: 0x00004664
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00006478 File Offset: 0x00004678
		[CanBeNull]
		public string AnonymousProperty { get; private set; }

		// Token: 0x04000086 RID: 134
		[CompilerGenerated]
		private string string_0;
	}
}
