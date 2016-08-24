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
/*
using System;

namespace Inheritance
	{

	// Класс для двумерных объектов.
	class TwoDShape
		{
		Double pri_width;
		Double pri_height;

		// Свойства ширины и длины объекта.

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
			Console.WriteLine(" Ширина и длина = " + Width + " и " + Height);
			}
		}

	// Класс для треугольников, производный от класса TwoDShape.

	class Triangle: TwoDShape
		{
		String Style;

		//  Конструктор.

		public Triangle(String s, Double w, Double h)
			{
			Width = w;  // инициализировать член базового класса	
			Height = h; // инициализировать член базового класса
			Style = s;  // инициализировать член производного класса
			}

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
	class Shapes3
		{
		static void Main()
			{
			Triangle tr_1 = new Triangle(" равнобедренный ", 4.0, 4.0);
			Triangle tr_2 = new Triangle(" прямоугольный ", 8.0, 12.0);

			Console.WriteLine(" Сведения об объекте tr_1 = ");

			tr_1.ShowStyle();
			tr_1.ShowDim();

			Console.WriteLine(" Площадь = " + tr_1.Area());

			Console.WriteLine();

			Console.WriteLine(" Сведения об объекте tr_2 = ");

			tr_2.ShowStyle();
			tr_2.ShowDim();

			Console.WriteLine(" Площадь = " + tr_2.Area());
			}
		}
	}
*/
// Добавить конструктор в класс TwoDShape.
/*
using System;

namespace Inheritance
	{

	// Класс для двумерных объектов.
	class TwoDShape
		{
		Double pri_width;
		Double pri_height;

		// Конструктор класса TwoDShape.

		public TwoDShape(Double w, Double h)
			{
			Width = w;
			Height = h;
			}

		// Свойства ширины и длины объекта.

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
			Console.WriteLine(" Ширина и длина = " + Width + " и " + Height);
			}
		}

	// Класс для треугольников, производный от класса TwoDShape.

	class Triangle: TwoDShape
		{
		String Style;
		
		// Вызвать конструктор базового класса.

		public Triangle(String s, Double w, Double h) : base(w, h)
			{
			Style = s;
			}

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
	class Shapes4
		{
		static void Main()
			{
			Triangle t1 = new Triangle(" равнобедренный ", 4.0, 4.0);
			Triangle t2 = new Triangle(" прямоугольный ", 8.0, 12.0);

			Console.WriteLine(" Сведения об объекте t1 = ");

			t1.ShowStyle();
			t1.ShowDim();

			Console.WriteLine("Площадь = " + t1.Area());

			Console.WriteLine();

			Console.WriteLine(" Сведения об объекте t2 = ");

			t2.ShowStyle();
			t2.ShowDim();

			Console.WriteLine(" Площадь = " + t2.Area());
			}
		}
	}
*/
// Добавить дополнительные конструкторы в класс TwoDShape.

using System;

namespace Inheritance
	{
	class TwoDShape
		{
		Double pri_width;
		Double pri_height;

		// Конструктор, вызываемый по умолчанию.
		public TwoDShape()
			{
			Width = Height = 0.0;
			}

		// Конструктор класса TwoDShape.
		public TwoDShape(double w, double h)
			{
			Width = w;
			Height = h;
			}
		// Сконструировать объект равной ширины и высоты.
		public TwoDShape(double x)
			{
			Width = Height = x;
			}
		// Свойства ширины и высоты объекта.
		public double Width
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
		public double Height
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
			Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
			}
		}
	// Класс для треугольников, производный от класса TwoDShape.
	class Triangle: TwoDShape
		{
		String Style;

		// Конструктор, используемый по умолчанию.
		// Автоматически вызывает конструктор, доступный по
		// умолчанию в классе TwoDShape.

		public Triangle()
			{
			Style = "null";
			}
		// Конструктор, принимающий три аргумента.
		public Triangle(String s, Double w, Double h) : base(w, h)
			{
			Style = s;
			}
		// Сконструировать равнобедренный треугольник.
		public Triangle(double x) : base(x)
			{
			Style = "равнобедренный";
			}
		// Возвратить площадь треугольника.
		public double Area()
			{
			return Width * Height / 2;
			}
		// Показать тип треугольника.
		public void ShowStyle()
			{
			Console.WriteLine("Треугольник " + Style);
			}
		}
	class Shapes5
		{
		static void Main()
			{
			Triangle t1 = new Triangle();
			Triangle t2 = new Triangle("прямоугольный", 8.0, 12.0);
			Triangle t3 = new Triangle(4.0);

			t1 = t2;

			Console.WriteLine("Сведения об объекте t1: ");

			t1.ShowStyle();
			t1.ShowDim();

			Console.WriteLine("Площадь равна " + t1.Area());

			Console.WriteLine();

			Console.WriteLine("Сведения об объекте t2: ");

			t2.ShowStyle();
			t2.ShowDim();

			Console.WriteLine("Площадь равна " + t2.Area());

			Console.WriteLine();

			Console.WriteLine("Сведения об объекте t3: ");

			t3.ShowStyle();
			t3.ShowDim();

			Console.WriteLine("Площадь равна " + t3.Area());

			Console.WriteLine();
			}
		}
	}

		