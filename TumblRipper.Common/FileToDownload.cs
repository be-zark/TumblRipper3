using System;

namespace TumblRipper
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	public class FileToDownload : IEquatable<FileToDownload>, IFileToDownload
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000056C8 File Offset: 0x000038C8
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000056DC File Offset: 0x000038DC
		public string Key { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000056F0 File Offset: 0x000038F0
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00005704 File Offset: 0x00003904
		public string Url { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00005718 File Offset: 0x00003918
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000572C File Offset: 0x0000392C
		public string Filename { get; set; }

		// Token: 0x060000B6 RID: 182 RVA: 0x000033A4 File Offset: 0x000015A4
		public FileToDownload()
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00005740 File Offset: 0x00003940
		public FileToDownload(string string_0, string string_1, string string_2)
		{
			this.Url = string_0;
			this.Filename = string_1;
			this.Key = string_2;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005768 File Offset: 0x00003968
		public FileToDownload(string string_0, string string_1)
		{
			this.Url = string_0;
			this.Filename = string_1;
			this.Key = string_0;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005790 File Offset: 0x00003990
		public bool Equals(FileToDownload obj)
		{
			return this.Key.Equals(obj.Key);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000057B0 File Offset: 0x000039B0
		public override bool Equals(object obj)
		{
			return this.Equals(obj as FileToDownload);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000057CC File Offset: 0x000039CC
		public override int GetHashCode()
		{
			return this.Key.GetHashCode();
		}
	}
}
