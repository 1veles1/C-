using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
	{
	class Stack
		{

		// Эти члены класса являются закрытыми.

		Char[] stck; // массив, содержащий стек
		Int32 tos;   // индекс вершины стека

		// Построить пустой класс Stack для реализации стека заданного размера.
		
		public Stack(Int32 size)
			{
			stck = new Char[size]; // распределить память для стека
			tos = 0;
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
				}
			tos--;
			return stck[tos];
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

		// Возвратить общую емкость стека.

		public Int32 Capacity()
			{
			return stck.Length;
			}

		// Возвратить количество объектов, находящихся в данный момент в стеке.

		public Int32 GetNum()
			{
			return tos;
			}
		}
	class StackDemo
		{
		static void Main()
			{
			Stack stk_1 = new Stack(10);
			Stack stk_2 = new Stack(10);
			Stack stk_3 = new Stack(10);
			Char ch;
			Int32 i;

			// Поместить ряд символов в стек stk1.

			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Поместить символы A - J в стек stk_1 ");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			for(i = 0; !stk_1.IsFull(); i++)
				stk_1.Push((Char)('A' + i));
			if(stk_1.IsFull())

				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("     Стек stk_1 заполнен ");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			// Вывести содержимое стека stk1.

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("     Содержимое стека stk_1  " + "\n");

			while(!stk_1.IsEmpty())
				{
				ch = stk_1.Pop();
				Console.Write(" " + ch + " ");
				}

			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));
			
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			if(stk_1.IsEmpty())

				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("     Стек stk_1 пуст ");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			// Поместить дополнительные символы в стек stk1.

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Вновь поместить символы A-J в стек stk_1 ");

			for(i = 0; !stk_1.IsFull(); i++)
				stk_1.Push((Char) ('A' + i));

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			// А теперь извлечь элементы из стека stk1 и поместить их в стек stk2.
			// В итоге элементы сохраняются в стеке stk2 в обратном порядке.

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" А теперь извлечь символы из стека \n stk_1 и поместить их в стек stk_2 ");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			while(!stk_1.IsEmpty())
				{
				ch = stk_1.Pop();
				stk_2.Push(ch);
				}

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("    Содержимое стека stk_2 " + "\n");

			while(!stk_2.IsEmpty())
				{
				ch = stk_2.Pop();
				Console.Write(" " + ch + " ");
				}

			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			// Поместить 5 символов в стек.

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Поместить 5 символов в стек stk_3 ");

			for(i = 0; i < 5; i++)
				stk_3.Push((Char) ('A' + i));

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Емкость стека stk_3 = " + stk_3.Capacity());

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Количество объектов в стеке stk_3 = " + stk_3.GetNum());

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 41));

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 7));

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" Done ! ");

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(new String('-', 7));

			Console.ReadLine();
			Console.Beep();
			}
		}
	}
	
