using System;
using System.Runtime.CompilerServices;

// Token: 0x0200003D RID: 61
[GAttribute14(GEnum1.WithMembers)]
public sealed class GAttribute15 : Attribute
{
	// Token: 0x06000158 RID: 344 RVA: 0x00009190 File Offset: 0x00007390
	public GAttribute15()
	{
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00009510 File Offset: 0x00007710
	public GAttribute15([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x0600015A RID: 346 RVA: 0x0000952C File Offset: 0x0000772C
	// (set) Token: 0x0600015B RID: 347 RVA: 0x00009540 File Offset: 0x00007740
	[GAttribute0]
	public string String_0 { get; private set; }

	// Token: 0x040000BF RID: 191
	[CompilerGenerated]
	private string string_0;
}
