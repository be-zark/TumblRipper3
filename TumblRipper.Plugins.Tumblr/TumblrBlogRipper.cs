using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace TumblRipper.Plugins.Tumblr
{
	// Token: 0x0200000E RID: 14
	public class TumblrBlogRipper
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00004990 File Offset: 0x00002B90
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000049A4 File Offset: 0x00002BA4
		public IRipper MyRipper { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000049B8 File Offset: 0x00002BB8
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000049CC File Offset: 0x00002BCC
		public TumblrSettings Settings { get; set; }

		// Token: 0x0600005B RID: 91 RVA: 0x000049E0 File Offset: 0x00002BE0
		public TumblrBlogRipper(TumblrWebsite tumblrWebsite_1)
		{
			this.tumblrWebsite_0 = tumblrWebsite_1;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000049FC File Offset: 0x00002BFC
		public void Start(CancellationToken _token)
		{
			this.method_0(_token);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004A10 File Offset: 0x00002C10
		private void method_0(CancellationToken cancellationToken_1)
		{
			if (TumblrBlogRipper.smethod_0(this.MyRipper).Count == 0)
			{
				this.Settings.LastTs = -1;
			}
			this.cancellationToken_0 = cancellationToken_1;
			this._url = TumblrBlogRipper.smethod_2(TumblrBlogRipper.smethod_1(this.MyRipper));
			this._url = this.method_10();
			if (this.Settings.LastTs != -1)
			{
				this.method_12(this.Settings.LastTs, false);
			}
			else
			{
				this.method_11();
			}
			TumblrBlogRipper.smethod_3(this.MyRipper, <Module>.smethod_27<string>(3091863595u));
			TumblrBlogRipper.smethod_4(this.MyRipper);
			TumblrBlogRipper.smethod_5(this.MyRipper);
			TumblrBlogRipper.smethod_6(this.MyRipper, this.tumblrWebsite_0.writeSettings(this.Settings));
			TumblrBlogRipper.smethod_3(this.MyRipper, <Module>.smethod_28<string>(4151463725u));
			this.method_2();
			if (this.cancellationToken_0.IsCancellationRequested)
			{
				while (this.MyRipper.ActiveThreads.Count > 0)
				{
					this.MyRipper.UpdateStatusText(string.Format(<Module>.smethod_25<string>(3642327270u), this.MyRipper.ActiveThreads.Count));
					try
					{
						Thread.Sleep(500);
					}
					catch
					{
					}
				}
				this.MyRipper.SaveFailed();
				this.MyRipper.SavePostsFound();
				this.MyRipper.SaveHistory();
				this.MyRipper.UpdateStatusText(<Module>.smethod_29<string>(771062664u));
				return;
			}
			int num = 0;
			while (this.MyRipper.FailedPosts.Count > 0 && num < 2)
			{
				this.MyRipper.UpdateStatusText(string.Format(<Module>.smethod_28<string>(4260671325u), this.MyRipper.FailedPosts.Count, num + 1));
				this.MyRipper.PostsFound = new Queue<IFileToDownload>(this.MyRipper.FailedPosts.ToArray());
				this.MyRipper.FailedPosts.Clear();
				this.method_2();
				this.MyRipper.SaveFailed();
				num++;
				Thread.Sleep(1000);
			}
			if (this.MyRipper.FailedPosts.Count > 0)
			{
				this.MyRipper.UpdateStatusText(string.Format(<Module>.smethod_25<string>(3794897258u), this.MyRipper.FailedPosts.Count));
			}
			else
			{
				this.MyRipper.UpdateStatusText(<Module>.smethod_28<string>(4008228432u));
			}
			this.MyRipper.SaveFailed();
			this.MyRipper.SavePostsFound();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004CB4 File Offset: 0x00002EB4
		private List<KeyValuePair<string, string>> method_1(string string_0)
		{
			if (string_0 == null)
			{
				return new List<KeyValuePair<string, string>>();
			}
			HtmlDocument htmlDocument_ = TumblrBlogRipper.smethod_7();
			TumblrBlogRipper.smethod_8(htmlDocument_, string_0);
			List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
			IEnumerator<HtmlNode> enumerator = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_28<string>(1310222922u)).GetEnumerator();
			try
			{
				while (TumblrBlogRipper.smethod_17(enumerator))
				{
					HtmlNode htmlNode_ = enumerator.Current;
					if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_27<string>(2834548480u)))
					{
						string string_ = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_29<string>(3457315392u)));
						if (TumblrBlogRipper.smethod_15(string_, <Module>.smethod_26<string>(3223307683u)) && (TumblrBlogRipper.smethod_15(string_, <Module>.smethod_29<string>(3261920575u)) || TumblrBlogRipper.smethod_15(string_, <Module>.smethod_27<string>(1057564334u))))
						{
							string text = "";
							IEnumerator<HtmlNode> enumerator2 = TumblrBlogRipper.smethod_10(htmlNode_, <Module>.smethod_29<string>(2590357393u)).GetEnumerator();
							try
							{
								while (TumblrBlogRipper.smethod_17(enumerator2))
								{
									HtmlNode htmlNode_2 = enumerator2.Current;
									if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_26<string>(989339024u)) && !TumblrBlogRipper.smethod_16(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_27<string>(2834548480u))), <Module>.smethod_26<string>(3569247727u)))
									{
										text = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_25<string>(1536070937u)));
										break;
									}
								}
							}
							finally
							{
								if (enumerator2 != null)
								{
									TumblrBlogRipper.smethod_18(enumerator2);
								}
							}
							list.Add(new KeyValuePair<string, string>(text, text));
						}
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					TumblrBlogRipper.smethod_18(enumerator);
				}
			}
			return list;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004E6C File Offset: 0x0000306C
		private void method_2()
		{
			List<IFileToDownload> list = new List<IFileToDownload>(TumblrBlogRipper.smethod_19(this.MyRipper));
			int num = 0;
			using (List<string>.Enumerator enumerator = TumblrBlogRipper.smethod_21(TumblrBlogRipper.smethod_20(TumblrBlogRipper.smethod_1(this.MyRipper))).Select(new Func<string, string>(Path.GetFileName)).ToList<string>().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TumblrBlogRipper.Class5 @class = new TumblrBlogRipper.Class5();
					@class.string_0 = enumerator.Current;
					IFileToDownload fileToDownload = list.FirstOrDefault(new Func<IFileToDownload, bool>(@class.method_0));
					if (fileToDownload != null && TumblrBlogRipper.smethod_24(TumblrBlogRipper.smethod_23(TumblrBlogRipper.smethod_22(TumblrBlogRipper.smethod_20(TumblrBlogRipper.smethod_1(this.MyRipper)), @class.string_0))) > 0L)
					{
						list.Remove(fileToDownload);
					}
				}
			}
			TumblrBlogRipper.smethod_25(this.MyRipper, new Queue<IFileToDownload>(list));
			list.Clear();
			list = null;
			TumblrBlogRipper.smethod_26(this.MyRipper, TumblrBlogRipper.smethod_19(this.MyRipper).Count);
			IL_F8:
			while (!this.cancellationToken_0.IsCancellationRequested)
			{
				TumblrBlogRipper.Class6 class2 = new TumblrBlogRipper.Class6();
				class2.tumblrBlogRipper_0 = this;
				while (TumblrBlogRipper.smethod_28(this.MyRipper).Count > TumblrBlogRipper.smethod_29(this.MyRipper))
				{
					try
					{
						TumblrBlogRipper.smethod_27(50);
						continue;
					}
					catch (Exception)
					{
						continue;
					}
					IL_12F:
					class2.ifileToDownload_0 = null;
					Queue<IFileToDownload> object_ = TumblrBlogRipper.smethod_19(this.MyRipper);
					bool flag = false;
					try
					{
						TumblrBlogRipper.smethod_30(object_, ref flag);
						if (num++ == 50)
						{
							num = 0;
							TumblrBlogRipper.smethod_4(this.MyRipper);
							TumblrBlogRipper.smethod_32(this.MyRipper, TumblrBlogRipper.smethod_31(TumblrBlogRipper.smethod_29(this.MyRipper) + 1, 10));
						}
						if (TumblrBlogRipper.smethod_19(this.MyRipper).Count == 0)
						{
							TumblrBlogRipper.smethod_4(this.MyRipper);
							TumblrBlogRipper.smethod_33(<Module>.smethod_27<string>(488108740u));
							while (TumblrBlogRipper.smethod_28(this.MyRipper).Count > 0)
							{
								TumblrBlogRipper.smethod_27(50);
							}
							return;
						}
						class2.ifileToDownload_0 = TumblrBlogRipper.smethod_19(this.MyRipper).Dequeue();
						TumblrBlogRipper.smethod_26(this.MyRipper, TumblrBlogRipper.smethod_19(this.MyRipper).Count);
						TumblrBlogRipper.smethod_34(class2.ifileToDownload_0);
					}
					finally
					{
						if (flag)
						{
							TumblrBlogRipper.smethod_35(object_);
						}
					}
					Thread thread = TumblrBlogRipper.smethod_36(new ThreadStart(class2.method_0));
					TumblrBlogRipper.smethod_38(thread, TumblrBlogRipper.smethod_37(class2.ifileToDownload_0));
					TumblrBlogRipper.smethod_28(this.MyRipper).Add(thread);
					TumblrBlogRipper.smethod_39(thread);
					goto IL_F8;
				}
				goto IL_12F;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000512C File Offset: 0x0000332C
		private List<IFileToDownload> method_3(string string_0)
		{
			if (string_0 == null)
			{
				return new List<IFileToDownload>();
			}
			HtmlDocument htmlDocument_ = TumblrBlogRipper.smethod_7();
			TumblrBlogRipper.smethod_8(htmlDocument_, string_0);
			List<IFileToDownload> list = new List<IFileToDownload>();
			IEnumerator<HtmlNode> enumerator = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_27<string>(2851702821u)).Where(new Func<HtmlNode, bool>(TumblrBlogRipper.Class7.<>9.method_0)).GetEnumerator();
			try
			{
				while (TumblrBlogRipper.smethod_17(enumerator))
				{
					HtmlNode htmlNode_ = enumerator.Current;
					if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_26<string>(989339024u)) && TumblrBlogRipper.smethod_15(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_27<string>(2834548480u))), <Module>.smethod_29<string>(310079643u)))
					{
						IEnumerator<HtmlNode> enumerator2 = TumblrBlogRipper.smethod_10(htmlNode_, <Module>.smethod_28<string>(1419430522u)).GetEnumerator();
						try
						{
							while (TumblrBlogRipper.smethod_17(enumerator2))
							{
								HtmlNode htmlNode_2 = enumerator2.Current;
								if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_25<string>(2795898019u)) && TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_28<string>(1116867691u)))
								{
									string string_ = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_29<string>(911449438u)));
									list.AddRange(this.method_5(TumblrBlogRipper.smethod_40(this.MyRipper, string_)));
								}
							}
						}
						finally
						{
							if (enumerator2 != null)
							{
								TumblrBlogRipper.smethod_18(enumerator2);
							}
						}
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					TumblrBlogRipper.smethod_18(enumerator);
				}
			}
			return list;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000052B8 File Offset: 0x000034B8
		private List<string> method_4(string string_0)
		{
			List<string> list = new List<string>();
			if (string_0 == null)
			{
				return null;
			}
			HtmlDocument htmlDocument_ = TumblrBlogRipper.smethod_7();
			TumblrBlogRipper.smethod_8(htmlDocument_, string_0);
			IEnumerator<HtmlNode> enumerator = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_29<string>(2324769189u)).Where(new Func<HtmlNode, bool>(TumblrBlogRipper.Class7.<>9.method_1)).GetEnumerator();
			try
			{
				while (TumblrBlogRipper.smethod_17(enumerator))
				{
					string item = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(enumerator.Current), <Module>.smethod_27<string>(2368018932u)));
					list.Add(item);
				}
			}
			finally
			{
				if (enumerator != null)
				{
					TumblrBlogRipper.smethod_18(enumerator);
				}
			}
			return list;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000536C File Offset: 0x0000356C
		private List<IFileToDownload> method_5(string string_0)
		{
			List<IFileToDownload> list = new List<IFileToDownload>();
			HtmlDocument htmlDocument_ = TumblrBlogRipper.smethod_7();
			if (string_0 == null)
			{
				return null;
			}
			TumblrBlogRipper.smethod_8(htmlDocument_, string_0);
			string string_ = <Module>.smethod_28<string>(4092376063u);
			string text = string.Empty;
			string empty = string.Empty;
			IEnumerator<HtmlNode> enumerator = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_26<string>(4203471141u)).Where(new Func<HtmlNode, bool>(TumblrBlogRipper.Class7.<>9.method_2)).GetEnumerator();
			try
			{
				while (TumblrBlogRipper.smethod_17(enumerator))
				{
					HtmlNode htmlNode_ = enumerator.Current;
					string string_2 = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_29<string>(3738088940u)));
					if (TumblrBlogRipper.smethod_15(string_2, <Module>.smethod_27<string>(2954628867u)))
					{
						string_ = TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_26<string>(2315442526u))), <Module>.smethod_25<string>(3502096554u), "");
					}
					if (TumblrBlogRipper.smethod_15(string_2, <Module>.smethod_25<string>(1873183774u)))
					{
						text = TumblrBlogRipper.smethod_42(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_28<string>(898452491u))));
					}
					if (TumblrBlogRipper.smethod_15(string_2, <Module>.smethod_27<string>(3314870028u)))
					{
						text = TumblrBlogRipper.smethod_42(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_27<string>(1729945974u))));
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					TumblrBlogRipper.smethod_18(enumerator);
				}
			}
			if (TumblrBlogRipper.smethod_43(text) == 0)
			{
				text = empty;
			}
			if (TumblrBlogRipper.smethod_44(string_, <Module>.smethod_28<string>(4092376063u)))
			{
				return null;
			}
			if (TumblrBlogRipper.smethod_44(string_, <Module>.smethod_27<string>(244585625u)))
			{
				HtmlNode htmlNode = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_28<string>(3150659877u)).FirstOrDefault<HtmlNode>();
				if (htmlNode == null)
				{
					return null;
				}
				if (!TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode), <Module>.smethod_29<string>(2129374372u)))
				{
					return null;
				}
				string string_3 = TumblrBlogRipper.smethod_40(this.MyRipper, TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode), <Module>.smethod_25<string>(1459785943u))));
				List<string> list2 = this.method_4(string_3);
				int num = 0;
				foreach (string string_4 in list2)
				{
					string string_5 = this.method_7(string_4, TumblrBlogRipper.smethod_45(text, <Module>.smethod_25<string>(3279411208u), num++), "");
					list.Add(TumblrBlogRipper.smethod_46(this.MyRipper, string_4, string_5));
				}
			}
			return list;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005604 File Offset: 0x00003804
		private List<IFileToDownload> method_6(string string_0)
		{
			if (string_0 == null)
			{
				return new List<IFileToDownload>();
			}
			HtmlDocument htmlDocument_ = TumblrBlogRipper.smethod_7();
			TumblrBlogRipper.smethod_8(htmlDocument_, string_0);
			List<IFileToDownload> list = new List<IFileToDownload>();
			IEnumerator<HtmlNode> enumerator = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_25<string>(537071698u)).GetEnumerator();
			try
			{
				while (TumblrBlogRipper.smethod_17(enumerator))
				{
					HtmlNode htmlNode_ = enumerator.Current;
					if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_28<string>(3705665601u)))
					{
						string string_ = null;
						string string_2 = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_29<string>(3457315392u)));
						if (TumblrBlogRipper.smethod_15(string_2, <Module>.smethod_26<string>(3223307683u)))
						{
							string string_3 = <Module>.smethod_27<string>(916967265u);
							if (!TumblrBlogRipper.smethod_15(string_2, <Module>.smethod_26<string>(3338621031u)))
							{
								if (!TumblrBlogRipper.smethod_15(string_2, <Module>.smethod_29<string>(3597702166u)))
								{
									continue;
								}
								string_3 = <Module>.smethod_29<string>(2209019770u);
							}
							else
							{
								string_3 = <Module>.smethod_28<string>(259299136u);
							}
							if (this.Settings.DoReblogs || TumblrBlogRipper.smethod_15(string_2, <Module>.smethod_28<string>(755217198u)))
							{
								string text = "";
								IEnumerator<HtmlNode> enumerator2 = TumblrBlogRipper.smethod_10(htmlNode_, <Module>.smethod_26<string>(3396277705u)).GetEnumerator();
								try
								{
									while (TumblrBlogRipper.smethod_17(enumerator2))
									{
										HtmlNode htmlNode_2 = enumerator2.Current;
										if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_29<string>(3457315392u)) && !TumblrBlogRipper.smethod_16(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_27<string>(2834548480u))), <Module>.smethod_29<string>(575667847u)))
										{
											text = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_29<string>(911449438u)));
											string_ = TumblrBlogRipper.smethod_42(TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_48(text, TumblrBlogRipper.smethod_47(text, <Module>.smethod_26<string>(1781890833u), StringComparison.InvariantCultureIgnoreCase) + 6), <Module>.smethod_25<string>(1612355931u), <Module>.smethod_27<string>(4021560350u)));
											break;
										}
									}
								}
								finally
								{
									if (enumerator2 != null)
									{
										TumblrBlogRipper.smethod_18(enumerator2);
									}
								}
								long num = long.Parse(TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_28<string>(730157229u))), <Module>.smethod_29<string>(3286557930u), ""));
								string text2 = string.Empty;
								text2 = TumblrBlogRipper.smethod_10(htmlNode_, <Module>.smethod_29<string>(1943431566u)).Where(new Func<HtmlNode, bool>(TumblrBlogRipper.Class7.<>9.method_3)).Select(new Func<HtmlNode, string>(TumblrBlogRipper.Class7.<>9.method_4)).FirstOrDefault<string>();
								if (text2 != null)
								{
									text2 = TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_49(text2), <Module>.smethod_26<string>(2243144225u), ""), <Module>.smethod_27<string>(2831186139u), "");
									text2 = TumblrBlogRipper.smethod_42(text2);
								}
								else
								{
									text2 = string.Empty;
								}
								if (TumblrBlogRipper.smethod_50(string_3, <Module>.smethod_26<string>(3727576122u)) && this.Settings.DoVideos)
								{
									if (!TumblrBlogRipper.smethod_15(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_29<string>(3457315392u))), <Module>.smethod_27<string>(381820353u)))
									{
										continue;
									}
									enumerator2 = TumblrBlogRipper.smethod_10(htmlNode_, <Module>.smethod_26<string>(355115610u)).GetEnumerator();
									try
									{
										while (TumblrBlogRipper.smethod_17(enumerator2))
										{
											HtmlNode htmlNode_3 = enumerator2.Current;
											if (TumblrBlogRipper.smethod_15(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_3), <Module>.smethod_27<string>(2834548480u))), <Module>.smethod_28<string>(536801998u)))
											{
												string string_4 = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_3), <Module>.smethod_29<string>(4168701273u)));
												if (TumblrBlogRipper.smethod_43(string_4) >= 1)
												{
													string[] array = TumblrBlogRipper.smethod_51(string_4, new char[]
													{
														'/'
													});
													string text3 = TumblrBlogRipper.smethod_51(array[array.Length - 1], new char[]
													{
														'_'
													})[1];
													string string_5 = TumblrBlogRipper.smethod_52(new object[]
													{
														<Module>.smethod_29<string>(2489793318u),
														num,
														<Module>.smethod_27<string>(762578196u),
														text3
													});
													string string_6 = this.method_7(string_5, string_, text2);
													list.Add(TumblrBlogRipper.smethod_54(this.MyRipper, string_5, TumblrBlogRipper.smethod_53(string_6, <Module>.smethod_25<string>(2986610504u)), text));
												}
											}
										}
									}
									finally
									{
										if (enumerator2 != null)
										{
											TumblrBlogRipper.smethod_18(enumerator2);
										}
									}
								}
								if (TumblrBlogRipper.smethod_50(string_3, <Module>.smethod_25<string>(1650498428u)))
								{
									enumerator2 = TumblrBlogRipper.smethod_10(htmlNode_, <Module>.smethod_26<string>(355115610u)).GetEnumerator();
									try
									{
										while (TumblrBlogRipper.smethod_17(enumerator2))
										{
											HtmlNode htmlNode_4 = enumerator2.Current;
											if (TumblrBlogRipper.smethod_15(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_4), <Module>.smethod_29<string>(3457315392u))), <Module>.smethod_29<string>(3356751317u)))
											{
												string string_7 = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_4), <Module>.smethod_29<string>(4168701273u)));
												if (!TumblrBlogRipper.smethod_15(string_7, <Module>.smethod_27<string>(1987261089u)))
												{
													string string_8 = TumblrBlogRipper.smethod_49(TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_41(string_7, <Module>.smethod_28<string>(3890053108u), ""), <Module>.smethod_28<string>(1192047598u), ""));
													string_8 = TumblrBlogRipper.smethod_41(string_8, <Module>.smethod_25<string>(2541239812u), <Module>.smethod_27<string>(193122602u));
													string string_9 = this.method_7(string_8, string_, text2);
													list.Add(TumblrBlogRipper.smethod_54(this.MyRipper, string_8, string_9, text));
												}
											}
										}
									}
									finally
									{
										if (enumerator2 != null)
										{
											TumblrBlogRipper.smethod_18(enumerator2);
										}
									}
								}
							}
						}
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					TumblrBlogRipper.smethod_18(enumerator);
				}
			}
			return list;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005BF8 File Offset: 0x00003DF8
		private string method_7(string string_0, string string_1, string string_2)
		{
			string text = TumblrBlogRipper.smethod_57(TumblrBlogRipper.smethod_56(TumblrBlogRipper.smethod_55(string_0)));
			string text2 = TumblrBlogRipper.smethod_58(text);
			if (this.Settings.DoRename && TumblrBlogRipper.smethod_43(string_1) > 0)
			{
				string_1 = TumblrBlogRipper.smethod_42(string_1);
				string_1 = TumblrBlogRipper.smethod_41(string_1, <Module>.smethod_29<string>(685683933u), <Module>.smethod_28<string>(3318955139u));
				text = TumblrBlogRipper.smethod_53(TumblrBlogRipper.smethod_59(this.MyRipper, string_1), text2);
			}
			if (!this.Settings.DoTags)
			{
				return text;
			}
			return TumblrBlogRipper.smethod_41(text, text2, TumblrBlogRipper.smethod_60(<Module>.smethod_28<string>(3318955139u), string_2, text2));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005C94 File Offset: 0x00003E94
		private void method_8(string string_0)
		{
			string text = null;
			try
			{
				text = TumblrBlogRipper.smethod_40(this.MyRipper, string_0);
			}
			catch (WebException)
			{
				HtmlDocument htmlDocument_ = TumblrBlogRipper.smethod_7();
				if (text != null)
				{
					TumblrBlogRipper.smethod_8(htmlDocument_, text);
					string[] array = TumblrBlogRipper.smethod_51(TumblrBlogRipper.smethod_41(string_0, <Module>.smethod_28<string>(368506736u), ""), new char[]
					{
						'/'
					});
					string string_ = TumblrBlogRipper.smethod_61(<Module>.smethod_27<string>(2625334047u), array[0], <Module>.smethod_29<string>(3301743274u), array[2]);
					string text2 = array[2];
					string text3 = null;
					IEnumerator<HtmlNode> enumerator = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_28<string>(2192851446u)).GetEnumerator();
					try
					{
						while (TumblrBlogRipper.smethod_17(enumerator))
						{
							HtmlNode htmlNode_ = enumerator.Current;
							if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_28<string>(1662905691u)) && TumblrBlogRipper.smethod_44(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_28<string>(1662905691u))), <Module>.smethod_29<string>(2099003684u)))
							{
								text3 = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_29<string>(3066525758u)));
								text3 = TumblrBlogRipper.smethod_42(text3);
								text3 = TumblrBlogRipper.smethod_59(this.MyRipper, text3);
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							TumblrBlogRipper.smethod_18(enumerator);
						}
					}
					if (TumblrBlogRipper.smethod_43(text3) > 0)
					{
						text3 = TumblrBlogRipper.smethod_60(text2, <Module>.smethod_28<string>(2268031353u), text3);
					}
					else
					{
						text3 = text2;
					}
					int num = TumblrBlogRipper.smethod_62(text, string_);
					if (num > -1)
					{
						int num2 = TumblrBlogRipper.smethod_63(text, <Module>.smethod_27<string>(2676797070u), num);
						TumblrBlogRipper.smethod_53(TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_64(text, num, num2 - num), string_, <Module>.smethod_28<string>(1276195229u)), <Module>.smethod_25<string>(2986610504u));
					}
					HtmlNodeCollection htmlNodeCollection = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_26<string>(3554606100u));
					bool flag = false;
					enumerator = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_26<string>(4203471141u)).GetEnumerator();
					try
					{
						while (TumblrBlogRipper.smethod_17(enumerator))
						{
							HtmlNode htmlNode_2 = enumerator.Current;
							if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_29<string>(3738088940u)) && TumblrBlogRipper.smethod_15(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_28<string>(402534429u))), <Module>.smethod_26<string>(2920382686u)))
							{
								TumblrBlogRipper.smethod_58(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_2), <Module>.smethod_27<string>(1729945974u))));
								flag = true;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							TumblrBlogRipper.smethod_18(enumerator);
						}
					}
					htmlNodeCollection = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_28<string>(1310222922u));
					if (htmlNodeCollection != null && !flag)
					{
						enumerator = htmlNodeCollection.GetEnumerator();
						try
						{
							while (TumblrBlogRipper.smethod_17(enumerator))
							{
								HtmlNode htmlNode_3 = enumerator.Current;
								if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_3), <Module>.smethod_25<string>(2795898019u)))
								{
									string string_2 = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_3), <Module>.smethod_26<string>(989339024u)));
									if (TumblrBlogRipper.smethod_15(string_2, <Module>.smethod_27<string>(3970097327u)) && TumblrBlogRipper.smethod_15(string_2, <Module>.smethod_28<string>(1218950770u)))
									{
										IEnumerator<HtmlNode> enumerator2 = TumblrBlogRipper.smethod_10(htmlNode_3, <Module>.smethod_29<string>(2324769189u)).GetEnumerator();
										try
										{
											while (TumblrBlogRipper.smethod_17(enumerator2))
											{
												HtmlNode htmlNode_4 = enumerator2.Current;
												if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_4), <Module>.smethod_29<string>(2129374372u)))
												{
													TumblrBlogRipper.smethod_58(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_4), <Module>.smethod_29<string>(2129374372u))));
													break;
												}
											}
										}
										finally
										{
											if (enumerator2 != null)
											{
												TumblrBlogRipper.smethod_18(enumerator2);
											}
										}
									}
								}
							}
						}
						finally
						{
							if (enumerator != null)
							{
								TumblrBlogRipper.smethod_18(enumerator);
							}
						}
					}
					htmlDocument_ = null;
				}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000060BC File Offset: 0x000042BC
		private string method_9(int int_0)
		{
			TumblrBlogRipper.smethod_33(TumblrBlogRipper.smethod_65(<Module>.smethod_27<string>(3613218507u), int_0));
			string text = TumblrBlogRipper.smethod_60(<Module>.smethod_26<string>(225160635u), this._url, <Module>.smethod_28<string>(2622557325u));
			if (int_0 > 0)
			{
				text = TumblrBlogRipper.smethod_45(text, <Module>.smethod_26<string>(3743127583u), int_0);
			}
			return TumblrBlogRipper.smethod_40(this.MyRipper, text);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000612C File Offset: 0x0000432C
		private string method_10()
		{
			try
			{
				string string_ = this.method_9(0);
				HtmlDocument htmlDocument_ = TumblrBlogRipper.smethod_7();
				TumblrBlogRipper.smethod_8(htmlDocument_, string_);
				IEnumerator<HtmlNode> enumerator = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_28<string>(529677477u)).GetEnumerator();
				try
				{
					while (TumblrBlogRipper.smethod_17(enumerator))
					{
						HtmlNode htmlNode_ = enumerator.Current;
						if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_28<string>(1662905691u)) && TumblrBlogRipper.smethod_44(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_28<string>(1662905691u))), <Module>.smethod_28<string>(2925120156u)))
						{
							return TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_29<string>(2129374372u))), <Module>.smethod_25<string>(3578381548u), ""), <Module>.smethod_25<string>(1593847023u), ""), <Module>.smethod_29<string>(3958121112u), "");
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						TumblrBlogRipper.smethod_18(enumerator);
					}
				}
			}
			catch (Exception)
			{
			}
			return TumblrBlogRipper.smethod_2(TumblrBlogRipper.smethod_1(this.MyRipper));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00006258 File Offset: 0x00004458
		private void method_11()
		{
			TumblrBlogRipper.Class9 @class = new TumblrBlogRipper.Class9();
			@class.tumblrBlogRipper_0 = this;
			string string_ = this.method_9(0);
			string string_2 = this.method_13(string_);
			string string_3 = TumblrBlogRipper.smethod_40(this.MyRipper, TumblrBlogRipper.smethod_60(<Module>.smethod_28<string>(368506736u), this._url, string_2));
			int num = this.method_14(string_);
			int num2 = this.method_14(string_3);
			int num3 = (int)TumblrBlogRipper.smethod_66((double)(num - num2) / 20.0);
			List<Task> list = new List<Task>();
			@class.int_0 = 0;
			TumblrBlogRipper.smethod_67(this.MyRipper, @class.int_0);
			if (num3 > 0)
			{
				for (int i = num2; i <= num + num3; i += num3)
				{
					TumblrBlogRipper.Class8 class2 = new TumblrBlogRipper.Class8();
					class2.class9_0 = @class;
					TumblrBlogRipper.smethod_33(TumblrBlogRipper.smethod_65(<Module>.smethod_25<string>(1962932721u), list.Count));
					class2.int_0 = i;
					list.Add(TumblrBlogRipper.smethod_69(TumblrBlogRipper.smethod_68(), new Action(class2.method_0)));
				}
			}
			TumblrBlogRipper.smethod_70(list.ToArray());
			this.cancellationToken_0.ThrowIfCancellationRequested();
			this.MyRipper.UpdatePercentageComplete(100);
			this.Settings.LastTs = num;
			this.method_12(0, true);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00006398 File Offset: 0x00004598
		private void method_12(int int_0, bool bool_0)
		{
			int num = 0;
			while (int_0 > -1)
			{
				this.cancellationToken_0.ThrowIfCancellationRequested();
				string text = this.method_9(int_0);
				if (text != null)
				{
					int_0 = this.method_14(text);
					List<IFileToDownload> list = this.method_6(text);
					bool flag = false;
					foreach (IFileToDownload item in list)
					{
						List<IFileToDownload> history = this.MyRipper.History;
						lock (history)
						{
							if (!this.MyRipper.History.Contains(item))
							{
								Queue<IFileToDownload> postsFound = this.MyRipper.PostsFound;
								lock (postsFound)
								{
									this.MyRipper.PostsFound.Enqueue(item);
								}
								this.MyRipper.History.Add(item);
							}
							else
							{
								flag = true;
							}
						}
					}
					this.MyRipper.UpdateStatusText(<Module>.smethod_29<string>(2178649082u));
					this.MyRipper.UpdateStatusTotalPosts(this.MyRipper.History.Count);
					if (bool_0 && this.MyRipper.History.Count - num > 500)
					{
						num = this.MyRipper.History.Count;
						this.Settings.LastTs = int_0;
						this.MyRipper.SaveSettings(this.tumblrWebsite_0.writeSettings(this.Settings));
						this.MyRipper.SaveHistory();
					}
					if (flag)
					{
						break;
					}
				}
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006554 File Offset: 0x00004754
		private string method_13(string string_0)
		{
			if (string_0 == null)
			{
				return null;
			}
			int num = int.MaxValue;
			string result = null;
			try
			{
				HtmlDocument htmlDocument_ = TumblrBlogRipper.smethod_7();
				TumblrBlogRipper.smethod_8(htmlDocument_, string_0);
				IEnumerator<HtmlNode> enumerator = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_71(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_25<string>(3000074457u)), <Module>.smethod_25<string>(1740247375u)).GetEnumerator();
				try
				{
					while (TumblrBlogRipper.smethod_17(enumerator))
					{
						HtmlNode htmlNode_ = enumerator.Current;
						if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_25<string>(1536070937u)))
						{
							string text = TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_28<string>(1116867691u)));
							if (TumblrBlogRipper.smethod_15(text, <Module>.smethod_29<string>(3256187242u)))
							{
								string[] array = TumblrBlogRipper.smethod_51(TumblrBlogRipper.smethod_41(text, <Module>.smethod_26<string>(2374009034u), ""), new char[]
								{
									'/'
								});
								int num2 = int.Parse(array[0]);
								int num3 = int.Parse(array[1]);
								int num4 = num2 * 12 + num3;
								if (num4 < num)
								{
									result = text;
									num = num4;
								}
							}
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						TumblrBlogRipper.smethod_18(enumerator);
					}
				}
			}
			catch (Exception)
			{
			}
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00006680 File Offset: 0x00004880
		private int method_14(string string_0)
		{
			if (string_0 == null)
			{
				return -1;
			}
			int result;
			try
			{
				HtmlDocument htmlDocument_ = TumblrBlogRipper.smethod_7();
				TumblrBlogRipper.smethod_8(htmlDocument_, string_0);
				result = int.Parse(TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_51(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(TumblrBlogRipper.smethod_71(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_26<string>(2489322382u))), <Module>.smethod_27<string>(2265092886u))), new char[]
				{
					'?'
				})[1], <Module>.smethod_28<string>(807180339u), ""));
			}
			catch (Exception)
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00006710 File Offset: 0x00004910
		private bool method_15(IFileToDownload ifileToDownload_0)
		{
			string string_ = TumblrBlogRipper.smethod_22(TumblrBlogRipper.smethod_20(TumblrBlogRipper.smethod_1(this.MyRipper)), TumblrBlogRipper.smethod_37(ifileToDownload_0));
			bool result = true;
			List<string> list = new List<string>
			{
				<Module>.smethod_28<string>(4110311511u),
				<Module>.smethod_28<string>(1412306001u),
				<Module>.smethod_25<string>(3146474809u)
			};
			int num = 200;
			bool flag = false;
			if (!TumblrBlogRipper.smethod_72(string_))
			{
				flag = true;
			}
			else if (TumblrBlogRipper.smethod_24(TumblrBlogRipper.smethod_23(string_)) == 0L)
			{
				flag = true;
			}
			if (flag)
			{
				string string_2 = (string)TumblrBlogRipper.smethod_73(TumblrBlogRipper.smethod_34(ifileToDownload_0));
				string string_3 = (string)TumblrBlogRipper.smethod_73(TumblrBlogRipper.smethod_37(ifileToDownload_0));
				num = TumblrBlogRipper.smethod_74(this.MyRipper, ifileToDownload_0);
				if (num == 404 && TumblrBlogRipper.smethod_15(TumblrBlogRipper.smethod_34(ifileToDownload_0), <Module>.smethod_27<string>(193122602u)))
				{
					foreach (string string_4 in list)
					{
						TumblrBlogRipper.smethod_75(ifileToDownload_0, TumblrBlogRipper.smethod_41(string_2, <Module>.smethod_26<string>(2113189250u), TumblrBlogRipper.smethod_60(<Module>.smethod_26<string>(1493607463u), string_4, <Module>.smethod_26<string>(3728485956u))));
						TumblrBlogRipper.smethod_76(ifileToDownload_0, TumblrBlogRipper.smethod_41(string_3, <Module>.smethod_28<string>(561861967u), TumblrBlogRipper.smethod_60(<Module>.smethod_26<string>(1493607463u), string_4, <Module>.smethod_25<string>(263904583u))));
						num = TumblrBlogRipper.smethod_74(this.MyRipper, ifileToDownload_0);
						TumblrBlogRipper.smethod_33(TumblrBlogRipper.smethod_45(<Module>.smethod_25<string>(1078360973u), num, <Module>.smethod_25<string>(3337187294u)));
						if (num == 200)
						{
							break;
						}
						if (num == -1)
						{
							break;
						}
					}
				}
				if (num == -1)
				{
					TumblrBlogRipper.smethod_77(this.MyRipper).Add(ifileToDownload_0);
					TumblrBlogRipper.smethod_78(this.MyRipper, TumblrBlogRipper.smethod_77(this.MyRipper).Count);
				}
				else if (num == 404)
				{
					TumblrBlogRipper.smethod_77(this.MyRipper).Add(ifileToDownload_0);
					TumblrBlogRipper.smethod_78(this.MyRipper, TumblrBlogRipper.smethod_77(this.MyRipper).Count);
				}
				else if (num != 200)
				{
					TumblrBlogRipper.smethod_33(TumblrBlogRipper.smethod_65(<Module>.smethod_25<string>(2115502709u), num));
				}
			}
			List<Thread> object_ = TumblrBlogRipper.smethod_28(this.MyRipper);
			bool flag2 = false;
			try
			{
				TumblrBlogRipper.smethod_30(object_, ref flag2);
				if (TumblrBlogRipper.smethod_28(this.MyRipper).Contains(TumblrBlogRipper.smethod_79()))
				{
					TumblrBlogRipper.smethod_28(this.MyRipper).Remove(TumblrBlogRipper.smethod_79());
				}
			}
			finally
			{
				if (flag2)
				{
					TumblrBlogRipper.smethod_35(object_);
				}
			}
			return result;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000069D0 File Offset: 0x00004BD0
		public string GetTitle(string url)
		{
			return this.method_16(url);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000069E4 File Offset: 0x00004BE4
		private string method_16(string string_0)
		{
			string result;
			try
			{
				string text = TumblrBlogRipper.smethod_41(string_0, <Module>.smethod_27<string>(1664690951u), "");
				text = TumblrBlogRipper.smethod_51(text, new char[]
				{
					'.'
				})[0];
				string string_ = TumblrBlogRipper.smethod_40(this.MyRipper, TumblrBlogRipper.smethod_60(<Module>.smethod_29<string>(2965961683u), string_0, <Module>.smethod_27<string>(1146698380u)));
				HtmlDocument htmlDocument_ = TumblrBlogRipper.smethod_7();
				TumblrBlogRipper.smethod_8(htmlDocument_, string_);
				IEnumerator<HtmlNode> enumerator = TumblrBlogRipper.smethod_10(TumblrBlogRipper.smethod_9(htmlDocument_), <Module>.smethod_28<string>(1764988770u)).GetEnumerator();
				try
				{
					while (TumblrBlogRipper.smethod_17(enumerator))
					{
						HtmlNode htmlNode_ = enumerator.Current;
						if (TumblrBlogRipper.smethod_12(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_27<string>(2834548480u)) && TumblrBlogRipper.smethod_50(TumblrBlogRipper.smethod_14(TumblrBlogRipper.smethod_13(TumblrBlogRipper.smethod_11(htmlNode_), <Module>.smethod_26<string>(989339024u))), <Module>.smethod_25<string>(448447432u)))
						{
							return TumblrBlogRipper.smethod_42(TumblrBlogRipper.smethod_49(TumblrBlogRipper.smethod_41(TumblrBlogRipper.smethod_80(htmlNode_), <Module>.smethod_27<string>(2872219503u), "")));
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						TumblrBlogRipper.smethod_18(enumerator);
					}
				}
				result = text;
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006B34 File Offset: 0x00004D34
		static List<IFileToDownload> smethod_0(IRipper iripper_1)
		{
			return iripper_1.History;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00006B48 File Offset: 0x00004D48
		static IWebsite smethod_1(IRipper iripper_1)
		{
			return iripper_1.Website;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00006B5C File Offset: 0x00004D5C
		static string smethod_2(IWebsite iwebsite_0)
		{
			return iwebsite_0.Url;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00006B70 File Offset: 0x00004D70
		static void smethod_3(IRipper iripper_1, string string_0)
		{
			iripper_1.UpdateStatusText(string_0);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00006B84 File Offset: 0x00004D84
		static void smethod_4(IRipper iripper_1)
		{
			iripper_1.SaveHistory();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00006B98 File Offset: 0x00004D98
		static void smethod_5(IRipper iripper_1)
		{
			iripper_1.SavePostsFound();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00006BAC File Offset: 0x00004DAC
		static void smethod_6(IRipper iripper_1, string string_0)
		{
			iripper_1.SaveSettings(string_0);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00006BC0 File Offset: 0x00004DC0
		static HtmlDocument smethod_7()
		{
			return new HtmlDocument();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00006BD4 File Offset: 0x00004DD4
		static void smethod_8(HtmlDocument htmlDocument_0, string string_0)
		{
			htmlDocument_0.LoadHtml(string_0);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006BE8 File Offset: 0x00004DE8
		static HtmlNode smethod_9(HtmlDocument htmlDocument_0)
		{
			return htmlDocument_0.DocumentNode;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006BFC File Offset: 0x00004DFC
		static HtmlNodeCollection smethod_10(HtmlNode htmlNode_0, string string_0)
		{
			return htmlNode_0.SelectNodes(string_0);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00006C10 File Offset: 0x00004E10
		static HtmlAttributeCollection smethod_11(HtmlNode htmlNode_0)
		{
			return htmlNode_0.Attributes;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00006C24 File Offset: 0x00004E24
		static bool smethod_12(HtmlAttributeCollection htmlAttributeCollection_0, string string_0)
		{
			return htmlAttributeCollection_0.Contains(string_0);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00006C38 File Offset: 0x00004E38
		static HtmlAttribute smethod_13(HtmlAttributeCollection htmlAttributeCollection_0, string string_0)
		{
			return htmlAttributeCollection_0[string_0];
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00006C4C File Offset: 0x00004E4C
		static string smethod_14(HtmlAttribute htmlAttribute_0)
		{
			return htmlAttribute_0.Value;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00006C60 File Offset: 0x00004E60
		static bool smethod_15(string string_0, string string_1)
		{
			return string_0.Contains(string_1);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00006C74 File Offset: 0x00004E74
		static bool smethod_16(string string_0, string string_1)
		{
			return string_0 != string_1;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00006C88 File Offset: 0x00004E88
		static bool smethod_17(IEnumerator ienumerator_0)
		{
			return ienumerator_0.MoveNext();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00006C9C File Offset: 0x00004E9C
		static void smethod_18(IDisposable idisposable_0)
		{
			idisposable_0.Dispose();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00006CB0 File Offset: 0x00004EB0
		static Queue<IFileToDownload> smethod_19(IRipper iripper_1)
		{
			return iripper_1.PostsFound;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00006CC4 File Offset: 0x00004EC4
		static string smethod_20(IWebsite iwebsite_0)
		{
			return iwebsite_0.LocalDir;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00006CD8 File Offset: 0x00004ED8
		static IEnumerable<string> smethod_21(string string_0)
		{
			return Directory.EnumerateFiles(string_0);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00006CEC File Offset: 0x00004EEC
		static string smethod_22(string string_0, string string_1)
		{
			return Path.Combine(string_0, string_1);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00006D00 File Offset: 0x00004F00
		static FileInfo smethod_23(string string_0)
		{
			return new FileInfo(string_0);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00006D14 File Offset: 0x00004F14
		static long smethod_24(FileInfo fileInfo_0)
		{
			return fileInfo_0.Length;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006D28 File Offset: 0x00004F28
		static void smethod_25(IRipper iripper_1, Queue<IFileToDownload> queue_0)
		{
			iripper_1.PostsFound = queue_0;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00006D3C File Offset: 0x00004F3C
		static void smethod_26(IRipper iripper_1, int int_0)
		{
			iripper_1.UpdateStatusPendingPosts(int_0);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002AA0 File Offset: 0x00000CA0
		static void smethod_27(int int_0)
		{
			Thread.Sleep(int_0);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00006D50 File Offset: 0x00004F50
		static List<Thread> smethod_28(IRipper iripper_1)
		{
			return iripper_1.ActiveThreads;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00006D64 File Offset: 0x00004F64
		static int smethod_29(IRipper iripper_1)
		{
			return iripper_1.MaxThreads;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006D78 File Offset: 0x00004F78
		static void smethod_30(object object_0, ref bool bool_0)
		{
			Monitor.Enter(object_0, ref bool_0);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00006D8C File Offset: 0x00004F8C
		static int smethod_31(int int_0, int int_1)
		{
			return Math.Min(int_0, int_1);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006DA0 File Offset: 0x00004FA0
		static void smethod_32(IRipper iripper_1, int int_0)
		{
			iripper_1.MaxThreads = int_0;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00006DB4 File Offset: 0x00004FB4
		static void smethod_33(string string_0)
		{
			Console.WriteLine(string_0);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00006DC8 File Offset: 0x00004FC8
		static string smethod_34(IFileToDownload ifileToDownload_0)
		{
			return ifileToDownload_0.Url;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00006DDC File Offset: 0x00004FDC
		static void smethod_35(object object_0)
		{
			Monitor.Exit(object_0);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006DF0 File Offset: 0x00004FF0
		static Thread smethod_36(ThreadStart threadStart_0)
		{
			return new Thread(threadStart_0);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006E04 File Offset: 0x00005004
		static string smethod_37(IFileToDownload ifileToDownload_0)
		{
			return ifileToDownload_0.Filename;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00006E18 File Offset: 0x00005018
		static void smethod_38(Thread thread_0, string string_0)
		{
			thread_0.Name = string_0;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00006E2C File Offset: 0x0000502C
		static void smethod_39(Thread thread_0)
		{
			thread_0.Start();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00006E40 File Offset: 0x00005040
		static string smethod_40(IRipper iripper_1, string string_0)
		{
			return iripper_1.GetWebPage(string_0);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00006E54 File Offset: 0x00005054
		static string smethod_41(string string_0, string string_1, string string_2)
		{
			return string_0.Replace(string_1, string_2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006E6C File Offset: 0x0000506C
		static string smethod_42(string string_0)
		{
			return WebUtility.HtmlDecode(string_0);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006E80 File Offset: 0x00005080
		static int smethod_43(string string_0)
		{
			return string_0.Length;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00006E94 File Offset: 0x00005094
		static bool smethod_44(string string_0, string string_1)
		{
			return string_0.Equals(string_1);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006EA8 File Offset: 0x000050A8
		static string smethod_45(object object_0, object object_1, object object_2)
		{
			return object_0 + object_1 + object_2;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006EC0 File Offset: 0x000050C0
		static IFileToDownload smethod_46(IRipper iripper_1, string string_0, string string_1)
		{
			return iripper_1.NewDownloadFile(string_0, string_1);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00006ED8 File Offset: 0x000050D8
		static int smethod_47(string string_0, string string_1, StringComparison stringComparison_0)
		{
			return string_0.IndexOf(string_1, stringComparison_0);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00006EF0 File Offset: 0x000050F0
		static string smethod_48(string string_0, int int_0)
		{
			return string_0.Substring(int_0);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00006F04 File Offset: 0x00005104
		static string smethod_49(string string_0)
		{
			return string_0.Trim();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00006F18 File Offset: 0x00005118
		static bool smethod_50(string string_0, string string_1)
		{
			return string_0 == string_1;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006F2C File Offset: 0x0000512C
		static string[] smethod_51(string string_0, char[] char_0)
		{
			return string_0.Split(char_0);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006F40 File Offset: 0x00005140
		static string smethod_52(object[] object_0)
		{
			return string.Concat(object_0);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000029FC File Offset: 0x00000BFC
		static string smethod_53(string string_0, string string_1)
		{
			return string_0 + string_1;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006F54 File Offset: 0x00005154
		static IFileToDownload smethod_54(IRipper iripper_1, string string_0, string string_1, string string_2)
		{
			return iripper_1.NewDownloadFile(string_0, string_1, string_2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00006F6C File Offset: 0x0000516C
		static Uri smethod_55(string string_0)
		{
			return new Uri(string_0);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006F80 File Offset: 0x00005180
		static string smethod_56(Uri uri_0)
		{
			return uri_0.LocalPath;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006F94 File Offset: 0x00005194
		static string smethod_57(string string_0)
		{
			return Path.GetFileName(string_0);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00006FA8 File Offset: 0x000051A8
		static string smethod_58(string string_0)
		{
			return Path.GetExtension(string_0);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00006FBC File Offset: 0x000051BC
		static string smethod_59(IRipper iripper_1, string string_0)
		{
			return iripper_1.MakeValidFileName(string_0);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00006FD0 File Offset: 0x000051D0
		static string smethod_60(string string_0, string string_1, string string_2)
		{
			return string_0 + string_1 + string_2;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00006FE8 File Offset: 0x000051E8
		static string smethod_61(string string_0, string string_1, string string_2, string string_3)
		{
			return string_0 + string_1 + string_2 + string_3;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00007000 File Offset: 0x00005200
		static int smethod_62(string string_0, string string_1)
		{
			return string_0.IndexOf(string_1);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00007014 File Offset: 0x00005214
		static int smethod_63(string string_0, string string_1, int int_0)
		{
			return string_0.IndexOf(string_1, int_0);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000702C File Offset: 0x0000522C
		static string smethod_64(string string_0, int int_0, int int_1)
		{
			return string_0.Substring(int_0, int_1);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007044 File Offset: 0x00005244
		static string smethod_65(object object_0, object object_1)
		{
			return object_0 + object_1;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00007058 File Offset: 0x00005258
		static double smethod_66(double double_0)
		{
			return Math.Round(double_0);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000706C File Offset: 0x0000526C
		static void smethod_67(IRipper iripper_1, int int_0)
		{
			iripper_1.UpdatePercentageComplete(int_0);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00007080 File Offset: 0x00005280
		static TaskFactory smethod_68()
		{
			return Task.Factory;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00007094 File Offset: 0x00005294
		static Task smethod_69(TaskFactory taskFactory_0, Action action_0)
		{
			return taskFactory_0.StartNew(action_0);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000070A8 File Offset: 0x000052A8
		static void smethod_70(Task[] task_0)
		{
			Task.WaitAll(task_0);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000070BC File Offset: 0x000052BC
		static HtmlNode smethod_71(HtmlNode htmlNode_0, string string_0)
		{
			return htmlNode_0.SelectSingleNode(string_0);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000070D0 File Offset: 0x000052D0
		static bool smethod_72(string string_0)
		{
			return File.Exists(string_0);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000070E4 File Offset: 0x000052E4
		static object smethod_73(string string_0)
		{
			return string_0.Clone();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000070F8 File Offset: 0x000052F8
		static int smethod_74(IRipper iripper_1, IFileToDownload ifileToDownload_0)
		{
			return iripper_1.DownloadFile(ifileToDownload_0);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000710C File Offset: 0x0000530C
		static void smethod_75(IFileToDownload ifileToDownload_0, string string_0)
		{
			ifileToDownload_0.Url = string_0;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00007120 File Offset: 0x00005320
		static void smethod_76(IFileToDownload ifileToDownload_0, string string_0)
		{
			ifileToDownload_0.Filename = string_0;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00007134 File Offset: 0x00005334
		static List<IFileToDownload> smethod_77(IRipper iripper_1)
		{
			return iripper_1.FailedPosts;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00007148 File Offset: 0x00005348
		static void smethod_78(IRipper iripper_1, int int_0)
		{
			iripper_1.UpdateStatusFailedPosts(int_0);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002A8C File Offset: 0x00000C8C
		static Thread smethod_79()
		{
			return Thread.CurrentThread;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000715C File Offset: 0x0000535C
		static string smethod_80(HtmlNode htmlNode_0)
		{
			return htmlNode_0.InnerText;
		}

		// Token: 0x04000036 RID: 54
		private TumblrWebsite tumblrWebsite_0;

		// Token: 0x04000037 RID: 55
		[CompilerGenerated]
		private IRipper iripper_0;

		// Token: 0x04000038 RID: 56
		[CompilerGenerated]
		private TumblrSettings tumblrSettings_0;

		// Token: 0x04000039 RID: 57
		public string _url;

		// Token: 0x0400003A RID: 58
		private CancellationToken cancellationToken_0;

		// Token: 0x0200000F RID: 15
		[CompilerGenerated]
		private sealed class Class5
		{
			// Token: 0x060000C1 RID: 193 RVA: 0x00007170 File Offset: 0x00005370
			internal bool method_0(IFileToDownload ifileToDownload_0)
			{
				return TumblrBlogRipper.Class5.smethod_1(TumblrBlogRipper.Class5.smethod_0(ifileToDownload_0), this.string_0);
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00006E04 File Offset: 0x00005004
			static string smethod_0(IFileToDownload ifileToDownload_0)
			{
				return ifileToDownload_0.Filename;
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x00006E94 File Offset: 0x00005094
			static bool smethod_1(string string_1, string string_2)
			{
				return string_1.Equals(string_2);
			}

			// Token: 0x0400003B RID: 59
			public string string_0;
		}

		// Token: 0x02000010 RID: 16
		[CompilerGenerated]
		private sealed class Class6
		{
			// Token: 0x060000C5 RID: 197 RVA: 0x00007190 File Offset: 0x00005390
			internal void method_0()
			{
				if (this.ifileToDownload_0 == null)
				{
					return;
				}
				this.tumblrBlogRipper_0.method_15(this.ifileToDownload_0);
				TumblrBlogRipper.Class6.smethod_4(this.tumblrBlogRipper_0.MyRipper, TumblrBlogRipper.Class6.smethod_3(TumblrBlogRipper.Class6.smethod_1(TumblrBlogRipper.Class6.smethod_0(this.tumblrBlogRipper_0.MyRipper)), TumblrBlogRipper.Class6.smethod_2(this.ifileToDownload_0)));
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x00006B48 File Offset: 0x00004D48
			static IWebsite smethod_0(IRipper iripper_0)
			{
				return iripper_0.Website;
			}

			// Token: 0x060000C7 RID: 199 RVA: 0x00006CC4 File Offset: 0x00004EC4
			static string smethod_1(IWebsite iwebsite_0)
			{
				return iwebsite_0.LocalDir;
			}

			// Token: 0x060000C8 RID: 200 RVA: 0x00006E04 File Offset: 0x00005004
			static string smethod_2(IFileToDownload ifileToDownload_1)
			{
				return ifileToDownload_1.Filename;
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x00006CEC File Offset: 0x00004EEC
			static string smethod_3(string string_0, string string_1)
			{
				return Path.Combine(string_0, string_1);
			}

			// Token: 0x060000CA RID: 202 RVA: 0x000071F0 File Offset: 0x000053F0
			static void smethod_4(IRipper iripper_0, string string_0)
			{
				iripper_0.UpdatePreviewImagePath(string_0);
			}

			// Token: 0x0400003C RID: 60
			public IFileToDownload ifileToDownload_0;

			// Token: 0x0400003D RID: 61
			public TumblrBlogRipper tumblrBlogRipper_0;
		}

		// Token: 0x02000011 RID: 17
		[CompilerGenerated]
		[Serializable]
		private sealed class Class7
		{
			// Token: 0x060000CD RID: 205 RVA: 0x0000721C File Offset: 0x0000541C
			internal bool method_0(HtmlNode htmlNode_0)
			{
				return TumblrBlogRipper.Class7.smethod_1(TumblrBlogRipper.Class7.smethod_0(htmlNode_0), <Module>.smethod_29<string>(3457315392u)) && TumblrBlogRipper.Class7.smethod_4(TumblrBlogRipper.Class7.smethod_3(TumblrBlogRipper.Class7.smethod_2(TumblrBlogRipper.Class7.smethod_0(htmlNode_0), <Module>.smethod_29<string>(3457315392u))), <Module>.smethod_29<string>(310079643u));
			}

			// Token: 0x060000CE RID: 206 RVA: 0x0000726C File Offset: 0x0000546C
			internal bool method_1(HtmlNode htmlNode_0)
			{
				return TumblrBlogRipper.Class7.smethod_1(TumblrBlogRipper.Class7.smethod_0(htmlNode_0), <Module>.smethod_27<string>(2368018932u));
			}

			// Token: 0x060000CF RID: 207 RVA: 0x00007290 File Offset: 0x00005490
			internal bool method_2(HtmlNode htmlNode_0)
			{
				return TumblrBlogRipper.Class7.smethod_1(TumblrBlogRipper.Class7.smethod_0(htmlNode_0), <Module>.smethod_27<string>(3575547484u)) && TumblrBlogRipper.Class7.smethod_4(TumblrBlogRipper.Class7.smethod_3(TumblrBlogRipper.Class7.smethod_2(TumblrBlogRipper.Class7.smethod_0(htmlNode_0), <Module>.smethod_26<string>(2257785852u))), <Module>.smethod_26<string>(67742074u));
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x000072E0 File Offset: 0x000054E0
			internal bool method_3(HtmlNode htmlNode_0)
			{
				return TumblrBlogRipper.Class7.smethod_1(TumblrBlogRipper.Class7.smethod_0(htmlNode_0), <Module>.smethod_25<string>(2795898019u)) && TumblrBlogRipper.Class7.smethod_4(TumblrBlogRipper.Class7.smethod_3(TumblrBlogRipper.Class7.smethod_2(TumblrBlogRipper.Class7.smethod_0(htmlNode_0), <Module>.smethod_27<string>(2834548480u))), <Module>.smethod_25<string>(1892817363u));
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x00007330 File Offset: 0x00005530
			internal string method_4(HtmlNode htmlNode_0)
			{
				return TumblrBlogRipper.Class7.smethod_5(htmlNode_0);
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00006C10 File Offset: 0x00004E10
			static HtmlAttributeCollection smethod_0(HtmlNode htmlNode_0)
			{
				return htmlNode_0.Attributes;
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x00006C24 File Offset: 0x00004E24
			static bool smethod_1(HtmlAttributeCollection htmlAttributeCollection_0, string string_0)
			{
				return htmlAttributeCollection_0.Contains(string_0);
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x00006C38 File Offset: 0x00004E38
			static HtmlAttribute smethod_2(HtmlAttributeCollection htmlAttributeCollection_0, string string_0)
			{
				return htmlAttributeCollection_0[string_0];
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x00006C4C File Offset: 0x00004E4C
			static string smethod_3(HtmlAttribute htmlAttribute_0)
			{
				return htmlAttribute_0.Value;
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x00006C60 File Offset: 0x00004E60
			static bool smethod_4(string string_0, string string_1)
			{
				return string_0.Contains(string_1);
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x0000715C File Offset: 0x0000535C
			static string smethod_5(HtmlNode htmlNode_0)
			{
				return htmlNode_0.InnerText;
			}

			// Token: 0x0400003E RID: 62
			public static readonly TumblrBlogRipper.Class7 <>9 = new TumblrBlogRipper.Class7();

			// Token: 0x0400003F RID: 63
			public static Func<HtmlNode, bool> <>9__16_0;

			// Token: 0x04000040 RID: 64
			public static Func<HtmlNode, bool> <>9__17_0;

			// Token: 0x04000041 RID: 65
			public static Func<HtmlNode, bool> <>9__18_0;

			// Token: 0x04000042 RID: 66
			public static Func<HtmlNode, bool> <>9__19_0;

			// Token: 0x04000043 RID: 67
			public static Func<HtmlNode, string> <>9__19_1;
		}

		// Token: 0x02000012 RID: 18
		[CompilerGenerated]
		private sealed class Class8
		{
			// Token: 0x060000D9 RID: 217 RVA: 0x00007344 File Offset: 0x00005544
			internal void method_0()
			{
				try
				{
					this.class9_0.tumblrBlogRipper_0.method_12(this.int_0, false);
				}
				catch (Exception exception_)
				{
					TumblrBlogRipper.Class8.smethod_1(TumblrBlogRipper.Class8.smethod_0(exception_));
				}
				int num = this.class9_0.int_0;
				this.class9_0.int_0 = num + 1;
				TumblrBlogRipper.Class8.smethod_1(TumblrBlogRipper.Class8.smethod_2(<Module>.smethod_25<string>(2707273753u), this.class9_0.int_0));
				TumblrBlogRipper.Class8.smethod_3(this.class9_0.tumblrBlogRipper_0.MyRipper, this.class9_0.int_0 * 5);
			}

			// Token: 0x060000DA RID: 218 RVA: 0x000073E8 File Offset: 0x000055E8
			static string smethod_0(Exception exception_0)
			{
				return exception_0.Message;
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00006DB4 File Offset: 0x00004FB4
			static void smethod_1(string string_0)
			{
				Console.WriteLine(string_0);
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00007044 File Offset: 0x00005244
			static string smethod_2(object object_0, object object_1)
			{
				return object_0 + object_1;
			}

			// Token: 0x060000DD RID: 221 RVA: 0x0000706C File Offset: 0x0000526C
			static void smethod_3(IRipper iripper_0, int int_1)
			{
				iripper_0.UpdatePercentageComplete(int_1);
			}

			// Token: 0x04000044 RID: 68
			public int int_0;

			// Token: 0x04000045 RID: 69
			public TumblrBlogRipper.Class9 class9_0;
		}

		// Token: 0x02000013 RID: 19
		[CompilerGenerated]
		private sealed class Class9
		{
			// Token: 0x04000046 RID: 70
			public int int_0;

			// Token: 0x04000047 RID: 71
			public TumblrBlogRipper tumblrBlogRipper_0;
		}
	}
}
