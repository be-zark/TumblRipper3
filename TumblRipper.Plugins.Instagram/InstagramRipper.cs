// Decompiled with JetBrains decompiler
// Type: TumblRipper.Plugins.Instagram.InstagramRipper
// Assembly: TumblRipper.Plugins.Instagram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 33A2707F-B533-4B14-88E0-4B68F738EE55
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Plugins.Instagram.dll

using HtmlAgilityPack;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using TumblRipper.PluginInterface;

namespace TumblRipper.Plugins.Instagram
{
  public class InstagramRipper
  {
    private List<IFileToDownload> list_0 = new List<IFileToDownload>();
    private List<Cookie> list_1 = new List<Cookie>();
    private CancellationToken cancellationToken_0;
    private readonly InstagramBlog instagramBlog_0;
    public string _url;

    public IRipper MyRipper { get; set; }

    public InstagramSettings Settings { get; set; }

    public InstagramRipper(InstagramBlog instagramBlog_1)
    {
      this.instagramBlog_0 = instagramBlog_1;
    }

    public void Start(CancellationToken _token)
    {
      this.cancellationToken_0 = _token;
      this.method_0();
    }

    private void method_0()
    {
      this._url = this.MyRipper.Website.Url;
      this.MyRipper.UpdatePercentageComplete(0);
      if (this.MyRipper.PostsFound.Count > 0)
      {
        this.MyRipper.UpdateStatusText("Downloading Pending ...");
        this.MyRipper.DownloadPostsFound(this.cancellationToken_0);
      }
      this.method_2((string) null, true);
      this.MyRipper.UpdateStatusText("Indexing done");
      this.MyRipper.SaveHistory();
      this.MyRipper.SavePostsFound();
      this.MyRipper.UpdateStatusText("Downloading ...");
      this.MyRipper.DownloadPostsFound(this.cancellationToken_0);
      if (this.MyRipper.FailedPosts.Count > 0)
      {
        this.MyRipper.UpdateStatusText("Retrying ...");
        this.MyRipper.SaveFailed();
        this.method_1();
      }
      this.MyRipper.UpdateStatusText("Done");
    }

    private void method_1()
    {
      foreach (IFileToDownloadFailed toDownloadFailed in (IEnumerable<IFileToDownloadFailed>) this.MyRipper.FailedPosts)
      {
        if (toDownloadFailed.Retry <= 5)
          this.MyRipper.PostsFound.Enqueue((IFileToDownload) toDownloadFailed);
      }
      this.MyRipper.DownloadPostsFound(this.cancellationToken_0);
    }

    public string GetNextTs(object dyn)
    {
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class5.callSite_1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class5.callSite_1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, bool> func1 = InstagramRipper.Class5.callSite_1.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, bool>> callSite1 = InstagramRipper.Class5.callSite_1;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class5.callSite_0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class5.callSite_0 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj1 = InstagramRipper.Class5.callSite_0.Target((CallSite) InstagramRipper.Class5.callSite_0, dyn, (object) null);
      if (func1((CallSite) callSite1, obj1))
        return (string) null;
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class5.callSite_10 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class5.callSite_10 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, bool> func2 = InstagramRipper.Class5.callSite_10.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, bool>> callSite2 = InstagramRipper.Class5.callSite_10;
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class5.callSite_9 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class5.callSite_9 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Value", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, object> func3 = InstagramRipper.Class5.callSite_9.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, object>> callSite3 = InstagramRipper.Class5.callSite_9;
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class5.callSite_8 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class5.callSite_8 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "has_next_page", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, object> func4 = InstagramRipper.Class5.callSite_8.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, object>> callSite4 = InstagramRipper.Class5.callSite_8;
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class5.callSite_7 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class5.callSite_7 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "page_info", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, object> func5 = InstagramRipper.Class5.callSite_7.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, object>> callSite5 = InstagramRipper.Class5.callSite_7;
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class5.callSite_6 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class5.callSite_6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "media", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, object> func6 = InstagramRipper.Class5.callSite_6.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, object>> callSite6 = InstagramRipper.Class5.callSite_6;
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class5.callSite_5 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class5.callSite_5 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "user", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, object> func7 = InstagramRipper.Class5.callSite_5.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, object>> callSite7 = InstagramRipper.Class5.callSite_5;
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class5.callSite_4 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class5.callSite_4 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, int, object> func8 = InstagramRipper.Class5.callSite_4.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, int, object>> callSite8 = InstagramRipper.Class5.callSite_4;
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class5.callSite_3 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class5.callSite_3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "ProfilePage", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, object> func9 = InstagramRipper.Class5.callSite_3.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, object>> callSite9 = InstagramRipper.Class5.callSite_3;
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class5.callSite_2 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class5.callSite_2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "entry_data", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj2 = InstagramRipper.Class5.callSite_2.Target((CallSite) InstagramRipper.Class5.callSite_2, dyn);
        object obj3 = func9((CallSite) callSite9, obj2);
        int num1 = 0;
        object obj4 = func8((CallSite) callSite8, obj3, num1);
        object obj5 = func7((CallSite) callSite7, obj4);
        object obj6 = func6((CallSite) callSite6, obj5);
        object obj7 = func5((CallSite) callSite5, obj6);
        object obj8 = func4((CallSite) callSite4, obj7);
        object obj9 = func3((CallSite) callSite3, obj8);
        if (func2((CallSite) callSite2, obj9))
        {
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class5.callSite_19 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class5.callSite_19 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (InstagramRipper)));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, string> func10 = InstagramRipper.Class5.callSite_19.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, string>> callSite10 = InstagramRipper.Class5.callSite_19;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class5.callSite_18 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class5.callSite_18 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Value", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object> func11 = InstagramRipper.Class5.callSite_18.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object>> callSite11 = InstagramRipper.Class5.callSite_18;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class5.callSite_17 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class5.callSite_17 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "end_cursor", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object> func12 = InstagramRipper.Class5.callSite_17.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object>> callSite12 = InstagramRipper.Class5.callSite_17;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class5.callSite_16 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class5.callSite_16 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "page_info", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object> func13 = InstagramRipper.Class5.callSite_16.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object>> callSite13 = InstagramRipper.Class5.callSite_16;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class5.callSite_15 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class5.callSite_15 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "media", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object> func14 = InstagramRipper.Class5.callSite_15.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object>> callSite14 = InstagramRipper.Class5.callSite_15;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class5.callSite_14 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class5.callSite_14 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "user", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object> func15 = InstagramRipper.Class5.callSite_14.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object>> callSite15 = InstagramRipper.Class5.callSite_14;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class5.callSite_13 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class5.callSite_13 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, int, object> func16 = InstagramRipper.Class5.callSite_13.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, int, object>> callSite16 = InstagramRipper.Class5.callSite_13;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class5.callSite_12 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class5.callSite_12 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "ProfilePage", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object> func17 = InstagramRipper.Class5.callSite_12.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object>> callSite17 = InstagramRipper.Class5.callSite_12;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class5.callSite_11 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class5.callSite_11 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "entry_data", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj10 = InstagramRipper.Class5.callSite_11.Target((CallSite) InstagramRipper.Class5.callSite_11, dyn);
          object obj11 = func17((CallSite) callSite17, obj10);
          int num2 = 0;
          object obj12 = func16((CallSite) callSite16, obj11, num2);
          object obj13 = func15((CallSite) callSite15, obj12);
          object obj14 = func14((CallSite) callSite14, obj13);
          object obj15 = func13((CallSite) callSite13, obj14);
          object obj16 = func12((CallSite) callSite12, obj15);
          object obj17 = func11((CallSite) callSite11, obj16);
          return func10((CallSite) callSite10, obj17);
        }
      }
      catch (Exception ex)
      {
        return (string) null;
      }
      return (string) null;
    }

    private void method_2(string string_0, bool bool_0)
    {
      int num = 0;
      do
      {
        this.cancellationToken_0.ThrowIfCancellationRequested();
        string url = "http://" + this._url + "/";
        if (string_0 != null)
          goto label_40;
label_1:
        string webPage = this.MyRipper.GetWebPage(url);
        if (webPage != null)
        {
          HtmlDocument htmlDocument = new HtmlDocument();
          string str1 = webPage;
          htmlDocument.LoadHtml(str1);
          string str2 = "";
          using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//script")).GetEnumerator())
          {
            while (((IEnumerator) enumerator).MoveNext())
            {
              HtmlNode current = enumerator.Current;
              if (current.get_InnerText().StartsWith("window._sharedData"))
                str2 = current.get_InnerText().Substring(current.get_InnerText().IndexOf("{"));
            }
          }
          if (str2.Length >= 1)
          {
            object obj1 = JsonConvert.DeserializeObject(str2.Replace("</script>", "").Replace("};", "}"));
            // ISSUE: reference to a compiler-generated field
            if (InstagramRipper.Class6.callSite_1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              InstagramRipper.Class6.callSite_1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (InstagramRipper)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, string> func1 = InstagramRipper.Class6.callSite_1.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, string>> callSite1 = InstagramRipper.Class6.callSite_1;
            // ISSUE: reference to a compiler-generated field
            if (InstagramRipper.Class6.callSite_0 == null)
            {
              // ISSUE: reference to a compiler-generated field
              InstagramRipper.Class6.callSite_0 = CallSite<Func<CallSite, InstagramRipper, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "GetNextTs", (IEnumerable<Type>) null, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj2 = InstagramRipper.Class6.callSite_0.Target((CallSite) InstagramRipper.Class6.callSite_0, this, obj1);
            string_0 = func1((CallSite) callSite1, obj2);
            // ISSUE: reference to a compiler-generated field
            if (InstagramRipper.Class6.callSite_3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              InstagramRipper.Class6.callSite_3 = CallSite<Func<CallSite, object, List<IFileToDownload>>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (List<IFileToDownload>), typeof (InstagramRipper)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, List<IFileToDownload>> func2 = InstagramRipper.Class6.callSite_3.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, List<IFileToDownload>>> callSite2 = InstagramRipper.Class6.callSite_3;
            // ISSUE: reference to a compiler-generated field
            if (InstagramRipper.Class6.callSite_2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              InstagramRipper.Class6.callSite_2 = CallSite<Func<CallSite, InstagramRipper, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ProcessPage", (IEnumerable<Type>) null, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj3 = InstagramRipper.Class6.callSite_2.Target((CallSite) InstagramRipper.Class6.callSite_2, this, obj1);
            List<IFileToDownload> list = func2((CallSite) callSite2, obj3);
            bool flag = false;
            foreach (IFileToDownload fileToDownload in list)
            {
              IList<IFileToDownload> history = this.MyRipper.History;
              bool lockTaken1 = false;
              try
              {
                Monitor.Enter((object) history, ref lockTaken1);
                if (!this.MyRipper.History.Contains(fileToDownload))
                {
                  System.Collections.Generic.Queue<IFileToDownload> postsFound = this.MyRipper.PostsFound;
                  bool lockTaken2 = false;
                  try
                  {
                    Monitor.Enter((object) postsFound, ref lockTaken2);
                    this.MyRipper.PostsFound.Enqueue(fileToDownload);
                  }
                  finally
                  {
                    if (lockTaken2)
                      Monitor.Exit((object) postsFound);
                  }
                  this.MyRipper.History.Add(fileToDownload);
                }
                else
                  flag = true;
              }
              finally
              {
                if (lockTaken1)
                  Monitor.Exit((object) history);
              }
            }
            this.MyRipper.UpdateStatusText("indexing ...");
            this.MyRipper.UpdateStatusTotalPosts(this.MyRipper.History.Count);
            if (bool_0 && this.MyRipper.History.Count - num > 500)
            {
              num = this.MyRipper.History.Count;
              this.MyRipper.SaveSettings(this.instagramBlog_0.writeSettings(this.Settings));
              this.MyRipper.SaveHistory();
            }
            if (flag)
              goto label_43;
          }
          else
            goto label_42;
        }
        continue;
label_40:
        url = url + "?max_id=" + string_0;
        goto label_1;
      }
      while (string_0 != null);
      goto label_39;
label_42:
      return;
label_43:
      return;
label_39:;
    }

    public IList<IFileToDownload> ProcessPage(object dyn)
    {
      List<IFileToDownload> list = new List<IFileToDownload>();
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_6 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Value", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, object> func1 = InstagramRipper.Class7.callSite_6.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, object>> callSite1 = InstagramRipper.Class7.callSite_6;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_5 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_5 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "count", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, object> func2 = InstagramRipper.Class7.callSite_5.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, object>> callSite2 = InstagramRipper.Class7.callSite_5;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_4 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "media", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, object> func3 = InstagramRipper.Class7.callSite_4.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, object>> callSite3 = InstagramRipper.Class7.callSite_4;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_3 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_3 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "user", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, object> func4 = InstagramRipper.Class7.callSite_3.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, object>> callSite4 = InstagramRipper.Class7.callSite_3;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_2 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, int, object> func5 = InstagramRipper.Class7.callSite_2.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, int, object>> callSite5 = InstagramRipper.Class7.callSite_2;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_1 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_1 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "ProfilePage", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, object> func6 = InstagramRipper.Class7.callSite_1.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, object>> callSite6 = InstagramRipper.Class7.callSite_1;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "entry_data", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj1 = InstagramRipper.Class7.callSite_0.Target((CallSite) InstagramRipper.Class7.callSite_0, dyn);
      object obj2 = func6((CallSite) callSite6, obj1);
      int num1 = 0;
      object obj3 = func5((CallSite) callSite5, obj2, num1);
      object obj4 = func4((CallSite) callSite4, obj3);
      object obj5 = func3((CallSite) callSite3, obj4);
      object obj6 = func2((CallSite) callSite2, obj5);
      object obj7 = func1((CallSite) callSite1, obj6);
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_36 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_36 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (IEnumerable), typeof (InstagramRipper)));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, IEnumerable> func7 = InstagramRipper.Class7.callSite_36.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, IEnumerable>> callSite7 = InstagramRipper.Class7.callSite_36;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_12 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_12 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "nodes", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, object> func8 = InstagramRipper.Class7.callSite_12.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, object>> callSite8 = InstagramRipper.Class7.callSite_12;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_11 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_11 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "media", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, object> func9 = InstagramRipper.Class7.callSite_11.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, object>> callSite9 = InstagramRipper.Class7.callSite_11;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_10 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_10 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "user", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, object> func10 = InstagramRipper.Class7.callSite_10.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, object>> callSite10 = InstagramRipper.Class7.callSite_10;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_9 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_9 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, int, object> func11 = InstagramRipper.Class7.callSite_9.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, int, object>> callSite11 = InstagramRipper.Class7.callSite_9;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_8 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_8 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.ResultIndexed, "ProfilePage", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      Func<CallSite, object, object> func12 = InstagramRipper.Class7.callSite_8.Target;
      // ISSUE: reference to a compiler-generated field
      CallSite<Func<CallSite, object, object>> callSite12 = InstagramRipper.Class7.callSite_8;
      // ISSUE: reference to a compiler-generated field
      if (InstagramRipper.Class7.callSite_7 == null)
      {
        // ISSUE: reference to a compiler-generated field
        InstagramRipper.Class7.callSite_7 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "entry_data", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj8 = InstagramRipper.Class7.callSite_7.Target((CallSite) InstagramRipper.Class7.callSite_7, dyn);
      object obj9 = func12((CallSite) callSite12, obj8);
      int num2 = 0;
      object obj10 = func11((CallSite) callSite11, obj9, num2);
      object obj11 = func10((CallSite) callSite10, obj10);
      object obj12 = func9((CallSite) callSite9, obj11);
      object obj13 = func8((CallSite) callSite8, obj12);
      foreach (object obj14 in func7((CallSite) callSite7, obj13))
      {
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class7.callSite_15 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class7.callSite_15 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, bool> func13 = InstagramRipper.Class7.callSite_15.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, bool>> callSite13 = InstagramRipper.Class7.callSite_15;
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class7.callSite_14 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class7.callSite_14 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Value", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, object> func14 = InstagramRipper.Class7.callSite_14.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, object>> callSite14 = InstagramRipper.Class7.callSite_14;
        // ISSUE: reference to a compiler-generated field
        if (InstagramRipper.Class7.callSite_13 == null)
        {
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class7.callSite_13 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "is_video", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj15 = InstagramRipper.Class7.callSite_13.Target((CallSite) InstagramRipper.Class7.callSite_13, obj14);
        object obj16 = func14((CallSite) callSite14, obj15);
        if (func13((CallSite) callSite13, obj16))
        {
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_18 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_18 = CallSite<Func<CallSite, IRipper, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetWebPage", (IEnumerable<Type>) null, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, IRipper, object, object> func15 = InstagramRipper.Class7.callSite_18.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, IRipper, object, object>> callSite15 = InstagramRipper.Class7.callSite_18;
          IRipper myRipper1 = this.MyRipper;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_17 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_17 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, string, object, object> func16 = InstagramRipper.Class7.callSite_17.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, string, object, object>> callSite16 = InstagramRipper.Class7.callSite_17;
          string str1 = "https://www.instagram.com/p/";
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_16 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_16 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "code", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj17 = InstagramRipper.Class7.callSite_16.Target((CallSite) InstagramRipper.Class7.callSite_16, obj14);
          object obj18 = func16((CallSite) callSite16, str1, obj17);
          object obj19 = func15((CallSite) callSite15, myRipper1, obj18);
          HtmlDocument htmlDocument = new HtmlDocument();
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_19 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_19 = CallSite<Action<CallSite, HtmlDocument, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "LoadHtml", (IEnumerable<Type>) null, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class7.callSite_19.Target((CallSite) InstagramRipper.Class7.callSite_19, htmlDocument, obj19);
          using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>) htmlDocument.get_DocumentNode().SelectNodes("//meta")).GetEnumerator())
          {
            while (((IEnumerator) enumerator).MoveNext())
            {
              HtmlNode current = enumerator.Current;
              if (current.get_Attributes().Contains("property") && current.get_Attributes().get_Item("property").get_Value().Equals("og:video"))
              {
                // ISSUE: reference to a compiler-generated field
                if (InstagramRipper.Class7.callSite_22 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  InstagramRipper.Class7.callSite_22 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
                  {
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
                  }));
                }
                // ISSUE: reference to a compiler-generated field
                Func<CallSite, object, string, object> func17 = InstagramRipper.Class7.callSite_22.Target;
                // ISSUE: reference to a compiler-generated field
                CallSite<Func<CallSite, object, string, object>> callSite17 = InstagramRipper.Class7.callSite_22;
                // ISSUE: reference to a compiler-generated field
                if (InstagramRipper.Class7.callSite_21 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  InstagramRipper.Class7.callSite_21 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Value", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                  {
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                  }));
                }
                // ISSUE: reference to a compiler-generated field
                Func<CallSite, object, object> func18 = InstagramRipper.Class7.callSite_21.Target;
                // ISSUE: reference to a compiler-generated field
                CallSite<Func<CallSite, object, object>> callSite18 = InstagramRipper.Class7.callSite_21;
                // ISSUE: reference to a compiler-generated field
                if (InstagramRipper.Class7.callSite_20 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  InstagramRipper.Class7.callSite_20 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "code", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                  {
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                  }));
                }
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                object obj20 = InstagramRipper.Class7.callSite_20.Target((CallSite) InstagramRipper.Class7.callSite_20, obj14);
                object obj21 = func18((CallSite) callSite18, obj20);
                string str2 = ".mp4";
                object obj22 = func17((CallSite) callSite17, obj21, str2);
                string str3 = current.get_Attributes().get_Item("content").get_Value();
                // ISSUE: reference to a compiler-generated field
                if (InstagramRipper.Class7.callSite_25 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  InstagramRipper.Class7.callSite_25 = CallSite<Func<CallSite, IRipper, string, object, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "NewDownloadFile", (IEnumerable<Type>) null, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[4]
                  {
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                  }));
                }
                // ISSUE: reference to a compiler-generated field
                Func<CallSite, IRipper, string, object, object, object> func19 = InstagramRipper.Class7.callSite_25.Target;
                // ISSUE: reference to a compiler-generated field
                CallSite<Func<CallSite, IRipper, string, object, object, object>> callSite19 = InstagramRipper.Class7.callSite_25;
                IRipper myRipper2 = this.MyRipper;
                string str4 = str3;
                object obj23 = obj22;
                // ISSUE: reference to a compiler-generated field
                if (InstagramRipper.Class7.callSite_24 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  InstagramRipper.Class7.callSite_24 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", (IEnumerable<Type>) null, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                  {
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                  }));
                }
                // ISSUE: reference to a compiler-generated field
                Func<CallSite, object, object> func20 = InstagramRipper.Class7.callSite_24.Target;
                // ISSUE: reference to a compiler-generated field
                CallSite<Func<CallSite, object, object>> callSite20 = InstagramRipper.Class7.callSite_24;
                // ISSUE: reference to a compiler-generated field
                if (InstagramRipper.Class7.callSite_23 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  InstagramRipper.Class7.callSite_23 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
                  {
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                  }));
                }
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                object obj24 = InstagramRipper.Class7.callSite_23.Target((CallSite) InstagramRipper.Class7.callSite_23, obj14);
                object obj25 = func20((CallSite) callSite20, obj24);
                object obj26 = func19((CallSite) callSite19, myRipper2, str4, obj23, obj25);
                // ISSUE: reference to a compiler-generated field
                if (InstagramRipper.Class7.callSite_26 == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  InstagramRipper.Class7.callSite_26 = CallSite<Action<CallSite, List<IFileToDownload>, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", (IEnumerable<Type>) null, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
                  {
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                  }));
                }
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                InstagramRipper.Class7.callSite_26.Target((CallSite) InstagramRipper.Class7.callSite_26, list, obj26);
              }
            }
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_29 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_29 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, string, object> func15 = InstagramRipper.Class7.callSite_29.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, string, object>> callSite15 = InstagramRipper.Class7.callSite_29;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_28 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_28 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Value", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object> func16 = InstagramRipper.Class7.callSite_28.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object>> callSite16 = InstagramRipper.Class7.callSite_28;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_27 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_27 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "code", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj17 = InstagramRipper.Class7.callSite_27.Target((CallSite) InstagramRipper.Class7.callSite_27, obj14);
          object obj18 = func16((CallSite) callSite16, obj17);
          string str = ".jpg";
          object obj19 = func15((CallSite) callSite15, obj18, str);
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_31 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_31 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Value", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object> func17 = InstagramRipper.Class7.callSite_31.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object>> callSite17 = InstagramRipper.Class7.callSite_31;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_30 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_30 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "display_src", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj20 = InstagramRipper.Class7.callSite_30.Target((CallSite) InstagramRipper.Class7.callSite_30, obj14);
          object obj21 = func17((CallSite) callSite17, obj20);
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_34 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_34 = CallSite<Func<CallSite, IRipper, object, object, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "NewDownloadFile", (IEnumerable<Type>) null, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[4]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, IRipper, object, object, object, object> func18 = InstagramRipper.Class7.callSite_34.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, IRipper, object, object, object, object>> callSite18 = InstagramRipper.Class7.callSite_34;
          IRipper myRipper = this.MyRipper;
          object obj22 = obj21;
          object obj23 = obj19;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_33 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_33 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", (IEnumerable<Type>) null, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object> func19 = InstagramRipper.Class7.callSite_33.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object>> callSite19 = InstagramRipper.Class7.callSite_33;
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_32 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_32 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj24 = InstagramRipper.Class7.callSite_32.Target((CallSite) InstagramRipper.Class7.callSite_32, obj14);
          object obj25 = func19((CallSite) callSite19, obj24);
          object obj26 = func18((CallSite) callSite18, myRipper, obj22, obj23, obj25);
          // ISSUE: reference to a compiler-generated field
          if (InstagramRipper.Class7.callSite_35 == null)
          {
            // ISSUE: reference to a compiler-generated field
            InstagramRipper.Class7.callSite_35 = CallSite<Action<CallSite, List<IFileToDownload>, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", (IEnumerable<Type>) null, typeof (InstagramRipper), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          InstagramRipper.Class7.callSite_35.Target((CallSite) InstagramRipper.Class7.callSite_35, list, obj26);
        }
      }
      return (IList<IFileToDownload>) list;
    }
  }
}
