using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000023 RID: 35
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00005D64 File Offset: 0x00003F64
		public NotifyPropertyChangedInvocatorAttribute()
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005E00 File Offset: 0x00004000
		public NotifyPropertyChangedInvocatorAttribute([NotNull] string string_1)
		{
			this.ParameterName = string_1;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00005E1C File Offset: 0x0000401C
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00005E30 File Offset: 0x00004030
		[CanBeNull]
		public string ParameterName { get; private set; }

		// Token: 0x04000064 RID: 100
		[CompilerGenerated]
		private string string_0;
	}
}
