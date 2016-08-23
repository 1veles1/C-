// Класс для двумерных объектов (Пример простой иерархии классов)

using System;


namespace Inheritance
	{

		// Класс для двумерных объектов.
	class TwoDShape
		{
		public Double Width;
		public Double Height;

		public void ShowDim()
			{
			Console.WriteLine(" Ширина и высота =  " + Width + " и " + Height);
			}
		}

		// Класс Triangle, производный от класса TwoDShape.
	class Triangle:TwoDShape
		{
		public String Style;            // тип треугольника

		// Возвратить площадь треугольника.

		public Double Area()
			{
			return 
				Width * Height / 2;
			}

		// Показать тип треугольника.

		public void ShowStyle()
			{
			Console.WriteLine(" Треугольник " + Style);
			}
		}

		// Класс для прямоугольников, производный от класса TwoDShape.
	class Rectangle: TwoDShape
		{

		// Возвратить логическое значение true, если прямоугольник является квадратом.

		public Boolean IsSquare()
			{
			if(Width == Height)
				return
					true;
			return
				false;
			}

		// Возвратить площадь прямоугольника.

		public Double Area()
			{
			return
				Width * Height;
			}
		}

		// Демонстрация
	class Shapes
		{
		static void Main()
			{
			Triangle t_1 = new Triangle();
			Triangle t_2 = new Triangle();

			t_1.Width = 4.0;
			t_1.Height = 4.0;
			t_1.Style = " равнобедренный ";

			t_2.Width = 8.0;
			t_2.Height = 12.0;
			t_2.Style = " прямоугольный ";

			Console.WriteLine(" Сведения об объекте t_1 = ");

			t_1.ShowStyle();
			t_1.ShowDim();
			Console.Write(" Площадь = " + t_1.Area());

			Console.WriteLine();

			Console.WriteLine(" Сведения об объекте t_2 = ");

			t_2.ShowStyle();
			t_2.ShowDim();
			Console.Write(" Площадь = " + t_2.Area());

			Console.WriteLine();			
			}
		}
	}

	
