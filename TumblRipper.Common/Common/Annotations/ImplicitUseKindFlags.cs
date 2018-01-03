using System;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200002A RID: 42
	[Flags]
	public enum ImplicitUseKindFlags
	{
		// Token: 0x0400006E RID: 110
		Default = 7,
		// Token: 0x0400006F RID: 111
		Access = 1,
		// Token: 0x04000070 RID: 112
		Assign = 2,
		// Token: 0x04000071 RID: 113
		InstantiatedWithFixedConstructorSignature = 4,
		// Token: 0x04000072 RID: 114
		InstantiatedNoFixedConstructorSignature = 8
	}
}
