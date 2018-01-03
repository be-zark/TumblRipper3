using System;
using System.Runtime.CompilerServices;

// Token: 0x02000038 RID: 56
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
[GAttribute12(typeof(Attribute))]
public sealed class GAttribute12 : Attribute
{
	// Token: 0x06000145 RID: 325 RVA: 0x00009354 File Offset: 0x00007554
	public GAttribute12([GAttribute1] Type type_1)
	{
		this.Type_0 = type_1;
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000146 RID: 326 RVA: 0x00009370 File Offset: 0x00007570
	// (set) Token: 0x06000147 RID: 327 RVA: 0x00009384 File Offset: 0x00007584
	[GAttribute1]
	public Type Type_0 { get; private set; }

	// Token: 0x040000AF RID: 175
	[CompilerGenerated]
	private Type type_0;
}
