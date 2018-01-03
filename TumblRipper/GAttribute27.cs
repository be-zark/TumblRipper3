using System;
using System.Runtime.CompilerServices;

// Token: 0x02000049 RID: 73
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute27 : Attribute
{
	// Token: 0x0600017B RID: 379 RVA: 0x00009764 File Offset: 0x00007964
	public GAttribute27([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x0600017C RID: 380 RVA: 0x00009780 File Offset: 0x00007980
	// (set) Token: 0x0600017D RID: 381 RVA: 0x00009794 File Offset: 0x00007994
	[GAttribute1]
	public string String_0 { get; private set; }

	// Token: 0x040000C9 RID: 201
	[CompilerGenerated]
	private string string_0;
}
