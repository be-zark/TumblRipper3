using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

// Token: 0x02000011 RID: 17
public sealed class GClass1
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600004E RID: 78 RVA: 0x00005E20 File Offset: 0x00004020
	public string String_0
	{
		get
		{
			return this.string_0;
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00005E34 File Offset: 0x00004034
	public GClass1()
	{
		this.string_0 = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Intertel"), "Errors");
		if (!Directory.Exists(this.string_0))
		{
			Directory.CreateDirectory(this.string_0);
		}
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00005E84 File Offset: 0x00004084
	public GClass1(string string_1)
	{
		this.string_0 = string_1;
		if (!Directory.Exists(this.string_0))
		{
			Directory.CreateDirectory(this.string_0);
		}
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00005EB8 File Offset: 0x000040B8
	public string method_0(Exception exception_0)
	{
		Assembly entryAssembly = Assembly.GetEntryAssembly();
		Process currentProcess = Process.GetCurrentProcess();
		string text = DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss") + ".txt";
		using (StreamWriter streamWriter = new StreamWriter(Path.Combine(this.string_0, text)))
		{
			streamWriter.WriteLine("==============================================================================");
			streamWriter.WriteLine(entryAssembly.FullName);
			streamWriter.WriteLine("------------------------------------------------------------------------------");
			streamWriter.WriteLine("MyApp Information");
			streamWriter.WriteLine("------------------------------------------------------------------------------");
			streamWriter.WriteLine("Program      : " + entryAssembly.Location);
			streamWriter.WriteLine("Version      : " + Assembly.GetEntryAssembly().GetName().Version);
			streamWriter.WriteLine("Time         : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
			streamWriter.WriteLine("User         : " + Environment.UserName);
			streamWriter.WriteLine("Computer     : " + Environment.MachineName);
			streamWriter.WriteLine("OS           : " + Environment.OSVersion.ToString());
			streamWriter.WriteLine("Culture      : " + CultureInfo.CurrentCulture.Name);
			streamWriter.WriteLine("Processors   : " + Environment.ProcessorCount);
			streamWriter.WriteLine("Working Set  : " + Environment.WorkingSet);
			streamWriter.WriteLine("Framework    : " + Environment.Version);
			streamWriter.WriteLine("Run Time     : " + (DateTime.Now - Process.GetCurrentProcess().StartTime).ToString());
			streamWriter.WriteLine("------------------------------------------------------------------------------");
			streamWriter.WriteLine("Exception Information");
			streamWriter.WriteLine("------------------------------------------------------------------------------");
			streamWriter.WriteLine("Source       : " + exception_0.Source.ToString().Trim());
			streamWriter.WriteLine("Method       : " + exception_0.TargetSite.Name.ToString());
			streamWriter.WriteLine("Type         : " + exception_0.GetType().ToString());
			streamWriter.WriteLine("Error        : " + this.method_1(exception_0));
			streamWriter.WriteLine("Stack Trace  : " + exception_0.StackTrace.ToString().Trim());
			streamWriter.WriteLine("------------------------------------------------------------------------------");
			streamWriter.WriteLine("Loaded Modules");
			streamWriter.WriteLine("------------------------------------------------------------------------------");
			foreach (object obj in currentProcess.Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				try
				{
					streamWriter.WriteLine(string.Concat(new object[]
					{
						processModule.FileName,
						" | ",
						processModule.FileVersionInfo.FileVersion,
						" | ",
						processModule.ModuleMemorySize
					}));
				}
				catch (FileNotFoundException)
				{
					streamWriter.WriteLine("File Not Found: " + processModule.ToString());
				}
				catch (Exception)
				{
				}
			}
			streamWriter.WriteLine("------------------------------------------------------------------------------");
			streamWriter.WriteLine(text);
			streamWriter.WriteLine("==============================================================================");
		}
		return Path.Combine(this.String_0, text);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x000062A4 File Offset: 0x000044A4
	private string method_1(Exception exception_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(exception_0.Message);
		if (exception_0.InnerException != null)
		{
			exception_0 = exception_0.InnerException;
			stringBuilder.Append(Environment.NewLine);
			stringBuilder.Append(exception_0.Message);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x04000033 RID: 51
	private string string_0;
}
