// Класс для двумерных объектов (Пример простой иерархии классов)
/*
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
*/
// Доступ к закрытым членам класса не наследуется. Этот пример кода не подлежит компиляции.
/*
using System;

		// Класс для двумерных объектов.
class TwoDShape
	{
	double Width;	// теперь это закрытая переменная
	double Height;	// теперь это закрытая переменная
	public void ShowDim()
		{
		Console.WriteLine("Ширина и высота равны " +
		Width + " и " + Height);
		}
	}
		// Класс Triangle, производный от класса TwoDShape.
class Triangle: TwoDShape
	{
	public string Style; // тип треугольника
						 // Возвратить площадь треугольника.
	public double Area()
		{
		return 
			Width * Height / 2;		// Ошибка, доступ к закрытому
									// члену класса запрещен
		}
		// Показать тип треугольника.
	public void ShowStyle()
		{
		Console.WriteLine("Треугольник " + Style);
		}
	}
*/
// Использовать открытые свойства для установки и получения значений закрытых членов класса.
/*
using System;

namespace Inheritance
	{

	// Класс для двумерных объектов.
	class TwoDshape
		{
		Double pri_width;	// теперь это закрытая переменная
		Double pri_height;  // теперь это закрытая переменная

		// Свойства ширины и высоты двумерного объекта.

		public Double Width
			{
			get
				{
				return
					pri_width;
				}
			set
				{
				pri_width = value < 0 ? -value : value;
				}
			}
		public Double Height
			{
			get
				{
				return
					pri_height;
				}
			set
				{
				pri_height = value < 0 ? -value : value;
				}
			}
		public void ShowDim()
			{
			Console.WriteLine(" Ширина и высота = " + Width + " и " + Height);
			}
		}
		// Класс для треугольников, производный от класса TwoDShape.

	class Triangle: TwoDshape
		{
		public String Style; // тип треугольника

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

	class Shapes2
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

			Console.WriteLine(" Площадь = " + t_1.Area());

			Console.WriteLine();

			Console.WriteLine(" Сведения об объекте t_2 = ");

			t_2.ShowStyle();
			t_2.ShowDim();

			Console.WriteLine(" Площадь = " + t_2.Area());
			}
		}
	}
*/
// Добавить конструктор в класс Triangle.

using System;

namespace Inheritance
	{

	// Класс для двумерных объектов.
	class TwoDShape
		{

		}
	}