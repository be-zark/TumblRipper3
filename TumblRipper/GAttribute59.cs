using System;
using System.Runtime.CompilerServices;

// Token: 0x0200006B RID: 107
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class GAttribute59 : Attribute
{
	// Token: 0x060001B5 RID: 437 RVA: 0x00009A3C File Offset: 0x00007C3C
	public GAttribute59([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060001B6 RID: 438 RVA: 0x00009A58 File Offset: 0x00007C58
	// (set) Token: 0x060001B7 RID: 439 RVA: 0x00009A6C File Offset: 0x00007C6C
	[GAttribute1]
	public string String_0 { get; private set; }

	// Token: 0x040000DE RID: 222
	[CompilerGenerated]
	private string string_0;
}
