// Пример сокрытия имени с наследственной связью.
/*
using System;


namespace NameHiding
	{
	class A
		{
		public Int32 i = 0;
		}
	// Создать производный класс.

	class B:A
		{
		new Int32 i; // этот член скрывает член i из класса А

		public B(Int32 b)
			{
			i = b; // член i в классе В
			}
		public void Show()
			{
			Console.WriteLine(" Член i в производном классе = " + i);
			}
		}
	class NameHiding
		{
		static void Main()
			{
			B ob = new B(2);

			ob.Show();
			}
		}
	}
*/
// Применение ключевого слова base для преодоления препятствия, связанного с сокрытием имен.
/*
using System;

namespace NameHiding
	{
	class A
		{
		public Int32 i = 0;
		}
	class B: A
		{
		new Int32 i;		//  этот член скрывает член i из класса А

		public B(Int32 a, Int32 b)
			{
			base.i = a;     // здесь обнаруживается скрытый член из класса А
			i = b;          // член i из класса В
			}
		public void Show()
			{

			// Здесь выводится член i из класса А.

			Console.WriteLine(" Член i в базовом классе = " + base.i);

			// А здесь выводится член i из класса В.

			Console.WriteLine(" Член i в производном классе = " + i);
			}
		}
	class UncoverName
		{
		static void Main()
			{
			B ob = new B(1, 2);

			ob.Show();
			}
		}
	}
*/
// Вызвать скрытый метод.
/*
using System;

namespace NameHiding
	{
	class A
		{
		public Int32 i = 0;

		// Метод Show() в классе A

		public void Show()
			{
			Console.WriteLine(" Член i в базовом классе = " + i);
			}
		}
	class B:A
		{
		new Int32 i;            // этот член скрывает член i из класса А

		public B(Int32 a, Int32 b)
			{
			base.i = a;         // здесь обнаруживается скрытый член из класса А
			i = b;              // член i из класса В
			}

			// Здесь скрывается метод Show() из класса А. Обратите внимание на применение ключевого слова new.

		new public void Show()
			{
			base.Show();        // здесь вызывается метод Show() из класса А

			// далее выводится член i из класса В

			Console.WriteLine(" Член i в производном классе = " + i);
			}
		}
	class UncoverName
		{
		static void Main()
			{
			B ob = new B(1, 2);

			ob.Show();
			}
		}
	}
*/
// Пример построения многоуровневой иерархии классов.
/*
using System;

namespace NameHiding
	{
	class TwoDShape
		{
		Double pri_width;
		Double pri_height;

		// Конструктор, используемый по умолчанию.

		public TwoDShape()
			{
			Width = Height = 0.0;
			}

		// Конструктор для класса TwoDShape.

		public TwoDShape(Double w, Double h)
			{
			Width = w;
			Height = h;
			}

		// Сконструировать объект равной ширины и высоты.

		public TwoDShape(Double x)
			{
			Width = Height = x;
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
		public void ShowDim()
			{
			Console.WriteLine("Ширина и высота равны " + Width + " и " + Height);
			}
		}

		// Класс для треугольников, производный от класса TwoDShape.

	class Triangle: TwoDShape
		{
		String Style;           // закрытый член класса

		// Конструктор, используемый по умолчанию.
		// Автоматически вызывает конструктор, доступный по
		// умолчанию в классе TwoDShape.

		public Triangle()
			{
			Style = "null";
			}

		// Конструктор.

		public Triangle(String s, Double w, Double h) : base(w, h)
			{
			Style = s;
			}

		// Сконструировать равнобедренный треугольник.

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

		// Расширить класс Triangle.

	class ColorTriangle: Triangle
		{
		String color;

		public ColorTriangle(String c, String s, Double w, Double h) : base(s, w, h)
			{
			color = c;
			}

		// Показать цвет треугольника.

		public void ShowColor()
			{
			Console.WriteLine(" Цвет " + color);
			}
		}
		
		// Продемонстрировать
	class Shapes6
		{
		static void Main()
			{
			ColorTriangle t1 = new ColorTriangle("синий", "прямоугольный", 8.0, 12.0);
			ColorTriangle t2 = new ColorTriangle("красный", "равнобедренный", 2.0, 2.0);

			Console.WriteLine(" Сведения об объекте t1 = ");

			t1.ShowStyle();
			t1.ShowDim();
			t1.ShowColor();

			Console.WriteLine(" Площадь = " + t1.Area());

			Console.WriteLine();

			Console.WriteLine(" Сведения об объекте t2 = ");

			t2.ShowStyle();
			t2.ShowDim();
			t2.ShowColor();

			Console.WriteLine(" Площадь = " + t2.Area());
			}
		}
	}
*/
// Продемонстрировать порядок вызова конструкторов.
/*
using System;

namespace NameHidding
	{
	// Создать базовый класс.
	class A
		{
		public A()
			{
			Console.WriteLine("Конструирование класса А");
			}
		}
	// Создать класс, производный от класса А.

	class B:A
		{
		public B()
			{
			Console.WriteLine("Конструирование класса В");
			}
		}
	// Создать класс, производный от класса В.

	class C:B
		{
		public C()
			{
			Console.WriteLine("Конструирование класса С");
			}
		}
	class OrderOfConstruction
		{
		static void Main()
			{
			C c = new C();
			}
		}
	}
*/
// Эта программа не подлежит компиляции.
/*
using System;

namespace NameHiding
	{
	class X
		{
		Int32 а;
		public X(Int32 i) { a = i; }
		}
	class Y
		{
		Int32 a;
		public Y(Int32 i) { a = i; }
		}
	class IncompatibleRef
		{
		static void Main()
			{
			X x = new X(10);
			X x2;

			Y у = new Y(5);

			x2 = x; // верно, поскольку оба объекта относятся к одному и тому же типу
			x2 = у; // ошибка, поскольку это разнотипные объекты
			}
		}
	}
*/
// По ссылке на объект базового класса можно обращаться к объекту производного класса.
/*
using System;

namespace NameHiding
	{
	class X
		{
		public Int32 a;
		public X(Int32 i)
			{
			a = i;
			}
		}
	class Y: X
		{
		public Int32 b;
		public Y(Int32 i, Int32 j) : base(j)
			{
			b = i;
			}
		}
	class BaseRef
		{
		static void Main()
			{
			X x = new X(10);

			X x2;

			Y у = new Y(5, 6);

			x2 = x; // верно, поскольку оба объекта относятся к одному и тому же типу

			Console.WriteLine("х2.а: " + x2.a);

			x2 = у; // тоже верно, поскольку класс Y является производным от класса X

			Console.WriteLine("х2.а: " + x2.a);

			// ссылкам на объекты класса X известно только о членах класса X

			x2.a = 19; // верно
			
			//  х2.b = 27; // неверно, поскольку член b отсутствует у класса X
			}
		}
	}
*/
// Передать ссылку на объект производного класса переменной ссылки на объект базового класса.

using System;

namespace NameHiding
	{
	class TwoDShape
		{
		Double pri_width;
		Double pri_height;

		// Конструктор по умолчанию.
		public TwoDShape()
			{
			Width = Height = 0.0;
			}
		// Конструктор для класса TwoDShape.
		public TwoDShape(Double w, Double h)
			{
			Width = w;
			Height = h;
			}
		// Сконструировать объект равной ширины и высоты.
		public TwoDShape(Double x)
			{
			Width = Height = x;
			}
		// Сконструировать копию объекта TwoDShape.
		public TwoDShape(TwoDShape ob)
			{
			Width = ob.Width;
			Height = ob.Height;
			}
		// Свойства ширины и высоты объекта.
		public Double Width
			{
			get {
				return 
					pri_width;
				}
			set { pri_width = value < 0 ? -value : value; }
			}
		public Double Height
			{
			get {
				return 
					pri_height; }
			set
				{ pri_height = value < 0 ? -value : value; }
			}
		public void ShowDim()
			{
			Console.WriteLine(" Ширина и высота = " + Width + " и " + Height);
			}
		}
	// Класс для треугольников, производный от класса TwoDShape.
	class Triangle: TwoDShape
		{
		string Style;
		// Конструктор, используемый по умолчанию.
		public Triangle()
			{
			Style = "null";
			}
		// Конструктор для класса Triangle.
		public Triangle(String s, Double w, Double h) : base(w, h)
			{
			Style = s;
			}
		// Сконструировать равнобедренный треугольник.
		public Triangle(Double x) : base(x)
			{
			Style = "равнобедренный";
			}
		// Сконструировать копию объекта типа Triangle.
		public Triangle(Triangle ob) : base(ob)
			{
			Style = ob.Style;
			}
		// Возвратить площадь треугольника.
		public Double Area()
			{
			return Width * Height / 2;
			}
		// Показать тип треугольника.
		public void ShowStyle()
			{
			Console.WriteLine(" Треугольник " + Style);
			}
		}
	class Shapes7
		{
		static void Main()
			{
			Triangle t1 = new Triangle("прямоугольный", 8.0, 12.0);

			// Сделать копию объекта t1.

			Triangle t2 = new Triangle(t1);

			Console.WriteLine("Сведения об объекте t1: ");

			t1.ShowStyle();
			t1.ShowDim();

			Console.WriteLine("Площадь = " + t1.Area());

			Console.WriteLine();

			Console.WriteLine("Сведения об объекте t2: ");

			t2.ShowStyle();
			t2.ShowDim();

			Console.WriteLine("Площадь = " + t2.Area());
			}
		}
	}