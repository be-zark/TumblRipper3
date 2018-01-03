using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200004E RID: 78
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class AssertionConditionAttribute : Attribute
	{
		// Token: 0x06000161 RID: 353 RVA: 0x00006558 File Offset: 0x00004758
		public AssertionConditionAttribute(AssertionConditionType assertionConditionType_1)
		{
			this.ConditionType = assertionConditionType_1;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00006574 File Offset: 0x00004774
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00006588 File Offset: 0x00004788
		public AssertionConditionType ConditionType { get; private set; }

		// Token: 0x0400008F RID: 143
		[CompilerGenerated]
		private AssertionConditionType assertionConditionType_0;
	}
}
