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


// Пример "проваливания" пустых ветвей case.

using System;

namespace Test
{
    class EmptyCasesCanFall
    {
        static void Main()
        {
            int i;

            Console.ForegroundColor = ConsoleColor.Red;

            for(i = 0; i < 5; i++)
                switch (i)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine(" i = 1, 2 или 3 " + "\n");
                        break;
                    case 4:
                        Console.WriteLine(" i = 4 " + "\n");
                        break;
                }
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}

//  Выполнение цикла for в отрицательном направлении.

using System;

namespace Test
{
    class DecrFor
    {
        static void Main()
        {
            int x;

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(" Выполнение цикла for в отрицательном направлении " + " \n");
            for (x = 100; x > -100; x -= 5)
                Console.WriteLine(x + "\n");
            
            int y;

            Console.WriteLine(" Выполнение цикла for в положительном направлении " + "\n");
            for (y = -100; y < 100; y += 5)
                Console.WriteLine(y + "\n");
           
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}

// Выяснить, является ли число простым. Если оно
// непростое, вывести наибольший его множитель.

using System;

namespace Test
{
    class FindPrimes
    {
        static void Main()
        {
            int num;
            int i;
            int factor;
            bool isprime;

            Console.ForegroundColor = ConsoleColor.Red;

            for (num = 2; num < 20; num++)
            {
                isprime = true;
                factor = 0;

                // Выяснить, делится ли значение переменной num нацело.

                for (i = 2; i <= num / 2; i++)
                {
                    if ((num % i) == 0)
                    {
                        // Значение переменной num делится нацело.
                        // Следовательно, это непростое число.

                        isprime = false;
                        factor = i;
                    }

                    if (isprime)
                        Console.WriteLine(num + " — простое число " + "\n");
                    else
                        Console.WriteLine(" Наибольший множитель числа " + num + " = " + factor + "\n");
                }
            }

            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
      }
  }

// Использовать запятые в операторе цикла for

using System;

namespace Test
{
    class Comma
    {
        static void Main()
        {
            int i;
            int j;

            Console.ForegroundColor = ConsoleColor.Red;

            for ( i = 0, j = 10; i <= j; i++, j--)
                    Console.WriteLine(" i и j =  " + i + " и " + j + "\n");

            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    
    }
}

// Использовать запятые в операторе цикла for для
// выявления наименьшего и наибольшего множителя числа.

using System;

namespace Test
{
    class Comma
    {
        static void Main()
        {
            int i;
            int j;
            int smallest;
            int largest;
            int num;

            num = 100;
            smallest = largest = 1;

            Console.ForegroundColor = ConsoleColor.Red;

            for ( i = 2, j = num / 2; (i <= num / 2) & (j >= 2); i++, j--){
                if ((smallest == 1) & ((num % i) == 0))
                    smallest = i;
                if ((largest == 1) & ((num % j) == 0))
                    largest = j;
            }
            Console.WriteLine(" Наибольший множитель = " + largest + "\n");
            Console.WriteLine(" Наименьший множитель = " + smallest + "\n");

            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}

// Условием выполнения цикла может служить любое выражение типа bool.

using System;

namespace Test
{
    class forDemo
    {
        static void Main()
        {
            int i;
            int j;
            bool done = false;

            Console.ForegroundColor = ConsoleColor.Red;

            for (i = 0, j = 100; !done; i++, j--)
            {
                if (i * i >= j) done = true;
                Console.WriteLine(" i и j = " + i + " и " + j + "\n");
            }
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}

// Отдельные части цикла for могут оставаться пустыми.

using System;

namespace Test
{
    class Emty
    {
        static void Main()
        {
            int i;

            Console.ForegroundColor = ConsoleColor.Red;

            for (i = 0; i < 10;)
            {
                Console.WriteLine(" Проход № " + i + "\n");
                i++; // инкрементировать переменную управления циклом
            }
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}

// Исключить еще одну часть из определения цикла for.

using System;

namespace Test
{
    class Empty2
    {
        static void Main()
        {
            int i;

            Console.ForegroundColor = ConsoleColor.Red;

            i = 0; // исключить инициализацию из определения цикла
            for(; i < 10;)
            {
                Console.WriteLine(" Проход № " + i + "\n");
                i++; // инкрементировать переменную управления циклом
            }
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Тело цикла может быть пустым.

using System;

namespace Test
{
    class Empty3
    {
        static void Main()
        {
            int i;
            int sum = 0;

            Console.ForegroundColor = ConsoleColor.Blue;

            // получить сумму чисел от 1 до 5

            for (i = 1; i <= 5; sum += i++)
            {
                Console.WriteLine(" Сумма = " + sum + "\n");
            }
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}