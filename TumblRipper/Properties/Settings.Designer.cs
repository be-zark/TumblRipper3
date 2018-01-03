using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace TumblRipper.Properties
{
	// Token: 0x02000023 RID: 35
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00007D54 File Offset: 0x00005F54
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x04000071 RID: 113
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
