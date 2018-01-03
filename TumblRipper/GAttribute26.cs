using System;
using System.Runtime.CompilerServices;

// Token: 0x02000048 RID: 72
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute26 : Attribute
{
	// Token: 0x06000178 RID: 376 RVA: 0x00009720 File Offset: 0x00007920
	public GAttribute26(string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000179 RID: 377 RVA: 0x0000973C File Offset: 0x0000793C
	// (set) Token: 0x0600017A RID: 378 RVA: 0x00009750 File Offset: 0x00007950
	public string String_0 { get; private set; }

	// Token: 0x040000C8 RID: 200
	[CompilerGenerated]
	private string string_0;
}
