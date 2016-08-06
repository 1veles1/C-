// Возвратить объект из метода.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnFromMethod
	{
	class Rect
		{
		Int32 width;
		Int32 height;

		public Rect(Int32 w, Int32 h)
			{
			width = w;
			height = h;
			}
		public Int32 Area()
			{
			return width * height;
			}
		public void Show()
			{
			Console.WriteLine(" " + width + " " + height);
			}

		// Метод возвращает прямоугольник со сторонами, пропорционально
		// увеличенными на указанный коэффициент по сравнению с вызывающим
		// объектом прямоугольника.

		public Rect Enlarge(Int32 factor)
			{
			return new Rect(width * factor, height * factor);
			}
		}
	class RetObj
		{
		static void Main()
			{
			Rect r_1 = new Rect(4,5);
				Console.Write(" Размеры прямоугольника r_1 = ");
			r_1.Show();

			Console.WriteLine();

			// Создать прямоугольник в два раза больший прямоугольника r_l.

			Rect r_2 = r_1.Enlarge(2);
				Console.Write(" Размеры прямоугольника r_2 = ");
			r_2.Show();

			Console.WriteLine();

			Console.WriteLine(" Площадь прямоугольника r_2 = " + r_2.Area());
			Console.WriteLine();
			}
		}
	}
	
