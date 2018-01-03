using System;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200001D RID: 29
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public sealed class ItemNotNullAttribute : Attribute
	{
	}
}
