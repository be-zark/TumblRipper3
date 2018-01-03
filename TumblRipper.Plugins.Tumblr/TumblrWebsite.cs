using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Xml.Serialization;

namespace TumblRipper.Plugins.Tumblr
{
	// Token: 0x02000015 RID: 21
	public class TumblrWebsite : ITrPlugin
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000755C File Offset: 0x0000575C
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00007570 File Offset: 0x00005770
		public TumblrSettings TumblrSettings { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00007584 File Offset: 0x00005784
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00007598 File Offset: 0x00005798
		public TumblrBlogRipper BlogRipper { get; set; }

		// Token: 0x060000F4 RID: 244 RVA: 0x000075AC File Offset: 0x000057AC
		public TumblrWebsite()
		{
			this.TumblrSettings = new TumblrSettings();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000075CC File Offset: 0x000057CC
		public string GetName()
		{
			return <Module>.smethod_27<string>(4148365419u);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000075E4 File Offset: 0x000057E4
		public TrPluginConfiguration GetInfo()
		{
			TrPluginConfiguration trPluginConfiguration = TumblrWebsite.smethod_0();
			trPluginConfiguration.HasExtraConfiguration = true;
			trPluginConfiguration.Version = 1;
			trPluginConfiguration.Author = <Module>.smethod_28<string>(1134803139u);
			trPluginConfiguration.AuthorWebsite = <Module>.smethod_26<string>(586652140u);
			return trPluginConfiguration;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00007624 File Offset: 0x00005824
		public bool ValidateUrl(IRipper w, string url)
		{
			return true;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00007634 File Offset: 0x00005834
		public string GetFriendlyUrlTitle(IRipper w, string url)
		{
			string result = TumblrWebsite.smethod_1(url, <Module>.smethod_25<string>(2077360212u), "");
			try
			{
				result = new TumblrBlogRipper(this)
				{
					MyRipper = w
				}.GetTitle(url);
			}
			catch (Exception)
			{
				throw;
			}
			return result;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00007684 File Offset: 0x00005884
		public void Init()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00007694 File Offset: 0x00005894
		private TumblrSettings method_0(string string_0)
		{
			TumblrSettings result;
			try
			{
				XmlSerializer xmlSerializer_ = TumblrWebsite.smethod_3(TumblrWebsite.smethod_2(typeof(TumblrSettings).TypeHandle));
				StringReader stringReader = TumblrWebsite.smethod_4(string_0);
				try
				{
					result = (TumblrWebsite.smethod_5(xmlSerializer_, stringReader) as TumblrSettings);
				}
				finally
				{
					if (stringReader != null)
					{
						TumblrWebsite.smethod_6(stringReader);
					}
				}
			}
			catch (Exception)
			{
				result = new TumblrSettings();
			}
			return result;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000076F8 File Offset: 0x000058F8
		public string writeSettings(TumblrSettings settings)
		{
			XmlSerializer xmlSerializer_ = TumblrWebsite.smethod_3(TumblrWebsite.smethod_2(typeof(TumblrSettings).TypeHandle));
			StringWriter stringWriter = TumblrWebsite.smethod_7();
			TumblrWebsite.smethod_8(xmlSerializer_, stringWriter, settings);
			TumblrWebsite.smethod_9(stringWriter);
			return TumblrWebsite.smethod_10(stringWriter);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007730 File Offset: 0x00005930
		public ITrPlugin NewInstance(IRipper w, string xmlConfig)
		{
			ITrPlugin result = new TumblrWebsite();
			TumblrSettings tumblrSettings = this.method_0(xmlConfig);
			this.TumblrSettings = tumblrSettings;
			this.BlogRipper = new TumblrBlogRipper(this)
			{
				MyRipper = w,
				Settings = this.TumblrSettings
			};
			return result;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007770 File Offset: 0x00005970
		public void Start(CancellationToken _cancellationToken)
		{
			this.BlogRipper.Start(_cancellationToken);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000778C File Offset: 0x0000598C
		public UserControl GetControlPanel(string s)
		{
			this.controlPanel_0 = new ControlPanel();
			TumblrSettings tumblrSettings = this.method_0(s);
			TumblrWebsite.smethod_11(this.controlPanel_0.checkBox_1, new bool?(tumblrSettings.DoPhotoSets));
			TumblrWebsite.smethod_11(this.controlPanel_0.checkBox_0, new bool?(tumblrSettings.DoVideos));
			TumblrWebsite.smethod_11(this.controlPanel_0.checkBox_2, new bool?(tumblrSettings.DoRename));
			TumblrWebsite.smethod_11(this.controlPanel_0.checkBox_3, new bool?(tumblrSettings.DoReblogs));
			TumblrWebsite.smethod_11(this.controlPanel_0.checkBox_4, new bool?(tumblrSettings.DoTags));
			TumblrWebsite.smethod_12(this.controlPanel_0.textBox_0, tumblrSettings.FilenameMask);
			return this.controlPanel_0;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007850 File Offset: 0x00005A50
		public string GetConfiguration()
		{
			bool doPhotoSets = TumblrWebsite.smethod_13(this.controlPanel_0.checkBox_1) != null && TumblrWebsite.smethod_13(this.controlPanel_0.checkBox_1).Value;
			bool doVideos = TumblrWebsite.smethod_13(this.controlPanel_0.checkBox_0) != null && TumblrWebsite.smethod_13(this.controlPanel_0.checkBox_0).Value;
			bool doRename = TumblrWebsite.smethod_13(this.controlPanel_0.checkBox_2) != null && TumblrWebsite.smethod_13(this.controlPanel_0.checkBox_2).Value;
			bool doReblogs = TumblrWebsite.smethod_13(this.controlPanel_0.checkBox_3) != null && TumblrWebsite.smethod_13(this.controlPanel_0.checkBox_3).Value;
			bool doTags = TumblrWebsite.smethod_13(this.controlPanel_0.checkBox_4) != null && TumblrWebsite.smethod_13(this.controlPanel_0.checkBox_4).Value;
			string filenameMask = TumblrWebsite.smethod_14(this.controlPanel_0.textBox_0);
			TumblrSettings settings = new TumblrSettings
			{
				DoPhotoSets = doPhotoSets,
				DoVideos = doVideos,
				DoRename = doRename,
				DoReblogs = doReblogs,
				DoTags = doTags,
				FilenameMask = filenameMask
			};
			return this.writeSettings(settings);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000079C4 File Offset: 0x00005BC4
		static TrPluginConfiguration smethod_0()
		{
			return new TrPluginConfiguration();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00006E54 File Offset: 0x00005054
		static string smethod_1(string string_0, string string_1, string string_2)
		{
			return string_0.Replace(string_1, string_2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000029D0 File Offset: 0x00000BD0
		static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000079D8 File Offset: 0x00005BD8
		static XmlSerializer smethod_3(Type type_0)
		{
			return new XmlSerializer(type_0);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000079EC File Offset: 0x00005BEC
		static StringReader smethod_4(string string_0)
		{
			return new StringReader(string_0);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00007A00 File Offset: 0x00005C00
		static object smethod_5(XmlSerializer xmlSerializer_0, TextReader textReader_0)
		{
			return xmlSerializer_0.Deserialize(textReader_0);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00006C9C File Offset: 0x00004E9C
		static void smethod_6(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00007A14 File Offset: 0x00005C14
		static StringWriter smethod_7()
		{
			return new StringWriter();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00007A28 File Offset: 0x00005C28
		static void smethod_8(XmlSerializer xmlSerializer_0, TextWriter textWriter_0, object object_0)
		{
			xmlSerializer_0.Serialize(textWriter_0, object_0);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00007A40 File Offset: 0x00005C40
		static void smethod_9(TextWriter textWriter_0)
		{
			textWriter_0.Close();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00007A54 File Offset: 0x00005C54
		static string smethod_10(object object_0)
		{
			return object_0.ToString();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00007A68 File Offset: 0x00005C68
		static void smethod_11(ToggleButton toggleButton_0, bool? nullable_0)
		{
			toggleButton_0.IsChecked = nullable_0;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00007A7C File Offset: 0x00005C7C
		static void smethod_12(TextBox textBox_0, string string_0)
		{
			textBox_0.Text = string_0;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00007A90 File Offset: 0x00005C90
		static bool? smethod_13(ToggleButton toggleButton_0)
		{
			return toggleButton_0.IsChecked;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00007AA4 File Offset: 0x00005CA4
		static string smethod_14(TextBox textBox_0)
		{
			return textBox_0.Text;
		}

		// Token: 0x04000050 RID: 80
		[CompilerGenerated]
		private TumblrSettings tumblrSettings_0;

		// Token: 0x04000051 RID: 81
		[CompilerGenerated]
		private TumblrBlogRipper tumblrBlogRipper_0;

		// Token: 0x04000052 RID: 82
		private ControlPanel controlPanel_0;
	}
}
