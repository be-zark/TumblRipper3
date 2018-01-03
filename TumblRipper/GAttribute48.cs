using System;
using System.Runtime.CompilerServices;

// Token: 0x0200005F RID: 95
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class GAttribute48 : Attribute
{
	// Token: 0x060001A4 RID: 420 RVA: 0x00009984 File Offset: 0x00007B84
	public GAttribute48(GEnum3 genum3_1)
	{
		this.GEnum3_0 = genum3_1;
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060001A5 RID: 421 RVA: 0x000099A0 File Offset: 0x00007BA0
	// (set) Token: 0x060001A6 RID: 422 RVA: 0x000099B4 File Offset: 0x00007BB4
	public GEnum3 GEnum3_0 { get; private set; }

	// Token: 0x040000D6 RID: 214
	[CompilerGenerated]
	private GEnum3 genum3_0;
}
