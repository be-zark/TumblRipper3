// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.MyLicence
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace TumblRipper.Common
{
  [Serializable]
  public class MyLicence
  {
    public string Serial { get; set; }

    public string Email { get; set; }

    public MyLicence(string string_0, string string_1)
    {
      this.Serial = string_0;
      this.Email = string_1;
    }

    private MyLicence()
    {
    }

    public static MyLicence LoadFromFile(string path)
    {
      if (!File.Exists(path))
        return (MyLicence) null;
      try
      {
        byte[] buffer = ProtectedData.Unprotect(File.ReadAllBytes(path), (byte[]) null, DataProtectionScope.LocalMachine);
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (MyLicence));
        MemoryStream memoryStream1 = new MemoryStream(buffer);
        MemoryStream memoryStream2 = memoryStream1;
        MyLicence myLicence = xmlSerializer.Deserialize((Stream) memoryStream2) as MyLicence;
        memoryStream1.Close();
        return myLicence;
      }
      catch (Exception ex)
      {
        return (MyLicence) null;
      }
    }

    public static void SaveToFile(string path, MyLicence licence)
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        new XmlSerializer(typeof (MyLicence)).Serialize((Stream) memoryStream, (object) licence);
        byte[] bytes = ProtectedData.Protect(memoryStream.ToArray(), (byte[]) null, DataProtectionScope.LocalMachine);
        File.WriteAllBytes(path, bytes);
      }
    }
  }
}
