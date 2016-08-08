// Пример перегрузки бинарных операторов.
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperator
	{

	// Класс для хранения трехмерных координат.

	class TreeD {
		Int32 x, y, z; // трехмерные координаты

		public TreeD()
			{
			x = y = z = 0;
			}
		public TreeD(Int32 i, Int32 j, Int32 k)
			{
			x = i; y = j; z = k;
			}

		// Перегрузить бинарный оператор +.

		public static TreeD operator + (TreeD op_1, TreeD op_2)
			{
			TreeD result = new TreeD();

			// Сложить координаты двух точек и возвратить результат.

			result.x = op_1.x + op_2.x; // Эти операторы выполняют
			result.y = op_1.y + op_2.y; // целочисленное сложение,
			result.z = op_1.z + op_2.z; // сохраняя свое исходное назначение.

			return result;
			}

		// Перегрузить бинарный оператор -.

		public static TreeD operator - (TreeD op_1, TreeD op_2)
			{
			TreeD result = new TreeD();

			// Обратите внимание на порядок следования операндов:
			// op_1 — левый операнд, а ор_2 — правый операнд. 

			result.x = op_1.x - op_2.x; // Эти операторы
			result.y = op_1.y - op_2.y; // выполняют целочисленное
			result.z = op_1.z - op_2.z; // вычитание

			return result;
			}

		// Вывести координаты X, Y, Z.

		public void Show()
			{
			Console.WriteLine(" " + x + ", " + y + ", " + z);
			}
		}
	class TreeDDemo
		{
		static void Main()
			{

			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine();

			TreeD a = new TreeD(1, 2, 3);
			TreeD b = new TreeD(10, 10, 10);
			TreeD c;

			Console.Write(" Координаты точки a = ");
			a.Show();

			Console.WriteLine();

			Console.Write(" Координаты точки b = ");
			b.Show();

			Console.WriteLine();

			c = a + b; //  сложить координаты точек а и b

			Console.Write(" Результат сложения а + b = ");
			c.Show();

			Console.WriteLine();

			c = a + b + c; // сложить координаты точек а, b и с

			Console.Write(" Результат сложения а + b + с = ");
			c.Show();

			Console.WriteLine();

			c = c - a; // вычесть координаты точки а

			Console.Write(" Результат вычитания с - а = ");
			c.Show();

			Console.WriteLine();

			c = c - b; // вычесть координаты точки b

			Console.Write(" Результат вычитания с - b = ");
			c.Show();

			Console.WriteLine();
			}
		}
	}
*/
// Пример перегрузки бинарных и унарных операторов.


