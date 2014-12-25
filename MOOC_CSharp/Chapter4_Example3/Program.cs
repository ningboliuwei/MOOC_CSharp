using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Example3
{
	internal delegate void D(int x);
	internal class Program
	{
		private static void Main(string[] args)
		{
			D cd1 = C.M1;
			cd1(-1);

			D cd2 = null;
			cd2 += C.M2;
			cd2(-2);

			D cd3 = cd1 + cd2;
			cd3(10);
			cd3 += cd1;
			cd3(20);

			C c = new C();
			D cd4 = c.M3;
			cd3 += cd4;
			cd3(30);
			cd3 -= cd1;
			cd3(40);
			cd3 -= cd4;
			cd3(50);
			cd3 -= cd2;
			cd3(60);
			cd3 -= cd2;
			cd3(60);
			cd3 -= cd1;
			Console.WriteLine(cd3 == null);
			cd3 -= cd1;
			Console.WriteLine(cd3 == null);

			Console.ReadKey();

		}
	}


	internal class C
	{
		public static void M1(int i)
		{
			Console.WriteLine("C.M1:" + i);
		}

		public static void M2(int i)
		{
			Console.WriteLine("C.M2:" + i);
		}

		public void M3(int i)
		{
			Console.WriteLine("C.M3:" + i);
		}
	}

}