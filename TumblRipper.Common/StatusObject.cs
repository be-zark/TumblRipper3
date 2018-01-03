using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using TumblRipper.Common.Annotations;

namespace TumblRipper
{
	// Token: 0x02000013 RID: 19
	public class StatusObject : INotifyPropertyChanged
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000053B4 File Offset: 0x000035B4
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000053C8 File Offset: 0x000035C8
		public string PreviewImageSource
		{
			get
			{
				return this.string_1;
			}
			set
			{
				if (value == this.string_1)
				{
					return;
				}
				this.string_1 = value;
				this.OnPropertyChanged("PreviewImageSource");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000053F8 File Offset: 0x000035F8
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000540C File Offset: 0x0000360C
		public int ProgressBar
		{
			get
			{
				return this.int_3;
			}
			set
			{
				if (value == this.int_3)
				{
					return;
				}
				this.int_3 = value;
				this.OnPropertyChanged("ProgressBar");
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00005438 File Offset: 0x00003638
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000544C File Offset: 0x0000364C
		public int TotalPosts
		{
			get
			{
				return this.int_0;
			}
			set
			{
				if (value == this.int_0)
				{
					return;
				}
				this.int_0 = value;
				this.OnPropertyChanged("TotalPosts");
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00005478 File Offset: 0x00003678
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000548C File Offset: 0x0000368C
		public int PendingPosts
		{
			get
			{
				return this.int_1;
			}
			set
			{
				if (value == this.int_1)
				{
					return;
				}
				this.int_1 = value;
				this.OnPropertyChanged("PendingPosts");
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000054B8 File Offset: 0x000036B8
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000054CC File Offset: 0x000036CC
		public int FailedPosts
		{
			get
			{
				return this.int_2;
			}
			set
			{
				if (value == this.int_2)
				{
					return;
				}
				this.int_2 = value;
				this.OnPropertyChanged("FailedPosts");
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000054F8 File Offset: 0x000036F8
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000550C File Offset: 0x0000370C
		public string DisplayStatus
		{
			get
			{
				return this.string_0;
			}
			set
			{
				if (value == this.string_0)
				{
					return;
				}
				this.string_0 = value;
				this.OnPropertyChanged("DisplayStatus");
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000553C File Offset: 0x0000373C
		public StatusObject()
		{
			this.DisplayStatus = string.Empty;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000AA RID: 170 RVA: 0x0000555C File Offset: 0x0000375C
		// (remove) Token: 0x060000AB RID: 171 RVA: 0x00005598 File Offset: 0x00003798
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000055D4 File Offset: 0x000037D4
		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler == null)
			{
				return;
			}
			propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x04000047 RID: 71
		private int int_0;

		// Token: 0x04000048 RID: 72
		private int int_1;

		// Token: 0x04000049 RID: 73
		private int int_2;

		// Token: 0x0400004A RID: 74
		private string string_0;

		// Token: 0x0400004B RID: 75
		private int int_3;

		// Token: 0x0400004C RID: 76
		private string string_1;

		// Token: 0x0400004D RID: 77
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;
	}
}
