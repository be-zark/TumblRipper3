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
	// Token: 0x06000002 RID: 2 RVA: 0x00003EE4 File Offset: 0x000020E4
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

	// Token: 0x06000003 RID: 3 RVA: 0x00003F7C File Offset: 0x0000217C
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

	// Token: 0x06000004 RID: 4 RVA: 0x00003FF4 File Offset: 0x000021F4
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

	// Token: 0x06000005 RID: 5 RVA: 0x0000408C File Offset: 0x0000228C
	internal static void smethod_3()
	{
		uint num = 352u;
		uint[] array = new uint[]
		{
			256495363u,
			189505475u,
			2873200581u,
			2437561311u,
			398561101u,
			937970184u,
			1649432446u,
			2762745812u,
			2894038609u,
			2231111163u,
			2773607825u,
			1746875276u,
			3774831988u,
			3224954094u,
			1552728954u,
			2767295266u,
			871113701u,
			2200662751u,
			3409459140u,
			2602970861u,
			2293510717u,
			3140206203u,
			2374333238u,
			1984207020u,
			1601339195u,
			2096254717u,
			1470078616u,
			3857663029u,
			3964042137u,
			778664476u,
			212125841u,
			1689044928u,
			2478970341u,
			2688909977u,
			4022523170u,
			621167338u,
			1477043902u,
			1766587733u,
			4245131930u,
			1789216452u,
			1953114489u,
			1350702409u,
			1564032241u,
			4100812414u,
			2252321746u,
			1699158900u,
			3361006883u,
			3792646254u,
			2558175648u,
			1528185549u,
			2608323976u,
			4025726535u,
			4144022148u,
			4086689868u,
			2390960227u,
			475873669u,
			2901588602u,
			1097449931u,
			1820055331u,
			777931527u,
			2955397580u,
			170908523u,
			502656516u,
			2908254999u,
			441361635u,
			4214379053u,
			2968812883u,
			3727147083u,
			2835887043u,
			3735771001u,
			396609894u,
			3464586437u,
			1955135086u,
			937147132u,
			2559427734u,
			1492583656u,
			1648016644u,
			981821857u,
			2442439272u,
			3986282724u,
			3449684241u,
			3738958082u,
			3792055449u,
			1580577772u,
			2550304199u,
			1261628510u,
			1565850734u,
			856676207u,
			802424220u,
			1605823271u,
			3975549536u,
			3836714185u,
			1147122608u,
			3129463853u,
			3206219555u,
			2932941946u,
			3809825502u,
			3038900937u,
			392673892u,
			511390802u,
			1257847474u,
			4116886064u,
			1655592966u,
			2085857772u,
			2696134746u,
			1223175508u,
			3787319098u,
			2624487832u,
			1905491218u,
			1310289540u,
			3714267268u,
			1661495176u,
			770545253u,
			2723136768u,
			3113845514u,
			290497559u,
			1425804562u,
			1510229562u,
			3507685494u,
			2444367163u,
			3856466073u,
			2046077886u,
			3488343604u,
			3681686481u,
			275027449u,
			3534186854u,
			456289041u,
			3638001530u,
			2921659474u,
			1678471512u,
			331008489u,
			3813093072u,
			2538076256u,
			4227630405u,
			105085325u,
			1903574150u,
			682118895u,
			4068109224u,
			2825173706u,
			860497217u,
			3240942803u,
			835195312u,
			3590005235u,
			1242349194u,
			3783521320u,
			3416931410u,
			2436747183u,
			3533841289u,
			3562326933u,
			2217884197u,
			1304962639u,
			810204696u,
			799731637u,
			2728422654u,
			4113973366u,
			164533380u,
			616716130u,
			1117977223u,
			2478250592u,
			1396761785u,
			2232742063u,
			1026625041u,
			18718917u,
			4060056686u,
			2204205664u,
			4122570720u,
			669521010u,
			1639782626u,
			1496894836u,
			3115512437u,
			2696317729u,
			2773388365u,
			1114055045u,
			2499167222u,
			3691741775u,
			4239784769u,
			1011875309u,
			4040986182u,
			3960774621u,
			1574823514u,
			800833295u,
			2853066614u,
			3565797513u,
			1383435137u,
			3594487722u,
			3511903938u,
			78684232u,
			665890869u,
			1633570437u,
			3768447275u,
			1691557381u,
			4024937367u,
			3873503490u,
			3623757120u,
			711426197u,
			2521622177u,
			3513883279u,
			637703323u,
			2396104549u,
			631066333u,
			3342040069u,
			482257989u,
			1889691029u,
			1719592749u,
			1579657283u,
			3590571775u,
			2227295209u,
			1441463508u,
			2167801371u,
			1525758010u,
			3367462404u,
			3246095085u,
			3057915406u,
			3615955840u,
			3665579944u,
			2551985797u,
			1454857486u,
			1434072904u,
			1779396460u,
			3367393502u,
			2979869776u,
			3327896719u,
			2474927431u,
			2091719650u,
			517678450u,
			299831540u,
			78725432u,
			1726882139u,
			3089314732u,
			621067123u,
			3994413434u,
			663021867u,
			1663191587u,
			3982736185u,
			1323733558u,
			1221121440u,
			4288648163u,
			2411720583u,
			1937760741u,
			3180560376u,
			1699243656u,
			1946033717u,
			3805909167u,
			1995934547u,
			3685168168u,
			1773329944u,
			550701939u,
			4058565095u,
			289649467u,
			1773103191u,
			767444948u,
			3722636033u,
			695508385u,
			2366960807u,
			3737327128u,
			3609825058u,
			881322924u,
			1265883768u,
			1694897312u,
			2964348844u,
			3198566109u,
			3047911048u,
			883679899u,
			4071860768u,
			3007852452u,
			4116491930u,
			1029452650u,
			3970374539u,
			3874788668u,
			3843320915u,
			649154829u,
			897904059u,
			1904315230u,
			1102710474u,
			3802577749u,
			1160378647u,
			4240245063u,
			484380409u,
			3707115574u,
			281338916u,
			618351750u,
			438236522u,
			643433437u,
			2414036195u,
			573029857u,
			573050392u,
			3174926745u,
			3657421662u,
			764085602u,
			1937527312u,
			591375409u,
			745142260u,
			1012459096u,
			1190581694u,
			651666044u,
			2134442151u,
			3672490489u,
			2237878284u,
			807622010u,
			1831217479u,
			1515266833u,
			4126447441u,
			2649102788u,
			1544289801u,
			311261180u,
			535245218u,
			2735956004u,
			2638184610u,
			3507545394u,
			611131872u,
			825114415u,
			2322298901u,
			2711238378u,
			638131016u,
			1331501908u,
			1245456349u,
			1860441140u,
			1726006878u,
			1880700619u,
			4188821828u,
			3577746994u,
			1418625950u,
			1349792636u,
			1425058155u,
			2002841035u,
			2246986500u,
			897632442u,
			2726345107u,
			4120770572u,
			1909658242u,
			2987504618u,
			1078911966u,
			901544411u,
			3412788665u,
			2605367128u,
			3775467677u,
			4132518997u,
			3388455233u,
			1095161927u,
			891668029u,
			2002818621u,
			2246986500u,
			897632442u,
			2726345107u,
			4120770572u,
			1909658242u,
			2987504618u,
			1078911966u,
			901544411u,
			3412788665u,
			2605367128u,
			3775467677u
		};
		uint[] array2 = new uint[16];
		uint num2 = 289987522u;
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

	// Token: 0x06000006 RID: 6 RVA: 0x00004288 File Offset: 0x00002488
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

	// Token: 0x06000007 RID: 7 RVA: 0x00004428 File Offset: 0x00002628
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

	// Token: 0x06000008 RID: 8 RVA: 0x000045C8 File Offset: 0x000027C8
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

	// Token: 0x06000009 RID: 9 RVA: 0x00004768 File Offset: 0x00002968
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

	// Token: 0x0600000A RID: 10 RVA: 0x00004908 File Offset: 0x00002B08
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

	// Token: 0x0600000B RID: 11 RVA: 0x00003ED0 File Offset: 0x000020D0
	internal static byte[] smethod_9()
	{
		return null;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00004AA8 File Offset: 0x00002CA8
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

	// Token: 0x04000004 RID: 4 RVA: 0x000025D0 File Offset: 0x000007D0
	internal static <Module>.Struct5 struct5_0;

	// Token: 0x02000002 RID: 2
	internal struct Struct0
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00004AD4 File Offset: 0x00002CD4
		internal void method_0()
		{
			this.uint_0 = 1024u;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004AEC File Offset: 0x00002CEC
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
		// Token: 0x0600000F RID: 15 RVA: 0x00004BD8 File Offset: 0x00002DD8
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00004C00 File Offset: 0x00002E00
		internal void method_0()
		{
			uint num = 1u;
			while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
			{
				this.struct0_0[(int)((UIntPtr)num)].method_0();
				num += 1u;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004C38 File Offset: 0x00002E38
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = 1u;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
			}
			return num - (1u << this.int_0);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00004C80 File Offset: 0x00002E80
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

		// Token: 0x06000013 RID: 19 RVA: 0x00004CC8 File Offset: 0x00002EC8
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
		// Token: 0x06000014 RID: 20 RVA: 0x00004D08 File Offset: 0x00002F08
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

		// Token: 0x06000015 RID: 21 RVA: 0x00004D54 File Offset: 0x00002F54
		internal void method_1()
		{
			this.stream_0 = null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00004D68 File Offset: 0x00002F68
		internal void method_2()
		{
			while (this.uint_1 < 16777216u)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00004DB0 File Offset: 0x00002FB0
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

		// Token: 0x06000018 RID: 24 RVA: 0x00004E24 File Offset: 0x00003024
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
		// Token: 0x06000019 RID: 25 RVA: 0x00004E38 File Offset: 0x00003038
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

		// Token: 0x0600001A RID: 26 RVA: 0x00004F38 File Offset: 0x00003138
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

		// Token: 0x0600001B RID: 27 RVA: 0x00004F84 File Offset: 0x00003184
		internal void method_1(int int_0, int int_1)
		{
			this.class3_0.method_0(int_0, int_1);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004FA0 File Offset: 0x000031A0
		internal void method_2(int int_0)
		{
			uint num = 1u << int_0;
			this.class2_0.method_0(num);
			this.class2_1.method_0(num);
			this.uint_2 = num - 1u;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004FD8 File Offset: 0x000031D8
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

		// Token: 0x0600001E RID: 30 RVA: 0x00005104 File Offset: 0x00003304
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

		// Token: 0x0600001F RID: 31 RVA: 0x00005478 File Offset: 0x00003678
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

		// Token: 0x06000020 RID: 32 RVA: 0x000054D8 File Offset: 0x000036D8
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
			// Token: 0x06000021 RID: 33 RVA: 0x000054F4 File Offset: 0x000036F4
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1u)
				{
					this.struct1_0[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
					this.struct1_1[(int)((UIntPtr)num)] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x06000022 RID: 34 RVA: 0x0000554C File Offset: 0x0000374C
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

			// Token: 0x06000023 RID: 35 RVA: 0x000055B0 File Offset: 0x000037B0
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

			// Token: 0x06000024 RID: 36 RVA: 0x0000561C File Offset: 0x0000381C
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
			// Token: 0x06000025 RID: 37 RVA: 0x00005670 File Offset: 0x00003870
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

			// Token: 0x06000026 RID: 38 RVA: 0x000056F4 File Offset: 0x000038F4
			internal void method_1()
			{
				uint num = 1u << this.int_1 + this.int_0;
				for (uint num2 = 0u; num2 < num; num2 += 1u)
				{
					this.struct2_0[(int)((UIntPtr)num2)].method_1();
				}
			}

			// Token: 0x06000027 RID: 39 RVA: 0x00005734 File Offset: 0x00003934
			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00005764 File Offset: 0x00003964
			internal byte method_3(<Module>.Class0 class0_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_2(class0_0);
			}

			// Token: 0x06000029 RID: 41 RVA: 0x0000578C File Offset: 0x0000398C
			internal byte method_4(<Module>.Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_3(class0_0, byte_1);
			}

			// Token: 0x0600002A RID: 42 RVA: 0x00004E24 File Offset: 0x00003024
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
				// Token: 0x0600002B RID: 43 RVA: 0x000057B8 File Offset: 0x000039B8
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x0600002C RID: 44 RVA: 0x000057D8 File Offset: 0x000039D8
				internal void method_1()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_0();
					}
				}

				// Token: 0x0600002D RID: 45 RVA: 0x00005808 File Offset: 0x00003A08
				internal byte method_2(<Module>.Class0 class0_0)
				{
					uint num = 2u | this.struct0_0[(int)((UIntPtr)1)].method_1(class0_0);
					if (num >= 256u)
					{
					}
					return (byte)num;
				}

				// Token: 0x0600002E RID: 46 RVA: 0x00005838 File Offset: 0x00003A38
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
		// Token: 0x0600002F RID: 47 RVA: 0x000058A8 File Offset: 0x00003AA8
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

		// Token: 0x06000030 RID: 48 RVA: 0x000058E0 File Offset: 0x00003AE0
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

		// Token: 0x06000031 RID: 49 RVA: 0x0000590C File Offset: 0x00003B0C
		internal void method_2()
		{
			this.method_3();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005948 File Offset: 0x00003B48
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

		// Token: 0x06000033 RID: 51 RVA: 0x000059A0 File Offset: 0x00003BA0
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

		// Token: 0x06000034 RID: 52 RVA: 0x00005A1C File Offset: 0x00003C1C
		internal void method_5(byte byte_1)
		{
			this.byte_0[(int)((UIntPtr)(this.uint_0++))] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_3();
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005A58 File Offset: 0x00003C58
		internal byte method_6(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1u;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)((UIntPtr)num)];
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004E24 File Offset: 0x00003024
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
		// Token: 0x06000037 RID: 55 RVA: 0x00005A8C File Offset: 0x00003C8C
		internal void method_0()
		{
			this.uint_0 = 0u;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005AA0 File Offset: 0x00003CA0
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

		// Token: 0x06000039 RID: 57 RVA: 0x00005AE8 File Offset: 0x00003CE8
		internal void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 7u : 10u);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005B0C File Offset: 0x00003D0C
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 8u : 11u);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005B30 File Offset: 0x00003D30
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 9u : 11u);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005B54 File Offset: 0x00003D54
		internal bool method_5()
		{
			return this.uint_0 < 7u;
		}

		// Token: 0x0400002D RID: 45
		internal uint uint_0;
	}

	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Size = 1408)]
	internal struct Struct4
	{
	}

	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6400)]
	internal struct Struct5
	{
	}
}
