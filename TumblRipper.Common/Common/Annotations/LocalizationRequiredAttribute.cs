using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000025 RID: 37
	[AttributeUsage(AttributeTargets.All)]
	public sealed class LocalizationRequiredAttribute : Attribute
	{
		// Token: 0x060000FD RID: 253 RVA: 0x00005ED0 File Offset: 0x000040D0
		public LocalizationRequiredAttribute() : this(true)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005EE4 File Offset: 0x000040E4
		public LocalizationRequiredAttribute(bool bool_1)
		{
			this.Required = bool_1;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00005F00 File Offset: 0x00004100
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00005F14 File Offset: 0x00004114
		public bool Required { get; private set; }

		// Token: 0x04000067 RID: 103
		[CompilerGenerated]
		private bool bool_0;
	}
}
