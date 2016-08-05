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

		char[] stck; // массив, содержащий стек
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
	class Program
		{
		static void Main()
			{

			}
		}
	}
	
