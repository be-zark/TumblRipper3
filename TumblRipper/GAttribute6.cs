using System;
using System.Runtime.CompilerServices;

// Token: 0x02000032 RID: 50
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class GAttribute6 : Attribute
{
	// Token: 0x06000132 RID: 306 RVA: 0x000091E8 File Offset: 0x000073E8
	public GAttribute6([GAttribute1] string string_1)
	{
		this.Name = string_1;
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000133 RID: 307 RVA: 0x00009204 File Offset: 0x00007404
	// (set) Token: 0x06000134 RID: 308 RVA: 0x00009218 File Offset: 0x00007418
	[GAttribute1]
	public string Name { get; private set; }

	// Token: 0x040000AA RID: 170
	[CompilerGenerated]
	private string string_0;
}
