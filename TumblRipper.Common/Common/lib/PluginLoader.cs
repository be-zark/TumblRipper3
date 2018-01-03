using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace TumblRipper.Common.lib
{
	// Token: 0x02000066 RID: 102
	public class PluginLoader
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00006834 File Offset: 0x00004A34
		public static void Init(string path)
		{
			PluginLoader.idictionary_0 = new Dictionary<string, ITrPlugin>();
			if (Directory.Exists(path))
			{
				string[] files = Directory.GetFiles(path, "TumblRipper.Plugins.*.dll");
				new List<Assembly>(files.Length);
				string[] array = files;
				for (int i = 0; i < array.Length; i++)
				{
					foreach (Type type in Assembly.Load(AssemblyName.GetAssemblyName(array[i])).GetTypes())
					{
						if (type.IsClass && !type.IsNotPublic && ((IList)type.GetInterfaces()).Contains(typeof(ITrPlugin)))
						{
							ITrPlugin trPlugin = (ITrPlugin)Activator.CreateInstance(type);
							PluginLoader.idictionary_0.Add(trPlugin.GetName(), trPlugin);
						}
					}
				}
				return;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000068EC File Offset: 0x00004AEC
		public static ITrPlugin GetPlugin(string name)
		{
			return PluginLoader.idictionary_0[name];
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00006904 File Offset: 0x00004B04
		public static List<string> GetListPlugins()
		{
			return new List<string>(PluginLoader.idictionary_0.Keys);
		}

		// Token: 0x040000A1 RID: 161
		private static IDictionary<string, ITrPlugin> idictionary_0;
	}
}
