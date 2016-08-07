// Простой пример, демонстрирующий применение инициализаторов объектов.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitialiser
	{
	class MyClass
		{
		public Int32 Count;
		public String Str;
		}

	class ObjInitDemo
		{
		static void Main()
			{

			// Сконструировать объект типа MyClass, используя инициализаторы объектов.

			MyClass obj = new MyClass { Count = 100, Str = "Test"};

			Console.WriteLine(obj.Count + " " + obj.Str);
			}
		}
	}
