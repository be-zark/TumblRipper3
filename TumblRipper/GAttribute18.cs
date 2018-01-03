using System;
using System.Runtime.CompilerServices;

// Token: 0x02000040 RID: 64
[AttributeUsage(AttributeTargets.Method)]
public sealed class GAttribute18 : Attribute
{
	// Token: 0x0600015E RID: 350 RVA: 0x00009190 File Offset: 0x00007390
	public GAttribute18()
	{
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00009554 File Offset: 0x00007754
	public GAttribute18([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000160 RID: 352 RVA: 0x00009570 File Offset: 0x00007770
	// (set) Token: 0x06000161 RID: 353 RVA: 0x00009584 File Offset: 0x00007784
	[GAttribute0]
	public string String_0 { get; private set; }

	// Token: 0x040000C0 RID: 192
	[CompilerGenerated]
	private string string_0;
}
