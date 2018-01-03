using System;
using System.Runtime.CompilerServices;

// Token: 0x02000044 RID: 68
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = true)]
public sealed class GAttribute22 : Attribute
{
	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000168 RID: 360 RVA: 0x000095DC File Offset: 0x000077DC
	// (set) Token: 0x06000169 RID: 361 RVA: 0x000095F0 File Offset: 0x000077F0
	public string String_0 { get; set; }

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600016A RID: 362 RVA: 0x00009604 File Offset: 0x00007804
	// (set) Token: 0x0600016B RID: 363 RVA: 0x00009618 File Offset: 0x00007818
	public int Int32_0 { get; set; }

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x0600016C RID: 364 RVA: 0x0000962C File Offset: 0x0000782C
	// (set) Token: 0x0600016D RID: 365 RVA: 0x00009640 File Offset: 0x00007840
	public string String_1 { get; set; }

	// Token: 0x040000C2 RID: 194
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040000C3 RID: 195
	[CompilerGenerated]
	private int int_0;

	// Token: 0x040000C4 RID: 196
	[CompilerGenerated]
	private string string_1;
}
