using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002890 File Offset: 0x00000A90
	static <Module>()
	{
		<Module>.smethod_30();
		<Module>.smethod_24();
		<Module>.smethod_0();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000028AC File Offset: 0x00000AAC
	private static void smethod_0()
	{
		string string_ = <Module>.smethod_25<string>(3273241572u);
		Type type_ = <Module>.smethod_2(typeof(Environment).TypeHandle);
		MethodInfo methodInfo = <Module>.smethod_4(type_, <Module>.smethod_27<string>(573880445u), new Type[]
		{
			<Module>.smethod_3(typeof(string).TypeHandle)
		});
		if (methodInfo != null && <Module>.smethod_7(<Module>.smethod_28<string>(74911629u), <Module>.smethod_6(methodInfo, null, new object[]
		{
			<Module>.smethod_5(string_, <Module>.smethod_26<string>(2661382570u))
		})))
		{
			<Module>.smethod_8(null);
		}
		Thread thread_ = <Module>.smethod_9(new ParameterizedThreadStart(<Module>.smethod_1));
		<Module>.smethod_10(thread_, true);
		<Module>.smethod_11(thread_, null);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002958 File Offset: 0x00000B58
	private static void smethod_1(object object_0)
	{
		Thread thread = object_0 as Thread;
		if (thread == null)
		{
			thread = <Module>.smethod_12(new ParameterizedThreadStart(<Module>.smethod_1));
			<Module>.smethod_13(thread, true);
			<Module>.smethod_15(thread, <Module>.smethod_14());
			<Module>.smethod_16(500);
		}
		for (;;)
		{
			if (<Module>.smethod_17() || <Module>.smethod_18())
			{
				<Module>.smethod_19(null);
			}
			if (!<Module>.smethod_20(thread))
			{
				<Module>.smethod_21(null);
			}
			<Module>.smethod_22(1000);
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000029D0 File Offset: 0x00000BD0
	static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000029D0 File Offset: 0x00000BD0
	static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000029E4 File Offset: 0x00000BE4
	static MethodInfo smethod_4(Type type_0, string string_0, Type[] type_1)
	{
		return type_0.GetMethod(string_0, type_1);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000029FC File Offset: 0x00000BFC
	static string smethod_5(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002A10 File Offset: 0x00000C10
	static object smethod_6(MethodBase methodBase_0, object object_0, object[] object_1)
	{
		return methodBase_0.Invoke(object_0, object_1);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002A28 File Offset: 0x00000C28
	static bool smethod_7(object object_0, object object_1)
	{
		return object_0.Equals(object_1);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002A3C File Offset: 0x00000C3C
	static void smethod_8(string string_0)
	{
		Environment.FailFast(string_0);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002A50 File Offset: 0x00000C50
	static Thread smethod_9(ParameterizedThreadStart parameterizedThreadStart_0)
	{
		return new Thread(parameterizedThreadStart_0);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002A64 File Offset: 0x00000C64
	static void smethod_10(Thread thread_0, bool bool_0)
	{
		thread_0.IsBackground = bool_0;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002A78 File Offset: 0x00000C78
	static void smethod_11(Thread thread_0, object object_0)
	{
		thread_0.Start(object_0);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002A50 File Offset: 0x00000C50
	static Thread smethod_12(ParameterizedThreadStart parameterizedThreadStart_0)
	{
		return new Thread(parameterizedThreadStart_0);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002A64 File Offset: 0x00000C64
	static void smethod_13(Thread thread_0, bool bool_0)
	{
		thread_0.IsBackground = bool_0;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002A8C File Offset: 0x00000C8C
	static Thread smethod_14()
	{
		return Thread.CurrentThread;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002A78 File Offset: 0x00000C78
	static void smethod_15(Thread thread_0, object object_0)
	{
		thread_0.Start(object_0);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002AA0 File Offset: 0x00000CA0
	static void smethod_16(int int_0)
	{
		Thread.Sleep(int_0);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002AB4 File Offset: 0x00000CB4
	static bool smethod_17()
	{
		return Debugger.IsAttached;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002AC8 File Offset: 0x00000CC8
	static bool smethod_18()
	{
		return Debugger.IsLogging();
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002A3C File Offset: 0x00000C3C
	static void smethod_19(string string_0)
	{
		Environment.FailFast(string_0);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002ADC File Offset: 0x00000CDC
	static bool smethod_20(Thread thread_0)
	{
		return thread_0.IsAlive;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002A3C File Offset: 0x00000C3C
	static void smethod_21(string string_0)
	{
		Environment.FailFast(string_0);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002AA0 File Offset: 0x00000CA0
	static void smethod_22(int int_0)
	{
		Thread.Sleep(int_0);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002AF0 File Offset: 0x00000CF0
	internal static byte[] smethod_23(byte[] byte_1)
	{
		MemoryStream memoryStream = new MemoryStream(byte_1);
		<Module>.Class1 @class = new <Module>.Class1();
		byte[] buffer = new byte[5];
		memoryStream.Read(buffer, 0, 5);
		@class.method_5(buffer);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] array = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(array, true);
		long long_ = memoryStream.Length - 13L;
		@class.method_4(memoryStream, stream_, long_, num);
		return array;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002B88 File Offset: 0x00000D88
	internal static void smethod_24()
	{
		uint num = 224u;
		uint[] array = new uint[]
		{
			1033386404u,
			1234590835u,
			3549919575u,
			328941618u,
			1629018553u,
			2201383295u,
			4270137849u,
			2557516803u,
			2829119565u,
			1445148170u,
			1938027401u,
			3435153569u,
			4029311916u,
			3337412453u,
			3394803104u,
			204253352u,
			20829506u,
			3254169967u,
			1251131478u,
			1139309917u,
			2201592587u,
			3056054394u,
			965317119u,
			3983571872u,
			533999425u,
			3900600127u,
			755476254u,
			1914607062u,
			4278652836u,
			3342563136u,
			2320566525u,
			2529655085u,
			962625847u,
			3947374695u,
			3507890396u,
			3471025198u,
			597901831u,
			3235863842u,
			1981534253u,
			3461842030u,
			1733042423u,
			2007576456u,
			1542637421u,
			1649962617u,
			2546616462u,
			1012756906u,
			2678885482u,
			1788389043u,
			1989274565u,
			1518833143u,
			3111500172u,
			3347138824u,
			3945625653u,
			3546555441u,
			4177951013u,
			1186287159u,
			3055069969u,
			1152121239u,
			3097216872u,
			1897658239u,
			781877488u,
			1175215494u,
			1752042157u,
			3971889514u,
			3376472487u,
			2955014894u,
			3535680613u,
			3376127245u,
			34118760u,
			2427159206u,
			2398273795u,
			1154113522u,
			3912267867u,
			656680782u,
			393050750u,
			2579367071u,
			2669115094u,
			535980210u,
			3988233678u,
			334727360u,
			1933567607u,
			3548404839u,
			2073115718u,
			731391858u,
			1318178197u,
			1938018171u,
			2939369094u,
			3246297669u,
			135194186u,
			4235795754u,
			1003813114u,
			160022933u,
			3218407141u,
			2531104320u,
			503795225u,
			538520714u,
			968948493u,
			3348452989u,
			2772917346u,
			2175001803u,
			949502276u,
			774311350u,
			1321396004u,
			2614760752u,
			2737096603u,
			2164783987u,
			2408266935u,
			2562939282u,
			1706057167u,
			3110327576u,
			1124454602u,
			884595840u,
			158760407u,
			697409966u,
			988888386u,
			2967793131u,
			535623315u,
			1913989028u,
			3846368611u,
			3396170559u,
			2462853412u,
			3303615673u,
			3261500466u,
			3902917872u,
			3487639720u,
			3124905678u,
			2495957002u,
			843008430u,
			1334409936u,
			4107069041u,
			4092563353u,
			3657063737u,
			4056790545u,
			2574405345u,
			3853095012u,
			642850267u,
			819537372u,
			704523946u,
			3609590453u,
			3805990350u,
			182220715u,
			757160186u,
			898541611u,
			210939427u,
			2583384698u,
			449032199u,
			963831274u,
			2904227776u,
			1026888776u,
			2652000918u,
			2039003736u,
			3966490394u,
			3201685135u,
			4152834494u,
			2682865006u,
			3219522407u,
			1787736093u,
			3017349918u,
			2970164189u,
			1691300155u,
			3726617035u,
			120275179u,
			330220431u,
			1426851411u,
			1615639160u,
			1757793267u,
			3062873413u,
			734200021u,
			3018998946u,
			297546723u,
			1840240483u,
			2983917315u,
			957341467u,
			1909944221u,
			2097133924u,
			2320427970u,
			4148696276u,
			2256158826u,
			2484674575u,
			721334106u,
			1708804538u,
			1222401721u,
			2428517150u,
			846882402u,
			2475501994u,
			2950918769u,
			2797084131u,
			2391382877u,
			1694212891u,
			2744614252u,
			3989511101u,
			3590973864u,
			1253187698u,
			3220700734u,
			3425596581u,
			761559931u,
			3590609889u,
			3874623045u,
			900506382u,
			3196739250u,
			1361294994u,
			1830572842u,
			1269008205u,
			299317354u,
			1374268425u,
			4242548688u,
			3735734775u,
			2283209135u,
			283192884u,
			3220700714u,
			3425596581u,
			761559931u,
			3590609889u,
			3874623045u,
			900506382u,
			3196739250u,
			1361294994u,
			1830572842u,
			1269008205u,
			299317354u,
			1374268425u,
			4242548688u,
			3735734775u,
			2283209135u
		};
		uint[] array2 = new uint[16];
		uint num2 = 1637752844u;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 12;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4u];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = (array3[0] ^ array2[0]);
			array3[1] = (array3[1] ^ array2[1]);
			array3[2] = (array3[2] ^ array2[2]);
			array3[3] = (array3[3] ^ array2[3]);
			array3[4] = (array3[4] ^ array2[4]);
			array3[5] = (array3[5] ^ array2[5]);
			array3[6] = (array3[6] ^ array2[6]);
			array3[7] = (array3[7] ^ array2[7]);
			array3[8] = (array3[8] ^ array2[8]);
			array3[9] = (array3[9] ^ array2[9]);
			array3[10] = (array3[10] ^ array2[10]);
			array3[11] = (array3[11] ^ array2[11]);
			array3[12] = (array3[12] ^ array2[12]);
			array3[13] = (array3[13] ^ array2[13]);
			array3[14] = (array3[14] ^ array2[14]);
			array3[15] = (array3[15] ^ array2[15]);
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		<Module>.byte_0 = <Module>.smethod_23(array4);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002D84 File Offset: 0x00000F84
	internal static T smethod_25<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 3457276043u ^ 2296450252u);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 2UL)
		{
			int count = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num != 0UL)
		{
			if ((ulong)num == 1UL)
			{
				int num2 = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
				int length = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
				Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, num2 - 4);
				result = (T)((object)array);
			}
		}
		else
		{
			T[] array2 = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, sizeof(T));
			result = array2[0];
		}
		return result;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002F24 File Offset: 0x00001124
	internal static T smethod_26<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 392485295u ^ 1558922557u);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num != 1UL)
		{
			if ((ulong)num == 0UL)
			{
				T[] array = new T[1];
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
				result = array[0];
			}
			else if ((ulong)num == 2UL)
			{
				int num2 = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
				int length = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
				Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
				result = (T)((object)array2);
			}
		}
		else
		{
			int count = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		return result;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000030C4 File Offset: 0x000012C4
	internal static T smethod_27<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 201401019u ^ 2441108813u);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num != 1UL)
		{
			if ((ulong)num == 2UL)
			{
				int num2 = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
				int length = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
				Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, num2 - 4);
				result = (T)((object)array);
			}
		}
		else
		{
			T[] array2 = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, sizeof(T));
			result = array2[0];
		}
		return result;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00003264 File Offset: 0x00001464
	internal static T smethod_28<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 1483590485u ^ 2078669016u);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num != 2UL)
		{
			if ((ulong)num == 3UL)
			{
				T[] array = new T[1];
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
				result = array[0];
			}
			else if ((ulong)num == 1UL)
			{
				int num2 = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
				int length = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
				Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
				result = (T)((object)array2);
			}
		}
		else
		{
			int count = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		return result;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003404 File Offset: 0x00001604
	internal static T smethod_29<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 3091739879u ^ 3554285453u);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num == 2UL)
		{
			T[] array = new T[1];
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
			result = array[0];
		}
		else if ((ulong)num == 1UL)
		{
			int num2 = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
			int length = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
			Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
			Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
			result = (T)((object)array2);
		}
		return result;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000035A4 File Offset: 0x000017A4
	internal static void smethod_30()
	{
		uint num = 304u;
		uint[] array = new uint[]
		{
			3558746694u,
			2148698874u,
			3155724809u,
			2956683977u,
			1964780192u,
			1092265508u,
			1021800150u,
			3076126194u,
			1810562157u,
			2568900326u,
			1490344433u,
			2497965586u,
			1201616455u,
			1751462693u,
			3304369747u,
			3124430062u,
			2480661815u,
			2734244561u,
			1180267596u,
			3266589562u,
			446440356u,
			2219100702u,
			2486922114u,
			3948143829u,
			3535500274u,
			3102616410u,
			2752645356u,
			2687151411u,
			2272793241u,
			3101241754u,
			730094161u,
			961242624u,
			3211758368u,
			472304786u,
			3601867722u,
			4017580682u,
			1351547233u,
			487809425u,
			1208654130u,
			4238964215u,
			4042784445u,
			2171369693u,
			2730483477u,
			2007262704u,
			3917235486u,
			2962532721u,
			2512169307u,
			2883180469u,
			11914141u,
			2330103913u,
			4289350404u,
			863346008u,
			2479767598u,
			3496716019u,
			238143078u,
			1842043876u,
			3505468130u,
			1028827770u,
			837000294u,
			125357597u,
			718896544u,
			1058517842u,
			1872343538u,
			4045805834u,
			1494875248u,
			1978478089u,
			357726132u,
			1273105094u,
			3468195681u,
			2764366912u,
			3510508189u,
			2792675852u,
			2393382824u,
			3077728682u,
			1182241241u,
			13916643u,
			3465879469u,
			1807764909u,
			1468619909u,
			2766448122u,
			1106769373u,
			117450700u,
			3115462720u,
			537844044u,
			628776997u,
			892675896u,
			1581251282u,
			3042615602u,
			2971933542u,
			3246537779u,
			247804374u,
			3978376476u,
			1387762499u,
			3797042708u,
			983886048u,
			2102054084u,
			1277796219u,
			1560253287u,
			906677737u,
			2724147370u,
			857288953u,
			3294970924u,
			894026058u,
			4141280276u,
			2726121163u,
			3853651453u,
			2639400026u,
			389336040u,
			3534354211u,
			3866839700u,
			830235823u,
			2724716077u,
			1303108053u,
			3308361158u,
			3817368884u,
			1459070508u,
			1608664220u,
			4072033301u,
			157760660u,
			3157665929u,
			2539808328u,
			1355225140u,
			861856076u,
			3071851342u,
			3240028746u,
			44051980u,
			1147710269u,
			1450427644u,
			4097129454u,
			237258377u,
			3304440119u,
			3472332390u,
			4158341435u,
			1801807747u,
			1312924525u,
			3371217807u,
			3065358635u,
			3317300363u,
			1527017982u,
			4133846776u,
			3735908428u,
			2185330875u,
			1028377144u,
			3932852264u,
			2850315140u,
			2886411989u,
			1101504822u,
			1409534373u,
			2912773746u,
			810211831u,
			3243584809u,
			4175665410u,
			1176513414u,
			609206106u,
			3809325578u,
			2858086779u,
			3888283787u,
			2375816982u,
			1855666228u,
			762038804u,
			526515699u,
			536024230u,
			4055653061u,
			1981682948u,
			1124493214u,
			680358272u,
			1473114580u,
			3192355850u,
			784379721u,
			2593082790u,
			140906140u,
			3528965719u,
			265028983u,
			516168374u,
			937091436u,
			2043547919u,
			3788035652u,
			2813997672u,
			1535699004u,
			351763386u,
			3492383670u,
			1988871266u,
			403010121u,
			3616586559u,
			209861601u,
			509310587u,
			1101515006u,
			3402641026u,
			888638305u,
			4107646572u,
			568715277u,
			309319048u,
			3878876638u,
			1723257026u,
			2971430447u,
			2233790484u,
			2501858162u,
			2773794480u,
			3007815529u,
			3241046197u,
			3644422424u,
			3895174259u,
			2618263616u,
			3525943603u,
			3498361578u,
			2313292503u,
			795283338u,
			867204063u,
			831281838u,
			25106478u,
			3235737237u,
			97732548u,
			294503264u,
			898738049u,
			683746665u,
			3761866581u,
			671283339u,
			1718894750u,
			333777900u,
			3023253172u,
			3895588586u,
			2994245620u,
			992986385u,
			2670105533u,
			2485177932u,
			1924345907u,
			3421277442u,
			996129568u,
			4062576022u,
			3912694331u,
			2415401473u,
			4287228035u,
			2216975004u,
			1451943648u,
			3503531022u,
			1912370366u,
			2062512701u,
			997436696u,
			3199030500u,
			197195221u,
			3883838816u,
			1203323561u,
			195788553u,
			40838985u,
			3468668943u,
			2710243153u,
			2567412867u,
			1667647056u,
			1599237189u,
			2281283124u,
			3500645146u,
			3179411522u,
			3049936344u,
			583884108u,
			554017476u,
			2565292764u,
			1852097698u,
			2707671264u,
			3273588002u,
			2197640853u,
			1247243736u,
			3438824742u,
			4212327060u,
			3102609579u,
			1392766517u,
			3413251629u,
			2402347878u,
			4001246263u,
			3037241691u,
			3837900754u,
			2667388034u,
			4170581572u,
			2284439047u,
			3011978174u,
			2055051272u,
			2233224654u,
			4070531060u,
			1625598951u,
			1330182319u,
			2666180147u,
			3823440156u,
			2329464223u,
			3379502683u,
			11736791u,
			2902416464u,
			2248378380u,
			4088072745u,
			693791595u,
			1965901390u,
			1223172866u,
			3802640180u,
			688700534u,
			1716531148u,
			1731934920u,
			2317099254u,
			76051011u,
			2258098172u,
			399147968u,
			3373277751u,
			11736791u,
			2902416464u,
			2248378380u,
			4088072745u,
			693791595u
		};
		uint[] array2 = new uint[16];
		uint num2 = 1981651709u;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 13;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4u];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = (array3[0] ^ array2[0]);
			array3[1] = (array3[1] ^ array2[1]);
			array3[2] = (array3[2] ^ array2[2]);
			array3[3] = (array3[3] ^ array2[3]);
			array3[4] = (array3[4] ^ array2[4]);
			array3[5] = (array3[5] ^ array2[5]);
			array3[6] = (array3[6] ^ array2[6]);
			array3[7] = (array3[7] ^ array2[7]);
			array3[8] = (array3[8] ^ array2[8]);
			array3[9] = (array3[9] ^ array2[9]);
			array3[10] = (array3[10] ^ array2[10]);
			array3[11] = (array3[11] ^ array2[11]);
			array3[12] = (array3[12] ^ array2[12]);
			array3[13] = (array3[13] ^ array2[13]);
			array3[14] = (array3[14] ^ array2[14]);
			array3[15] = (array3[15] ^ array2[15]);
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		<Module>.assembly_0 = Assembly.Load(<Module>.smethod_23(array4));
		AppDomain.CurrentDomain.AssemblyResolve += <Module>.smethod_31;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000037BC File Offset: 0x000019BC
	internal static Assembly smethod_31(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (<Module>.assembly_0.FullName == resolveEventArgs_0.Name)
		{
			return <Module>.assembly_0;
		}
		return null;
	}

	// Token: 0x04000001 RID: 1
	internal static byte[] byte_0;

	// Token: 0x04000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	internal static <Module>.Struct4 struct4_0;

	// Token: 0x04000003 RID: 3
	internal static Assembly assembly_0;

	// Token: 0x04000004 RID: 4 RVA: 0x000023D0 File Offset: 0x000005D0
	internal static <Module>.Struct5 struct5_0;

	// Token: 0x02000002 RID: 2
	internal struct Struct0
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000037E8 File Offset: 0x000019E8
		internal void method_0()
		{
			this.uint_0 = 1024u;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003800 File Offset: 0x00001A00
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = (class0_0.uint_1 >> 11) * this.uint_0;
			if (class0_0.uint_0 < num)
			{
				class0_0.uint_1 = num;
				this.uint_0 += 2048u - this.uint_0 >> 5;
				if (class0_0.uint_1 < 16777216u)
				{
					class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
					class0_0.uint_1 <<= 8;
				}
				return 0u;
			}
			class0_0.uint_1 -= num;
			class0_0.uint_0 -= num;
			this.uint_0 -= this.uint_0 >> 5;
			if (class0_0.uint_1 < 16777216u)
			{
				class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
				class0_0.uint_1 <<= 8;
			}
			return 1u;
		}

		// Token: 0x04000005 RID: 5
		internal uint uint_0;
	}

	// Token: 0x02000003 RID: 3
	internal struct Struct1
	{
		// Token: 0x06000024 RID: 36 RVA: 0x000038EC File Offset: 0x00001AEC
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003914 File Offset: 0x00001B14
		internal void method_0()
		{
			uint num = 1u;
			while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
			{
				this.struct0_0[(int)((UIntPtr)num)].method_0();
				num += 1u;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000394C File Offset: 0x00001B4C
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = 1u;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
			}
			return num - (1u << this.int_0);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003994 File Offset: 0x00001B94
		internal uint method_2(<Module>.Class0 class0_0)
		{
			uint num = 1u;
			uint num2 = 0u;
			for (int i = 0; i < this.int_0; i++)
			{
				uint num3 = this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000039DC File Offset: 0x00001BDC
		internal static uint smethod_0(<Module>.Struct0[] struct0_1, uint uint_0, <Module>.Class0 class0_0, int int_1)
		{
			uint num = 1u;
			uint num2 = 0u;
			for (int i = 0; i < int_1; i++)
			{
				uint num3 = struct0_1[(int)((UIntPtr)(uint_0 + num))].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x04000006 RID: 6
		internal readonly <Module>.Struct0[] struct0_0;

		// Token: 0x04000007 RID: 7
		internal readonly int int_0;
	}

	// Token: 0x02000004 RID: 4
	internal class Class0
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00003A1C File Offset: 0x00001C1C
		internal void method_0(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.uint_0 = 0u;
			this.uint_1 = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003A68 File Offset: 0x00001C68
		internal void method_1()
		{
			this.stream_0 = null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003A7C File Offset: 0x00001C7C
		internal void method_2()
		{
			while (this.uint_1 < 16777216u)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003AC4 File Offset: 0x00001CC4
		internal uint method_3(int int_0)
		{
			uint num = this.uint_1;
			uint num2 = this.uint_0;
			uint num3 = 0u;
			for (int i = int_0; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= (num & num4 - 1u);
				num3 = (num3 << 1 | 1u - num4);
				if (num < 16777216u)
				{
					num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
					num <<= 8;
				}
			}
			this.uint_1 = num;
			this.uint_0 = num2;
			return num3;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003B38 File Offset: 0x00001D38
		internal Class0()
		{
		}

		// Token: 0x04000008 RID: 8
		internal uint uint_0;

		// Token: 0x04000009 RID: 9
		internal uint uint_1;

		// Token: 0x0400000A RID: 10
		internal Stream stream_0;
	}

	// Token: 0x02000005 RID: 5
	internal class Class1
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00003B4C File Offset: 0x00001D4C
		internal Class1()
		{
			this.uint_0 = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.struct1_0[num] = new <Module>.Struct1(6);
				num++;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003C4C File Offset: 0x00001E4C
		internal void method_0(uint uint_3)
		{
			if (this.uint_0 != uint_3)
			{
				this.uint_0 = uint_3;
				this.uint_1 = Math.Max(this.uint_0, 1u);
				uint uint_4 = Math.Max(this.uint_1, 4096u);
				this.class4_0.method_0(uint_4);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003C98 File Offset: 0x00001E98
		internal void method_1(int int_0, int int_1)
		{
			this.class3_0.method_0(int_0, int_1);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003CB4 File Offset: 0x00001EB4
		internal void method_2(int int_0)
		{
			uint num = 1u << int_0;
			this.class2_0.method_0(num);
			this.class2_1.method_0(num);
			this.uint_2 = num - 1u;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003CEC File Offset: 0x00001EEC
		internal void method_3(Stream stream_0, Stream stream_1)
		{
			this.class0_0.method_0(stream_0);
			this.class4_0.method_1(stream_1, this.bool_0);
			for (uint num = 0u; num < 12u; num += 1u)
			{
				for (uint num2 = 0u; num2 <= this.uint_2; num2 += 1u)
				{
					uint num3 = (num << 4) + num2;
					this.struct0_0[(int)((UIntPtr)num3)].method_0();
					this.struct0_1[(int)((UIntPtr)num3)].method_0();
				}
				this.struct0_2[(int)((UIntPtr)num)].method_0();
				this.struct0_3[(int)((UIntPtr)num)].method_0();
				this.struct0_4[(int)((UIntPtr)num)].method_0();
				this.struct0_5[(int)((UIntPtr)num)].method_0();
			}
			this.class3_0.method_1();
			for (uint num = 0u; num < 4u; num += 1u)
			{
				this.struct1_0[(int)((UIntPtr)num)].method_0();
			}
			for (uint num = 0u; num < 114u; num += 1u)
			{
				this.struct0_6[(int)((UIntPtr)num)].method_0();
			}
			this.class2_0.method_1();
			this.class2_1.method_1();
			this.struct1_1.method_0();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003E18 File Offset: 0x00002018
		internal void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			this.method_3(stream_0, stream_1);
			<Module>.Struct3 @struct = default(<Module>.Struct3);
			@struct.method_0();
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			ulong num5 = 0UL;
			if (0L < long_1)
			{
				this.struct0_0[(int)((UIntPtr)(@struct.uint_0 << 4))].method_1(this.class0_0);
				@struct.method_1();
				byte byte_ = this.class3_0.method_3(this.class0_0, 0u, 0);
				this.class4_0.method_5(byte_);
				num5 += 1UL;
			}
			while (num5 < (ulong)long_1)
			{
				uint num6 = (uint)num5 & this.uint_2;
				if (this.struct0_0[(int)((UIntPtr)((@struct.uint_0 << 4) + num6))].method_1(this.class0_0) == 0u)
				{
					byte byte_2 = this.class4_0.method_6(0u);
					byte byte_3;
					if (@struct.method_5())
					{
						byte_3 = this.class3_0.method_3(this.class0_0, (uint)num5, byte_2);
					}
					else
					{
						byte_3 = this.class3_0.method_4(this.class0_0, (uint)num5, byte_2, this.class4_0.method_6(num));
					}
					this.class4_0.method_5(byte_3);
					@struct.method_1();
					num5 += 1UL;
				}
				else
				{
					uint num8;
					if (this.struct0_2[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) == 1u)
					{
						if (this.struct0_3[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) == 0u)
						{
							if (this.struct0_1[(int)((UIntPtr)((@struct.uint_0 << 4) + num6))].method_1(this.class0_0) == 0u)
							{
								@struct.method_4();
								this.class4_0.method_5(this.class4_0.method_6(num));
								num5 += 1UL;
								continue;
							}
						}
						else
						{
							uint num7;
							if (this.struct0_4[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) == 0u)
							{
								num7 = num2;
							}
							else
							{
								if (this.struct0_5[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) != 0u)
								{
									num7 = num4;
									num4 = num3;
								}
								else
								{
									num7 = num3;
								}
								num3 = num2;
							}
							num2 = num;
							num = num7;
						}
						num8 = this.class2_1.method_2(this.class0_0, num6) + 2u;
						@struct.method_3();
					}
					else
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num8 = 2u + this.class2_0.method_2(this.class0_0, num6);
						@struct.method_2();
						uint num9 = this.struct1_0[(int)((UIntPtr)<Module>.Class1.smethod_0(num8))].method_1(this.class0_0);
						if (num9 < 4u)
						{
							num = num9;
						}
						else
						{
							int num10 = (int)((num9 >> 1) - 1u);
							num = (2u | (num9 & 1u)) << num10;
							if (num9 < 14u)
							{
								num += <Module>.Struct1.smethod_0(this.struct0_6, num - num9 - 1u, this.class0_0, num10);
							}
							else
							{
								num += this.class0_0.method_3(num10 - 4) << 4;
								num += this.struct1_1.method_2(this.class0_0);
							}
						}
					}
					if (((ulong)num >= num5 || num >= this.uint_1) && num == 4294967295u)
					{
						break;
					}
					this.class4_0.method_4(num, num8);
					num5 += (ulong)num8;
				}
			}
			this.class4_0.method_3();
			this.class4_0.method_2();
			this.class0_0.method_1();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000418C File Offset: 0x0000238C
		internal void method_5(byte[] byte_0)
		{
			int int_ = (int)(byte_0[0] % 9);
			int num = (int)(byte_0[0] / 9);
			int int_2 = num % 5;
			int int_3 = num / 5;
			uint num2 = 0u;
			for (int i = 0; i < 4; i++)
			{
				num2 += (uint)((uint)byte_0[1 + i] << i * 8);
			}
			this.method_0(num2);
			this.method_1(int_2, int_);
			this.method_2(int_3);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000041EC File Offset: 0x000023EC
		internal static uint smethod_0(uint uint_3)
		{
			uint_3 -= 2u;
			if (uint_3 < 4u)
			{
				return uint_3;
			}
			return 3u;
		}

		// Token: 0x0400000B RID: 11
		internal readonly <Module>.Struct0[] struct0_0 = new <Module>.Struct0[192];

		// Token: 0x0400000C RID: 12
		internal readonly <Module>.Struct0[] struct0_1 = new <Module>.Struct0[192];

		// Token: 0x0400000D RID: 13
		internal readonly <Module>.Struct0[] struct0_2 = new <Module>.Struct0[12];

		// Token: 0x0400000E RID: 14
		internal readonly <Module>.Struct0[] struct0_3 = new <Module>.Struct0[12];

		// Token: 0x0400000F RID: 15
		internal readonly <Module>.Struct0[] struct0_4 = new <Module>.Struct0[12];

		// Token: 0x04000010 RID: 16
		internal readonly <Module>.Struct0[] struct0_5 = new <Module>.Struct0[12];

		// Token: 0x04000011 RID: 17
		internal readonly <Module>.Class1.Class2 class2_0 = new <Module>.Class1.Class2();

		// Token: 0x04000012 RID: 18
		internal readonly <Module>.Class1.Class3 class3_0 = new <Module>.Class1.Class3();

		// Token: 0x04000013 RID: 19
		internal readonly <Module>.Class4 class4_0 = new <Module>.Class4();

		// Token: 0x04000014 RID: 20
		internal readonly <Module>.Struct0[] struct0_6 = new <Module>.Struct0[114];

		// Token: 0x04000015 RID: 21
		internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[4];

		// Token: 0x04000016 RID: 22
		internal readonly <Module>.Class0 class0_0 = new <Module>.Class0();

		// Token: 0x04000017 RID: 23
		internal readonly <Module>.Class1.Class2 class2_1 = new <Module>.Class1.Class2();

		// Token: 0x04000018 RID: 24
		internal bool bool_0;

		// Token: 0x04000019 RID: 25
		internal uint uint_0;

		// Token: 0x0400001A RID: 26
		internal uint uint_1;

		// Token: 0x0400001B RID: 27
		internal <Module>.Struct1 struct1_1 = new <Module>.Struct1(4);

		// Token: 0x0400001C RID: 28
		internal uint uint_2;

		// Token: 0x02000006 RID: 6
		internal class Class2
		{
			// Token: 0x06000036 RID: 54 RVA: 0x00004208 File Offset: 0x00002408
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1u)
				{
					this.struct1_0[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
					this.struct1_1[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x06000037 RID: 55 RVA: 0x00004260 File Offset: 0x00002460
			internal void method_1()
			{
				this.struct0_0.method_0();
				for (uint num = 0u; num < this.uint_0; num += 1u)
				{
					this.struct1_0[(int)((UIntPtr)num)].method_0();
					this.struct1_1[(int)((UIntPtr)num)].method_0();
				}
				this.struct0_1.method_0();
				this.struct1_2.method_0();
			}

			// Token: 0x06000038 RID: 56 RVA: 0x000042C4 File Offset: 0x000024C4
			internal uint method_2(<Module>.Class0 class0_0, uint uint_1)
			{
				if (this.struct0_0.method_1(class0_0) == 0u)
				{
					return this.struct1_0[(int)((UIntPtr)uint_1)].method_1(class0_0);
				}
				uint num = 8u;
				if (this.struct0_1.method_1(class0_0) == 0u)
				{
					num += this.struct1_1[(int)((UIntPtr)uint_1)].method_1(class0_0);
				}
				else
				{
					num += 8u;
					num += this.struct1_2.method_1(class0_0);
				}
				return num;
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00004330 File Offset: 0x00002530
			internal Class2()
			{
			}

			// Token: 0x0400001D RID: 29
			internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[16];

			// Token: 0x0400001E RID: 30
			internal readonly <Module>.Struct1[] struct1_1 = new <Module>.Struct1[16];

			// Token: 0x0400001F RID: 31
			internal <Module>.Struct0 struct0_0 = default(<Module>.Struct0);

			// Token: 0x04000020 RID: 32
			internal <Module>.Struct0 struct0_1 = default(<Module>.Struct0);

			// Token: 0x04000021 RID: 33
			internal <Module>.Struct1 struct1_2 = new <Module>.Struct1(8);

			// Token: 0x04000022 RID: 34
			internal uint uint_0;
		}

		// Token: 0x02000007 RID: 7
		internal class Class3
		{
			// Token: 0x0600003A RID: 58 RVA: 0x00004384 File Offset: 0x00002584
			internal void method_0(int int_2, int int_3)
			{
				if (this.struct2_0 != null)
				{
					if (this.int_1 == int_3)
					{
						if (this.int_0 == int_2)
						{
							return;
						}
					}
				}
				this.int_0 = int_2;
				this.uint_0 = (1u << int_2) - 1u;
				this.int_1 = int_3;
				uint num = 1u << this.int_1 + this.int_0;
				this.struct2_0 = new <Module>.Class1.Class3.Struct2[num];
				for (uint num2 = 0u; num2 < num; num2 += 1u)
				{
					this.struct2_0[(int)((UIntPtr)num2)].method_0();
				}
			}

			// Token: 0x0600003B RID: 59 RVA: 0x00004408 File Offset: 0x00002608
			internal void method_1()
			{
				uint num = 1u << this.int_1 + this.int_0;
				uint num2 = 0u;
				if (0u < num)
				{
					this.struct2_0[(int)((UIntPtr)num2)].method_1();
					num2 += 1u;
				}
			}

			// Token: 0x0600003C RID: 60 RVA: 0x00004444 File Offset: 0x00002644
			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00004474 File Offset: 0x00002674
			internal byte method_3(<Module>.Class0 class0_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_2(class0_0);
			}

			// Token: 0x0600003E RID: 62 RVA: 0x0000449C File Offset: 0x0000269C
			internal byte method_4(<Module>.Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_3(class0_0, byte_1);
			}

			// Token: 0x0600003F RID: 63 RVA: 0x00003B38 File Offset: 0x00001D38
			internal Class3()
			{
			}

			// Token: 0x04000023 RID: 35
			internal <Module>.Class1.Class3.Struct2[] struct2_0;

			// Token: 0x04000024 RID: 36
			internal int int_0;

			// Token: 0x04000025 RID: 37
			internal int int_1;

			// Token: 0x04000026 RID: 38
			internal uint uint_0;

			// Token: 0x02000008 RID: 8
			internal struct Struct2
			{
				// Token: 0x06000040 RID: 64 RVA: 0x000044C8 File Offset: 0x000026C8
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x06000041 RID: 65 RVA: 0x000044E8 File Offset: 0x000026E8
				internal void method_1()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_0();
					}
				}

				// Token: 0x06000042 RID: 66 RVA: 0x00004518 File Offset: 0x00002718
				internal byte method_2(<Module>.Class0 class0_0)
				{
					uint num = 1u;
					do
					{
						num = (num << 1 | this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0));
					}
					while (num < 256u);
					return (byte)num;
				}

				// Token: 0x06000043 RID: 67 RVA: 0x0000454C File Offset: 0x0000274C
				internal byte method_3(<Module>.Class0 class0_0, byte byte_0)
				{
					uint num = 1u;
					for (;;)
					{
						uint num2 = (uint)(byte_0 >> 7 & 1);
						byte_0 = (byte)(byte_0 << 1);
						uint num3 = this.struct0_0[(int)((UIntPtr)((1u + num2 << 8) + num))].method_1(class0_0);
						num = (num << 1 | num3);
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256u)
						{
							goto IL_5E;
						}
					}
					while (num < 256u)
					{
						num = (num << 1 | this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0));
					}
					IL_5E:
					return (byte)num;
				}

				// Token: 0x04000027 RID: 39
				internal <Module>.Struct0[] struct0_0;
			}
		}
	}

	// Token: 0x02000009 RID: 9
	internal class Class4
	{
		// Token: 0x06000044 RID: 68 RVA: 0x000045BC File Offset: 0x000027BC
		internal void method_0(uint uint_3)
		{
			if (this.uint_2 != uint_3)
			{
				this.byte_0 = new byte[uint_3];
			}
			this.uint_2 = uint_3;
			this.uint_0 = 0u;
			this.uint_1 = 0u;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000045F4 File Offset: 0x000027F4
		internal void method_1(Stream stream_1, bool bool_0)
		{
			this.method_2();
			this.stream_0 = stream_1;
			if (!bool_0)
			{
				this.uint_1 = 0u;
				this.uint_0 = 0u;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004620 File Offset: 0x00002820
		internal void method_2()
		{
			this.method_3();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000465C File Offset: 0x0000285C
		internal void method_3()
		{
			uint num = this.uint_0 - this.uint_1;
			if (num != 0u)
			{
				this.stream_0.Write(this.byte_0, (int)this.uint_1, (int)num);
				if (this.uint_0 >= this.uint_2)
				{
					this.uint_0 = 0u;
				}
				this.uint_1 = this.uint_0;
				return;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000046B4 File Offset: 0x000028B4
		internal void method_4(uint uint_3, uint uint_4)
		{
			uint num = this.uint_0 - uint_3 - 1u;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			while (uint_4 > 0u)
			{
				if (num >= this.uint_2)
				{
					num = 0u;
				}
				this.byte_0[(int)((UIntPtr)(this.uint_0++))] = this.byte_0[(int)((UIntPtr)(num++))];
				if (this.uint_0 >= this.uint_2)
				{
					this.method_3();
				}
				uint_4 -= 1u;
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004730 File Offset: 0x00002930
		internal void method_5(byte byte_1)
		{
			this.byte_0[(int)((UIntPtr)(this.uint_0++))] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_3();
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000476C File Offset: 0x0000296C
		internal byte method_6(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1u;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)((UIntPtr)num)];
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003B38 File Offset: 0x00001D38
		internal Class4()
		{
		}

		// Token: 0x04000028 RID: 40
		internal byte[] byte_0;

		// Token: 0x04000029 RID: 41
		internal uint uint_0;

		// Token: 0x0400002A RID: 42
		internal Stream stream_0;

		// Token: 0x0400002B RID: 43
		internal uint uint_1;

		// Token: 0x0400002C RID: 44
		internal uint uint_2;
	}

	// Token: 0x0200000A RID: 10
	internal struct Struct3
	{
		// Token: 0x0600004C RID: 76 RVA: 0x000047A0 File Offset: 0x000029A0
		internal void method_0()
		{
			this.uint_0 = 0u;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000047B4 File Offset: 0x000029B4
		internal void method_1()
		{
			if (this.uint_0 < 4u)
			{
				this.uint_0 = 0u;
				return;
			}
			if (this.uint_0 >= 10u)
			{
				this.uint_0 -= 6u;
				return;
			}
			this.uint_0 -= 3u;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000047FC File Offset: 0x000029FC
		internal void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 7u : 10u);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004820 File Offset: 0x00002A20
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 8u : 11u);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004844 File Offset: 0x00002A44
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 9u : 11u);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004868 File Offset: 0x00002A68
		internal bool method_5()
		{
			return this.uint_0 < 7u;
		}

		// Token: 0x0400002D RID: 45
		internal uint uint_0;
	}

	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Size = 896)]
	internal struct Struct4
	{
	}

	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1216)]
	internal struct Struct5
	{
	}
}
