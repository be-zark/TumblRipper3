using System;
using System.Runtime.CompilerServices;

// Token: 0x0200003A RID: 58
[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
public sealed class GAttribute14 : Attribute
{
	// Token: 0x06000150 RID: 336 RVA: 0x00009454 File Offset: 0x00007654
	public GAttribute14() : this(GEnum0.Default, GEnum1.Default)
	{
	}

	// Token: 0x06000151 RID: 337 RVA: 0x0000946C File Offset: 0x0000766C
	public GAttribute14(GEnum0 genum0_1) : this(genum0_1, GEnum1.Default)
	{
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00009484 File Offset: 0x00007684
	public GAttribute14(GEnum1 genum1_1) : this(GEnum0.Default, genum1_1)
	{
	}

	// Token: 0x06000153 RID: 339 RVA: 0x0000949C File Offset: 0x0000769C
	public GAttribute14(GEnum0 genum0_1, GEnum1 genum1_1)
	{
		this.GEnum0_0 = genum0_1;
		this.GEnum1_0 = genum1_1;
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000154 RID: 340 RVA: 0x000094C0 File Offset: 0x000076C0
	// (set) Token: 0x06000155 RID: 341 RVA: 0x000094D4 File Offset: 0x000076D4
	[GAttribute13]
	public GEnum0 GEnum0_0 { get; private set; }

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x06000156 RID: 342 RVA: 0x000094E8 File Offset: 0x000076E8
	// (set) Token: 0x06000157 RID: 343 RVA: 0x000094FC File Offset: 0x000076FC
	[GAttribute13]
	public GEnum1 GEnum1_0 { get; private set; }

	// Token: 0x040000B2 RID: 178
	[CompilerGenerated]
	private GEnum0 genum0_0;

	// Token: 0x040000B3 RID: 179
	[CompilerGenerated]
	private GEnum1 genum1_0;
}
