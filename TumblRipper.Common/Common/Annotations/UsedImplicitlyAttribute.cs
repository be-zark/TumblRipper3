using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000028 RID: 40
	[AttributeUsage(AttributeTargets.All)]
	public sealed class UsedImplicitlyAttribute : Attribute
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00005F6C File Offset: 0x0000416C
		public UsedImplicitlyAttribute() : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00005F84 File Offset: 0x00004184
		public UsedImplicitlyAttribute(ImplicitUseKindFlags implicitUseKindFlags_1) : this(implicitUseKindFlags_1, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00005F9C File Offset: 0x0000419C
		public UsedImplicitlyAttribute(ImplicitUseTargetFlags implicitUseTargetFlags_1) : this(ImplicitUseKindFlags.Default, implicitUseTargetFlags_1)
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00005FB4 File Offset: 0x000041B4
		public UsedImplicitlyAttribute(ImplicitUseKindFlags implicitUseKindFlags_1, ImplicitUseTargetFlags implicitUseTargetFlags_1)
		{
			this.UseKindFlags = implicitUseKindFlags_1;
			this.TargetFlags = implicitUseTargetFlags_1;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00005FD8 File Offset: 0x000041D8
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00005FEC File Offset: 0x000041EC
		public ImplicitUseKindFlags UseKindFlags { get; private set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00006000 File Offset: 0x00004200
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00006014 File Offset: 0x00004214
		public ImplicitUseTargetFlags TargetFlags { get; private set; }

		// Token: 0x04000069 RID: 105
		[CompilerGenerated]
		private ImplicitUseKindFlags implicitUseKindFlags_0;

		// Token: 0x0400006A RID: 106
		[CompilerGenerated]
		private ImplicitUseTargetFlags implicitUseTargetFlags_0;
	}
}
