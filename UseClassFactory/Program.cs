// Использовать фабрику класса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseClassFactory
	{	
		class MyClass
			{
			Int32 a, b; // закрытые члены класса

			// Создать фабрику для класса MyClass.

			public MyClass Factory(Int32 i, Int32 j)
				{
				MyClass t = new MyClass();

				t.a = i;
				t.b = j;

				return t; // возвратить объект
				}
			public void Show()
				{
				Console.WriteLine(" а и b = " + a + " и " + b);
				}
			}
		class MakeObjects
			{
			static void Main()
				{
				MyClass ob = new MyClass();

				Int32 i;
				Int32 j;

				// Сформировать объекты, используя фабрику класса.

				for(i = 0, j = 10; i < 10; i++, j--)
					{
					MyClass anotherOb = ob.Factory(i, j); // создать объект
					anotherOb.Show();
					}
				Console.WriteLine();
				}
			}
		}
	
	
