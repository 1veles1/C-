// Определить наименьший множитель заданного целого значения, состоящий из одной цифры.
/*
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
*/
// Продемонстрировать применение оператора switch.
/*
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
/*
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
*/
// Пример "проваливания" пустых ветвей case.
/*
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
*/
//  Выполнение цикла for в отрицательном направлении.
/*
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
*/
// Выяснить, является ли число простым. Если оно непростое, вывести наибольший его множитель.
/*
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
*/
// Использовать запятые в операторе цикла for
/*
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
*/
// Использовать запятые в операторе цикла for для выявления наименьшего и наибольшего множителя числа.
/*
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
*/
// Условием выполнения цикла может служить любое выражение типа bool.
/*
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
*/
// Отдельные части цикла for могут оставаться пустыми.
/*
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

*/
// Исключить еще одну часть из определения цикла for.
/*
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
/*
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
*/
// Объявить переменную управления циклом в самом цикле for.
/*
using System;

namespace Test
{
    class ForVar
    {
        static void Main()
        {
            int sum = 0;
            int fact = 1;

            Console.ForegroundColor = ConsoleColor.Blue;

            // вычислить факториал чисел от 1 до 5

            for (int i  = 1; i <= 5; sum += i++)
            {
                sum += i; // Переменная i действует в цикле.
                fact *= i;
            }

            // А здесь переменная i недоступна.

            Console.WriteLine(" Сумма равна " + sum + "\n");
            Console.WriteLine(" Факториал равен " + fact + "\n");
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Калькулятор
/*
using System;

namespace FirstApp
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Calculator calc = new Calculator();
            calc.Add(2, 3);
        }
    }

    // объявление нового класса

    class Calculator
    {
        public void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Сумма {0} и {1} равна {2}", x, y, z, "\n");
            Console.ReadLine();
            Console.Beep();
        }
    }
}
*/
// Вычислить порядок величины целого числа. Оператор цикла while
/*
using System;

namespace Example
{
    class WhileDemo
    {
        static void Main()
        {
            int num;
            int mag;

            num = 435679;
            mag = 0;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Число =  " + num + "\n");

            while (num > 0)
            {
                mag++;
                num = num / 10;
            }
            Console.WriteLine(" Порядок величины = " + mag + "\n");
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Вычислить целые степени числа 2.
/*
using System;

namespace Test
{
    class Power
    {
        static void Main()
        {
            int e;
            int result;

            Console.ForegroundColor = ConsoleColor.Blue;

            for( int i = 0; i < 10; i++)
            {
                result = 1;
                e = i;

                while (e > 0)
                {
                    result *= 2;
                    e--;
                }
                Console.WriteLine(" 2 в степени " + i + " = " + result + "\n");
            }
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Отобразить цифры целого числа в обратном порядке.
/*
using System;

namespace Test
{
    class DoWhileDemo
    {
        static void Main()
        {
            int num;
            int nextdigit;

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            num = 198;
            Console.WriteLine(" Число = " + num + "\n");
            Console.WriteLine(" Число в обратном порядке " + num + "\n");

            do
            {
                nextdigit = num % 10;
                Console.Write(nextdigit);

                num = num / 10;
            }
            while (num > 0);

            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Применить оператор break для выхода из цикла.
/*
using System;

namespace Test
{
    class BreakDemo
    {
        static void Main()
        {
            // Использовать оператор break для выхода из этого цикла.

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            for( int i = -10; i <= 0; i++)
            {
                if (i > 0)
                break; // завершить цикл, как только значение переменной i станет положительным 

                Console.Write(i + " ");
            }
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Применить оператор break для выхода из цикла do-while.
/*
using System;

namespace Test
{
    class BreakDemo2
    {
        static void Main()
        {
            int i = -10;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            do
            {
                if (i > 0)
                    break;

                Console.Write(i + " ");

                i++;
            }
            while (i <= 10);

            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Выявить наименьший множитель числа.
/*
using System;

namespace Test
{
    class FindSmallestFactor
    {
        static void Main()
        {
            int factor = 1;
            int num = -1000;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            for( int i = 2; i <= num/i; i++)
            {
                if(( num / i) == 0)
                {
                    factor = i;
                    break; // прервать цикл, как только будет выявлен наименьший множитель числа
                }
            }
            Console.WriteLine(" Наименьший множитель = " + factor + "\n");
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Применить оператор break во вложенных циклах.
/*
using System;

namespace Test
{
    class BreakNested
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" Подсчет во внешнем цикле = " + i + "\n");
                Console.Write(" Подсчет во внутреннем цикле = ");

                int t = 0;
                while (t < 100)
                {
                    if (t == 10)
                        break; // прервать цикл, если t равно 10

                    Console.Write(t + " ");

                    t++;
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine(" Циклы завершены");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Применить оператор continue.
/*
using System;

namespace Test
{
    class ContDemo
    {
        static void Main()
        {
            // вывести четные числа от 0 до 100.

            Console.ForegroundColor = ConsoleColor.DarkRed;

            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) != 0)
                    continue; // перейти к следующему шагу итерации
                Console.WriteLine(i);

            }
            Console.WriteLine();
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
 }
*/
// Применить оператор goto в операторе switch.
/*
using System;

namespace Test
{
    class SwitchGoto
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (int i = 1; i < 5; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine(" В ветви case 1" + "\n");
                        goto case 3;
                    case 2:
                        Console.WriteLine(" В ветви case 2" + "\n");
                        goto case 1;
                    case 3:
                        Console.WriteLine(" В ветви case 3" + "\n");
                        goto default;
                    default:
                        Console.WriteLine(" В ветви default" + "\n");
                        break;
                }
                Console.WriteLine();
            }
            
            // goto case 1; // Ошибка! Безусловный переход к оператору switch недопустим.

            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Продемонстрировать практическое применение оператора goto.
/*
using System;

namespace Test
{
    class Use_goto
    {
        static void Main()
        {
            int i = 0, j = 0, k = 0;
            for (i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                for (j = 0; j < 10; j++)
                {
                    for (k = 0; k < 10; k++)
                    {
                        Console.WriteLine(" i, j, k = " + i + " " + j + " " + k + "\n");
                        if (k == 3) goto stop;
                    }
                }
            }
        stop:
            Console.WriteLine(" Остановлено! i, j, k = " + i + ", " + j + " " + k + "\n");
            Console.WriteLine();
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Программа, в которой используется класс Building.
/*
using System;

namespace Test
{
    class Building
    {
        public int Floors; // Количество этажей
        public int Area;   // Площадь здания 
        public int Occupants; // Количество жильцов
    }
        // В этом классе объявляется объект типа Building.

        class BuildingDemo
    {
        static void Main()
        {
            Building house = new Building(); // создать объект типа Building
            int areaS; // площадь на одного человека

            // Присвоить значения полям в объекте house.

            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // Вычислить площадь на одного человека.

            areaS = house.Area / house.Occupants;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" Дом имеет = \n " + house.Floors + " этажа \n " + house.Occupants + " жильца \n " + house.Area + 
                                " кв. футов общей площади, из них \n " +  areaS + " приходится на одного человека");
            Console.WriteLine();
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
 }
*/
// В этой программе создаются два объекта типа Building.
/*
using System;

namespace Test
{
    class Building
    {
        public int Floors; // количество этажей
        public int Area; // общая площадь здания
        public int Occupants; // количество жильцов
    }
    // В этом классе объявляются два объекта типа Building.

    class BuildingDemo
    {
        static void Main()
        {
            Building house = new Building();
            Building office = new Building();

            int areaPP;

            // Присвоить значения полям в объекте house.

            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // Присвоить значения полям в объекте office.

            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            // Вычислить площадь на одного человека в жилом доме.

            areaPP = house.Area / house.Occupants;

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Дом имеет = \n " + house.Floors + " этажа\n " + house.Occupants + " жильца\n " + house.Area + 
                                " кв. футов общей площади, из них\n " + areaPP + " приходится на одного человека" + "\n");

            // Вычислить площадь на одного человека в учреждении.

            areaPP = office.Area / office.Occupants;

            Console.WriteLine("Учреждение имеет = \n " + office.Floors + " этажа\n " + office.Occupants + " работников\n " + office.Area + 
                                " кв. футов общей площади, из них\n " + areaPP + " приходится на одного человека" + "\n");
            Console.WriteLine();
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Добавить метод в класс Building.
/*
using System;

namespace Test
{
    class Building
    {
        public int Floors; // количество этажей
        public int Area; // общая площадь здания
        public int Occupants; // // количество жильцов

        // Вывести площадь на одного человека,

        public void AreaPerPerson()
        {
            Console.WriteLine("\n" + Area / Occupants + " приходится на одного человека ");
        }
    
    }
        // Использовать метод AreaPerPerson()

    class BuldingDemo
    {
        static void Main()
        {
            Building house = new Building();
            Building office = new Building();

            // Присвоить значения полям в объекте house.

            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // Присвоить значения полям в объекте office.

            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" Дом имеет = " + house.Floors + " этажа " + house.Occupants + " жильца " + house.Area + 
                                "кв.  футов общей площади, из них ");
            house.AreaPerPerson();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" Учреждение имеет = " + office.Floors + " этажа " + office.Occupants + 
                                " работников " + office.Area + " кв. футов общей площади, из них ");
            office.AreaPerPerson();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Возвратить значение из метода AreaPerPerson().
/*
using System;

namespace Test
{
    class Building
    {
        public int Floors; // количество этажей
        public int Area; // общая площадь здания
        public int Occupants; // количество жильцов

        // Возвратить величину площади на одного человека,

        public int AreaPerPerson()
        {
            return Area / Occupants;
        }
    }
    // Использовать значение, возвращаемое методом AreaPerPerson!).
    class BuildingDemo
    {
        static void Main()
        {
            Building house = new Building();
            Building office = new Building();

            int areaPP; // площадь на одного человека

            // Присвоить значения полям в объекте house.

            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // Присвоить значения полям в объекте office.

            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            // Получить площадь на одного человека в жилом доме.

            areaPP = house.AreaPerPerson(); // При использовании закоментированого способа эта строка не нужна !!!

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Дом имеет =  " + house.Floors + " этажа " + house.Occupants + " жильца " + house.Area +
                                " кв. футов общей площади, из них " + "\n" + areaPP + " приходится на одного человека");

            // Console.WriteLine("Дом имеет =  " + house.Floors + " этажа " + house.Occupants + " жильца " + house.Area +
            // " кв. футов общей площади, из них " + house.AreaPerPerson() + " приходится на одного человека");

            Console.WriteLine();

            // Получить площадь на одного человека в учреждении.

            areaPP = office.AreaPerPerson(); // При использовании закоментированого способа эта строка не нужна !!!

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Учреждение имеет = " + office.Floors + " этажа " + office.Occupants + " работников " +
                                office.Area + " кв. футов общей площади, из них" + "\n" + areaPP + " приходится на одного человека");

            // Console.WriteLine("Учреждение имеет = " + office.Floors + " этажа " + office.Occupants + " работников " +
            //                   office.Area + " кв. футов общей площади, из них" + house.AreaPerPerson() + " приходится на одного человека");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Простой пример применения параметра.
/*
using System;

namespace Test
{
    class ChkNum
    {
        // Возвратить значение true, если значение параметра х окажется простым числом.

        public bool IsPrime(int x)
        {
            if (x <= 1)
                return false;
            for (int i = 2; i <= x / i; i++)
                if ((x % i) == 0)
                    return false;
            return true;
        }
    }
    class ParmDemo
    {
        static void Main()
        {
            ChkNum ob = new ChkNum();

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (int i = 2; i < 10; i++)
                if (ob.IsPrime(i))
                     Console.WriteLine(i + " простое число" + "\n");
                else Console.WriteLine(i + " непростое число" +"\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();

        }
    }
}
*/
// Добавить метод, принимающий два аргумента.
/*
using System;

namespace Test
{
    class ChkNum
    {
        // Возвратить значение true, если значение параметра х окажется простым числом.

        public bool IsPrime(int x)
        {
            if (x <= 1) return false;

            for (int i = 2; i <= x / i; i++)
                if ((x % i) == 0)
                    return false;
            return true;
        }
        
        // Возвратить наименьший общий множитель.
        public int LeastComFactor(int a, int b)
        {
            int max;

            if (IsPrime(a) || IsPrime(b))
                return 1;

            max = a < b ? a : b;

            for (int i = 2; i <= max / 2; i++)
                if (((a % i) == 0) && ((b % i) == 0))
                    return i;
            return 1;
        }
    }
    class ParmDemo
    {
        static void Main()
        {
            ChkNum ob = new ChkNum();

            int a, b;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            for (int i = 2; i < 10; i++)
                if (ob.IsPrime(i))
                    Console.WriteLine(" " + i + " простое число" + "\n");
                else Console.WriteLine(" " + i + " непростое число." + "\n");

            a = 7;
            b = 8;

            Console.WriteLine(" Наименьший общий множитель чисел " + a + " и " + b + " = " + ob.LeastComFactor(a, b) + "\n");

            a = 100;
            b = 8;

            Console.WriteLine(" Наименьший общий множитель чисел " + a + " и " + b + " = " + ob.LeastComFactor(a, b) + "\n");

            a = 100;
            b = 75;

            Console.WriteLine(" Наименьший общий множитель чисел " + a + " и " + b + " = " + ob.LeastComFactor(a, b) + "\n");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Добавить параметризированный метод, вычисляющий максимальное количество человек, которые могут занимать здание, исходя из заданной минимальной площади на одного человека.
/*
using System;

namespace Test
{
    class Building
    {
        public int Floors; // количество этажей
        public int Area; // общая площадь здания
        public int Occupants; // количество жильцов

        // Возвратить площадь на одного человека.
        public int AreaPerPerson()
        {
            return Area / Occupants;
        }

        // Возвратить максимальное количество человек, занимающих здание,
        // исходя из заданной минимальной площади на одного человека.

        public int MaxOccupant(int minArea)
        {
            return Area / minArea;
        }
    }
    // Использовать метод MaxOccupant().
    class BuildingDemo
    {
        static void Main()
        {
            Building house = new Building();
            Building office = new Building();

            // Присвоить значения полям в объекте house.

            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // Присвоить значения полям в объекте office.

            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Максимальное количество человек в доме " + " если на каждого должно приходиться " +
                                300 + " кв. футов = " + house.MaxOccupant(300) + "\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" Максимальное количество человек " + "в учреждении, " + "если на каждого должно приходиться " +
                                300 + " кв. футов = " + office.MaxOccupant(300) + "\n");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
    }
}
*/
// Простой конструктор.
/*
using System;

namespace Test
{
    class MyClass
    {
        public int x;

        public MyClass()
        {
            x = 10;
        }
    }
    class ConsDemo
    {
        static void Main()
        {
            MyClass t1 = new MyClass();
            MyClass t2 = new MyClass();

            Console.WriteLine(t1.x + " " + t2.x);
        }
    }
}
*/
// Параметризированный конструктор.
/*
using System;

namespace Test
{
    class MyClass
    {
        public UInt16 x;
        
        public MyClass(UInt16 i)
        {
            x = i;
        }
    }
    class ParmConsDemo
    {
        static void Main()
        {
            MyClass t1 = new MyClass(10);
            MyClass t2 = new MyClass(88);

            Console.WriteLine(t1.x + " " + t2.x);
        }
    }
}
*/
// Добавить конструктор в класс Building.
/*
using System;

class Building
{
    public int Floors; // количество этажей
    public int Area; // общая площадь здания
    public int Occupants; // количество жильцов
                          
    // Параметризированный конструктор для класса Building.
    public Building(int f, int a, int o)
    {
        Floors = f;
        Area = a;
        Occupants = o;
    }
    // Возвратить площадь на одного человека.
    public int AreaPerPerson()
    {
        return Area / Occupants;
    }
    // Возвратить максимальное количество человек, занимающих здание,
    // исходя из заданной минимальной площади на одного человека.
    public int MaxOccupant(int minArea)
    {
        return Area / minArea;
    }
}
// Использовать параметризированный конструктор класса Building.
class BuildingDemo
{
    static void Main()
    {
        Building house = new Building(2, 2500, 4);
        Building office = new Building(3, 4200, 25);

        Console.WriteLine("Максимальное количество человек в доме, \n" +
        "если на каждого должно приходиться " +
        300 + " кв. футов: " +
        house.MaxOccupant(300));

        Console.WriteLine("Максимальное количество человек " +
        "в учреждении, \n" +
        "если на каждого должно приходиться " +
        300 + " кв. футов: " +
        office.MaxOccupant(300));
    }
}
*/
// Использовать оператор new вместе с типом значения.
/*
using System;
class newValue
{
    static void Main()
    {
        int i = new int(); // инициализировать переменную i нулевым значением
        Console.WriteLine("Значение переменной i равно: " + i);
    }
}
*/
// Продемонстрировать применение деструктора.
/*
using System;

namespace Test {
    
    class Destruct {
        
        public int x;

        public Destruct(int i) {
            x = i;
        }
        
        // Вызывается при утилизации объекта.

        ~Destruct() {
            Console.WriteLine(" Уничтожить " + x);
        }
        
        // Создает объект и тут же уничтожает его

        public void Generator(int i) {
            Destruct o = new Destruct(i);
        }
    }
    class DestructDemo {
        
            static void Main() {
            int count;
            
            Destruct ob = new Destruct(0);

            // А теперь создать большое число объектов.
            // В какой-то момент произойдет "сборка мусора".
            // Примечание: для того чтобы активизировать
            // "сборку мусора", возможно, придется увеличить
            // число создаваемых объектов. 

            for (count = 1; count < 100000; count++)
                ob.Generator(count);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" Done ! ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadLine();
            Console.Beep();
        }
    }
}
*/
// this
/*
using System;

namespace Test {
    class Rect {
        public Int32 Width;
        public Int32 Height;

        public Rect(Int32 w, Int32 h) {

            this.Width = w;
            this.Height = h;
        }
        public Int32 Area() {
                     
            // return Weight * Height;
            
            return this.Width * this.Height;
        }
        }
    class UseRect {
    static void Main() {
            
            Rect r1 = new Rect(4, 5);
            Rect r2 = new Rect(7, 9);
            Rect r3 = new Rect(245, 345);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Площадь прямоугольника r1 = " + r1.Area() + "\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" Площадь прямоугольника r2 = " + r2.Area() +"\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" Площадь прямоугольника r3 =" + r3.Area() + "\n");
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Clear();
            Console.Beep();

        }
        }
}
*/
// приведен весь класс  Rect, написанный с использованием ссыл­ки this.

using System;

namespace Test {

class Rect {
        public Int32 Width;
        public Int32 Height;

        public Rect(Int32 w, Int32 h) {
            this.Width = w;
            this.Height = h;
        }
        public Int32 Area() {
            return this.Width * this.Height;
        }
}
class UseRect {
static void Main() {
            Rect r1 = new Rect(4, 5);
            Rect r2 = new Rect(7, 9);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" Площадь прямоугольника r1 = " + r1.Area() + "\n");
            Console.WriteLine(" Площадь прямоугольника r2 =  " + r2.Area() + "\n");
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine(" Done ");
            Console.ReadLine();
            Console.Beep();
        }
}
}
