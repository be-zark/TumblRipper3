using System;
using System.Runtime.CompilerServices;

// Token: 0x02000045 RID: 69
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute23 : Attribute
{
	// Token: 0x0600016F RID: 367 RVA: 0x00009654 File Offset: 0x00007854
	public GAttribute23([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06000170 RID: 368 RVA: 0x00009670 File Offset: 0x00007870
	// (set) Token: 0x06000171 RID: 369 RVA: 0x00009684 File Offset: 0x00007884
	[GAttribute1]
	public string String_0 { get; private set; }

	// Token: 0x040000C5 RID: 197
	[CompilerGenerated]
	private string string_0;
}
