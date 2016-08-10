// Пример применения оператора неявного преобразования.
/*
using System;

namespace ImplicitExplicit
	{

	// Класс для хранения трехмерных координат.

	class ThreeD
		{
		Int32 x, y, z; // // трехмерные координаты

		public ThreeD()
			{
			x = y = z = 0;
			}
		public ThreeD(Int32 i, Int32 j, Int32 k)
			{
			x = i; y = j; z = k;
			}

		// Перегрузить бинарный оператор +.

		public static ThreeD operator + (ThreeD op_1, ThreeD op_2)
			{
			ThreeD result = new ThreeD();

			result.x = op_1.x + op_2.x;
			result.y = op_1.y + op_2.y;
			result.z = op_1.z + op_2.z;

			return result;
			}

		// Неявное преобразование объекта типа ThreeD к типу Int32

		public static implicit operator Int32(ThreeD op_1)
			{
			return op_1.x * op_1.y * op_1.z;
			}

		// Вывести координаты X, Y, Z.

		public void Show()
			{
			Console.WriteLine(x + ", " + y + ", " + z);
			}
		}
	class ThreeDDemo
		{
		static void Main()
			{
			ThreeD a = new ThreeD(1, 2, 3);
			ThreeD b = new ThreeD(10, 10, 10);
			ThreeD c = new ThreeD();

			Int32 i;

			Console.Write(" Координаты точки a = ");
			a.Show();

			Console.WriteLine();

			Console.Write(" Координаты точки b = ");
			b.Show();

			Console.WriteLine();

			c = a + b; // сложить координаты точек а и b

			Console.Write(" Результат сложения a + b = ");
			c.Show();

			Console.WriteLine();

			i = a; // преобразовать в тип Int32

			Console.WriteLine(" Результат присваивания i = a = " + i);

			Console.WriteLine();

			i = a * 2 - b; // преобразовать в тип Int32

			Console.WriteLine(" Результат вычисления выражения a * 2 - b = " + i);
			}
		}
	}
*/
// Применить явное преобразование.
/*
using System;

namespace ImplicitExplicit
	{
	// Класс для хранения трехмерных координат.

	class ThreeD
		{
		Int32 x, y, z; // // трехмерные координаты

		public ThreeD()
			{
			x = y = z = 0;
			}
		public ThreeD(Int32 i, Int32 j, Int32 k)
			{
			x = i; y = j; z = k;
			}

		// Перегрузить бинарный оператор +.

		public static ThreeD operator +(ThreeD op_1, ThreeD op_2)
			{
			ThreeD result = new ThreeD();

			result.x = op_1.x + op_2.x;
			result.y = op_1.y + op_2.y;
			result.z = op_1.z + op_2.z;

			return result;
			}

		// Явное преобразование объекта типа ThreeD к типу Int32

		public static explicit operator Int32(ThreeD op_1)
			{
			return op_1.x * op_1.y * op_1.z;
			}

		// Вывести координаты X, Y, Z.

		public void Show()
			{
			Console.WriteLine(x + ", " + y + ", " + z);
			}
		}
	class ThreeDDemo
		{
		static void Main()
			{
			ThreeD a = new ThreeD(1, 2, 3);
			ThreeD b = new ThreeD(10, 10, 10);
			ThreeD c = new ThreeD();

			Int32 i;

			Console.Write(" Координаты точки a = ");
			a.Show();

			Console.WriteLine();

			Console.Write(" Координаты точки b = ");
			b.Show();

			Console.WriteLine();

			c = a + b; // сложить координаты точек а и b

			Console.Write(" Результат сложения a + b = ");
			c.Show();

			Console.WriteLine();

			i = (Int32)a; // преобразовать в тип Int32 явно, поскольку указано приведение типов

			Console.WriteLine(" Результат присваивания i = a = " + i);

			Console.WriteLine();

			i = (Int32)a * 2 - (Int32)b; // явно требуется приведение типов

			Console.WriteLine(" Результат вычисления выражения a * 2 - b = " + i);
			}
		}
	}
*/
// Создать полубайтовый тип 4-разрядных данных под названием Nybble.

using System;

namespace ImplicitExplicit
	{

	// тип 4-разрядных данных.

	class Nybble
		{
		Int32 val; // базовый тип для хранения данных
		public Nybble()
			{
			val = 0;
			}
		public Nybble(Int32 i)
			{
			val = i;
			val = val & 0xF;  // сохранить 4 младших разряда
			}

		// Перегрузить бинарный оператор + для сложения двух объектов типа Nybble.

		public static Nybble operator +(Nybble op_1, Nybble op_2)
			{
			Nybble result = new Nybble();

			result.val = op_1.val + op_2.val;
			result.val = result.val & 0xF; // сохранить 4 младших разряда			

			return result;
			}

		// Перегрузить бинарный оператор + для сложения
		// объекта типа Nybble и значения типа Int32 

		public static Nybble operator + (Nybble op_1, Int32 op_2)
			{
			Nybble result = new Nybble();

			result.val = op_1.val + op_2;
			result.val = result.val & 0xF; // сохранить 4 младших разряда

			return result;
			}
		
		// Перегрузить бинарный оператор + для сложения
		// значения типа Int32 и объекта типа Nybble.

		public static Nybble operator + (Int32 op_1, Nybble op_2)
			{
			Nybble result = new Nybble();

			result.val = op_1 + op_2.val;
			result.val = result.val & 0xF; // сохранить 4 младших разряда

			return result;
			}
		
		// Перегрузить оператор ++.

		public static Nybble operator ++ (Nybble op)
			{
			Nybble result = new Nybble();

			result.val += op.val + 1;
			result.val = result.val & 0xF; // сохранить 4 младших разряда

			return result;
			}
		
		// Перегрузить оператор >.

		public static Boolean operator > (Nybble op_1, Nybble op_2)
			{
			if(op_1.val > op_2.val)

				return true;
			else
				return false;
			}
		public static Boolean operator < (Nybble op_1, Nybble op_2)
			{
			if(op_1.val < op_2.val)

				return true;
			else
				return false;
			}

		// Преобразовать тип Nybble в тип Int32

		public static implicit operator Int32(Nybble op)
			{
			return op.val;
			}

		// Преобразовать тип Int32 в тип Nybble.

		public static implicit operator Nybble(Int32 op)
			{
			return new Nybble(op);
			}
		
		}
	class NybbleDemo
		{
		static void Main()
			{
			
			Nybble a = new Nybble(1);
			Nybble b = new Nybble(10);
			Nybble c = new Nybble();

			Int32 t;

			Console.WriteLine(" a = " + (Int32) a);
			Console.WriteLine(" b = " + (Int32) b);

			// Использовать тип Nybble в условном операторе if.

			if(a < b)
				Console.WriteLine(" а меньше b \n ");

			// Сложить два объекта типа Nybble.

			c = a + b;
				Console.WriteLine(" с после операции с = а + b = " + (Int32) c);

			// Сложить значение типа Int32 с объектом типа Nybble.

			a += 5;
				Console.WriteLine(" а после операции а += 5 = " + (Int32) a);

			Console.WriteLine();

			// Использовать тип Nybble в выражении типа Int32

			t = a * 2 + 3;
				Console.WriteLine(" Результат вычисления выражения а * 2 + 3 = " + t);

			Console.WriteLine();

			// Продемонстрировать присваивание значения типа Int32 и переполнение.

			a = 19;
				Console.WriteLine(" Результат присваивания а = 19 = " + (Int32) a);

			Console.WriteLine();

			// Использовать тип Nybble для управления циклом.

			Console.WriteLine(" Управление циклом for с помощью объекта типа Nybble.");

			for(a = 0; a < 10; a++)

				Console.Write((Int32) a + " ");

			Console.WriteLine();
			}
		}
	}
