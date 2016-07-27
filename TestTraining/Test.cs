/*
// Определить наименьший множитель заданного
// целого значения, состоящий из одной цифры.

using System;

namespace Test
{
    class Ladder
    {
        static void Main()
        {
            int num;

            Console.ForegroundColor = ConsoleColor.Red;

            for( num = 2; num < 12; num++)
            {
                if ((num % 2) == 0)
                    Console.WriteLine(" Наименьший множитель числа " + num + " = 2 " + "\n");
                else if ((num % 3) == 0)
                    Console.WriteLine(" Наименьший множитель числа " + num + " = 3 " + "\n");
                else if ((num % 5) == 0)
                    Console.WriteLine(" Наименьший множитель числа " + num + " = 5" + " \n");
                else if ((num % 7) == 0)
                    Console.WriteLine(" Наименьший множитель числа " + num + " = 7" + "\n");
                else
                    Console.WriteLine(" Число " + num + " не делится на 2, 3, 5 или 7");
            }
            Console.WriteLine();
            Console.Beep();
            Console.WriteLine(" Done ");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            

        }
    }
}

// Продемонстрировать применение оператора switch.

using System;

namespace Test
{
    class SwitchDemo
    {
        static void Main()
        {
            int i;

            Console.ForegroundColor = ConsoleColor.Red;
            
            for(i = 0; i < 10; i++)
                switch (i)
                {
                    case 0:
                        Console.WriteLine(" i = 0 " + "\n");
                        break;
                    case 1:
                        Console.WriteLine(" i = 1 " + "\n");
                        break;
                    case 2:
                        Console.WriteLine(" i = 2 " + "\n");
                        break;
                    case 3:
                        Console.WriteLine(" i = 3 " + "\n");
                        break;
                    case 4:
                        Console.WriteLine(" i = 4" + "\n");
                        break;
                    default:
                        Console.WriteLine(" i = | > 5 " + "\n");
                        break;
             }
            Console.WriteLine(" Done ");
            Console.ReadKey();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Использовать элементы типа char для управления оператором switch.

using System;

namespace Test
{
    class SwitchDemo2
    {
        static void Main()
        {
            char ch;

            Console.ForegroundColor = ConsoleColor.Red;

            for(ch = 'A'; ch <= 'E'; ch++)
                switch (ch)
                {
                    case 'A':
                        Console.WriteLine(" ch содержит А " + "\n");
                        break;
                    case 'B':
                        Console.WriteLine(" ch содержит B " + "\n");
                        break;
                    case 'C':
                        Console.WriteLine(" ch содержит C " + "\n");
                        break;
                    case 'D':
                        Console.WriteLine(" ch содержит D " + "\n");
                        break;
                    case 'E':
                        Console.WriteLine(" ch содержит E " + "\n");
                        break;
                }
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Beep();
        }
    }
}