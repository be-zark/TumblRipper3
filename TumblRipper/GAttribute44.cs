using System;
using System.Runtime.CompilerServices;

// Token: 0x0200005A RID: 90
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class GAttribute44 : Attribute
{
	// Token: 0x0600019C RID: 412 RVA: 0x000098FC File Offset: 0x00007AFC
	public GAttribute44([GAttribute1] string string_1)
	{
		this.Name = string_1;
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x0600019D RID: 413 RVA: 0x00009918 File Offset: 0x00007B18
	// (set) Token: 0x0600019E RID: 414 RVA: 0x0000992C File Offset: 0x00007B2C
	[GAttribute1]
	public string Name { get; private set; }

	// Token: 0x040000CF RID: 207
	[CompilerGenerated]
	private string string_0;
}
