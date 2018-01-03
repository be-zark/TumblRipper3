// Decompiled with JetBrains decompiler
// Type: GClass1
// Assembly: TumblRipper.Windows, Version=3.2.4.0, Culture=neutral, PublicKeyToken=null
// MVID: 107F30DB-0738-4B3D-8EEE-8658D776066F
// Assembly location: C:\Users\xen\Downloads\TumblRipper3\TumblRipper.Windows.exe

using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

public sealed class GClass1
{
  public string String_0 { get; }

  public GClass1()
  {
    // ISSUE: reference to a compiler-generated field
    this.string_0 = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Intertel"), "Errors");
    if (Directory.Exists(this.String_0))
      return;
    Directory.CreateDirectory(this.String_0);
  }

  public GClass1(string string_1)
  {
    // ISSUE: reference to a compiler-generated field
    this.string_0 = string_1;
    if (Directory.Exists(this.String_0))
      return;
    Directory.CreateDirectory(this.String_0);
  }

  public string method_0(Exception exception_0)
  {
    Assembly entryAssembly = Assembly.GetEntryAssembly();
    Process currentProcess = Process.GetCurrentProcess();
    string path2 = DateTime.Now.ToString("yyyy-MM-dd_HH.mm.ss") + ".txt";
    using (StreamWriter streamWriter = new StreamWriter(Path.Combine(this.String_0, path2)))
    {
      streamWriter.WriteLine("==============================================================================");
      streamWriter.WriteLine(entryAssembly.FullName);
      streamWriter.WriteLine("------------------------------------------------------------------------------");
      streamWriter.WriteLine("MyApp Information");
      streamWriter.WriteLine("------------------------------------------------------------------------------");
      streamWriter.WriteLine("Program      : " + entryAssembly.Location);
      streamWriter.WriteLine("Version      : " + (object) Assembly.GetEntryAssembly().GetName().Version);
      streamWriter.WriteLine("Time         : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
      streamWriter.WriteLine("User         : " + Environment.UserName);
      streamWriter.WriteLine("Computer     : " + Environment.MachineName);
      streamWriter.WriteLine("OS           : " + (object) Environment.OSVersion);
      streamWriter.WriteLine("Culture      : " + CultureInfo.CurrentCulture.Name);
      streamWriter.WriteLine("Processors   : " + (object) Environment.ProcessorCount);
      streamWriter.WriteLine("Working Set  : " + (object) Environment.WorkingSet);
      streamWriter.WriteLine("Framework    : " + (object) Environment.Version);
      streamWriter.WriteLine("Run Time     : " + (object) (DateTime.Now - Process.GetCurrentProcess().StartTime));
      streamWriter.WriteLine("------------------------------------------------------------------------------");
      streamWriter.WriteLine("Exception Information");
      streamWriter.WriteLine("------------------------------------------------------------------------------");
      streamWriter.WriteLine("Source       : " + exception_0.Source.Trim());
      streamWriter.WriteLine("Method       : " + exception_0.TargetSite.Name);
      streamWriter.WriteLine("Type         : " + (object) exception_0.GetType());
      streamWriter.WriteLine("Error        : " + this.method_1(exception_0));
      streamWriter.WriteLine("Stack Trace  : " + exception_0.StackTrace.Trim());
      streamWriter.WriteLine("------------------------------------------------------------------------------");
      streamWriter.WriteLine("Loaded Modules");
      streamWriter.WriteLine("------------------------------------------------------------------------------");
      foreach (ProcessModule processModule in (ReadOnlyCollectionBase) currentProcess.Modules)
      {
        try
        {
          streamWriter.WriteLine(processModule.FileName + (object) " | " + processModule.FileVersionInfo.FileVersion + " | " + (string) (object) processModule.ModuleMemorySize);
        }
        catch (FileNotFoundException ex)
        {
          streamWriter.WriteLine("File Not Found: " + (object) processModule);
        }
        catch (Exception ex)
        {
        }
      }
      streamWriter.WriteLine("------------------------------------------------------------------------------");
      streamWriter.WriteLine(path2);
      streamWriter.WriteLine("==============================================================================");
    }
    return Path.Combine(this.String_0, path2);
  }

  private string method_1(Exception exception_0)
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(exception_0.Message);
    while (exception_0.InnerException != null)
    {
      exception_0 = exception_0.InnerException;
      stringBuilder.Append(Environment.NewLine);
      stringBuilder.Append(exception_0.Message);
    }
    return stringBuilder.ToString();
  }
}
