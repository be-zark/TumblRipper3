using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using TumblRipper.Common.lib;

namespace TumblRipper.Common
{
	// Token: 0x02000019 RID: 25
	public class Controller
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005C64 File Offset: 0x00003E64
		public static string CurrentVersion
		{
			get
			{
				return "3.0a";
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00005C78 File Offset: 0x00003E78
		public Controller Instance
		{
			get
			{
				if (Controller.controller_0 == null)
				{
					Controller.controller_0 = new Controller();
				}
				return Controller.controller_0;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00005C9C File Offset: 0x00003E9C
		public static void Init()
		{
			Controller.controller_0 = new Controller();
			PluginLoader.Init(AppDomain.CurrentDomain.BaseDirectory);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005CC4 File Offset: 0x00003EC4
		public static Task Start(IWebsite w, CancellationToken ct)
		{
			Controller.Class5 @class = new Controller.Class5();
			Controller.cancellationToken_0 = ct;
			Ripper w2 = new Ripper(w);
			@class.itrPlugin_0 = PluginLoader.GetPlugin(w.PluginInName);
			@class.itrPlugin_0.NewInstance(w2, MySettings.Instance.LoadPluginSettingsFile(w.PluginSettingsFilePath));
			Controller.itrPlugin_0 = @class.itrPlugin_0;
			Controller.task_0 = Task.Factory.StartNew(new Action(@class.method_0), Controller.cancellationToken_0);
			return Controller.task_0;
		}

		// Token: 0x0400005D RID: 93
		private static Task task_0;

		// Token: 0x0400005E RID: 94
		private static CancellationToken cancellationToken_0;

		// Token: 0x0400005F RID: 95
		private static Controller controller_0;

		// Token: 0x04000060 RID: 96
		private static ITrPlugin itrPlugin_0;

		// Token: 0x0200001A RID: 26
		[CompilerGenerated]
		private sealed class Class5
		{
			// Token: 0x060000E6 RID: 230 RVA: 0x00005D44 File Offset: 0x00003F44
			internal void method_0()
			{
				this.itrPlugin_0.Start(Controller.cancellationToken_0);
			}

			// Token: 0x04000061 RID: 97
			public ITrPlugin itrPlugin_0;
		}
	}
}
