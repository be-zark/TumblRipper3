using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000034 RID: 52
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00006228 File Offset: 0x00004428
		public AspMvcAreaMasterLocationFormatAttribute([NotNull] string string_1)
		{
			this.Format = string_1;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00006244 File Offset: 0x00004444
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00006258 File Offset: 0x00004458
		[NotNull]
		public string Format { get; private set; }

		// Token: 0x0400007E RID: 126
		[CompilerGenerated]
		private string string_0;
	}
}
