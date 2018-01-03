using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000033 RID: 51
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = true)]
	public sealed class MacroAttribute : Attribute
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000061B0 File Offset: 0x000043B0
		// (set) Token: 0x06000126 RID: 294 RVA: 0x000061C4 File Offset: 0x000043C4
		public string Expression { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000061D8 File Offset: 0x000043D8
		// (set) Token: 0x06000128 RID: 296 RVA: 0x000061EC File Offset: 0x000043EC
		public int Editable { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00006200 File Offset: 0x00004400
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00006214 File Offset: 0x00004414
		public string Target { get; set; }

		// Token: 0x0400007B RID: 123
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400007C RID: 124
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400007D RID: 125
		[CompilerGenerated]
		private string string_1;
	}
}
