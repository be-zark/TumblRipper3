using System;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace TumblRipper
{
	// Token: 0x02000010 RID: 16
	[Serializable]
	public class MyLicence
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00004B70 File Offset: 0x00002D70
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00004B84 File Offset: 0x00002D84
		public string Serial { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004B98 File Offset: 0x00002D98
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00004BAC File Offset: 0x00002DAC
		public string Email { get; set; }

		// Token: 0x06000079 RID: 121 RVA: 0x00004BC0 File Offset: 0x00002DC0
		public MyLicence(string string_0, string string_1)
		{
			this.Serial = string_0;
			this.Email = string_1;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000033A4 File Offset: 0x000015A4
		private MyLicence()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004BE4 File Offset: 0x00002DE4
		public static MyLicence LoadFromFile(string path)
		{
			if (!File.Exists(path))
			{
				return null;
			}
			MyLicence result;
			try
			{
				byte[] buffer = ProtectedData.Unprotect(File.ReadAllBytes(path), null, DataProtectionScope.LocalMachine);
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(MyLicence));
				MemoryStream memoryStream = new MemoryStream(buffer);
				MyLicence myLicence = xmlSerializer.Deserialize(memoryStream) as MyLicence;
				memoryStream.Close();
				result = myLicence;
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004C4C File Offset: 0x00002E4C
		public static void SaveToFile(string path, MyLicence licence)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(MyLicence));
			using (MemoryStream memoryStream = new MemoryStream())
			{
				xmlSerializer.Serialize(memoryStream, licence);
				byte[] bytes = ProtectedData.Protect(memoryStream.ToArray(), null, DataProtectionScope.LocalMachine);
				File.WriteAllBytes(path, bytes);
			}
		}
	}
}
