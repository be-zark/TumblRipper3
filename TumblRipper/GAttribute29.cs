using System;
using System.Runtime.CompilerServices;

// Token: 0x0200004B RID: 75
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public sealed class GAttribute29 : Attribute
{
	// Token: 0x06000181 RID: 385 RVA: 0x00009190 File Offset: 0x00007390
	public GAttribute29()
	{
	}

	// Token: 0x06000182 RID: 386 RVA: 0x000097EC File Offset: 0x000079EC
	public GAttribute29([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000183 RID: 387 RVA: 0x00009808 File Offset: 0x00007A08
	// (set) Token: 0x06000184 RID: 388 RVA: 0x0000981C File Offset: 0x00007A1C
	[GAttribute0]
	public string String_0 { get; private set; }

	// Token: 0x040000CB RID: 203
	[CompilerGenerated]
	private string string_0;
}
