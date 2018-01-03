using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000020 RID: 32
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate)]
	public sealed class StringFormatMethodAttribute : Attribute
	{
		// Token: 0x060000EC RID: 236 RVA: 0x00005D78 File Offset: 0x00003F78
		public StringFormatMethodAttribute([NotNull] string string_1)
		{
			this.FormatParameterName = string_1;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00005D94 File Offset: 0x00003F94
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[NotNull]
		public string FormatParameterName { get; private set; }

		// Token: 0x04000062 RID: 98
		[CompilerGenerated]
		private string string_0;
	}
}
