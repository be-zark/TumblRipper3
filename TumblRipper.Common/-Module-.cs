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
	// Token: 0x06000002 RID: 2 RVA: 0x00002464 File Offset: 0x00000664
	private static void smethod_0()
	{
		string str = "COR";
		Type typeFromHandle = typeof(Environment);
		MethodInfo method = typeFromHandle.GetMethod("GetEnvironmentVariable", new Type[]
		{
			typeof(string)
		});
		if (method != null && "1".Equals(method.Invoke(null, new object[]
		{
			str + "_ENABLE_PROFILING"
		})))
		{
			Environment.FailFast(null);
		}
		new Thread(new ParameterizedThreadStart(<Module>.smethod_1))
		{
			IsBackground = true
		}.Start(null);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000024FC File Offset: 0x000006FC
	private static void smethod_1(object object_0)
	{
		Thread thread = object_0 as Thread;
		if (thread == null)
		{
			thread = new Thread(new ParameterizedThreadStart(<Module>.smethod_1));
			thread.IsBackground = true;
			thread.Start(Thread.CurrentThread);
			Thread.Sleep(500);
		}
		for (;;)
		{
			if (Debugger.IsAttached)
			{
				goto IL_3A;
			}
			if (Debugger.IsLogging())
			{
				goto IL_3A;
			}
			IL_40:
			if (!thread.IsAlive)
			{
				Environment.FailFast(null);
			}
			Thread.Sleep(1000);
			continue;
			IL_3A:
			Environment.FailFast(null);
			goto IL_40;
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002574 File Offset: 0x00000774
	internal static byte[] smethod_2(byte[] byte_1)
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

	// Token: 0x06000005 RID: 5 RVA: 0x0000260C File Offset: 0x0000080C
	internal static void smethod_3()
	{
		uint num = 144u;
		uint[] array = new uint[]
		{
			1131505519u,
			2340330549u,
			1266018281u,
			2775601331u,
			3086526355u,
			266035523u,
			2824929054u,
			3130010813u,
			3762450161u,
			885335699u,
			3781414243u,
			2351519808u,
			1355249096u,
			202100681u,
			3132304243u,
			2898270420u,
			2144635785u,
			52326697u,
			3725418472u,
			1580416734u,
			2625608204u,
			1981763909u,
			2029699591u,
			967315455u,
			604277034u,
			3999219062u,
			1258175067u,
			3320792493u,
			3220682893u,
			3321311618u,
			1641239369u,
			3977568335u,
			1565628494u,
			2283563481u,
			2418932892u,
			1924135166u,
			2305614921u,
			1683600054u,
			4237635254u,
			2617871107u,
			3637824460u,
			234370354u,
			2211741959u,
			1433554235u,
			2044841737u,
			3642982824u,
			3222503687u,
			4209732303u,
			1042057781u,
			2338615804u,
			866832288u,
			3823877520u,
			2620780837u,
			4211194555u,
			1466057028u,
			1340664841u,
			1126619100u,
			1907053034u,
			323795431u,
			286229601u,
			2949758590u,
			708698322u,
			3671316315u,
			1385649141u,
			3853345098u,
			140483825u,
			1136390020u,
			3587834164u,
			237657206u,
			562883696u,
			1052092729u,
			1411745386u,
			29898055u,
			2602286006u,
			1077240534u,
			121232840u,
			2063066164u,
			1134043262u,
			1376582481u,
			2460508950u,
			328703098u,
			1876690142u,
			970428141u,
			3590899078u,
			1424476669u,
			2179513604u,
			2162523049u,
			1414016587u,
			1565323185u,
			1148058377u,
			792762251u,
			4195128180u,
			2797025251u,
			2869082928u,
			1053032310u,
			2595340472u,
			145297081u,
			910087665u,
			776927249u,
			1523264655u,
			3879663129u,
			4253496966u,
			3958884885u,
			2873103541u,
			3280995275u,
			2855263503u,
			1227258206u,
			1855463164u,
			4169608646u,
			507351399u,
			1566003913u,
			2020011857u,
			2666700425u,
			1805714079u,
			2858848355u,
			1833514230u,
			3639173727u,
			4050417948u,
			1816889546u,
			2173268854u,
			2376361424u,
			105012761u,
			1749230006u,
			3546924517u,
			3697812872u,
			1249664478u,
			4045276507u,
			3777662764u,
			4142224986u,
			4232755718u,
			1867940934u,
			866090338u,
			625501032u,
			2130033033u,
			128227065u,
			360157915u,
			3770619695u,
			730491927u,
			1351723689u,
			301549995u,
			3697804618u,
			1249664478u,
			4045276507u,
			3777662764u
		};
		uint[] array2 = new uint[16];
		uint num2 = 2541228203u;
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
		<Module>.byte_0 = <Module>.smethod_2(array4);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002808 File Offset: 0x00000A08
	internal static T smethod_4<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 2504670995u ^ 3521045809u);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 2UL)
		{
			int count = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num != 3UL)
		{
			if ((ulong)num == 0UL)
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

	// Token: 0x06000007 RID: 7 RVA: 0x000029A8 File Offset: 0x00000BA8
	internal static T smethod_5<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 2606850449u ^ 219280023u);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 3UL)
		{
			int count = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num != 1UL)
		{
			if ((ulong)num == 0UL)
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

	// Token: 0x06000008 RID: 8 RVA: 0x00002B48 File Offset: 0x00000D48
	internal static T smethod_6<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 2252266717u ^ 3300711382u);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num == 3UL)
		{
			int count = (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)<Module>.byte_0[(int)((UIntPtr)(uint_0++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
		}
		else if ((ulong)num != 2UL)
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

	// Token: 0x06000009 RID: 9 RVA: 0x00002CE8 File Offset: 0x00000EE8
	internal static T smethod_7<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 866358515u ^ 1002538010u);
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

	// Token: 0x0600000A RID: 10 RVA: 0x00002E88 File Offset: 0x00001088
	internal static T smethod_8<T>(uint uint_0)
	{
		uint_0 = (uint_0 * 1670294445u ^ 899798185u);
		uint num = uint_0 >> 30;
		T result = default(T);
		uint_0 &= 1073741823u;
		uint_0 <<= 2;
		if ((ulong)num != 0UL)
		{
			if ((ulong)num == 2UL)
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

	// Token: 0x0600000B RID: 11 RVA: 0x00002450 File Offset: 0x00000650
	internal static byte[] smethod_9()
	{
		return null;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00003028 File Offset: 0x00001228
	internal static Assembly smethod_10(object object_0, ResolveEventArgs resolveEventArgs_0)
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

	// Token: 0x04000004 RID: 4 RVA: 0x00002290 File Offset: 0x00000490
	internal static <Module>.Struct5 struct5_0;

	// Token: 0x02000002 RID: 2
	internal struct Struct0
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00003054 File Offset: 0x00001254
		internal void method_0()
		{
			this.uint_0 = 1024u;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000306C File Offset: 0x0000126C
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
		// Token: 0x0600000F RID: 15 RVA: 0x00003158 File Offset: 0x00001358
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003180 File Offset: 0x00001380
		internal void method_0()
		{
			uint num = 1u;
			while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
			{
				this.struct0_0[(int)((UIntPtr)num)].method_0();
				num += 1u;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000031B8 File Offset: 0x000013B8
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = 1u;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
			}
			return num - (1u << this.int_0);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003200 File Offset: 0x00001400
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

		// Token: 0x06000013 RID: 19 RVA: 0x00003248 File Offset: 0x00001448
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
		// Token: 0x06000014 RID: 20 RVA: 0x00003288 File Offset: 0x00001488
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

		// Token: 0x06000015 RID: 21 RVA: 0x000032D4 File Offset: 0x000014D4
		internal void method_1()
		{
			this.stream_0 = null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000032E8 File Offset: 0x000014E8
		internal void method_2()
		{
			while (this.uint_1 < 16777216u)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003330 File Offset: 0x00001530
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

		// Token: 0x06000018 RID: 24 RVA: 0x000033A4 File Offset: 0x000015A4
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
		// Token: 0x06000019 RID: 25 RVA: 0x000033B8 File Offset: 0x000015B8
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

		// Token: 0x0600001A RID: 26 RVA: 0x000034B8 File Offset: 0x000016B8
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

		// Token: 0x0600001B RID: 27 RVA: 0x00003504 File Offset: 0x00001704
		internal void method_1(int int_0, int int_1)
		{
			this.class3_0.method_0(int_0, int_1);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003520 File Offset: 0x00001720
		internal void method_2(int int_0)
		{
			uint num = 1u << int_0;
			this.class2_0.method_0(num);
			this.class2_1.method_0(num);
			this.uint_2 = num - 1u;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003558 File Offset: 0x00001758
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

		// Token: 0x0600001E RID: 30 RVA: 0x00003684 File Offset: 0x00001884
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
					if (!@struct.method_5())
					{
						byte_3 = this.class3_0.method_4(this.class0_0, (uint)num5, byte_2, this.class4_0.method_6(num));
					}
					else
					{
						byte_3 = this.class3_0.method_3(this.class0_0, (uint)num5, byte_2);
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

		// Token: 0x0600001F RID: 31 RVA: 0x000039F8 File Offset: 0x00001BF8
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

		// Token: 0x06000020 RID: 32 RVA: 0x00003A58 File Offset: 0x00001C58
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
			// Token: 0x06000021 RID: 33 RVA: 0x00003A74 File Offset: 0x00001C74
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1u)
				{
					this.struct1_0[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
					this.struct1_1[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x06000022 RID: 34 RVA: 0x00003ACC File Offset: 0x00001CCC
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

			// Token: 0x06000023 RID: 35 RVA: 0x00003B30 File Offset: 0x00001D30
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

			// Token: 0x06000024 RID: 36 RVA: 0x00003B9C File Offset: 0x00001D9C
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
			// Token: 0x06000025 RID: 37 RVA: 0x00003BF0 File Offset: 0x00001DF0
			internal void method_0(int int_2, int int_3)
			{
				if (this.struct2_0 != null && this.int_1 == int_3 && this.int_0 == int_2)
				{
					return;
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

			// Token: 0x06000026 RID: 38 RVA: 0x00003C74 File Offset: 0x00001E74
			internal void method_1()
			{
				uint num = 1u << this.int_1 + this.int_0;
				for (uint num2 = 0u; num2 < num; num2 += 1u)
				{
					this.struct2_0[(int)((UIntPtr)num2)].method_1();
				}
			}

			// Token: 0x06000027 RID: 39 RVA: 0x00003CB4 File Offset: 0x00001EB4
			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00003CE4 File Offset: 0x00001EE4
			internal byte method_3(<Module>.Class0 class0_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_2(class0_0);
			}

			// Token: 0x06000029 RID: 41 RVA: 0x00003D0C File Offset: 0x00001F0C
			internal byte method_4(<Module>.Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_3(class0_0, byte_1);
			}

			// Token: 0x0600002A RID: 42 RVA: 0x000033A4 File Offset: 0x000015A4
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
				// Token: 0x0600002B RID: 43 RVA: 0x00003D38 File Offset: 0x00001F38
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x0600002C RID: 44 RVA: 0x00003D58 File Offset: 0x00001F58
				internal void method_1()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_0();
					}
				}

				// Token: 0x0600002D RID: 45 RVA: 0x00003D88 File Offset: 0x00001F88
				internal byte method_2(<Module>.Class0 class0_0)
				{
					uint num = 2u | this.struct0_0[(int)((UIntPtr)1)].method_1(class0_0);
					if (num >= 256u)
					{
					}
					return (byte)num;
				}

				// Token: 0x0600002E RID: 46 RVA: 0x00003DB8 File Offset: 0x00001FB8
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
		// Token: 0x0600002F RID: 47 RVA: 0x00003E28 File Offset: 0x00002028
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

		// Token: 0x06000030 RID: 48 RVA: 0x00003E60 File Offset: 0x00002060
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

		// Token: 0x06000031 RID: 49 RVA: 0x00003E8C File Offset: 0x0000208C
		internal void method_2()
		{
			this.method_3();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003EC8 File Offset: 0x000020C8
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

		// Token: 0x06000033 RID: 51 RVA: 0x00003F20 File Offset: 0x00002120
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

		// Token: 0x06000034 RID: 52 RVA: 0x00003F9C File Offset: 0x0000219C
		internal void method_5(byte byte_1)
		{
			this.byte_0[(int)((UIntPtr)(this.uint_0++))] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_3();
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003FD8 File Offset: 0x000021D8
		internal byte method_6(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1u;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)((UIntPtr)num)];
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000033A4 File Offset: 0x000015A4
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
		// Token: 0x06000037 RID: 55 RVA: 0x0000400C File Offset: 0x0000220C
		internal void method_0()
		{
			this.uint_0 = 0u;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004020 File Offset: 0x00002220
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

		// Token: 0x06000039 RID: 57 RVA: 0x00004068 File Offset: 0x00002268
		internal void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 7u : 10u);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000408C File Offset: 0x0000228C
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 8u : 11u);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000040B0 File Offset: 0x000022B0
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 9u : 11u);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000040D4 File Offset: 0x000022D4
		internal bool method_5()
		{
			return this.uint_0 < 7u;
		}

		// Token: 0x0400002D RID: 45
		internal uint uint_0;
	}

	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Size = 576)]
	internal struct Struct4
	{
	}

	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 448)]
	internal struct Struct5
	{
	}
}
