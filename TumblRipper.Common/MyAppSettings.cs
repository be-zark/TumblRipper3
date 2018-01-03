using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace TumblRipper
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class MyAppSettings
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000049DC File Offset: 0x00002BDC
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000049F0 File Offset: 0x00002BF0
		public string LocalDir { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00004A04 File Offset: 0x00002C04
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00004A18 File Offset: 0x00002C18
		public string MachineID { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00004A2C File Offset: 0x00002C2C
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00004A40 File Offset: 0x00002C40
		public bool AnonymousUsage { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00004A54 File Offset: 0x00002C54
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00004A68 File Offset: 0x00002C68
		public bool UseProxy { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004A7C File Offset: 0x00002C7C
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00004A90 File Offset: 0x00002C90
		[XmlIgnore]
		public IWebProxy Proxy { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00004AA4 File Offset: 0x00002CA4
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00004AB8 File Offset: 0x00002CB8
		public string ProxyUrl { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004ACC File Offset: 0x00002CCC
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00004AE0 File Offset: 0x00002CE0
		public string ProxyUsername { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00004AF4 File Offset: 0x00002CF4
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00004B08 File Offset: 0x00002D08
		public string ProxyPassword { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00004B1C File Offset: 0x00002D1C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00004B30 File Offset: 0x00002D30
		public bool ProxyUseAuth { get; set; }

		// Token: 0x06000074 RID: 116 RVA: 0x00004B44 File Offset: 0x00002D44
		public MyAppSettings()
		{
			this.LocalDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "TumblRipper");
		}
	}
}
