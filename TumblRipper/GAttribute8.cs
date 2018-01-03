using System;
using System.Runtime.CompilerServices;

// Token: 0x02000034 RID: 52
[AttributeUsage(AttributeTargets.Method)]
public sealed class GAttribute8 : Attribute
{
	// Token: 0x06000136 RID: 310 RVA: 0x00009190 File Offset: 0x00007390
	public GAttribute8()
	{
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0000922C File Offset: 0x0000742C
	public GAttribute8([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000138 RID: 312 RVA: 0x00009248 File Offset: 0x00007448
	// (set) Token: 0x06000139 RID: 313 RVA: 0x0000925C File Offset: 0x0000745C
	[GAttribute0]
	public string String_0 { get; private set; }

	// Token: 0x040000AB RID: 171
	[CompilerGenerated]
	private string string_0;
}
