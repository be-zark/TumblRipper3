using System;
using System.Runtime.CompilerServices;

// Token: 0x02000035 RID: 53
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class GAttribute9 : Attribute
{
	// Token: 0x0600013A RID: 314 RVA: 0x00009270 File Offset: 0x00007470
	public GAttribute9([GAttribute1] string string_1) : this(string_1, false)
	{
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00009288 File Offset: 0x00007488
	public GAttribute9([GAttribute1] string string_1, bool bool_1)
	{
		this.String_0 = string_1;
		this.Boolean_0 = bool_1;
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x0600013C RID: 316 RVA: 0x000092AC File Offset: 0x000074AC
	// (set) Token: 0x0600013D RID: 317 RVA: 0x000092C0 File Offset: 0x000074C0
	[GAttribute1]
	public string String_0 { get; private set; }

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x0600013E RID: 318 RVA: 0x000092D4 File Offset: 0x000074D4
	// (set) Token: 0x0600013F RID: 319 RVA: 0x000092E8 File Offset: 0x000074E8
	public bool Boolean_0 { get; private set; }

	// Token: 0x040000AC RID: 172
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040000AD RID: 173
	[CompilerGenerated]
	private bool bool_0;
}
