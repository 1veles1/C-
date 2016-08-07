// Простой пример рекурсии.
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
	{
	class Factorial
		{
		
		// Это рекурсивный метод.

		public Int32 FactR(Int32 n)
			{
			Int32 result;

			if(n == 1)
				return 1;
			result = FactR(n - 1) * n;
			return result;
			}

		// Это итерационный метод.

		public Int32 FactI(Int32 n)
			{
			Int32 t;
			Int32 result;

			result = 1;

			for(t = 1; t <= n; t++)
				result *= t;
			return result;
			}
		}
	class Recursion
		{
		static void Main()
			{
			Factorial f = new Factorial();

			Console.WriteLine(" Факториалы, рассчитанные рекурсивным методом ");
			Console.WriteLine(" Факториал числа 3 = " + f.FactR(3));
			Console.WriteLine(" Факториал числа 4 = " + f.FactR(4));
			Console.WriteLine(" Факториал числа 5 = " + f.FactR(5));
			Console.WriteLine();

			Console.WriteLine(" Факториалы, рассчитанные итерационным методом");
			Console.WriteLine(" Факториал числа 3 = " + f.FactI(3));
			Console.WriteLine(" Факториал числа 4 = " + f.FactI(4));
			Console.WriteLine(" Факториал числа 5 = " + f.FactI(5));
			}
		}
	}
*/
// Вывести символьную строку в обратном порядке, используя рекурсию.
