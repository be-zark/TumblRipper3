using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Windows.Markup;

// Token: 0x0200000D RID: 13
[EditorBrowsable(EditorBrowsableState.Never)]
[DebuggerNonUserCode]
[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
public sealed class GClass0 : InternalTypeHelper
{
	// Token: 0x0600003D RID: 61 RVA: 0x00005B6C File Offset: 0x00003D6C
	protected object CreateInstance(Type type, CultureInfo culture)
	{
		return Activator.CreateInstance(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, null, culture);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00005B88 File Offset: 0x00003D88
	protected object GetPropertyValue(PropertyInfo propertyInfo, object target, CultureInfo culture)
	{
		return propertyInfo.GetValue(target, BindingFlags.Default, null, null, culture);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00005BA0 File Offset: 0x00003DA0
	protected void SetPropertyValue(PropertyInfo propertyInfo, object target, object value, CultureInfo culture)
	{
		propertyInfo.SetValue(target, value, BindingFlags.Default, null, null, culture);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00005BBC File Offset: 0x00003DBC
	protected Delegate CreateDelegate(Type delegateType, object target, string handler)
	{
		return (Delegate)target.GetType().InvokeMember("_CreateDelegate", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, target, new object[]
		{
			delegateType,
			handler
		}, null);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00005BF4 File Offset: 0x00003DF4
	protected void AddEventHandler(EventInfo eventInfo, object target, Delegate handler)
	{
		eventInfo.AddEventHandler(target, handler);
	}
}
