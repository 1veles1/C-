// Использовать индексатор для создания отказоустойчивого массива.
/*
using System;


namespace GetSet
	{
	class FailSoftArray
		{
		Int32[] a;              // ссылка на базовый массив

		public Int32 Lenght;    // открытая переменная длины массива

		public Boolean ErrFlag; // обозначает результат последней операции

		// Построить массив заданного размера.

		public FailSoftArray(Int32 size)
			{
			a = new Int32[size];
			Lenght = size;
			}

		// Это индексатор для класса FailSoftArray.

		public Int32 this[Int32 index]
			{

			// Это аксессор get.

			get
				{
				if(ok(index))
					{
					ErrFlag = false;
					return
						a[index];
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
				if(ok(index))
					{
					a[index] = value;
					ErrFlag = false;
					}
				else
					{
					ErrFlag = true;
					}
				}
			}

		// Возвратить логическое значение true, если
		// индекс находится в установленных границах.

		private Boolean ok(Int32 index)
			{
			if(index >= 0 & index < Lenght)
				return true;
			return false;
			}
		}

	// Продемонстрировать применение отказоустойчивого массива.

	class FSDemo
		{
		static void Main()
			{
			FailSoftArray fs = new FailSoftArray(5);

			Int32 x;

			// Выявить скрытые сбои.

			Console.WriteLine(" Скрытый сбой ");

			for(Int32 i = 0; i < (fs.Lenght * 2); i++)
				fs[i] = i * 10;

			for(Int32 i = 0; i < (fs.Lenght * 2); i++)
				{
				x = fs[i];

				if(x != -1)
					Console.Write(x + " ");
				}

			Console.WriteLine();

			// А теперь показать сбои.

			Console.WriteLine(" \n Сбой с уведомлением об ошибках ");

			for(Int32 i = 0; i < (fs.Lenght * 2); i++)
				{

				fs[i] = i * 10;

				if(fs.ErrFlag)
					Console.WriteLine(" fs [ " + i + " ] вне границ ");
				}
			for(Int32 i = 0; i < (fs.Lenght * 2); i++)
				{

				x = fs[i];

				if(!fs.ErrFlag)
					Console.Write(x + " ");
				else
					Console.WriteLine(" fs [ " + i + " ] вне границ ");
				}
			}
		}
	}
*/
// Перегрузить индексатор массива класса FailSoftArray.
/*
using System;

namespace GetSet
	{
	class FailSoftArray
		{
		Int32[] a;				// ссылка на базовый массив

		public Int32 Lenght;	// открытая переменная длины массива
		public Boolean ErrFlag; // обозначает результат последней операции

		// Построить массив заданного размера.

		public FailSoftArray(Int32 size)
			{
			a = new Int32[size];
			Lenght = size;
			}

		// Это индексатор типа int для массива FailSoftArray.

		public Int32 this[Int32 index]
			{

			// Это аксессор get.

			get
				{
				if(ok(index))
					{
					ErrFlag = false;
					return a[index];
					}
				else
					{
					ErrFlag = true;
					return 0;
					}
				}
			
			// Это аксессор set.

			set
				{
				if(ok(index))
					{
					a[index] = value;
					ErrFlag = false;
					}
				else
					ErrFlag = true;
				}
			}

			// Это еще один индексатор для массива FailSoftArray.
			// Он округляет свой аргумент до ближайшего целого индекса.

			public Int32 this[Double idx]
			{

			// Это аксессор get.

			get
				{
				Int32 index;

				// Округлить до ближайшего целого.

				if((idx - (Int32) idx) < 0.5) index = (Int32) idx;

				else
					index = (Int32) idx + 1;

				if(ok(index))
					{
					ErrFlag = false;
					return a[index];
					}
				else
					{
					ErrFlag = true;
					return 0;
					}
				}

				// Это аксессор set.

			set
				{
				Int32 index;

				// Округлить до ближайшего целого.

				if((idx - (Int32) idx) < 0.5) index = (Int32) idx;

				else
					index = (Int32) idx + 1;

				if(ok(index))
					{
					a[index] = value;
					ErrFlag = false;
					}
				else ErrFlag = true;
				}
			}

		// Возвратить логическое значение true, если
		// индекс находится в установленных границах.

		private Boolean ok(Int32 index)
			{
			if(index >= 0 & index < Lenght)
				return true;
			return false;
			}
		}

		// Продемонстрировать применение отказоустойчивого массива.
	class FSDemo
		{
		static void Main()
			{
			FailSoftArray fs = new FailSoftArray(5);

			// Поместить ряд значений в массив fs.

			for(Int32 i = 0; i < fs.Lenght; i++)
				fs[i] = i;

			// А теперь воспользоваться индексами
			// типа int и double для обращения к массиву.

			Console.WriteLine(" fs[1] = " + fs[1]);
			Console.WriteLine(" fs[2] = " + fs[2]);
			Console.WriteLine(" fs[1.1] = " + fs[1.1]);
			Console.WriteLine(" fs[1.6] = " + fs[1.6]);
			}
		}
	}
*/
// Индексаторы совсем не обязательно должны оперировать отдельными массивами.
/*
using System;

namespace GetSet
	{
	class PwrOfTwo
		{

		// Доступ к логическому массиву, содержащему степени числа 2 от 0 до 15

		public Int32 this[Int32 index]
			{

			// Вычислить и возвратить степень числа 2.

			get
				{
				if((index >= 0) && (index < 16))
					return pwr(index);
				else
					return -1;
				}

			// Аксессор set отсутствует

			}

		Int32 pwr(Int32 p)
			{
			Int32 result = 1;

			for(Int32 i = 0; i < p; i++)
				result *= 2;
			return result;
			}
		}
	class UsePwrOfTwo
		{
		static void Main()
			{
			PwrOfTwo pwr = new PwrOfTwo();

			Console.Write(" Первые 8 степеней числа 2 = ");

			for(Int32 i = 0; i < 8; i++)
				Console.Write(pwr[i] + " ");

			Console.WriteLine();

			Console.Write(" А это некоторые ошибки = ");
				Console.Write(pwr[-1] + " " + pwr[17]);

			Console.WriteLine();
			}
		}
	}
*/



	