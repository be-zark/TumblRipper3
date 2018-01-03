using System;
using System.Runtime.CompilerServices;

// Token: 0x0200006F RID: 111
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute63 : Attribute
{
	// Token: 0x060001C3 RID: 451 RVA: 0x00009B7C File Offset: 0x00007D7C
	public GAttribute63([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x060001C4 RID: 452 RVA: 0x00009B98 File Offset: 0x00007D98
	// (set) Token: 0x060001C5 RID: 453 RVA: 0x00009BAC File Offset: 0x00007DAC
	[GAttribute1]
	public string String_0 { get; private set; }

	// Token: 0x040000E3 RID: 227
	[CompilerGenerated]
	private string string_0;
}
