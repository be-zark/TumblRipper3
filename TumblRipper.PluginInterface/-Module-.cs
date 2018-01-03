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
	// Token: 0x06000001 RID: 1 RVA: 0x00002290 File Offset: 0x00000490
	static <Module>()
	{
		<Module>.smethod_30();
		<Module>.smethod_24();
		<Module>.smethod_0();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000022AC File Offset: 0x000004AC
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

	// Token: 0x06000003 RID: 3 RVA: 0x00002358 File Offset: 0x00000558
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

	// Token: 0x06000004 RID: 4 RVA: 0x000023D0 File Offset: 0x000005D0
	static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000023D0 File Offset: 0x000005D0
	static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000023E4 File Offset: 0x000005E4
	static MethodInfo smethod_4(Type type_0, string string_0, Type[] type_1)
	{
		return type_0.GetMethod(string_0, type_1);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000023FC File Offset: 0x000005FC
	static string smethod_5(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002410 File Offset: 0x00000610
	static object smethod_6(MethodBase methodBase_0, object object_0, object[] object_1)
	{
		return methodBase_0.Invoke(object_0, object_1);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002428 File Offset: 0x00000628
	static bool smethod_7(object object_0, object object_1)
	{
		return object_0.Equals(object_1);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000243C File Offset: 0x0000063C
	static void smethod_8(string string_0)
	{
		Environment.FailFast(string_0);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002450 File Offset: 0x00000650
	static Thread smethod_9(ParameterizedThreadStart parameterizedThreadStart_0)
	{
		return new Thread(parameterizedThreadStart_0);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002464 File Offset: 0x00000664
	static void smethod_10(Thread thread_0, bool bool_0)
	{
		thread_0.IsBackground = bool_0;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002478 File Offset: 0x00000678
	static void smethod_11(Thread thread_0, object object_0)
	{
		thread_0.Start(object_0);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002450 File Offset: 0x00000650
	static Thread smethod_12(ParameterizedThreadStart parameterizedThreadStart_0)
	{
		return new Thread(parameterizedThreadStart_0);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002464 File Offset: 0x00000664
	static void smethod_13(Thread thread_0, bool bool_0)
	{
		thread_0.IsBackground = bool_0;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0000248C File Offset: 0x0000068C
	static Thread smethod_14()
	{
		return Thread.CurrentThread;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002478 File Offset: 0x00000678
	static void smethod_15(Thread thread_0, object object_0)
	{
		thread_0.Start(object_0);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000024A0 File Offset: 0x000006A0
	static void smethod_16(int int_0)
	{
		Thread.Sleep(int_0);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000024B4 File Offset: 0x000006B4
	static bool smethod_17()
	{
		return Debugger.IsAttached;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000024C8 File Offset: 0x000006C8
	static bool smethod_18()
	{
		return Debugger.IsLogging();
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000243C File Offset: 0x0000063C
	static void smethod_19(string string_0)
	{
		Environment.FailFast(string_0);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000024DC File Offset: 0x000006DC
	static bool smethod_20(Thread thread_0)
	{
		return thread_0.IsAlive;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x0000243C File Offset: 0x0000063C
	static void smethod_21(string string_0)
	{
		Environment.FailFast(string_0);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000024A0 File Offset: 0x000006A0
	static void smethod_22(int int_0)
	{
		Thread.Sleep(int_0);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000024F0 File Offset: 0x000006F0
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

	// Token: 0x0600001A RID: 26 RVA: 0x00002588 File Offset: 0x00000788
	internal static void smethod_24()
	{
		uint num = 32u;
		uint[] array = new uint[]
		{
			1531987151u,
			4150113672u,
			1498580060u,
			827724130u,
			1238869049u,
			1174110224u,
			1480899677u,
			1153133989u,
			1181142345u,
			1995171689u,
			2403937912u,
			2282052085u,
			3203085984u,
			3123277427u,
			748349681u,
			115390943u,
			1744152617u,
			2134726804u,
			2518695005u,
			827724217u,
			1238869049u,
			1174110224u,
			1480899677u,
			1153133989u,
			1181142345u,
			1995171689u,
			2403937912u,
			2282052085u,
			3203085984u,
			3123277427u,
			748349681u,
			115390943u
		};
		uint[] array2 = new uint[16];
		uint num2 = 3378303300u;
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

	// Token: 0x0600001B RID: 27 RVA: 0x0000277C File Offset: 0x0000097C
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

	// Token: 0x0600001C RID: 28 RVA: 0x0000291C File Offset: 0x00000B1C
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

	// Token: 0x0600001D RID: 29 RVA: 0x00002ABC File Offset: 0x00000CBC
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

	// Token: 0x0600001E RID: 30 RVA: 0x00002C5C File Offset: 0x00000E5C
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

	// Token: 0x0600001F RID: 31 RVA: 0x00002DFC File Offset: 0x00000FFC
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

	// Token: 0x06000020 RID: 32 RVA: 0x00002F9C File Offset: 0x0000119C
	internal static void smethod_30()
	{
		uint num = 112u;
		uint[] array = new uint[]
		{
			3558746694u,
			2149223162u,
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
			2733720273u,
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
			1909993882u,
			1212634331u,
			2545992732u,
			3635303748u,
			977235360u,
			2829857130u,
			262891337u,
			2361077634u,
			2640435281u,
			4061545098u,
			98935208u,
			583266060u,
			3580716531u,
			2012470890u,
			2516105911u,
			1094319591u,
			246444220u,
			3715966759u,
			3846904984u,
			1350589572u,
			1083192799u,
			2359862660u,
			2125501507u,
			452409037u,
			2969376257u,
			4101542039u,
			1266598781u,
			1106348165u,
			3405063496u,
			2306635903u,
			2936096317u,
			3800626310u,
			1375241197u,
			3811551831u,
			723115908u,
			1015467197u,
			1688512498u,
			2354108823u,
			62148776u,
			1102553646u,
			2155355382u,
			2852748480u,
			3321592120u,
			592202167u,
			144399536u,
			491193986u,
			1271274137u,
			3637789680u,
			813954395u,
			735141762u,
			2934338810u,
			72365168u,
			292432223u,
			1320800256u,
			997034451u,
			1623376796u,
			755507806u,
			1759319359u,
			1917055195u,
			1963067017u,
			542003828u,
			2379948351u,
			3930286863u,
			1241865825u,
			3260004078u,
			2693631178u,
			1661892991u,
			4082781294u,
			2382806814u,
			3998055259u,
			2067132238u,
			1422499588u,
			843434029u,
			1759319392u,
			1917055195u,
			1963067017u,
			542003828u,
			2379948351u,
			3930286863u,
			1241865825u,
			3260004078u,
			2693631178u,
			1661892991u
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

	// Token: 0x06000021 RID: 33 RVA: 0x000031B4 File Offset: 0x000013B4
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

	// Token: 0x04000004 RID: 4 RVA: 0x000020D0 File Offset: 0x000002D0
	internal static <Module>.Struct5 struct5_0;

	// Token: 0x02000002 RID: 2
	internal struct Struct0
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000031E0 File Offset: 0x000013E0
		internal void method_0()
		{
			this.uint_0 = 1024u;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000031F8 File Offset: 0x000013F8
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
		// Token: 0x06000024 RID: 36 RVA: 0x000032E4 File Offset: 0x000014E4
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000330C File Offset: 0x0000150C
		internal void method_0()
		{
			uint num = 1u;
			while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
			{
				this.struct0_0[(int)((UIntPtr)num)].method_0();
				num += 1u;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003344 File Offset: 0x00001544
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = 1u;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
			}
			return num - (1u << this.int_0);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000338C File Offset: 0x0000158C
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

		// Token: 0x06000028 RID: 40 RVA: 0x000033D4 File Offset: 0x000015D4
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
		// Token: 0x06000029 RID: 41 RVA: 0x00003414 File Offset: 0x00001614
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

		// Token: 0x0600002A RID: 42 RVA: 0x00003460 File Offset: 0x00001660
		internal void method_1()
		{
			this.stream_0 = null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003474 File Offset: 0x00001674
		internal void method_2()
		{
			while (this.uint_1 < 16777216u)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000034BC File Offset: 0x000016BC
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

		// Token: 0x0600002D RID: 45 RVA: 0x00003530 File Offset: 0x00001730
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
		// Token: 0x0600002E RID: 46 RVA: 0x00003544 File Offset: 0x00001744
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

		// Token: 0x0600002F RID: 47 RVA: 0x00003644 File Offset: 0x00001844
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

		// Token: 0x06000030 RID: 48 RVA: 0x00003690 File Offset: 0x00001890
		internal void method_1(int int_0, int int_1)
		{
			this.class3_0.method_0(int_0, int_1);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000036AC File Offset: 0x000018AC
		internal void method_2(int int_0)
		{
			uint num = 1u << int_0;
			this.class2_0.method_0(num);
			this.class2_1.method_0(num);
			this.uint_2 = num - 1u;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000036E4 File Offset: 0x000018E4
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

		// Token: 0x06000033 RID: 51 RVA: 0x00003810 File Offset: 0x00001A10
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

		// Token: 0x06000034 RID: 52 RVA: 0x00003B84 File Offset: 0x00001D84
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

		// Token: 0x06000035 RID: 53 RVA: 0x00003BE4 File Offset: 0x00001DE4
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
			// Token: 0x06000036 RID: 54 RVA: 0x00003C00 File Offset: 0x00001E00
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1u)
				{
					this.struct1_0[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
					this.struct1_1[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x06000037 RID: 55 RVA: 0x00003C58 File Offset: 0x00001E58
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

			// Token: 0x06000038 RID: 56 RVA: 0x00003CBC File Offset: 0x00001EBC
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

			// Token: 0x06000039 RID: 57 RVA: 0x00003D28 File Offset: 0x00001F28
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
			// Token: 0x0600003A RID: 58 RVA: 0x00003D7C File Offset: 0x00001F7C
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

			// Token: 0x0600003B RID: 59 RVA: 0x00003E00 File Offset: 0x00002000
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

			// Token: 0x0600003C RID: 60 RVA: 0x00003E3C File Offset: 0x0000203C
			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00003E6C File Offset: 0x0000206C
			internal byte method_3(<Module>.Class0 class0_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_2(class0_0);
			}

			// Token: 0x0600003E RID: 62 RVA: 0x00003E94 File Offset: 0x00002094
			internal byte method_4(<Module>.Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_3(class0_0, byte_1);
			}

			// Token: 0x0600003F RID: 63 RVA: 0x00003530 File Offset: 0x00001730
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
				// Token: 0x06000040 RID: 64 RVA: 0x00003EC0 File Offset: 0x000020C0
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x06000041 RID: 65 RVA: 0x00003EE0 File Offset: 0x000020E0
				internal void method_1()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_0();
					}
				}

				// Token: 0x06000042 RID: 66 RVA: 0x00003F10 File Offset: 0x00002110
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

				// Token: 0x06000043 RID: 67 RVA: 0x00003F44 File Offset: 0x00002144
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
		// Token: 0x06000044 RID: 68 RVA: 0x00003FB4 File Offset: 0x000021B4
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

		// Token: 0x06000045 RID: 69 RVA: 0x00003FEC File Offset: 0x000021EC
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

		// Token: 0x06000046 RID: 70 RVA: 0x00004018 File Offset: 0x00002218
		internal void method_2()
		{
			this.method_3();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004054 File Offset: 0x00002254
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

		// Token: 0x06000048 RID: 72 RVA: 0x000040AC File Offset: 0x000022AC
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

		// Token: 0x06000049 RID: 73 RVA: 0x00004128 File Offset: 0x00002328
		internal void method_5(byte byte_1)
		{
			this.byte_0[(int)((UIntPtr)(this.uint_0++))] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_3();
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004164 File Offset: 0x00002364
		internal byte method_6(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1u;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)((UIntPtr)num)];
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003530 File Offset: 0x00001730
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
		// Token: 0x0600004C RID: 76 RVA: 0x00004198 File Offset: 0x00002398
		internal void method_0()
		{
			this.uint_0 = 0u;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000041AC File Offset: 0x000023AC
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

		// Token: 0x0600004E RID: 78 RVA: 0x000041F4 File Offset: 0x000023F4
		internal void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 7u : 10u);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004218 File Offset: 0x00002418
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 8u : 11u);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000423C File Offset: 0x0000243C
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 9u : 11u);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004260 File Offset: 0x00002460
		internal bool method_5()
		{
			return this.uint_0 < 7u;
		}

		// Token: 0x0400002D RID: 45
		internal uint uint_0;
	}

	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Size = 128)]
	internal struct Struct4
	{
	}

	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 448)]
	internal struct Struct5
	{
	}
}
