using System;
using System.Runtime.CompilerServices;

// Token: 0x02000046 RID: 70
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute24 : Attribute
{
	// Token: 0x06000172 RID: 370 RVA: 0x00009698 File Offset: 0x00007898
	public GAttribute24([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06000173 RID: 371 RVA: 0x000096B4 File Offset: 0x000078B4
	// (set) Token: 0x06000174 RID: 372 RVA: 0x000096C8 File Offset: 0x000078C8
	[GAttribute1]
	public string String_0 { get; private set; }

	// Token: 0x040000C6 RID: 198
	[CompilerGenerated]
	private string string_0;
}
