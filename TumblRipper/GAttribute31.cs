using System;
using System.Runtime.CompilerServices;

// Token: 0x0200004D RID: 77
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public sealed class GAttribute31 : Attribute
{
	// Token: 0x06000189 RID: 393 RVA: 0x00009190 File Offset: 0x00007390
	public GAttribute31()
	{
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00009874 File Offset: 0x00007A74
	public GAttribute31([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x0600018B RID: 395 RVA: 0x00009890 File Offset: 0x00007A90
	// (set) Token: 0x0600018C RID: 396 RVA: 0x000098A4 File Offset: 0x00007AA4
	[GAttribute0]
	public string String_0 { get; private set; }

	// Token: 0x040000CD RID: 205
	[CompilerGenerated]
	private string string_0;
}
