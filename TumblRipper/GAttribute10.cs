using System;
using System.Runtime.CompilerServices;

// Token: 0x02000036 RID: 54
[AttributeUsage(AttributeTargets.All)]
public sealed class GAttribute10 : Attribute
{
	// Token: 0x06000140 RID: 320 RVA: 0x000092FC File Offset: 0x000074FC
	public GAttribute10() : this(true)
	{
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00009310 File Offset: 0x00007510
	public GAttribute10(bool bool_1)
	{
		this.Boolean_0 = bool_1;
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000142 RID: 322 RVA: 0x0000932C File Offset: 0x0000752C
	// (set) Token: 0x06000143 RID: 323 RVA: 0x00009340 File Offset: 0x00007540
	public bool Boolean_0 { get; private set; }

	// Token: 0x040000AE RID: 174
	[CompilerGenerated]
	private bool bool_0;
}
