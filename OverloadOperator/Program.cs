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
/*
using System;

// Класс для хранения трехмерных координат.
class ThreeD
	{
	Int32 х, у, z; // трехмерные координаты
	public ThreeD() { х = у = z = 0; }
	public ThreeD(Int32 i, Int32 j, Int32 k) { х = i; у = j; z = k; }

	// Перегрузить бинарный оператор +.

	public static ThreeD operator +(ThreeD op1, ThreeD op2)
		{
		ThreeD result = new ThreeD();

		// Сложить координаты двух точек и возвратить результат. 

		result.х = op1.х + op2.х;
		result.у = op1.у + op2.у;
		result.z = op1.z + op2.z;

		return result;
		}
	
		// Перегрузить бинарный оператор -.
	public static ThreeD operator -(ThreeD op1, ThreeD op2)
		{
		ThreeD result = new ThreeD();

		// Обратить внимание на порядок следования операндов:
		// op1 — левый операнд, ор2 — правый операнд. 

		result.х = op1.х - op2.х;
		result.у = op1.у - op2.у;
		result.z = op1.z - op2.z;

		return result;
		}
	
		// Перегрузить унарный оператор -.
	public static ThreeD operator -(ThreeD op)
		{
		ThreeD result = new ThreeD();

		result.х = -op.х;
		result.у = -op.у;
		result.z = -op.z;

		return result;
		}
		
		
		// Перегрузить унарный оператор ++.
	public static ThreeD operator ++(ThreeD op)
		{
		ThreeD result = new ThreeD();

		// Возвратить результат инкрементирования.

		result.х = op.х + 1;
		result.у = op.у + 1;
		result.z = op.z + 1;

		return result;
		}
	
		// Вывести координаты X, Y, Z.
	public void Show()
		{
		Console.WriteLine(х + ", " + у + ", " + z);
		}
	}
class ThreeDDemo
	{
	static void Main()
		{

		Console.ForegroundColor = ConsoleColor.DarkCyan;

		Console.WriteLine();

		ThreeD a = new ThreeD(1, 2, 3);
		ThreeD b = new ThreeD(10, 10, 10);
		ThreeD c = new ThreeD();

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

		c = a + b + c; // сложить координаты точек a, b и с

		Console.Write(" Результат сложения a + b + с = ");
		c.Show();

		Console.WriteLine();

		c = c - a; // вычесть координаты точки а

		Console.Write(" Результат вычитания с - а = ");
		c.Show();

		Console.WriteLine();

		c = c - b; // вычесть координаты точки b
		Console.Write(" Результат вычитания с - b  ");
		c.Show();

		Console.WriteLine();

		c = -a; // присвоить точке с отрицательные координаты точки а
		Console.Write(" Результат присваивания - а = ");

		c.Show();

		Console.WriteLine();

		c = a++; // присвоить точке с координаты точки а,
				 // а затем инкрементировать их

		Console.WriteLine(" Если с = а++ ");

		Console.Write(" то координаты точки с = ");
		c.Show();

		Console.Write(" а координаты точки а = ");
		a.Show();

		// Установить исходные координаты (1,2,3) точки а

		a = new ThreeD(1, 2, 3);

		Console.Write(" \n Установка исходных координат точки а = ");
		a.Show();

		c = ++a; // инкрементировать координаты точки а,
				 // а затем присвоить их точке с

		Console.WriteLine(" \n Если с = ++а ");

		Console.Write(" то координаты точки с = ");
		c.Show();

		Console.Write(" а координаты точки а = ");
		a.Show();

		Console.WriteLine();
		}
	}
*/
// Перегрузить бинарный оператор + дважды:
// один раз - для сложения объектов класса ThreeD,
// а другой раз — для сложения объекта типа ThreeD и целого значения типа int.
/*
using System;

namespace OverloadOperator
	{
	class ThreeD
		{
		Int32 x, y, z; // трехмерные координаты

		public ThreeD()
			{
			x = y = z = 0;
			}
		public ThreeD(Int32 i, Int32 j, Int32 k)
			{
			x = i; y = j; z = k;
			}

		// Перегрузить бинарный оператор + для сложения объектов класса ThreeD.

		public static ThreeD operator + (ThreeD op_1, ThreeD op_2)
			{
			ThreeD result = new ThreeD();

			// Сложить координаты двух точек и возвратить результат.

			result.x = op_1.x + op_2.x;
			result.y = op_1.y + op_2.y;
			result.z = op_1.z + op_2.z;

			return result;
			}

		// Перегрузить бинарный оператор + для сложения
		// объекта типа ThreeD и целого значения типа int.

		public static ThreeD operator + (ThreeD op_1, Int32 op_2)
			{
			ThreeD result = new ThreeD();

			result.x = op_1.x + op_2;
			result.y = op_1.y + op_2;
			result.z = op_1.z + op_2;

			return result;
			}

		// Вывести координаты X, Y, Z.

		public void Show()
			{
			Console.WriteLine(x + "," + y + "," + z);
			}
		}
	class ThreeDDemo
		{
		static void Main()
			{
			ThreeD a = new ThreeD(1, 2, 3);
			ThreeD b = new ThreeD(10, 10, 10);
			ThreeD c = new ThreeD();

			Console.Write(" Координаты точки a = ");
			a.Show();

			Console.WriteLine();

			Console.Write(" Координаты точки b = ");
			b.Show();

			Console.WriteLine();

			c = a + b; // сложить объекты класса ThreeD

			Console.Write(" Результат сложения a + b = ");
			c.Show();

			Console.WriteLine();

			c = b + 10; //  сложить объект типа ThreeD и целое значение типа Int32

			Console.Write(" Результат сложения b + 10 = ");
			c.Show();
			}
		}
	}
*/
// Перегрузить бинарный оператор + трижды:
// один раз — для сложения объектов класса ThreeD,
// второй раз — для сложения объекта типа ThreeD и целого значения типа int,
// а третий раз — для сложения целого значения типа int и объекта типа ThreeD.
/*
using System;

namespace OverloadOperator
	{

	// Класс для хранения трехмерных координат.

	class ThreeD
		{
		Int32 x, y, z; // трехмерные координаты

		public ThreeD()
			{
			x = y = z = 0;
			}
		public ThreeD(Int32 i, Int32 j, Int32 k)
			{
			x = i; y = j; z = k;
			}

		// Перегрузить бинарный оператор + для сложения объектов класса ThreeD.

		public static ThreeD operator +(ThreeD op_1, ThreeD op_2)
			{
			ThreeD result = new ThreeD();

			// Сложить координаты двух точек и возвратить результат.

			result.x = op_1.x + op_2.x;
			result.y = op_1.y + op_2.y;
			result.z = op_1.z + op_2.z;

			return result;
			}

		// Перегрузить бинарный оператор + для сложения
		// объекта типа ThreeD и целого значения типа int.

		public static ThreeD operator +(ThreeD op_1, Int32 op_2)
			{
			ThreeD result = new ThreeD();

			result.x = op_1.x + op_2;
			result.y = op_1.y + op_2;
			result.z = op_1.z + op_2;

			return result;
			}

		// Перегрузить бинарный оператор + для сложения
		// целого значения типа int и объекта типа ThreeD.

		public static ThreeD operator + (Int32 op_1, ThreeD op_2)
			{
			ThreeD result = new ThreeD();

			result.x = op_1 + op_2.x;
			result.y = op_1 + op_2.y;
			result.z = op_1 + op_2.y;

			return result;
			}

		// Вывести координаты X, Y, Z.

		public void Show()
			{
			Console.WriteLine(x + "," + y + "," + z);
			}
		}
	class ThreeDDemo
		{
		static void Main()
			{
			ThreeD a = new ThreeD(1, 2, 3);
			ThreeD b = new ThreeD(10, 10, 10);
			ThreeD c = new ThreeD();

			Console.Write(" Координаты точки a = ");
			a.Show();

			Console.WriteLine();

			Console.Write(" Координаты точки b = ");
			b.Show();

			Console.WriteLine();

			c = a + b; // сложить объекты класса ThreeD

			Console.Write(" Результат сложения a + b = ");
			c.Show();

			Console.WriteLine();

			c = b + 10; //  сложить объект типа ThreeD и целое значение типа Int32

			Console.Write(" Результат сложения b + 10 = ");
			c.Show();

			c = 15 + b; // сложить целое значение типа Int32 и объект типа ThreeD

			Console.Write(" Результат сложения 15 + b = ");
			c.Show();
			}
		}
	}
*/
// Перегрузить операторы < и >.
/*
using System;

namespace OverloadOperator
	{

	// Класс для хранения трехмерных координат.

	class ThreeD
		{
		Int32 x, y, z; // трехмерные координаты
		public ThreeD() { x = y = z = 0; }
		public ThreeD(Int32 i, Int32 j, Int32 k) { x = i; y = j; z = k; }

		// Перегрузить оператор <.

		public static Boolean operator <(ThreeD op1, ThreeD op2)
			{
			if(Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z * op1.z) <

				Math.Sqrt(op2.x * op2.x + op2.y * op2.y + op2.z * op2.z))

				return true;
			else
				return false;
			}

		// Перегрузить оператор >.

		public static Boolean operator >(ThreeD op1, ThreeD op2)
			{
			if(Math.Sqrt(op1.x * op1.x + op1.y * op1.y + op1.z * op1.z) >

				Math.Sqrt(op2.x * op2.x + op2.y * op2.y + op2.z * op2.z))
				return true;
			else
				return false;
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
			ThreeD a = new ThreeD(5, 6, 7);
			ThreeD b = new ThreeD(10, 10, 10);
			ThreeD c = new ThreeD(1, 2, 3);
			ThreeD d = new ThreeD(6, 7, 5);

			Console.Write("Координаты точки a: ");
			a.Show();

			Console.Write("Координаты точки b: ");
			b.Show();

			Console.Write("Координаты точки с: ");
			c.Show();

			Console.Write("Координаты точки d: ");
			d.Show();

			Console.WriteLine();

			if(a > c)
				Console.WriteLine(" а > с истинно ");
			if(a < c)
				Console.WriteLine(" а < с истинно ");
			if(a > b)
				Console.WriteLine(" а > b истинно ");
			if(a < b)
				Console.WriteLine(" а < b истинно ");
			if(a > d)
				Console.WriteLine(" а > d истинно ");

			else if(a < d)
				Console.WriteLine(" a < d истинно ");

			else Console.WriteLine(" Точки a и d находятся на одном расстоянии от начала отсчета ");
			}
		}
	}
*/
// Перегрузить операторы true и false для класса ThreeD.
/*
using System;

namespace OverloadOperator
	{
	class ThreeD
		{
		Int32 x, y, z; //  трехмерные координаты

		public ThreeD()
			{
			x = y = z = 0;
			}
		public ThreeD(Int32 i, Int32 j, Int32 k)
			{
			x = i; y = j; z = k;
			}

		// Перегрузить оператор true.
		public static bool operator true(ThreeD op)
			{
			if((op.x != 0) || (op.y != 0) || (op.z != 0))
				return true; // хотя бы одна координата не равна нулю
			else
				return false;
			}

		// Перегрузить оператор false.
		public static bool operator false(ThreeD op)
			{
			if((op.x == 0) && (op.y == 0) && (op.z == 0))
				return true; // все координаты равны нулю
			else
				return false;
			}

		// Перегрузить унарный оператор --.
		public static ThreeD operator --(ThreeD op)
			{
			ThreeD result = new ThreeD();

			// Возвратить результат декрементирования.
			result.x = op.x - 1;
			result.y = op.y - 1;
			result.z = op.z - 1;

			return result;
			}

		// Вывести координаты X, Y, Z.
		public void Show()
			{
			Console.WriteLine(x + ", " + y + ", " + z);
			}
		}
	class TrueFalseDemo
		{
		static void Main()
			{

			ThreeD a = new ThreeD(5, 6, 7);
			ThreeD b = new ThreeD(10, 10, 10);
			ThreeD c = new ThreeD(0, 0, 0);

			Console.Write(" Координаты точки a = ");
			a.Show();

			Console.Write(" Координаты точки b = ");
			b.Show();

			Console.Write(" Координаты точки с = ");
			c.Show();

			Console.WriteLine();

			if(a)
				Console.WriteLine(" Точка а истинна.");
			else
				Console.WriteLine(" Точка а ложна.");
			if(b)
				Console.WriteLine(" Точка b истинна.");
			else
				Console.WriteLine(" Точка b ложна.");
			if(c)
				Console.WriteLine(" Точка с истинна.");
			else
				Console.WriteLine(" Точка с ложна.");
 
			Console.WriteLine();

			Console.WriteLine(" Управление циклом с помощью объекта класса ThreeD.");

			do
				{
				b.Show();
				b--;
				}

			while(b);
			}
		}
	}
*/
// Простой способ перегрузки логических операторов
// !, | и & для объектов класса ThreeD.
/*
using System;

namespace OverloadOperator
	{
	class ThreeD
		{
		Int32 x, y, z; // трехмерные координаты

		public ThreeD()
			{
			x = y = z = 0;
			}
		public ThreeD(Int32 i, Int32 j, Int32 k)
			{
			x = i; y = j; z = k;
			}

		// Перегрузить логический оператор |.
		public static Boolean operator |(ThreeD op1, ThreeD op2)
			{
			if(((op1.x != 0) || (op1.y != 0) || (op1.z != 0)) | ((op2.x != 0) || (op2.y != 0) || (op2.z != 0)))

				return true;
			else
				return false;
			}

		// Перегрузить логический оператор &.
		public static Boolean operator &(ThreeD op1, ThreeD op2)
			{
			if(((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) & ((op2.x != 0) && (op2.y != 0) && (op2.z != 0)))

				return true;
			else
				return false;
			}

		// Перегрузить логический оператор !.
		public static bool operator !(ThreeD op)
			{
			if((op.x != 0) || (op.y != 0) || (op.z != 0))

				return false;
			else
				return true;
			}

		// Вывести координаты X, Y, Z.
		public void Show()
			{
			Console.WriteLine(x + ", " + y + ", " + z);
			}
		}
	class TrueFalseDemo
		{
		static void Main()
			{

			ThreeD a = new ThreeD(5, 6, 7);
			ThreeD b = new ThreeD(10, 10, 10);
			ThreeD c = new ThreeD(0, 0, 0);

			Console.Write(" Координаты точки a = ");
			a.Show();

			Console.Write(" Координаты точки b = ");
			b.Show();

			Console.Write(" Координаты точки с = ");
			c.Show();

			Console.WriteLine();

			if(!a)
				Console.WriteLine(" Точка а ложна.");
			if(!b)
				Console.WriteLine(" Точка b ложна.");
			if(!c)
				Console.WriteLine(" Точка с ложна.");

			Console.WriteLine();

			if(a & b)
				Console.WriteLine(" a & b истинно.");
			else
				Console.WriteLine(" a & b ложно.");
			if(a & c)
				Console.WriteLine(" a & с истинно.");
			else
				Console.WriteLine(" a & с ложно.");
			if(a | b)
				Console.WriteLine(" a | b истинно.");
			else
				Console.WriteLine(" a | b ложно.");
			if(a | c)
				Console.WriteLine(" a | с истинно.");
			else
				Console.WriteLine(" a | с ложно.");
			}
		}
	}
*/
// Более совершенный способ перегрузки логических операторов !, | и & для объектов класса ThreeD.
// В этом варианте укороченные логические операторы && и || становятся доступными для применения автоматически.
/*
using System;

namespace OverloadOperator
	{
	class ThreeD
		{
		Int32 x, y, z; // трехмерные координаты

		public ThreeD()
			{
			x = y = z = 0;
			}
		public ThreeD(Int32 i, Int32 j, Int32 k)
			{
			x = i; y = j; z = k;
			}
		
		// Перегрузить логический оператор | для укороченного вычисления.

		public static ThreeD operator |(ThreeD op1, ThreeD op2)
			{
			if(((op1.x != 0) || (op1.y != 0) || (op1.z != 0)) | ((op2.x != 0) || (op2.y != 0) || (op2.z != 0)))

				return new ThreeD(1, 1, 1);
			else
				return new ThreeD(0, 0, 0);
			}
		
		// Перегрузить логический оператор & для укороченного вычисления.

		public static ThreeD operator &(ThreeD op1, ThreeD op2)
			{
			if(((op1.x != 0) && (op1.y != 0) && (op1.z != 0)) & ((op2.x != 0) && (op2.y != 0) && (op2.z != 0)))

				return new ThreeD(1, 1, 1);
			else
				return new ThreeD(0, 0, 0);
			}
		
		// Перегрузить логический оператор !.

		public static Boolean operator !(ThreeD op)
			{
			if(op)
				return false;
			else
				return true;
			}
		
		// Перегрузить оператор true.

		public static Boolean operator true(ThreeD op)
			{
			if((op.x != 0) || (op.y != 0) || (op.z != 0))

				return true; // хотя бы одна координата не равна нулю
			else
				return false;
			}
		
		// Перегрузить оператор false.

		public static Boolean operator false(ThreeD op)
			{
			if((op.x == 0) && (op.y == 0) && (op.z == 0))
				return true; // все координаты равны нулю
			else
				return false;
			}

		// Ввести координаты X, Y, Z.

		public void Show()
			{
			Console.WriteLine(x + ", " + y + ", " + z);
			}
		}
	class TrueFalseDemo
		{
		static void Main()
			{

			ThreeD a = new ThreeD(5, 6, 7);
			ThreeD b = new ThreeD(10, 10, 10);
			ThreeD c = new ThreeD(0, 0, 0);

			Console.Write(" Координаты точки a = ");
			a.Show();

			Console.Write(" Координаты точки b = ");
			b.Show();

			Console.Write(" Координаты точки с = ");
			c.Show();

			Console.WriteLine();

			if(a)
				Console.WriteLine(" Точка а истинна.");
			if(b)
				Console.WriteLine(" Точка b истинна.");
			if(c)
				Console.WriteLine(" Точка с истинна.");
			if(!a)
				Console.WriteLine(" Точка а ложна.");
			if(!b)
				Console.WriteLine(" Точка b ложна.");
			if(!c)
				Console.WriteLine(" Точка с ложна.");

			Console.WriteLine();

			Console.WriteLine(" Применение логических операторов & и |");

			if(a & b)
				Console.WriteLine(" а & b истинно.");
			else
				Console.WriteLine(" а & b ложно.");
			if(a & c)
				Console.WriteLine(" а & с истинно.");
			else
				Console.WriteLine(" а & с ложно.");
			if(a | b)
				Console.WriteLine(" a | b истинно.");
			else
				Console.WriteLine(" а | b ложно.");
			if(a | c)
				Console.WriteLine(" а | с истинно.");
			else
				Console.WriteLine(" а | с ложно.");

			Console.WriteLine();

			// А теперь применить укороченные логические операторы.

			Console.WriteLine(" Применение укороченных логических операторов && и ||");

			if(a && b)
				Console.WriteLine(" a && b истинно.");
			else
				Console.WriteLine(" а && b ложно.");
			if(a && c)
				Console.WriteLine(" а && с истинно.");
			else
				Console.WriteLine(" a && с ложно.");
			if(a || b)
				Console.WriteLine(" a || b истинно.");
			else
				Console.WriteLine(" a || b ложно.");
			if(a || c)
				Console.WriteLine(" a || с истинно.");
			else
				Console.WriteLine(" a || с ложно.");
			}
		}
	}
*/