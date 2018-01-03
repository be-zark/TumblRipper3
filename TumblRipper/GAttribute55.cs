using System;
using System.Runtime.CompilerServices;

// Token: 0x02000067 RID: 103
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class GAttribute55 : Attribute
{
	// Token: 0x060001AD RID: 429 RVA: 0x000099C8 File Offset: 0x00007BC8
	public GAttribute55([GAttribute1] string string_1, [GAttribute1] Type type_1)
	{
		this.String_0 = string_1;
		this.Type_0 = type_1;
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060001AE RID: 430 RVA: 0x000099EC File Offset: 0x00007BEC
	// (set) Token: 0x060001AF RID: 431 RVA: 0x00009A00 File Offset: 0x00007C00
	[GAttribute1]
	public string String_0 { get; private set; }

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060001B0 RID: 432 RVA: 0x00009A14 File Offset: 0x00007C14
	// (set) Token: 0x060001B1 RID: 433 RVA: 0x00009A28 File Offset: 0x00007C28
	[GAttribute1]
	public Type Type_0 { get; private set; }

	// Token: 0x040000DC RID: 220
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040000DD RID: 221
	[CompilerGenerated]
	private Type type_0;
}
