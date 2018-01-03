using System;
using System.Runtime.CompilerServices;

// Token: 0x0200006E RID: 110
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute62 : Attribute
{
	// Token: 0x060001BE RID: 446 RVA: 0x00009B08 File Offset: 0x00007D08
	public GAttribute62([GAttribute1] string string_2, [GAttribute1] string string_3)
	{
		this.String_0 = string_2;
		this.String_1 = string_3;
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x060001BF RID: 447 RVA: 0x00009B2C File Offset: 0x00007D2C
	// (set) Token: 0x060001C0 RID: 448 RVA: 0x00009B40 File Offset: 0x00007D40
	[GAttribute1]
	public string String_0 { get; private set; }

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x060001C1 RID: 449 RVA: 0x00009B54 File Offset: 0x00007D54
	// (set) Token: 0x060001C2 RID: 450 RVA: 0x00009B68 File Offset: 0x00007D68
	[GAttribute1]
	public string String_1 { get; private set; }

	// Token: 0x040000E1 RID: 225
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040000E2 RID: 226
	[CompilerGenerated]
	private string string_1;
}
