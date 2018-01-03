using System;
using System.Threading;
using System.Windows.Controls;

namespace TumblRipper
{
	// Token: 0x02000010 RID: 16
	public interface ITrPlugin
	{
		// Token: 0x06000075 RID: 117
		string GetName();

		// Token: 0x06000076 RID: 118
		TrPluginConfiguration GetInfo();

		// Token: 0x06000077 RID: 119
		bool ValidateUrl(IRipper w, string url);

		// Token: 0x06000078 RID: 120
		string GetFriendlyUrlTitle(IRipper w, string url);

		// Token: 0x06000079 RID: 121
		void Init();

		// Token: 0x0600007A RID: 122
		ITrPlugin NewInstance(IRipper w, string config);

		// Token: 0x0600007B RID: 123
		void Start(CancellationToken _cancellationToken);

		// Token: 0x0600007C RID: 124
		string GetConfiguration();

		// Token: 0x0600007D RID: 125
		UserControl GetControlPanel(string settings);
	}
}
