//  Калькулятор 

using System;

namespace Test
{
    class Prog
    {
        static void Main()
        {
            double a;
            double b;
            double total;
            char oper;

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n" + " Введите первое число = " + "\n");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n" + " Введите оператор = " + "\n");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\n" + " Введите второе число = " + "\n");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("\n" + " Cумма " + a + " и " + b + " = " + total + "." + "\n");
                Console.WriteLine();
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("\n" + " Разность " + a + " и " + b + " = " + total + "." + "\n");
                Console.WriteLine();
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("\n" + " Умножение " + a + " * " + b + " = " + total + "." +  "\n");
                Console.WriteLine();
            }

            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine("\n" + " Деление " + a + " / " + b + " = " + total + "." + "\n");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\n" + " Неизвестный оператор. ");
            }
            Console.WriteLine(" Done ");
            Console.ReadLine();
        }
    }
}