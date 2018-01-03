using System;
using System.Runtime.CompilerServices;

// Token: 0x0200006D RID: 109
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class GAttribute61 : Attribute
{
	// Token: 0x060001BB RID: 443 RVA: 0x00009AC4 File Offset: 0x00007CC4
	public GAttribute61([GAttribute1] string string_1)
	{
		this.Name = string_1;
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x060001BC RID: 444 RVA: 0x00009AE0 File Offset: 0x00007CE0
	// (set) Token: 0x060001BD RID: 445 RVA: 0x00009AF4 File Offset: 0x00007CF4
	[GAttribute1]
	public string Name { get; private set; }

	// Token: 0x040000E0 RID: 224
	[CompilerGenerated]
	private string string_0;
}
