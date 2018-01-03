using System;
using System.Runtime.CompilerServices;

namespace TumblRipper.Common.Annotations
{
	// Token: 0x02000027 RID: 39
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	[BaseTypeRequired(typeof(Attribute))]
	public sealed class BaseTypeRequiredAttribute : Attribute
	{
		// Token: 0x06000102 RID: 258 RVA: 0x00005F28 File Offset: 0x00004128
		public BaseTypeRequiredAttribute([NotNull] Type type_1)
		{
			this.BaseType = type_1;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00005F44 File Offset: 0x00004144
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00005F58 File Offset: 0x00004158
		[NotNull]
		public Type BaseType { get; private set; }

		// Token: 0x04000068 RID: 104
		[CompilerGenerated]
		private Type type_0;
	}
}
