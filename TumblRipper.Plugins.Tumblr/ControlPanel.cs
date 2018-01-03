using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace TumblRipper.Plugins.Tumblr
{
	// Token: 0x0200000D RID: 13
	public class ControlPanel : UserControl, IComponentConnector
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00004880 File Offset: 0x00002A80
		public ControlPanel()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000489C File Offset: 0x00002A9C
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (this.bool_0)
			{
				return;
			}
			this.bool_0 = true;
			Uri uri_ = ControlPanel.smethod_0(<Module>.smethod_25<string>(1606186295u), UriKind.Relative);
			ControlPanel.smethod_1(this, uri_);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000048D4 File Offset: 0x00002AD4
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.checkBox_0 = (CheckBox)target;
				return;
			case 2:
				this.checkBox_1 = (CheckBox)target;
				return;
			case 3:
				this.checkBox_2 = (CheckBox)target;
				return;
			case 4:
				this.checkBox_3 = (CheckBox)target;
				return;
			case 5:
				this.checkBox_4 = (CheckBox)target;
				return;
			case 6:
				this.textBox_0 = (TextBox)target;
				return;
			case 7:
				this.listBox_0 = (ListBox)target;
				return;
			default:
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004968 File Offset: 0x00002B68
		static Uri smethod_0(string string_0, UriKind uriKind_0)
		{
			return new Uri(string_0, uriKind_0);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000497C File Offset: 0x00002B7C
		static void smethod_1(object object_0, Uri uri_0)
		{
			Application.LoadComponent(object_0, uri_0);
		}

		// Token: 0x0400002E RID: 46
		internal CheckBox checkBox_0;

		// Token: 0x0400002F RID: 47
		internal CheckBox checkBox_1;

		// Token: 0x04000030 RID: 48
		internal CheckBox checkBox_2;

		// Token: 0x04000031 RID: 49
		internal CheckBox checkBox_3;

		// Token: 0x04000032 RID: 50
		internal CheckBox checkBox_4;

		// Token: 0x04000033 RID: 51
		internal TextBox textBox_0;

		// Token: 0x04000034 RID: 52
		internal ListBox listBox_0;

		// Token: 0x04000035 RID: 53
		private bool bool_0;
	}
}
