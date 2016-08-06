
// Возвратить массив из метода.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnArrayFromMethod
	{
	class Factor
		{

		// Метод возвращает массив facts, содержащий множители аргумента num.
		// При возврате из метода параметр numfactors типа out будет содержать
		// количество обнаруженных множителей.

		public Int32[] FindFactors(Int32 num, out Int32 numfactors)
			{
			Int32[] facts = new Int32[80]; // размер массива 80 выбран произвольно
			Int32 i, j;

			// Найти множители и поместить их в массив facts.
			
			for(i = 2, j = 0; i < num / 2 + 1; i++)
				if((num % i) == 0)
					{
					facts[j] = i;
					j++;
					}
			numfactors = j;
			return facts;
			}
		}
	class FindFactors
		{
		static void Main()
			{
			Factor f = new Factor();
			Int32 numfactors;
			Int32[] factors;

			factors = f.FindFactors(1000, out numfactors);

			Console.WriteLine(" Множители числа 1000 = ");

			for(Int32 i = 0; i < numfactors; i++)
				Console.WriteLine(factors[i] + " ");

			Console.WriteLine();
			}
		}
	}
	
