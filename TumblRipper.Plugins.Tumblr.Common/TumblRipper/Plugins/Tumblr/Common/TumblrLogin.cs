// Decompiled with JetBrains decompiler
// Type: TumblRipper.Plugins.Tumblr.Common.TumblrLogin
// Assembly: TumblRipper.Plugins.Tumblr.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 15755DA5-85D8-4ACD-AA0E-0AC767D82FC3
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Plugins.Tumblr.Common.dll

using HtmlAgilityPack;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using TumblRipper.PluginInterface;

namespace TumblRipper.Plugins.Tumblr.Common
{
  public class TumblrLogin
  {
    private static void smethod_0(IRipper iripper_0, ref List<Cookie> list_0, string string_0, string string_1)
    {
      string url = "https://www.tumblr.com/svc/account/register";
      iripper_0.PostWebPage(url, new NameValueCollection()
      {
        {
          "determine_email",
          string_1
        },
        {
          "user[email]",
          ""
        },
        {
          "user[password]",
          ""
        },
        {
          "tumblelog[name]",
          ""
        },
        {
          "user[age]",
          ""
        },
        {
          "context",
          "login"
        },
        {
          "version",
          "STANDARD"
        },
        {
          "follow",
          ""
        },
        {
          "redirect_to",
          "/dashboard"
        },
        {
          "http_referer",
          "https://www.tumblr.com/login?redirect_to=%2Fdashboard"
        },
        {
          "form_key",
          string_0
        },
        {
          "seen_suggestion",
          "0"
        },
        {
          "used_suggestion",
          "0"
        },
        {
          "used_auto_suggestion",
          "0"
        },
        {
          "about_tumblr_slide",
          ""
        },
        {
          "action",
          "signup_determine"
        },
        {
          "tracking_url",
          "/login"
        },
        {
          "tracking_version",
          "modal"
        },
        {
          "random_username_suggestions",
          "[\"DecadentAlpacaPerson\",\"CertainYouthNight\",\"BigAvenueObservation\",\"DarkPandaCherryblossom\",\"CyberKoalaLlama\"]"
        }
      }, ref list_0);
    }

    public static List<Cookie> Login(IRipper myRipper, string username, string password)
    {
      return TumblrLogin.smethod_1(myRipper, username, password);
    }

    private static List<Cookie> smethod_1(IRipper iripper_0, string string_0, string string_1)
    {
      string url = "https://www.tumblr.com/login";
      List<Cookie> list = new List<Cookie>();
      string webPage = iripper_0.GetWebPage(url, ref list);
      HtmlDocument htmlDocument = new HtmlDocument();
      string str = webPage;
      htmlDocument.LoadHtml(str);
      string string_0_1 = string.Empty;
      using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//input")).GetEnumerator())
      {
        while (((IEnumerator) enumerator).MoveNext())
        {
          HtmlNode current = enumerator.Current;
          if (current.get_Attributes().Contains("name") && current.get_Attributes().get_Item("name").get_Value().Equals("form_key"))
            string_0_1 = current.get_Attributes().get_Item("value").get_Value();
        }
      }
      TumblrLogin.smethod_0(iripper_0, ref list, string_0_1, string_0);
      iripper_0.PostWebPage(url, new NameValueCollection()
      {
        {
          "determine_email",
          string_0
        },
        {
          "user[email]",
          string_0
        },
        {
          "user[password]",
          string_1
        },
        {
          "tumblelog[name]",
          ""
        },
        {
          "user[age]",
          ""
        },
        {
          "context",
          "other"
        },
        {
          "version",
          "STANDARD"
        },
        {
          "follow",
          ""
        },
        {
          "http_referer",
          "https://www.tumblr.com/logout"
        },
        {
          "form_key",
          string_0_1
        },
        {
          "seen_suggestion",
          "0"
        },
        {
          "used_suggestion",
          "0"
        },
        {
          "used_auto_suggestion",
          "0"
        },
        {
          "about_tumblr_slide",
          ""
        },
        {
          "random_username_suggestions",
          "[\"DecadentAlpacaPerson\",\"CertainYouthNight\",\"BigAvenueObservation\",\"DarkPandaCherryblossom\",\"CyberKoalaLlama\"]"
        }
      }, ref list);
      return list;
    }
  }
}
