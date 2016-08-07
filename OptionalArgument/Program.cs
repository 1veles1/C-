// Продемонстрировать необязательные аргументы.
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArgument
	{
	class OptionArgDemo
		{
		static void OptArgMeth(Int32 alpha, Int32 beta = 10, Int32 gamma = 20)
			{
			Console.WriteLine(" Это аргументы alpha, beta и gamma = " + alpha + " " + beta + " " + gamma);
			}
		static void Main()
			{

			// Передать все аргументы явным образом.

			OptArgMeth(1, 2, 3);

			// Сделать аргумент gamma необязательным.

			OptArgMeth(1, 2);

			// Сделать оба аргумента beta и gamma необязательными.

			OptArgMeth(1);
			}
		}
	}	
*/
// Использовать необязательный аргумент, чтобы упростить вызов метода.

using System;

namespace OptionalArgument
	{
	class UseOptArgs
		{

		// Вывести на экран символьную строку полностью или частично.

		static void Display(String str, Int32 start = 0, Int32 stop = -1)
			{
			if(stop < 0)
				stop = str.Length;

			// Проверить условие выхода за заданные пределы.

			if(stop > str.Length | start > stop | start < 0)
				return;
			for(Int32 i = start; i < stop; i++)
				Console.Write(str[i]);

			Console.WriteLine();
			}
		static void Main()
			{
			Display("это простой тест");
			Display("это простой тест", 12);
			Display("это простой тест", 4, 14);
			}
		}
	}