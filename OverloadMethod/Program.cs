// Продемонстрировать перегрузку методов.
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethod
	{
	class Overload
		{
		public void OvlDemo()
			{
			Console.WriteLine(" Без параметров ");
			}

		// Перегрузка метода OvlDemo с одним целочисленным параметром.

		public void OvlDemo(Int32 a)
			{
			Console.WriteLine(" Один параметр = " + a);
			}

		// Перегрузка метода OvlDemo с двумя целочисленными параметрами.

		public Int32 OvlDemo(Int32 a, Int32 b)
			{
			Console.WriteLine(" Два параметра =  " + a + " и " + b);
			return a + b;
			}
		
		// Перегрузка метода OvlDemo с двумя параметрами типа double.

		public Double OvlDemo(Double a, Double b)
			{
			Console.WriteLine(" Два параметра типа double = " + a + " и " + b);
			return a + b;
			}
		}
	class OverloadDemo
		{
		static void Main()
			{
			Overload ob = new Overload();
			Int32 resI;
			Double resD;

			// Вызвать все варианты метода OvlDemo().

			ob.OvlDemo();

			Console.WriteLine();

			ob.OvlDemo(2);

			Console.WriteLine();

			resI = ob.OvlDemo(4, 6);

			Console.WriteLine(" Результат вызова метода ob.OvlDemo(4, 6) = " + resI);
			Console.WriteLine();

			resD = ob.OvlDemo(1.1, 2.32);

			Console.WriteLine(" Результат вызова метода ob.OvlDemo(1.1, 2.32) = " + resD);
			}
		}
	}
*/
// Неявные преобразования типов могут повлиять на
// решение перегружать метод.
/*
using System;

namespace OverloadMethod
	{
	class Overload
		{
		public void MyMeth( Int32 x)
			{
			Console.WriteLine(" В методе MyMeth(int) = " + x);
			}
		public void MyMeth(Double x)
			{
			Console.WriteLine(" В методе MyMeth(double) = " + x);
			}
		}
	class TypeConv
		{
		static void Main()
			{
			Overload ob = new Overload();

			Int32 i = 10;
			Double d = 10.1;
			Byte b = 99;
			Int16 s = 10;
			Single f = 11.5F;

			ob.MyMeth(i); // вызвать метод ob.MyMeth(int
			ob.MyMeth(d); // вызвать метод ob.MyMeth(double)

			ob.MyMeth(b); // вызвать метод ob.MyMeth(int)-- с преобразованием типа
			ob.MyMeth(s); // вызвать метод ob.MyMeth(int) -- с преобразованием типа
			ob.MyMeth(f); // вызвать метод ob.MyMeth(double) -- с преобразованием типа

			}
		}
	}
*/
// Добавить метод MyMeth(byte).

using System;

namespace OverloadMethod
	{
	class Overload
		{
		public void MyMeth(Byte x)
			{
			Console.WriteLine(" В методе MyMeth(byte) = " + x);
			}
		public void MyMeth(Int32 x)
			{
			Console.WriteLine(" В методе MyMeth(int) = " + x);
			}
		public void MyMeth(Double x)
			{
			Console.WriteLine(" В методе MyMeth(double) = " + x);
			}
		}
	class TypeConv
		{
		static void Main()
			{
			Overload ob = new Overload();

			Int32 i = 10;
			Double d = 10.1;
			Byte b = 99;
			Int16 s = 10;
			Single f = 11.5F;

			ob.MyMeth(i); // вызвать метод  ob.MyMeth(int)
			ob.MyMeth(d); // вызвать метод  ob.MyMeth(double)
			ob.MyMeth(b); // вызвать метод  ob.MyMeth(byte) --// на этот раз без преобразования типа
			ob.MyMeth(s); // вызвать метод ob.MyMeth(int) -- с преобразованием типа
			ob.MyMeth(f); // вызвать метод ob.MyMeth(double) -- с преобразованием типа
			}
		}
	}

