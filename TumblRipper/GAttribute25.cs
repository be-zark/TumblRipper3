using System;
using System.Runtime.CompilerServices;

// Token: 0x02000047 RID: 71
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute25 : Attribute
{
	// Token: 0x06000175 RID: 373 RVA: 0x000096DC File Offset: 0x000078DC
	public GAttribute25([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000176 RID: 374 RVA: 0x000096F8 File Offset: 0x000078F8
	// (set) Token: 0x06000177 RID: 375 RVA: 0x0000970C File Offset: 0x0000790C
	[GAttribute1]
	public string String_0 { get; private set; }

	// Token: 0x040000C7 RID: 199
	[CompilerGenerated]
	private string string_0;
}
