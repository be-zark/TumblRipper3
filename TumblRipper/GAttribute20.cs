using System;
using System.Runtime.CompilerServices;

// Token: 0x02000042 RID: 66
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class GAttribute20 : Attribute
{
	// Token: 0x06000163 RID: 355 RVA: 0x00009190 File Offset: 0x00007390
	public GAttribute20()
	{
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00009598 File Offset: 0x00007798
	public GAttribute20([GAttribute20, GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06000165 RID: 357 RVA: 0x000095B4 File Offset: 0x000077B4
	// (set) Token: 0x06000166 RID: 358 RVA: 0x000095C8 File Offset: 0x000077C8
	[GAttribute0]
	public string String_0 { get; private set; }

	// Token: 0x040000C1 RID: 193
	[CompilerGenerated]
	private string string_0;
}
