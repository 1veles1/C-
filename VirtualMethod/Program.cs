// Продемонстрировать виртуальный метод.
/*
using System;


namespace VirtualMethod
	{
	class Base
		{
		
		// Создать виртуальный метод в базовом классе.

		public virtual void Who()
			{
			Console.WriteLine("Метод Who() в классе Base");
			}
		}
	class Derived1: Base
		{

		// Переопределить метод Who() в производном классе.

		public override void Who()
			{
			Console.WriteLine("Метод Who() в классе Derivedl");
			}
		}
	class Derived2: Base
		{

		// Вновь переопределить метод Who() в еще одном производном классе.

		public override void Who()
			{
			Console.WriteLine("Метод Who() в классе Derived2");
			}
		}
	class OverrideDemo
		{
		static void Main()
			{
			Base baseOb = new Base();
			Derived1 dOb1 = new Derived1();
			Derived2 dOb2 = new Derived2();

			Base baseRef; // ссылка на базовый класс

			baseRef = baseOb;
			baseRef.Who();

			baseRef = dOb1;
			baseRef.Who();

			baseRef = dOb2;
			baseRef.Who();
			}
		}
	}
*/
// Если виртуальный метод не переопределяется, то используется его вариант из базового класса.
/*
using System;

namespace VirtualMethod
	{
	class Base
		{

		// Создать виртуальный метод в базовом классе.

		public virtual void Who()
			{
			Console.WriteLine("Метод Who() в классе Base");
			}
		}
	class Derived1:Base
		{

		// Переопределить метод Who() в производном классе.

		public override void Who()
			{
			Console.WriteLine("Метод Who() в классе Derived1");
			}
		}
	class Derived2:Base
		{
		// В этом классе метод Who() не переопределяется.
		}
	class OverrideDemo
		{
		static void Main()
			{
			Base baseOb = new Base();
			Derived1 dOb1 = new Derived1();
			Derived2 dOb2 = new Derived2();

			Base baseRef; // ссылка на базовый класс

			baseRef = baseOb;
			baseRef.Who();

			baseRef = dOb1;
			baseRef.Who();

			baseRef = dOb2;
			baseRef.Who(); // вызывается метод Who() из класса Base
			}
		}
	}
*/
// В многоуровневой иерархии классов выполняется тот переопределенный вариант виртуального метода,
// который обнаруживается первым при продвижении вверх по иерархии.
/*
using System;

namespace VirtualMethod
	{
	class Base
		{
		// Создать виртуальный метод в базовом классе.

		public virtual void Who()
			{
			Console.WriteLine("Метод Who() в классе Base");
			}
		}
	class Derived1:Base
		{
		// Переопределить метод Who() в производном классе.

		public override void Who()
			{
			Console.WriteLine("Метод Who() в классе Derived1");
			}
		}

	class Derived2:Base
		{
		// В этом классе метод Who() не переопределяется.
		}
	class Derived3:Base
		{
		// И в этом классе метод Who() не переопределяется.
		}
	class NoOverrideDemo2
		{
		static void Main()
			{
			Derived3 dOb = new Derived3();

			Base baseRef;	// ссылка на базовый класс

			baseRef = dOb;
			baseRef.Who();	// вызов метода Who() из класса Derived1
			}
		}
	}
*/
// Применить виртуальные методы и полиморфизм.

using System;

namespace VirtualMethod
	{
	class TwoDShape
		{
		Double pri_width;
		Double pri_height;

		// Конструктор по умолчанию.
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
		public virtual Double Area()
			{
			Console.WriteLine("Метод Area() должен быть переопределен");

			return 
				0.0;
			}
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

		public Triangle(String s, Double w, Double h):base(w, h, "треугольник")
			{
			Style = s;
			}
		// Сконструировать равнобедренный треугольник,

		public Triangle(Double x): base(x, "треугольник")
			{
			Style = "равнобедренный";
			}
		// Сконструировать копию объекта типа Triangle.

		public Triangle(Triangle ob)
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

		public void Show()
			{
			Console.WriteLine("Треугольник " + Style);
			}
		}
	// Класс для прямоугольников, производный от класса TwoDShape.

	class Rectangle: TwoDShape
		{
		// Конструктор для класса Rectangle.

		public Rectangle(Double w, Double h):base(w, h, "треугольник")
			{

			}
		// Сконструировать квадрат.

		public Rectangle(Double x):base(x, "прямоугольник")
			{

			}
		// Сконструировать копию объекта типа Rectangle.

		public Rectangle(Rectangle ob): base(ob)
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

		public override double Area()
			{
			return
				Width * Height;
			}
		}
	class DynShapes
		{
		static void Main()
			{
			TwoDShape[] shapes = new TwoDShape[5];

			shapes[0] = new Triangle("прямоугольный", 8.0, 12.0);
			shapes[1] = new Rectangle(10);
			shapes[2] = new Rectangle(10, 4);
			shapes[3] = new Rectangle(7.0);
			shapes[4] = new TwoDShape(10, 20, "общая форма");

			for(Int32 i = 0; i < shapes.Length; i++)
				{
				Console.WriteLine("Объект — " + shapes[i].name);

				Console.WriteLine("Площадь = " + shapes[i].Area());

				Console.WriteLine();
				}
			}
		}
	}