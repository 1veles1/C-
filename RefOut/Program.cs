// Использовать модификатор ref для передачи значения обычного типа по ссылке.
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
	{
	class RefTest
		{

		// Этот метод изменяет свой аргумент. Обратите
		// внимание на применение модификатора ref.

		public void Sqr(ref Int32 i)
			{
			i = i * i;
			}
		}
	class RefDemo
		{
		static void Main()
			{
			RefTest ob = new RefTest();

			Int32 a = 10;

			Console.WriteLine(" а до вызова = " + a);

			ob.Sqr(ref a); // обратите внимание на применение модификатора ref

			Console.WriteLine(" а после вызова = " + a);
			}
		}
	}
*/
// Поменять местами два значения.
/*
using System;

namespace RefOut
	{
	class ValueSwap
		{

		// Этот метод меняет местами свои аргументы.

		public void Swap(ref Int32 a, ref Int32 b)
			{
			Int32 t;
			t = a;
			a = b;
			b = t;
			} 
		}
	class ValueSwapDemo
		{
		static void Main()
			{
			ValueSwap ob = new ValueSwap();
			Int32 x = 10;
			Int32 y = 20;

			Console.WriteLine(" x и у до вызова = " + x + " " + y);

			ob.Swap(ref x, ref y);

			Console.WriteLine("х и у после вызова: " + x + " " + y);
			}
		}
	}	
*/
// Использовать модификатор параметра out.
/*
using System;

namespace RefOut
	{
	class Decompose
		{
		// Разделить числовое значение с плавающей точкой на
		// целую и дробную части.

		public Int32 GetParts(Double n, out Double frac)
			{
			Int32 whole;
			whole = (Int32) n;
			frac = n - whole; // передать дробную часть числа через параметр frac
			return whole;     // возвратить целую часть числа
			}
		}
	class UseOut
		{
		static void Main()
			{
			Decompose ob = new Decompose();

			Int32 i;
			Double f;

			i = ob.GetParts(10.125, out f);

			Console.WriteLine("Целая часть числа = " + i);
			Console.WriteLine(" Дробная часть числа = " + f);
			}
		}
	}
*/
// Использовать два параметра типа out.
/*
using System;

namespace RefOut
	{
	class Num
		{

		// Определить, имеется ли у числовых значений переменных х и v
		// общий множитель.Если имеется, то возвратить наименьший и
		// наибольший множители посредством параметров типа out

		public Boolean HasComFactor(Int32 x, Int32 y, out Int32 least, out Int32 greatest)
			{
			Int32 i;
			Int32 max = x < y ? x : y;
			Boolean first = true;

			least = 1;
			greatest = 1;

			// Найти наименьший и наибольший общий множитель.

			for(i = 2; i <= max/2; i++)
				{
				if(((y % i) == 0) & ((x % i) == 0))
					{
					if(first)
						{
						least = i;
						first = false;
						}
					greatest = i;
					}
				}
			if(least != 1) return true;
			else
				return false;
			}
		}
	class DemoOut
		{
		static void Main()
			{
			Num ob = new Num();

			Int32 lcf;
			Int32 gsf;

			if(ob.HasComFactor(231, 105, out lcf, out gsf))
				{
				Console.WriteLine(" Наименьший общий множитель чисел 231 и 105 = " + lcf);
				Console.WriteLine(" Наибольший общий множитель чисел 231 и 105 = " + gsf);
				}
			else
				Console.WriteLine(" Общий множитель у чисел 35 и 49 отсутствует ");
			
			if(ob.HasComFactor(35, 51, out lcf, out gsf))
				{
				Console.WriteLine(" Наименьший общий множитель чисел 35 и 51 = " + lcf);
				Console.WriteLine(" Наибольший общий множитель чисел 35 и 51  " + gsf);
				}
			else
				Console.WriteLine(" Общий множитель у чисел 35 и 51 отсутствует ");
			}
		}
	}
*/
// Поменять местами две ссылки.

using System;

namespace RefOut
	{
	class RefSwap
		{
		Int32 a, b;

		public RefSwap(Int32 i, Int32 j)
			{
			a = i;
			b = j;
			}
		public void Show()
			{
			Console.WriteLine(" a = {0}, b = {1} ", a, b);
			}

		// Этот метод изменяет свои аргументы.

		public void Swap(ref RefSwap ob_1,ref RefSwap ob_2)
			{
			RefSwap t;
			t = ob_1;
			ob_1 = ob_2;
			ob_2 = t;
			}
		}
	class RefSwapDemo
		{
		static void Main()
			{
			RefSwap x = new RefSwap(1, 2);
			RefSwap y = new RefSwap(3, 4);

			Console.Write("x до вызова = ");
			x.Show();

			Console.Write(" у до вызова = ");
			y.Show();

			Console.WriteLine();

			// Смена объектов, на которые ссылаются аргументы х и у

			x.Swap(ref x, ref y);

			Console.Write(" х после вызова = ");
			x.Show();

			Console.Write(" у после вызова = ");
			y.Show();
			}
		}
	}