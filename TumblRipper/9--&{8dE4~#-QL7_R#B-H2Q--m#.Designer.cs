using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000022 RID: 34
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
internal class Class7
{
	// Token: 0x060000A1 RID: 161 RVA: 0x00004E24 File Offset: 0x00003024
	internal Class7()
	{
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x060000A2 RID: 162 RVA: 0x00007CF4 File Offset: 0x00005EF4
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class7.resourceManager_0 == null)
			{
				Class7.resourceManager_0 = new ResourceManager("9/\\&{8dE4~#\"QL7_R#B/H2Q\\\\m#", typeof(Class7).Assembly);
			}
			return Class7.resourceManager_0;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x060000A3 RID: 163 RVA: 0x00007D2C File Offset: 0x00005F2C
	// (set) Token: 0x060000A4 RID: 164 RVA: 0x00007D40 File Offset: 0x00005F40
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class7.cultureInfo_0;
		}
		set
		{
			Class7.cultureInfo_0 = value;
		}
	}

	// Token: 0x0400006F RID: 111
	private static ResourceManager resourceManager_0;

	// Token: 0x04000070 RID: 112
	private static CultureInfo cultureInfo_0;
}
