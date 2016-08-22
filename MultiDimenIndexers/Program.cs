// Двумерный отказоустойчивый массив.
using System;


namespace MultiDimenIndexers
	{
	class FailSoftArray2D
		{
		Int32[,] a;					// ссылка на базовый двумерный массив
		Int32 rows, cols;			// размеры массива

		public Int32 Lenght;		// открытая переменная длины массива
		public Boolean ErrFlag;     // обозначает результат последней операции

			// Построить массив заданных размеров.

		public FailSoftArray2D(Int32 r, Int32 c)
			{
			rows = r;
			cols = c;

			a = new Int32[rows, cols];
			Lenght = rows * cols;
			}

			// Это индексатор для класса FailSoftArray2D.

		public Int32 this[Int32 index_1, Int32 index_2]
			{

			// Это аксессор get.

			get
				{
				if(ok(index_1, index_2))
					{
					ErrFlag = false;
					return
						a[index_1, index_2];
					}
				else
					{
					ErrFlag = true;
					return 
						0; 
					}
				}

			// Это аксессор set.

			set
				{
				if(ok(index_1, index_2))
					{
					a[index_1, index_2] = value;
					ErrFlag = false;
					}
				else
					{
					ErrFlag = true;
					}
				}
			}

		// Возвратить логическое значение true, если индексы находятся в установленных пределах.

		private Boolean ok(Int32 index_1, Int32 index_2)
			{
			if(index_1 >= 0 & index_1 < rows & index_2 >= 0 & index_2 < cols)
				return
					true;
			return
				false;
			}
		}

			// Продемонстрировать применение двумерного индексатора.

	class TwoDIndexerDemo
		{
		static void Main()
			{

			Console.ForegroundColor = ConsoleColor.DarkCyan;
			 
			FailSoftArray2D fs = new FailSoftArray2D(3, 5);
			Int32 x;

			// Выявить скрытые сбои.

			Console.WriteLine(" Скрытый сбой ");

			for(Int32 i = 0; i < 6; i++)
				fs[i, i] = i * 10;

			for(Int32 i = 0; i < 6; i++)
				{
				x = fs[i, i];

				if(x != -1)
					Console.Write(x + " ");
				}

			Console.WriteLine();

			// А теперь показать сбои.

			Console.WriteLine(" \n Сбой с уведомлением об ошибках ");

			for(Int32 i = 0; i < 6; i++)
				{
				fs[i, i] = i * 10;

				if(fs.ErrFlag)
					Console.WriteLine(" fs[" + i + ", " + i + "] вне границ ");
				}

			for(Int32 i = 0; i < 6; i++)
				{
				x = fs[i, i];

				if(!fs.ErrFlag)
					Console.Write(x + " ");
				else
					Console.WriteLine(" fs[" + i + ", " + i + "] вне границ ");
				}
			}
		}
	}
