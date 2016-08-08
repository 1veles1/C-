// Применить статический конструктор.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstractor
	{
	class Cons
		{
		public static Int32 alpha;
		public Int32 beta;

		// Статический конструктор.

		static Cons()
			{
			alpha = 99;
			Console.WriteLine(" В статическом конструкторе ");
			}
		
		// Конструктор экземпляра.

		public Cons()
			{
			beta = 100;
			Console.WriteLine(" В конструкторе экземпляра ");
			}
		}
	class ConsDemo
		{
		static void Main()
			{
			Cons ob = new Cons();
			Console.WriteLine(" Cons.alpha = " + Cons.alpha);
			Console.WriteLine(" ob.beta = " + ob.beta);
			}
		}
	}
