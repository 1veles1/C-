// Использовать модификатор static.
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
	{
	class StaticDemo
		{

		// Переменная типа static.

		public static Int32 Val = 100;

		// Метод типа static.
		
		public static Int32 ValDiv2()
			{
			return Val / 2;
			}		
		}
	class SDemo
		{
		static void Main()
			{

			Console.WriteLine(" Исходное значение переменной  StaticDemo.Val = " + StaticDemo.Val);

			StaticDemo.Val = 8;

			Console.WriteLine(" Текущее значение переменной StaticDemo.Val = " + StaticDemo.Val);

			Console.WriteLine(" StaticDemo.ValDiv2() = " + StaticDemo.ValDiv2());
			}
		}
	}
*/
// Использовать поле типа static для подсчета экземпляров существующих объектов.
/*
using System;

namespace Static
	{
	class CountInst
		{
		static Int32 count = 0;

		// Инкрементировать подсчет, когда создается объект.

		public CountInst()
			{
			count++;
			}

		// Декрементировать подсчет, когда уничтожается объект.

		~CountInst()
			{
			count--;
			}
		public static Int32 GetCount()
			{
			return count;
			}
		}
	class CountDemo
		{
		static void Main()
			{
			CountInst ob;

			for(Int32 i = 0; i < 10; i++)
				{
				ob = new CountInst();

				Console.WriteLine(" Текущий подсчет = " + CountInst.GetCount());
				}

			}
		}
	}
*/
// Использовать статическую фабрику класса.

using System;

namespace Static
	{
	class MyClass
		{
		Int32 a, b;

		// Создать фабрику для класса MyClass.

		static public MyClass Factory(Int32 i, Int32 j)
			{
			MyClass t = new MyClass();

			t.a = i;
			t.a = j;

			return t; //  возвратить объект
			}
		public void Show()
			{
			Console.WriteLine("а и b = " + a + " " + b);
			}
		}
	class MakeObjects
		{
		static void Main()
			{
			Int32 i, j;

			// Сформировать объекты, используя фабрику.

			for(i = 0, j = 10; i < 10; i++, j--)
				{
				MyClass ob = MyClass.Factory(i, j); //  создать объект
				ob.Show();
				}
			Console.WriteLine();
			}
		}
	}