using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200004B RID: 75
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class CollectionAccessAttribute : Attribute
	{
		// Token: 0x0600015D RID: 349 RVA: 0x00006514 File Offset: 0x00004714
		public CollectionAccessAttribute(CollectionAccessType collectionAccessType_1)
		{
			this.CollectionAccessType = collectionAccessType_1;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00006530 File Offset: 0x00004730
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00006544 File Offset: 0x00004744
		public CollectionAccessType CollectionAccessType { get; private set; }

		// Token: 0x04000089 RID: 137
		[CompilerGenerated]
		private CollectionAccessType collectionAccessType_0;
	}
}
