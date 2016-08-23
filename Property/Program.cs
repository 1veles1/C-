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
/*
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
*/
// Применить инициализаторы объектов в свойствах.
/*
using System;

namespace Prorerty
	{
	class MyClass
		{

		// Теперь это свойства.

		public Int32 Count { get; set; }
		public String Str { get; set; }
		}
	class ObjInitDemo
		{
		static void Main()
			{

			// Сконструировать объект типа MyClass с помощью инициализаторов объектов.

			MyClass obj = new MyClass { Count = 100, Str = " Test" };

			Console.WriteLine(obj.Count + " " + obj.Str);
			}
		}
	}
*/
// Применить модификатор доступа в аксессоре.
/*
using System;

namespace Property
	{
	class PropAccess
		{
		Int32 prop;                         // поле, управляемое свойством МуРrор

		public PropAccess()
			{
			prop = 0;
			}
			
			// Это свойство обеспечивает доступ к закрытой переменной экземпляра prop.
			// Оно разрешает получать значение переменной prop из любого кода,
			// но устанавливать его — только членам своего класса.

			public Int32 MyProp
			{
			get
				{
				return
					prop;
				}
			private set                              // теперь это закрытый аксессор
				{
				prop = value;					
				}
			}

			// Этот член класса инкрементирует значение свойства МуРrор.

		public void IncrProp()
			{
			MyProp++;                               // Допускается в. том же самом классе.
			}
		}

		// Продемонстрировать применение модификатора доступа в аксессоре свойства.

		class PropAccessDemo
		{
		static void Main()
			{
			PropAccess ob = new PropAccess();

			Console.WriteLine(" Первоначальное значение ob.МуРrор = " + ob.MyProp);

			// ob.МуРrор = 100; // недоступно для установки

			ob.IncrProp();

			Console.WriteLine("Значение ob.МуРrор после инкрементирования: " + ob.MyProp);
			}
		}
	}
*/
// Применить автоматически реализуемые и доступные только для чтения свойства Length и Error.
/*
using System;

namespace Property
	{
	class FailSoftArray
		{
		Int32[] a; // ссылка на базовый массив

		// Построить массив по заданному размеру.

		public FailSoftArray(Int32 size)
			{
			a = new Int32[size];
			Lenght = size; 
			}

		// Автоматически реализуемое и доступное только для чтения свойство Length.

		public Int32 Lenght { get; private set; }

		// Автоматически  реализуемое  и  доступное  только для чтения свойство Error.

		public Boolean Error { get; private set; }

		// Это индексатор для массива FailSoftArray.

		public Int32 this[Int32 index]
			{

			// Это аксессор get.

			get
				{
				if(ok(index))
					{
					Error = false;
					return 
						a[index];
					}
				else
					{
					Error = true;
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
					Error = false;
					}
				else
					Error = true;
				}
			}

		// Возвратить логическое значение true, если индекс находится в установленных границах.

		public Boolean ok(Int32 index)
			{
			if(index >= 0 & index < Lenght) 
				return 
					true;
			return 
				false;
			}
		}

		// Продемонстрировать применение усовершенствованного отказоустойчивого массива.

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

*/
// Создать класс со специально указываемыми пределами индексирования массива.
// Класс RangeArray допускает индексирование массива с любого значения, а не
// только с нуля.При создании объекта класса RangeArray указываются начальный
// и конечный индексы.Допускается также указывать отрицательные индексы.
// Например, можно создать массивы, индексируемые от -5 до 5, от 1 до 10
// или же от 50 до 56.

using System;

namespace Property
	{
	class RangeArray
		{
		Int32[] a;            // ссылка на базовый массив
		Int32 lowerBound;	  // наименьший индекс
		Int32 upperBound;     // наибольший индекс

			// Автоматически реализуемое и доступное только для чтения свойство Length.
			
		public Int32 Lenght { get; private set; }

			// Автоматически реализуемое и доступное только для чтения свойство Error.

		public Boolean Error { get; private set; }

			// Построить массив по заданному размеру.

		public  RangeArray(Int32 low, Int32 high)
			{
			high++;

			if(high <= low)
				{
				Console.WriteLine(" Неверные индексы ");

				high = 1; // создать для надежности минимально допустимый массив
				low = 0;
				}

			a = new Int32[high - low];
			Lenght = high - low;

			lowerBound = low;
			upperBound = --high;						
			}

			// Это индексатор для класса RangeArray.

		public Int32 this[Int32 index]
			{

			// Это аксессор get.

			get
				{
				if(ok(index))
					{
					Error = false;
					return 
						a[index - lowerBound];
					}
				else
					{
					Error = true;
					return 
						0;
					}
				}

			// Это аксессор set.

			set
				{
				if(ok(index))
					{
					a[index - lowerBound] = value;
					Error = false;
					}
				else
					Error = true;
				}
			}

			// Возвратить логическое значение true, если индекс находится в установленных границах.

		private Boolean ok(Int32 index)
			{
			if(index >= lowerBound & index <= upperBound)
				return 
					true;
			return 
				false;
			}
		}

			// Продемонстрировать применение массива с произвольно задаваемыми пределами индексирования.

	class RangeArrayDemo
		{
		static void Main()
			{
			RangeArray ra = new RangeArray(-5, 5);
			RangeArray ra2 = new RangeArray(1, 10);
			RangeArray ra3 = new RangeArray(-20, -12);

			// Использовать объект ra в качестве массива.

			Console.WriteLine(" Длина массива ra =  " + ra.Lenght);

			for(Int32 i = -5; i <= 5; i++)
				ra[i] = i;

			Console.Write(" Содержимое массива ra = ");

			for(Int32 i = -5; i <=5; i++)
				Console.Write(ra[i] + " ");

			Console.WriteLine("\n");

			// Использовать объект ra2 в качестве массива.

			Console.WriteLine(" Длина массива ra2 = " + ra2.Lenght);

			for(Int32 i = 1; i <= 10; i++)
				ra2[i] = i;

			Console.Write(" Содержимое массива ra2 = ");

			for(Int32 i = 1; i <= 10; i++)
				Console.Write(ra2[i] + " ");

			Console.WriteLine("\n");

			// Использовать объект raЗ в качестве массива.

			Console.WriteLine(" Длина массива ra3 = " + ra3.Lenght);

			for(Int32 i = -20; i <= -12; i++)
				ra3[i] = i;

			Console.Write(" Содержимое массива ra3 = ");

			for(Int32 i = -20; i <= -12; i++)
				Console.Write(ra3[i] + " ");

			Console.WriteLine("\n");
			}
		}
	}
