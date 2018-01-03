using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200005B RID: 91
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class AspTypePropertyAttribute : Attribute
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00006654 File Offset: 0x00004854
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00006668 File Offset: 0x00004868
		public bool CreateConstructorReferences { get; private set; }

		// Token: 0x06000177 RID: 375 RVA: 0x0000667C File Offset: 0x0000487C
		public AspTypePropertyAttribute(bool bool_1)
		{
			this.CreateConstructorReferences = bool_1;
		}

		// Token: 0x04000098 RID: 152
		[CompilerGenerated]
		private bool bool_0;
	}
}
