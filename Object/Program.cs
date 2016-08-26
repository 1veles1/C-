// Продемонстрировать применение метода ToString()
/*
using System;


namespace Object
	{
	class MyClass
		{
		static Int32 count = 0;
		Int32 id;

		public MyClass()
			{
			id = count;
			count++;
			}
		public override String ToString()
			{
			return
				"Объект" + id + " типа MyClass";
			}
		}
	class Test
		{
		static void Main()
			{
			MyClass ob1 = new MyClass();
			MyClass ob2 = new MyClass();
			MyClass ob3 = new MyClass();

			Console.WriteLine(ob1);
			Console.WriteLine(ob2);
			Console.WriteLine(ob3);
			}
		}
	}
*/
// Простой пример упаковки и распаковки.
/*
using System;

namespace Object
	{
	class BoxingDemo
		{
		static void Main()
			{
			Int32 x;

			object obj;

			x = 10;
			obj = x;				 // упаковать значение переменной х в объект

			Int32 y = (Int32)obj;    // распаковать значение из объекта, доступного по ссылке obj, в переменную типа Int32	 

			Console.WriteLine(y);
			}
		}
	}
*/
// Пример упаковки при передаче значения методу.
/*
using System;

namespace Object
	{
	class BoxingDemo
		{
		static void Main()
			{
			Int32 x;

			x = 10;

			Console.WriteLine("Значение x = " + x);

			// значение переменной x автоматически упаковывается когда оно передается методу Sqr().

			x = BoxingDemo.Sqr(x);

			Console.WriteLine("Значение x в квадрате = " + x);
			}
		static Int32 Sqr(object o)
			{
			return
				(Int32) o * (Int32) o;
			}
		}
	}
*/
// Благодаря упаковке становится возможным вызов методов по значению!
/*
using System;

namespace Object
	{	
	class MethOnValue
		{
		static void Main()
			{
			Console.WriteLine(10.ToString());
			}
		}
	}
*/
// Использовать класс object для создания массива "обобщенного" типа.

using System;

namespace Object
	{
	class GenericDemo
		{
		static void Main()
			{
			object[] ga = new object[10];

			// Сохранить целые значения.

			for(Int32 i = 0; i < 3; i++)
				ga[i] = i;

			// Сохранить значения типа Double.

			for(Int32 i = 3; i < 6; i++)
				ga[i] = (Double) i / 2;

			// Сохранить две строки, а также значения типа Boolean и Char.

			ga[6] = "Привет";
			ga[7] = true;
			ga[8] = 'X';
			ga[9] = "Конец";

			for(Int32 i = 0; i < ga.Length; i++)

			Console.WriteLine("ga[" + i + "]: " + ga[i] + " ");
			}
		}
	}