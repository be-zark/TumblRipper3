// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.Controller
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.Threading;
using System.Threading.Tasks;
using TumblRipper.PluginInterface;

namespace TumblRipper.Common
{
  public class Controller
  {
    private static Task task_0;
    private static CancellationToken cancellationToken_0;
    private static Controller controller_0;
    private static ITrPlugin itrPlugin_0;

    public Controller Instance
    {
      get
      {
        if (Controller.controller_0 == null)
          Controller.controller_0 = new Controller();
        return Controller.controller_0;
      }
    }

    public static void Init()
    {
      Controller.controller_0 = new Controller();
      PluginLoader.Init(AppDomain.CurrentDomain.BaseDirectory);
    }

    public static Task Start(IWebsite w, CancellationToken ct)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Controller.Class2 class2 = new Controller.Class2();
      Controller.cancellationToken_0 = ct;
      Ripper ripper = new Ripper(w);
      // ISSUE: reference to a compiler-generated field
      class2.itrPlugin_0 = PluginLoader.GetPlugin(w.PluginInName);
      // ISSUE: reference to a compiler-generated field
      if (class2.itrPlugin_0 == null)
        return (Task) null;
      // ISSUE: reference to a compiler-generated field
      class2.itrPlugin_0.NewInstance((IRipper) ripper, MySettings.Instance.LoadPluginSettingsFile(w.PluginSettingsFilePath));
      // ISSUE: reference to a compiler-generated field
      Controller.itrPlugin_0 = class2.itrPlugin_0;
      // ISSUE: reference to a compiler-generated method
      Controller.task_0 = Task.Factory.StartNew(new Action(class2.method_0), Controller.cancellationToken_0);
      return Controller.task_0;
    }
  }
}
