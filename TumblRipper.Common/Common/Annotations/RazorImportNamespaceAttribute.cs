using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200005C RID: 92
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RazorImportNamespaceAttribute : Attribute
	{
		// Token: 0x06000178 RID: 376 RVA: 0x00006698 File Offset: 0x00004898
		public RazorImportNamespaceAttribute([NotNull] string string_1)
		{
			this.Name = string_1;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000066B4 File Offset: 0x000048B4
		// (set) Token: 0x0600017A RID: 378 RVA: 0x000066C8 File Offset: 0x000048C8
		[NotNull]
		public string Name { get; private set; }

		// Token: 0x04000099 RID: 153
		[CompilerGenerated]
		private string string_0;
	}
}
