// Пример передачи объектов методам по ссылке.
/*
using System;

namespace trahsmission
	{
	class MyClass
		{
		int alpha, beta;
		public MyClass(int i, int j)
			{
			alpha = i;
			beta = j;
			}

		// Возвратить значение true, если параметр ob
		// имеет те же значения, что и вызывающий объект.

		public bool SameAs(MyClass ob)
			{
			if((ob.alpha == alpha) & (ob.beta == beta))
				return true;
			else return false;
			}

		// Сделать копию объекта ob.

		public void Copy(MyClass ob)
			{
			alpha = ob.alpha;
			beta = ob.beta;
			}
		public void Show()
			{
			Console.WriteLine("alpha: {0}, beta: {1}", alpha, beta);
			}
		}
	class PassOb
		{
		static void Main()
			{
			MyClass ob1 = new MyClass(4, 5);
			MyClass ob2 = new MyClass(6, 7);

			Console.Write("ob1: ");
			ob1.Show();

			Console.Write("ob2: ");
			ob2.Show();
			if(ob1.SameAs(ob2))
				Console.WriteLine("ob1 и ob2 имеют одинаковые значения.");
			else
				Console.WriteLine("ob1 и ob2 имеют разные значения.");
			Console.WriteLine();

			// А теперь сделать объект ob1 копией объекта ob2.

			ob1.Copy(ob2);
			Console.Write("оЫ после копирования: ");
			ob1.Show();
			if(ob1.SameAs(ob2))
				Console.WriteLine("ob1 и ob2 имеют одинаковые значения.");
			else
				Console.WriteLine("ob1 и ob2 имеют разные значения.");
			}
		}
	}
*/
// Передача аргументов обычных типов по значению.
/*
using System;

namespace transmission
	{
	class Test
		{

		// Этот метод не оказывает никакого влияния на
		// аргументы, используемые для его вызова.

		public void NoChange(Int32 i, Int32 j)
			{
			i = i + j;
			j = -j;
			}
		}
	class CallByValue
		{
		static void Main()
			{
			Test ob = new Test();

			Int32 a = 15;
			Int32 b = 20;

			Console.WriteLine(" а и b до вызова = " + a + " " + b);

			ob.NoChange(a, b);

			Console.WriteLine(" а и b после вызова: " + a + " " + b);
			}
		}
	}
*/
// Передача объектов по ссылке.

using System;

namespace transmisssion
	{
	class Test
		{
		public Int32 a, b;

		public Test(Int32 i, Int32 j)
			{
			a = i;
			b = j;
			}

		// Передать объект.Теперь переменные ob.а и ob.b из объекта,
		// используемого в вызове метода, будут изменены. 

		public void Change(Test ob)
			{
			ob.a = ob.a + ob.b;
			ob.b = -ob.b;
			}
		}
	class CallByRef
		{
		static void Main()
			{
			Test ob = new Test(15, 20);

			Console.WriteLine(" ob.а и ob.b до вызова = " + ob.a + " " + ob.b);

			ob.Change(ob);

			Console.WriteLine(" ob.а и ob.b после вызова = " + ob.a + " " + ob.b);

			}
		}
	}