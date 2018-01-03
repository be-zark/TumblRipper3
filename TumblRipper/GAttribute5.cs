using System;
using System.Runtime.CompilerServices;

// Token: 0x02000031 RID: 49
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate)]
public sealed class GAttribute5 : Attribute
{
	// Token: 0x0600012F RID: 303 RVA: 0x000091A4 File Offset: 0x000073A4
	public GAttribute5([GAttribute1] string string_1)
	{
		this.String_0 = string_1;
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000130 RID: 304 RVA: 0x000091C0 File Offset: 0x000073C0
	// (set) Token: 0x06000131 RID: 305 RVA: 0x000091D4 File Offset: 0x000073D4
	[GAttribute1]
	public string String_0 { get; private set; }

	// Token: 0x040000A9 RID: 169
	[CompilerGenerated]
	private string string_0;
}
