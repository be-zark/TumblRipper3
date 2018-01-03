using System;
using System.Runtime.CompilerServices;

// Token: 0x0200004C RID: 76
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class GAttribute30 : Attribute
{
	// Token: 0x06000185 RID: 389 RVA: 0x00009190 File Offset: 0x00007390
	public GAttribute30()
	{
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00009830 File Offset: 0x00007A30
	public GAttribute30([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000187 RID: 391 RVA: 0x0000984C File Offset: 0x00007A4C
	// (set) Token: 0x06000188 RID: 392 RVA: 0x00009860 File Offset: 0x00007A60
	[GAttribute0]
	public string String_0 { get; private set; }

	// Token: 0x040000CC RID: 204
	[CompilerGenerated]
	private string string_0;
}
