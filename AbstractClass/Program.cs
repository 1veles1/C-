// Создать абстрактный класс.

using System;


namespace AbstractClass
	{
	abstract class TwoDShape
		{
		Double pri_width;
		Double pri_height;

		// Конструктор, используемый по умолчанию.

		public TwoDShape()
			{
			Width = Height = 0.0;
			name = "null";
			}

		// Параметризированный конструктор.

		public TwoDShape(Double w, Double h, String n)
			{
			Width = w;
			Height = h;
			name = n;
			}
		// Сконструировать объект равной ширины и высоты.

		public TwoDShape(Double x, String n)
			{
			Width = Height = x;
			name = n;
			}
		// Сконструировать копию объекта TwoDShape.

		public TwoDShape(TwoDShape ob)
			{
			Width = ob.Width;
			Height = ob.Height;
			name = ob.name;
			}
		// Свойства ширины и высоты объекта.

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
		public String name { get; set; }

		public void ShowDim()
			{
			Console.WriteLine("Ширина и высота = " + Width + " и " + Height);
			}
		// Теперь метод Area() является абстрактным.

		public abstract Double Area();
		}
	// Класс для треугольников, производный от класса TwoDShape.

	class Triangle: TwoDShape
		{
		String Style;
		// Конструктор, используемый по умолчанию.
		public Triangle()
			{
			Style = "null";
			}
		// Конструктор для класса Triangle.
		public Triangle(String s, Double w, Double h) : base(w, h, "треугольник")
			{
			Style = s;
			}
		// Сконструировать равнобедренный треугольник,
		public Triangle(Double x) : base(x, "треугольник")
			{
			Style = "равнобедренный";
			}
		// Сконструировать копию объекта типа Triangle.
		public Triangle(Triangle ob) : base(ob)
			{
			Style = ob.Style;
			}
		// Переопределить метод Area() для класса Triangle.
		public override Double Area()
			{
			return
				Width * Height / 2;
			}
		// Показать тип треугольника.
		public void ShowStyle()
			{
			Console.WriteLine("Треугольник " + Style);
			}
		}
	// Класс для прямоугольников, производный от класса TwoDShape
	class Rectangle: TwoDShape
		{
		// Конструктор для класса Rectangle.
		public Rectangle(Double w, Double h) : base(w, h, "прямоугольник")
			{
			}
		// Сконструировать квадрат.
		public Rectangle(Double x) : base(x, "прямоугольник")
			{
			}
		// Сконструировать копию объекта типа Rectangle.
		public Rectangle(Rectangle ob) : base(ob)
			{
			}
		// Возвратить логическое значение true, если прямоугольник окажется квадратом.
		public Boolean IsSquare()
			{
			if(Width == Height)
				return
					true;
			return
				false;
			}
		// Переопределить метод Area() для класса Rectangle.
		public override Double Area()
			{
			return
				Width * Height;
			}
		}
	class AbsShape
		{
		static void Main()
			{
			TwoDShape[] shapes = new TwoDShape[4];

			shapes[0] = new Triangle("прямоугольный", 8.0, 12.0);
			shapes[1] = new Rectangle(10);
			shapes[2] = new Rectangle(10, 4);
			shapes[3] = new Triangle(7.0);

			for(Int32 i = 0; i < shapes.Length; i++)
				{

				Console.WriteLine("Объект — " + shapes[i].name);

				Console.WriteLine("Площадь = " + shapes[i].Area());

				Console.WriteLine();
				}
			}
		}
	}