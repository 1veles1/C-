// Продемонстрировать применение модификатора params
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
	{
	class Min
		{
		public Int32 MinVal(params Int32[] nums)
			{
			Int32 m;

			if(nums.Length == 0)
				{
				Console.WriteLine(" Ошибка =  нет аргументов ");
				return 0;
				}
			m = nums[0];
			for(Int32 i = 1; i < nums.Length; i++) 
			if(nums[i] < m)
				m = nums[i];
			return m;
			}
		}
		class ParamsDemo
		{
		static void Main()
			{
			Min ob = new Min();
			Int32 min;
			Int32 a = 10;
			Int32 b = 20;

			// Вызвать метод с двумя значениями.

			min = ob.MinVal(a, b);

			Console.WriteLine(" Наименьшее значение = " + min);

			// Вызвать метод с тремя значениями.

			min = ob.MinVal(a, b, -1);

			Console.WriteLine(" Наименьшее значение = " + min);

			// Вызвать метод с пятью значениями.

			min = ob.MinVal(18, 23, 3, 14, 25);

			Console.WriteLine(" Наименьшее значение = " + min);

			// Вызвать метод с массивом целых значений.

			Int32[] args = { 45, 67, 34, 9, 112, 8 };

			min = ob.MinVal(args);

			Console.WriteLine(" Наименьшее значение = " + min);
			}
		}
	}
*/
// Использовать обычный параметр вместе с параметром
// переменной длины типа params.	

using System;

namespace Params
	{
	class MyClass
		{
		public void ShowArgs(String msg, params Int32[] nums)
			{
			Console.Write(msg + " ");

			foreach(Int32 i in nums)
				Console.Write(i + " ");
			
			Console.WriteLine();
			}
		}
	class ParamsDemo
		{
		static void Main()
			{
			MyClass ob = new MyClass();

			ob.ShowArgs(" Это ряд целых чисел ", 1, 2, 3, 4, 5);
			ob.ShowArgs(" А это еще два целых числа ", 17, 20);
			}
		}	
	}