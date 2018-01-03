using System;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x0200001B RID: 27
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.GenericParameter)]
	public sealed class CanBeNullAttribute : Attribute
	{
	}
}
