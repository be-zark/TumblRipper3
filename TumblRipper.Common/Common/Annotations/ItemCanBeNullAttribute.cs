using System;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200001E RID: 30
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public sealed class ItemCanBeNullAttribute : Attribute
	{
	}
}
