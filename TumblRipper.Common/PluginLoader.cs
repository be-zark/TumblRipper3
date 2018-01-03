// Decompiled with JetBrains decompiler
// Type: TumblRipper.Common.PluginLoader
// Assembly: TumblRipper.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C21BADD-58D6-4711-989C-48D300E54E81
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Common.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using TumblRipper.PluginInterface;

namespace TumblRipper.Common
{
  public class PluginLoader
  {
    private static IDictionary<string, ITrPlugin> idictionary_0;

    public static void Init(string path)
    {
      PluginLoader.idictionary_0 = (IDictionary<string, ITrPlugin>) new Dictionary<string, ITrPlugin>();
      if (!Directory.Exists(path))
        return;
      string[] files = Directory.GetFiles(path, "TumblRipper.Plugins.*.dll");
      List<Assembly> list = new List<Assembly>(files.Length);
      foreach (string assemblyFile in files)
      {
        foreach (Type type in Assembly.Load(AssemblyName.GetAssemblyName(assemblyFile)).GetTypes())
        {
          if (type.IsClass && !type.IsNotPublic && type.GetInterfaces().Contains((object) typeof (ITrPlugin)))
          {
            ITrPlugin trPlugin = (ITrPlugin) Activator.CreateInstance(type);
            PluginLoader.idictionary_0.Add(trPlugin.GetName(), trPlugin);
          }
        }
      }
    }

    public static ITrPlugin GetPlugin(string name)
    {
      if (!PluginLoader.idictionary_0.ContainsKey(name))
        return (ITrPlugin) null;
      return PluginLoader.idictionary_0[name];
    }

    public static List<string> GetListPlugins()
    {
      return new List<string>((IEnumerable<string>) PluginLoader.idictionary_0.Keys);
    }
  }
}
