using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000037 RID: 55
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class AspMvcMasterLocationFormatAttribute : Attribute
	{
		// Token: 0x06000135 RID: 309 RVA: 0x000062F4 File Offset: 0x000044F4
		public AspMvcMasterLocationFormatAttribute(string string_1)
		{
			this.Format = string_1;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00006310 File Offset: 0x00004510
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00006324 File Offset: 0x00004524
		public string Format { get; private set; }

		// Token: 0x04000081 RID: 129
		[CompilerGenerated]
		private string string_0;
	}
}
