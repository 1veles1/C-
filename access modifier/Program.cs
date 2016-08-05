// Отличия между видами доступа public и private к членам класса.

using System;


namespace access_modifier
	{
	class MyClass
		{
		private Int32 alfa; // закрытый доступ, указываемый явно
		Int32 beta;         // закрытый доступ по умолчанию
		public Int32 gamma; // открытый доступ

		// Методы, которым  доступны члены alpha и beta данного класса.
		// Член класса может иметь доступ к закрытому члену этого же класса
		
		public void SetAlfa(Int32 a)
			{
			alfa = a;
			}
		public Int32 GetAlfa()
			{
			return alfa;
			}
		public void SetBeta(Int32 a)
			{
			beta = a;
			}
		public Int32 GetBeta()
			{
			return beta;
			}
		}
	class AcsessDemo
		{
		static void Main()
			{
			MyClass ob = new MyClass();

			// Доступ к членам alpha иbeta данного класса
			// разрешен только посредством его методов.

			ob.SetAlfa(-99);
			ob.SetBeta(19);

			// Член gamma данного класса доступен непосредственно,
			// поскольку он является открытым.

			ob.gamma = 99;

			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine(new string('-', 15));

			Console.ForegroundColor = ConsoleColor.Gray;

			Console.WriteLine(" ob.alpha = " + ob.GetAlfa());
			Console.WriteLine(new string('-', 15));
			Console.WriteLine(" ob.beta = " + ob.GetBeta());
			Console.WriteLine(new string('-', 15));
			Console.WriteLine(" ob.gamma = " + ob.gamma);
			
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine(new string('-', 15));

			// Следующие виды доступа к членам alpha и beta
			// данного класса не разрешаются.

			// ob.alpha = 10; // Ошибка! alpha - закрытый член!
			// ob.beta =9;  // Ошибка! beta - закрытый член!
			
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(new string('-', 7));

			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(" Done ! ");

			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(new string('-', 7));

			Console.ReadLine();
			Console.Beep();
			}
		}
	}
	
