using System;
using System.Runtime.CompilerServices;

// Token: 0x0200004A RID: 74
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute28 : Attribute
{
	// Token: 0x0600017E RID: 382 RVA: 0x000097A8 File Offset: 0x000079A8
	public GAttribute28([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600017F RID: 383 RVA: 0x000097C4 File Offset: 0x000079C4
	// (set) Token: 0x06000180 RID: 384 RVA: 0x000097D8 File Offset: 0x000079D8
	[GAttribute1]
	public string String_0 { get; private set; }

	// Token: 0x040000CA RID: 202
	[CompilerGenerated]
	private string string_0;
}
