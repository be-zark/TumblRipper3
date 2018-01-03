using System;
using System.Runtime.CompilerServices;

// Token: 0x0200006C RID: 108
[AttributeUsage(AttributeTargets.Property)]
public sealed class GAttribute60 : Attribute
{
	// Token: 0x17000053 RID: 83
	// (get) Token: 0x060001B8 RID: 440 RVA: 0x00009A80 File Offset: 0x00007C80
	// (set) Token: 0x060001B9 RID: 441 RVA: 0x00009A94 File Offset: 0x00007C94
	public bool Boolean_0 { get; private set; }

	// Token: 0x060001BA RID: 442 RVA: 0x00009AA8 File Offset: 0x00007CA8
	public GAttribute60(bool bool_1)
	{
		this.Boolean_0 = bool_1;
	}

	// Token: 0x040000DF RID: 223
	[CompilerGenerated]
	private bool bool_0;
}
