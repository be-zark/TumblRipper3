using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000024 RID: 36
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public sealed class ContractAnnotationAttribute : Attribute
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00005E44 File Offset: 0x00004044
		public ContractAnnotationAttribute([NotNull] string string_1) : this(string_1, false)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005E5C File Offset: 0x0000405C
		public ContractAnnotationAttribute([NotNull] string string_1, bool bool_1)
		{
			this.Contract = string_1;
			this.ForceFullStates = bool_1;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00005E80 File Offset: 0x00004080
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00005E94 File Offset: 0x00004094
		[NotNull]
		public string Contract { get; private set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00005EA8 File Offset: 0x000040A8
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00005EBC File Offset: 0x000040BC
		public bool ForceFullStates { get; private set; }

		// Token: 0x04000065 RID: 101
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000066 RID: 102
		[CompilerGenerated]
		private bool bool_0;
	}
}
