using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000029 RID: 41
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		// Token: 0x0600010D RID: 269 RVA: 0x00006028 File Offset: 0x00004228
		public MeansImplicitUseAttribute() : this(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00006040 File Offset: 0x00004240
		public MeansImplicitUseAttribute(ImplicitUseKindFlags implicitUseKindFlags_1) : this(implicitUseKindFlags_1, ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00006058 File Offset: 0x00004258
		public MeansImplicitUseAttribute(ImplicitUseTargetFlags implicitUseTargetFlags_1) : this(ImplicitUseKindFlags.Default, implicitUseTargetFlags_1)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00006070 File Offset: 0x00004270
		public MeansImplicitUseAttribute(ImplicitUseKindFlags implicitUseKindFlags_1, ImplicitUseTargetFlags implicitUseTargetFlags_1)
		{
			this.UseKindFlags = implicitUseKindFlags_1;
			this.TargetFlags = implicitUseTargetFlags_1;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00006094 File Offset: 0x00004294
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000060A8 File Offset: 0x000042A8
		[UsedImplicitly]
		public ImplicitUseKindFlags UseKindFlags { get; private set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000113 RID: 275 RVA: 0x000060BC File Offset: 0x000042BC
		// (set) Token: 0x06000114 RID: 276 RVA: 0x000060D0 File Offset: 0x000042D0
		[UsedImplicitly]
		public ImplicitUseTargetFlags TargetFlags { get; private set; }

		// Token: 0x0400006B RID: 107
		[CompilerGenerated]
		private ImplicitUseKindFlags implicitUseKindFlags_0;

		// Token: 0x0400006C RID: 108
		[CompilerGenerated]
		private ImplicitUseTargetFlags implicitUseTargetFlags_0;
	}
}
