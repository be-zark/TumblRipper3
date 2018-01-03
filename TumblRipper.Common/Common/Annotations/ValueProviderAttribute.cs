using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000021 RID: 33
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	public sealed class ValueProviderAttribute : Attribute
	{
		// Token: 0x060000EF RID: 239 RVA: 0x00005DBC File Offset: 0x00003FBC
		public ValueProviderAttribute([NotNull] string string_1)
		{
			this.Name = string_1;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005DD8 File Offset: 0x00003FD8
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00005DEC File Offset: 0x00003FEC
		[NotNull]
		public string Name { get; private set; }

		// Token: 0x04000063 RID: 99
		[CompilerGenerated]
		private string string_0;
	}
}
