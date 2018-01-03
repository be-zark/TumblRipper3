using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000056 RID: 86
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class AspChildControlTypeAttribute : Attribute
	{
		// Token: 0x0600016A RID: 362 RVA: 0x0000659C File Offset: 0x0000479C
		public AspChildControlTypeAttribute([NotNull] string string_1, [NotNull] Type type_1)
		{
			this.TagName = string_1;
			this.ControlType = type_1;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000065C0 File Offset: 0x000047C0
		// (set) Token: 0x0600016C RID: 364 RVA: 0x000065D4 File Offset: 0x000047D4
		[NotNull]
		public string TagName { get; private set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000065E8 File Offset: 0x000047E8
		// (set) Token: 0x0600016E RID: 366 RVA: 0x000065FC File Offset: 0x000047FC
		[NotNull]
		public Type ControlType { get; private set; }

		// Token: 0x04000095 RID: 149
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000096 RID: 150
		[CompilerGenerated]
		private Type type_0;
	}
}
