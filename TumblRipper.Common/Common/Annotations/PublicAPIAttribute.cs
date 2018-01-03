using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200002C RID: 44
	[MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
	public sealed class PublicAPIAttribute : Attribute
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00005D64 File Offset: 0x00003F64
		public PublicAPIAttribute()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000060E4 File Offset: 0x000042E4
		public PublicAPIAttribute([NotNull] string string_1)
		{
			this.Comment = string_1;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00006100 File Offset: 0x00004300
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00006114 File Offset: 0x00004314
		[CanBeNull]
		public string Comment { get; private set; }

		// Token: 0x04000078 RID: 120
		[CompilerGenerated]
		private string string_0;
	}
}
