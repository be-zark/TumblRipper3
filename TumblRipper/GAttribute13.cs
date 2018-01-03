using System;
using System.Runtime.CompilerServices;

// Token: 0x02000039 RID: 57
[AttributeUsage(AttributeTargets.All)]
public sealed class GAttribute13 : Attribute
{
	// Token: 0x06000148 RID: 328 RVA: 0x00009398 File Offset: 0x00007598
	public GAttribute13() : this(GEnum0.Default, GEnum1.Default)
	{
	}

	// Token: 0x06000149 RID: 329 RVA: 0x000093B0 File Offset: 0x000075B0
	public GAttribute13(GEnum0 genum0_1) : this(genum0_1, GEnum1.Default)
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x000093C8 File Offset: 0x000075C8
	public GAttribute13(GEnum1 genum1_1) : this(GEnum0.Default, genum1_1)
	{
	}

	// Token: 0x0600014B RID: 331 RVA: 0x000093E0 File Offset: 0x000075E0
	public GAttribute13(GEnum0 genum0_1, GEnum1 genum1_1)
	{
		this.GEnum0_0 = genum0_1;
		this.GEnum1_0 = genum1_1;
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x0600014C RID: 332 RVA: 0x00009404 File Offset: 0x00007604
	// (set) Token: 0x0600014D RID: 333 RVA: 0x00009418 File Offset: 0x00007618
	public GEnum0 GEnum0_0 { get; private set; }

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600014E RID: 334 RVA: 0x0000942C File Offset: 0x0000762C
	// (set) Token: 0x0600014F RID: 335 RVA: 0x00009440 File Offset: 0x00007640
	public GEnum1 GEnum1_0 { get; private set; }

	// Token: 0x040000B0 RID: 176
	[CompilerGenerated]
	private GEnum0 genum0_0;

	// Token: 0x040000B1 RID: 177
	[CompilerGenerated]
	private GEnum1 genum1_0;
}
