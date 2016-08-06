// Продемонстрировать перегрузку конструктора.
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadConstractor
	{
	class MyClass
		{
		public Int32 x;

		public MyClass()
			{
			Console.WriteLine(" В конструкторе MyClass() ");
			x = 0;
			}
		public MyClass(Int32 i)
			{
			Console.WriteLine(" В конструкторе MyClass(int) ");
			x = i;
			}
		public MyClass(Double d)
			{
			Console.WriteLine(" В конструкторе MyClass(double) ");
			x = (Int32) d;
			}
		public MyClass(Int32 i, Int32 j)
			{
			Console.WriteLine(" В конструкторе MyClass(int, int) ");
			x = i * j;
			}
		}
	class OverloadConsDemo
		{
		static void Main()
			{
			MyClass t1 = new MyClass();
			MyClass t2 = new MyClass(88);
			MyClass t3 = new MyClass(17.23);
			MyClass t4 = new MyClass(2, 4);

			Console.WriteLine(" t1.x = " + t1.x);
			Console.WriteLine(" t2.х = " + t2.x);
			Console.WriteLine(" t3.x = " + t3.x);
			Console.WriteLine(" t4.x = " + t4.x);
			}
		}
	}
*/
// Класс для хранения символов в стеке.

using System;

namespace OverloadConctractor
	{
	class Stack
		{

		// Эти члены класса являются закрытыми.

		Char[] stck; // массив, содержащий стек
		Int32 tos;   // индекс вершины стека

		// Сконструировать пустой объект класса Stack по заданному размеру стека.

		public Stack(Int32 size)
			{
			stck = new Char[size]; // распределить память для стека
			tos = 0;
			}

		// Сконструировать объект класса Stack из существующего стека.

		public Stack(Stack ob)
			{

			// Распределить память для стека.

			stck = new Char[ob.stck.Length];

			// Скопировать элементы в новый стек.

			for(Int32 i = 0; i < ob.tos; i++)
				stck[i] = ob.stck[i];

			// Установить переменную tos для нового стека.

			tos = ob.tos;
			}

		// Поместить символы в стек.

		public void Push(Char ch)
			{
			if(tos == stck.Length)
				{
				Console.WriteLine(" - Стек заполнен ");
				return;
				}
			stck[tos] = ch;
			tos++;
			}

		// Извлечь символ из стека.

		public Char Pop()
			{
			if(tos == 0)
				{
				Console.WriteLine(" - Стек пуст ");
				return (Char) 0;
				}
			tos--;
			return
				stck[tos];
			}

		// Возвратить значение true, если стек заполнен.

		public Boolean IsFull()
			{
			return tos == stck.Length;
			}

		// Возвратить значение true, если стек пуст.

		public Boolean IsEmpty()
			{
			return tos == 0;
			}
		public Int32 Capacity()
			{
			return stck.Length;
			}
		public Int32 GetNum()
			{
			return tos;
			}
		}

	// Продемонстрировать применение класса Stack.

	class StackDemo
		{
		static void Main()
			{
			Stack stk_1 = new Stack(10);

			Char ch;
			Int32 i;

			// Поместить ряд символов в стек stk_1

			Console.WriteLine(" Поместить символы А-J в стек stk_1 ");

			for(i = 0; !stk_1.IsFull(); i++)
				stk_1.Push((Char) ('A' + i));

			// Создать копию стека stck_1

			Stack stk_2 = new Stack(stk_1);

			// Вывести содержимое стека stk_1

			Console.Write(" Содержимое стека stk_1 = ");

			while(!stk_1.IsEmpty())
				{
				ch = stk_1.Pop();
				Console.Write(ch);
				}
			Console.WriteLine();

			Console.Write(" Содержимое стека stk_2 = ");

			while(!stk_2.IsEmpty())
				{
				ch = stk_2.Pop();
				Console.Write(ch);
				}

			Console.WriteLine("\n");
			}
		}
	}

