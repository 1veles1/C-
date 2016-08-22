// Простой пример применения свойства
/*
using System;


namespace Property
	{
	class SimpProp
		{
		Int32 prop;			// поле, управляемое свойством МуРrор

		public SimpProp()
			{
			prop = 0;
			}

			// Это свойство обеспечивает доступ к закрытой переменной экземпляра prop

			// Оно допускает присваивание только положительных значений

		public Int32 MyProp
			{
			get
				{
				return
					prop;
				}
			set
				{
				if(value >= 0)
					prop = value;
				}
			}
		}

			  // Продемонстрировать применение свойства.

	class PropertyDemno
		{
		static void Main()
			{
			SimpProp ob = new SimpProp();

			Console.WriteLine(" Первоначальное значение ob.МуРrор = " + ob.MyProp);

			ob.MyProp = 100;        // присвоить значение

			Console.WriteLine(" Текущее значение ob.МуРrор = " + ob.MyProp);

			// Переменной prop нельзя присвоить отрицательное значение.

			Console.WriteLine(" Попытка присвоить значение -10 свойству ob.МуРrор ");

			ob.MyProp = -10;

			Console.WriteLine(" Текущее значение ob.МуРrор = " + ob.MyProp);
			}
		}
	}
*/
// Добавить свойство Length в класс FailSoftArray.
/*
using System;

namespace Property
	{
	class FailSoftArray
		{
		Int32[] a;					// ссылка на базовый массив
		Int32 len;					// длина массива — служит основанием для свойства Length

		public Boolean ErrFlag;     // обозначает результат последней операции

		// Построить массив заданного размера.

		public FailSoftArray(Int32 size)
			{
			a = new Int32[size];
			len = size;
			}

		// Свойство Length только для чтения.

		public Int32 Lenght
			{
			get
				{
				return
					len;
				}
			}

			// Это индексатор для класса FailSoftArray.

		public Int32 this[Int32 index]
			{
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
					ErrFlag = true;
				}
			}

			// Возвратить логическое значение true, если индекс находится в установленных границах.

		private Boolean ok(Int32 index)
			{
			if(index >= 0 & index < Lenght)
				return
					true;
			return
				false;
			}
		}

			// Продемонстрировать применение усовершенствованного отказоустойчивого массива.
	class ImprovedFSDemo
		{
		static void Main()
			{
			FailSoftArray fs = new FailSoftArray(5);
			Int32 x;

			// Разрешить чтение свойства Length.

			for(Int32 i = 0; i < fs.Lenght; i++)
				fs[i] = i * 10;

			for(Int32 i = 0; i < fs.Lenght; i++)
				{
				x = fs[i];
				if(x != -1)
					Console.Write(x + " ");
				}

			Console.WriteLine();

			 // fs.Lenght = 10; // Ошибка, запись запрещена!
			}
		}
	}
*/
// Превратить переменную ErrFlag в свойство.

using System;

namespace Property
	{
	class FailSoftArray
		{
		Int32[] a;                      // ссылка на базовый массив
		Int32 len;                      // длина массива
		Boolean ErrFlag;                // теперь это частная переменная, обозначающая результат последней операции

		// Построить массив заданного размера.

		public FailSoftArray(Int32 size)
			{
			a = new Int32[size];
			len = size;
			}

		// Свойство Length только для чтения.

		public Int32 Lenght
			{
			get
				{
				return
					len;
				}
			}

		// Свойство Error только для чтения.

		public Boolean Error
			{
			get
				{
				return
					ErrFlag;
				}
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
					ErrFlag = true;
				}
			}

				// Возвратить логическое значение true, если индекс находится в установленных границах.

		private Boolean ok(Int32 index)
			{
			if(index >= 0 & index < Lenght)
				return 
					true;
			return 
				false;
			}
		}

			// Продемонстрировать применение отказоустойчивого массива.

	class FinalFSDemo
		{
		static void Main()
			{
			FailSoftArray fs = new FailSoftArray(5);

			// Использовать свойство Error.

			for(Int32 i = 0; i < fs.Lenght + 1; i++)
				{
				fs[i] = i * 10;

				if(fs.Error)
					Console.WriteLine(" Ошибка в индексе " + i);
				}
			}
		}
	}
