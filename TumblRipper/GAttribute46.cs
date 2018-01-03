using System;
using System.Runtime.CompilerServices;

// Token: 0x0200005C RID: 92
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
public sealed class GAttribute46 : Attribute
{
	// Token: 0x060001A0 RID: 416 RVA: 0x00009940 File Offset: 0x00007B40
	public GAttribute46(GEnum2 genum2_1)
	{
		this.GEnum2_0 = genum2_1;
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000995C File Offset: 0x00007B5C
	// (set) Token: 0x060001A2 RID: 418 RVA: 0x00009970 File Offset: 0x00007B70
	public GEnum2 GEnum2_0 { get; private set; }

	// Token: 0x040000D0 RID: 208
	[CompilerGenerated]
	private GEnum2 genum2_0;
}
