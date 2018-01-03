using System;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000050 RID: 80
	[Obsolete("Use [ContractAnnotation('=> halt')] instead")]
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class TerminatesProgramAttribute : Attribute
	{
	}
}
