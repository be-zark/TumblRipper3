// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.LicenceValidation
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;

namespace TumblRipper.Common
{
  public class LicenceValidation
  {
    public static void PostDebugMessage(string t)
    {
      using (MyWebClient myWebClient = new MyWebClient())
      {
        myWebClient.Encoding = Encoding.UTF8;
        Encoding.UTF8.GetString(myWebClient.UploadValues("https://www.zark.be/software/debug.html?t=TumblRipper", "POST", new NameValueCollection()
        {
          {
            "settings",
            t
          }
        }));
      }
    }

    public static void UpdateVisitWebsite(string version)
    {
      Process.Start("https://www.zark.be/software/TumblRipper.html");
    }

    public static string CheckForUpdate()
    {
      MyWebClient myWebClient = new MyWebClient();
      Encoding utF8 = Encoding.UTF8;
      myWebClient.Encoding = utF8;
      Uri address = new Uri("https://www.zark.be/software/getFile.html?file=TumblRipperUpdate.txt");
      return myWebClient.DownloadString(address).Trim();
    }

    public static bool ValidLicence(string e, string s)
    {
      bool flag1 = false;
      try
      {
        MyWebClient myWebClient = new MyWebClient();
        Encoding utF8 = Encoding.UTF8;
        myWebClient.Encoding = utF8;
        Uri address = new Uri(string.Format("https://www.zark.be/software/backend.html?p=TumblRipper&e={0}&s={1}", (object) e, (object) s));
        string[] strArray = myWebClient.DownloadString(address).Split(';');
        bool flag2 = false;
        for (int index = 0; index < 3; ++index)
        {
          double d = (double) long.Parse(strArray[index]) / 5479.0;
          flag2 = Math.Floor(d) == d;
        }
        if (flag2)
        {
          MySettings.Instance.Licence = new MyLicence(s, e);
          flag1 = true;
        }
        else
          MySettings.Instance.Licence = (MyLicence) null;
        MySettings.Instance.SetLicence(MySettings.Instance.Licence);
      }
      catch (Exception ex)
      {
      }
      return flag1;
    }
  }
}
