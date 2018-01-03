using System;
using System.Runtime.CompilerServices;

// Token: 0x02000059 RID: 89
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class GAttribute43 : Attribute
{
	// Token: 0x06000198 RID: 408 RVA: 0x00009190 File Offset: 0x00007390
	public GAttribute43()
	{
	}

	// Token: 0x06000199 RID: 409 RVA: 0x000098B8 File Offset: 0x00007AB8
	public GAttribute43([GAttribute1] string string_1)
	{
		this.Name = string_1;
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x0600019A RID: 410 RVA: 0x000098D4 File Offset: 0x00007AD4
	// (set) Token: 0x0600019B RID: 411 RVA: 0x000098E8 File Offset: 0x00007AE8
	[GAttribute0]
	public string Name { get; private set; }

	// Token: 0x040000CE RID: 206
	[CompilerGenerated]
	private string string_0;
}
