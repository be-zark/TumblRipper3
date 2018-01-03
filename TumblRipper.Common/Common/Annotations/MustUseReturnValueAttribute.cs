using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200002F RID: 47
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class MustUseReturnValueAttribute : Attribute
	{
		// Token: 0x0600011B RID: 283 RVA: 0x00005D64 File Offset: 0x00003F64
		public MustUseReturnValueAttribute()
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00006128 File Offset: 0x00004328
		public MustUseReturnValueAttribute([NotNull] string string_1)
		{
			this.Justification = string_1;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00006144 File Offset: 0x00004344
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00006158 File Offset: 0x00004358
		[CanBeNull]
		public string Justification { get; private set; }

		// Token: 0x04000079 RID: 121
		[CompilerGenerated]
		private string string_0;
	}
}
