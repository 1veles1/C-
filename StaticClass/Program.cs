// Продемонстрировать применение статического класса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
	{
	static class NumericFn
		{

		// Возвратить обратное числовое значение.

		static public Double Reciprocal(Double num)
			{
			return 1 / num;
			}

		// Возвратить дробную часть числового значения.

		static public Double FracPart(Double num)
			{
			return num - (Int32) num;
			}
		
		// Возвратить логическое значение true, если числовое
		// значение переменной num окажется четным.

		static public Boolean IsEven(Double num)
			{
			return (num % 2) == 0 ? true : false; 
			}

		// Возвратить логическое значение true, если числовое
		// значение переменной num окажется нечетным.

		static public Boolean IsOdd(Double num)
			{
			return !IsEven(num);
			}
		}
	class StaticClassDemo
		{
		static void Main()
			{
			Console.WriteLine(" Обратная величина числа 5 = " + NumericFn.Reciprocal(5));
			Console.WriteLine(" Дробная часть числа 4.234 = " + NumericFn.FracPart(4.234));

			if(NumericFn.IsEven(10))
				 Console.WriteLine(" 10 — четное число ");

			if(NumericFn.IsOdd(5))
				 Console.WriteLine(" 5 — нечетное число ");


			// Далее следует попытка создать экземпляр объекта класса NumericFn,
			// что может стать причиной появления ошибки.
			
			// NumericFn ob = new NumericFn(); // Ошибка!
			}
		}

	}
	
