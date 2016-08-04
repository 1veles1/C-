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
*/
// Продемонстрировать одномерный массив.
/*
using System;

namespace Test
{
class ArrayDemmo {
static void Main() {
            Int32[] sample = new Int32[10];
            Int32 i;

            for (i = 0; i < 10; i++)
                sample[i] = i;
            for (i = 0; i < 10; i++)
                Console.WriteLine(" sample [ " + i + " ] = " + sample[i]);
}
}
}
*/
// Вычислить среднее арифметическое ряда значений.
/*
using System;

namespace Test {
class Average {
static void Main() {
            Int32[] nums = new Int32[10];
            Int32 avg = 0;

            nums[0] = 99;
            nums[1] = 10;
            nums[2] = 100;
            nums[3] = 18;
            nums[4] = 78;
            nums[5] = 23;
            nums[6] = 63;
            nums[7] = 9;
            nums[8] = 87;
            nums[9] = 49;

            for (int i = 0; i < 10; i++)
                avg = avg + nums[i];
            avg = avg / 10;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Среднее арифметическое = " + avg);
            Console.WriteLine(new string('-', 28));
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Done ! ");
            Console.ReadLine();            
            Console.Beep();
        }
}
}
*/
// Вычислить среднее арифметическое ряда значений.
/*
using System;

namespace Test {
class Average {
static void Main() {
            Int32[] nums = { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };
            Int32 avg = 0;

            for (Int32 i = 0; i < 10; i++)
                avg = avg + nums[i];
            avg = avg / 10;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Среднее арифметическое = " + avg);
            Console.WriteLine(new string('-', 28));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Done ! ");
            Console.WriteLine(new string('-', 28));
            Console.ReadLine();
            Console.Beep();
        }
}
}
*/
// Продемонстрировать превышение границ массива.
/*
using System;
class ArrayErr
{
    static void Main()
    {
        int[] sample = new int[10];
        int i;
        
        // Воссоздать превышение границ массива.
        
        for (i = 0; i < 100; i = i + 1)
            sample[i] = i;
    }
}
*/
// Продемонстрировать двумерный массив.
/*
using System;

namespace Test {
class Twod {
static void Main() {
            Int32 t, i;
            Int32[,] table = new Int32[3, 4];

            for(t = 0; t < 3; ++t) {
            for(i = 0; i < 4; ++i) {
                    table[t, i] = (t * 4) + i + 1;
                    
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(table[t, i] + "\n");                  
                }
                }
            Console.WriteLine(new string('-', 28));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Done ! ");
            Console.WriteLine(new string('-', 28));
            Console.ReadLine();
            Console.Beep();
        }
}
}
*/
// Суммировать значения по одной из диагоналей матрицы 3×3×3.
/*
using System;

namespace Test {
class ThreeDMatrix {
static void Main() {
            Int32[,,] m = new Int32[3, 3, 3];
            Int32 sum_d1 = 0;
            Int32 sum_d2 = 0;
            Int32 n = 1;

            for (Int32 x = 0; x < 3; x++)
                for (Int32 y = 0; y < 3; y++)
                    for (Int32 z = 0; z < 3; z++)
                        m[x, y, z] = n++;
            sum_d1 = m[0, 0, 0] + m[1, 1, 1] + m[2, 2, 2];
            sum_d2 = m[2, 2, 0] + m[1, 1, 1] + m[0, 2, 2];

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" Сумма значений по первой диагонали = " + sum_d1 + "\n");
            Console.WriteLine(new string('-', 40));

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" Сумма значений по второй диагонали = " + sum_d2 + "\n");
            Console.WriteLine(new string('-', 40));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Done ! ");
            Console.WriteLine(new string('-', 40));
            Console.ReadLine();
            Console.Beep();
        }
}
}
*/
// Инициализировать двумерный массив.
/*
using System;

namespace Test
{

    class Squares
    {
        static void Main()
        {
            int[,] sqrs = {
                        { 1, 1 },
                        { 2, 4 },
                        { 3, 9 },
                        { 4, 16 },
                        { 5, 25 },
                        { 6, 36 },
                        { 7, 49 },
                        { 8, 64 },
                        { 9, 81 },
                        { 10, 100 }
                        };
            int i, j;

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 2; j++)

                    Console.Write(sqrs[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
*/
// Продемонстрировать применение ступенчатых массивов.
/*
using System;

namespace Test {
class Jadded {
static void Main() {
            Int32[][] jagged = new Int32[3][];
            jagged[0] = new Int32[4];
            jagged[1] = new Int32[3];
            jagged[2] = new Int32[5];

            Int32 i;

            // Сохранить значения в первом массиве.

            for (i = 0; i < 4; i++)
                jagged[0][i] = i;

            // Сохранить значения во втором массиве.

            for (i = 0; i < 3; i++)
                jagged[1][i] = i;

            // Сохранить значения в третьем массиве.

            for (i = 0; i < 5; i++)
                jagged[2][i] = i;

            // Вывести значения из первого массива.

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (i = 0; i < 4; i++)
                Console.Write(" " + jagged[0][i] + " ");
            Console.WriteLine();
            Console.WriteLine(new string ('*', 15) + "\n");

            // Вывести значения из второго массива.

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            for (i = 0; i < 3; i++)
                Console.Write(" " + jagged[1][i] + " ");
            Console.WriteLine();
            Console.WriteLine(new string ('*', 15) + "\n");

            // Вывести значения из третьего массива.
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (i = 0; i < 5; i++)
                Console.Write(" " + jagged[2][i] + " ");
            Console.WriteLine();
            Console.WriteLine(new string('*', 15) + "\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Done ! " + "\n");
            Console.WriteLine(new string('*', 15));
            Console.ReadLine();
            Console.Beep();
        }
    }
}
*/
// Присваивание ссылок на массивы.
/*
using System;

namespace Test {
class AssignARef {
static void Main() {

            Int32 i;

            int[] nums1 = new int[10];
            int[] nums2 = new int[10];
            
            Console.ForegroundColor = ConsoleColor.Blue;

            for (i = 0; i < 10; i++) nums1[i] = i;
            for (i = 0; i < 10; i++) nums2[i] = -i;
                        
            Console.Write(" Содержимое массива nums1 = ");
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            for (i = 0; i < 10; i++)
                            
            Console.Write(nums1[i] + " ");
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            Console.Write(" Содержимое массива nums2 = ");

            for (i = 0; i < 10; i++)
                      
            Console.Write(nums2[i] + " ");
            Console.WriteLine();
            
            nums2 = nums1; // теперь nums2 ссылается на nums1
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            Console.Write(" Содержимое массива nums2 после присваивания = ");
            
            for (i = 0; i < 10; i++)
            
            Console.Write(nums2[i] + " ");
            Console.WriteLine();
            
            // Далее оперировать массивом nums1 посредством
            // переменной ссылки на массив nums2.
            
            nums2[3] = 99;
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.Write(" Содержимое массива nums1 после изменения посредством переменной nums2 = ");
            for (i = 0; i < 10; i++)
            
            Console.Write(nums1[i] + " ");
            Console.WriteLine();
        }
}
}
*/
// Использовать свойство Length массива.
/*
using System;

namespace Test {
class LenghtDemo {
static void Main() {
            Int32[] nums = new Int32[10];
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;            
            Console.WriteLine(new string('*', 24) + "\n");
            Console.WriteLine(" Длина массива nums = " + nums.Length);
            Console.WriteLine();
            Console.WriteLine(new string('*', 24) + "\n");

            // Использовать свойство Length для инициализации массива nums.

            for (Int32 i = 0; i < nums.Length; i++)
                nums[i] = i * i;

            // А теперь воспользоваться свойством Length для вывода содержимого массива nums.
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(new string('*', 62) + "\n");
            Console.Write(" Содержимое массива nums = ");
            
            for (Int32 i = 0; i < nums.Length; i++)
                  
            Console.Write(" " + nums[i] + " ");
            Console.WriteLine("\n");
            Console.WriteLine(new string('*', 62) + "\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('*', 7) + "\n");
            Console.WriteLine(" Done ! " + "\n");
            Console.WriteLine(new string('*', 7));
            Console.ReadLine();
            Console.Beep();
        }
    }
}
*/
// Прямоугольник в консоли
/*
using System;
using System.Collections.Generic;
using System.Text;

namespace Equation
{
    class Program
    {
        const char DBL_VLINE = '║';
        const char DBL_HLINE = '═';
        const char DBL_LUCORNER = '╔';
        const char DBL_LDCORNER = '╚';
        const char DBL_RUCORNER = '╗';
        const char DBL_RDCORNER = '╝';

        static void Main(string[] args)
        {
            int width = 50, height = 20;
            int sx = (Console.WindowWidth - width) / 2;
            int sh = (Console.WindowHeight - height) / 2;

            Console.CursorTop = sh; Console.CursorLeft = sx;
            Console.Write(DBL_LUCORNER);
            Console.CursorTop = sh; Console.CursorLeft = sx + width - 1;
            Console.Write(DBL_RUCORNER);
            Console.CursorTop = sh + height - 1; Console.CursorLeft = sx;
            Console.Write(DBL_LDCORNER);
            Console.CursorTop = sh + height - 1; Console.CursorLeft = sx + width - 1;
            Console.Write(DBL_RDCORNER);

            // Draw horizontal lines.
            for (int i = 0; i < width - 2; i++)
            {
                Console.CursorTop = sh;
                Console.CursorLeft = sx + 1 + i;
                Console.Write(DBL_HLINE);

                Console.CursorTop = sh + height - 1;
                Console.CursorLeft = sx + 1 + i;
                Console.Write(DBL_HLINE);
            }

            // Draw vertical lines.
            for (int i = 0; i < height - 2; i++)
            {
                Console.CursorTop = sh + 1 + i;
                Console.CursorLeft = sx;
                Console.Write(DBL_VLINE);

                Console.CursorTop = sh + 1 + i;
                Console.CursorLeft = sx + width - 1;
                Console.Write(DBL_VLINE);
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
*/
// Использовать свойство Length трехмерного массива.
/*
using System;

namespace Test {
class LenghtDemo3D {
static void Main() {
            Int32[,,] nums = new Int32[10, 5, 6];
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(new string('*', 25));
            Console.WriteLine(" Длина массива nums = " + nums.Length);
            Console.WriteLine(new string('*', 25) + "\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('*', 7));
            Console.WriteLine(" Done ! ");
            Console.WriteLine(new string('*', 7));
            Console.ReadLine();
            Console.Beep();
        }
	}
}
*/
// Поменять местами содержимое элементов массива.
/*
using System;

namespace Test
	{
	class RevCopy
		{
		static void Main ()
			{
			int i, j;
			int[] nums1 = new int[10];
			int[] nums2 = new int[10];

			for ( i = 0; i < nums1.Length; i++ ) nums1[i] = i;

			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine( new string( '*', 50 ) );

			Console.ForegroundColor = ConsoleColor.DarkYellow;

			Console.Write( " Исходное содержимое массива = " );

			for ( i = 0; i < nums2.Length; i++ )
				Console.Write( nums1[i] + " " );
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine( new string( '*', 50 ) );
			Console.WriteLine();

			// Скопировать элементы массива nums1 в массив nums2 в обратном порядке.

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine( new string( '*', 60 ) );

			Console.ForegroundColor = ConsoleColor.DarkYellow;

			if ( nums2.Length >= nums1.Length ) // проверить, достаточно ли длины массива nums2
				for ( i = 0, j = nums1.Length - 1; i < nums1.Length; i++, j-- )
					nums2[j] = nums1[i];

			Console.Write( " Содержимое массива в обратном порядке = " );
			
			for ( i = 0; i < nums2.Length; i++ )
				Console.Write( nums2[i] + " " );
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine( new string( '*', 60 ) );
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine( new string( '*', 7 ) );

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine( " Done ! " );

			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine( new string( '*', 7 ) );

			Console.ReadLine();
			Console.Beep();
			}
		}
	}
*/
// Продемонстрировать применение свойства Length при обращении со ступенчатыми массивами.
/*
using System;

namespace Test
	{
	class Jagged
		{
		static void Main ()
			{
			int[][] network_nodes = new int[4][];
			network_nodes[0] = new int[3];
			network_nodes[1] = new int[7];
			network_nodes[2] = new int[2];
			network_nodes[3] = new int[5];
			int i, j;
			// Сфабриковать данные об использовании ЦП.
			for ( i = 0; i < network_nodes.Length; i++ )
				for ( j = 0; j < network_nodes[i].Length; j++ )
					network_nodes[i][j] = i * j + 70;
			Console.WriteLine( "Общее количество узлов сети: " +
			network_nodes.Length + "\n" );
			for ( i = 0; i < network_nodes.Length; i++ )
				{
				for ( j = 0; j < network_nodes[i].Length; j++ )
					{
					Console.Write( "Использование в узле сети " + i +
					" ЦП " + j + ": " );
					Console.Write( network_nodes[i][j] + "% " );
					Console.WriteLine();
					}
				Console.WriteLine();
				}
			}
		}
	}
*/
// Использовать оператор цикла foreach.
/*
using System;

namespace Test
	{
	class ForeachDemo
		{
		static void Main ()
			{
			Int32 sum = 0;
			
			Int32[] nums = new Int32[10];

			// Задать первоначальные значения элементов массива nums.

			for ( Int32 i = 0; i < 10; i++ )
				nums[i] = i;
			
			// Использовать цикл foreach для вывода значений
			// элементов массива и подсчета их суммы.

			foreach(Int32 c in nums )
				{
				
				Console.WriteLine(" Значение элемента равно = " + c);
				sum += c;
				}
			Console.WriteLine(" Сумма равна = " + sum );
			}
		}
	} 
*/
// Использовать оператор break для преждевременного завершения цикла foreach.
/*
using System;

namespace Test
	{
	class ForeachDemo
		{
		static void Main ()
			{
			Int32 sum = 0;
			Int32[] nums = new Int32[10];

			// Задать первоначальные значения элементов массива nums.

			for (Int32 i = 0; i < 10; i++ )
				nums[i] = i;

			// Использовать цикл foreach для вывода значений
			// элементов массива и подсчета их суммы.

			foreach ( Int32 x in nums )
				{
				Console.WriteLine( " Значение элемента равно = " + x );
				sum += x;
				if ( x == 4 )
					break; // прервать цикл, как только индекс массива достигнет 4
				}
			Console.WriteLine( " Сумма первых 5 элементов = " + sum );
			}
		}
	}
*/
// Использовать оператор цикла foreach для обращения к двумерному массиву.
/*
using System;

namespace Test
	{
	class ForeachDemo
		{
		static void Main ()
			{
			Int32 sum = 0;
			Int32[,] nums = new Int32[3,5];

			// Задать первоначальные значения элементов массива nums.

			for ( Int32 i = 0; i < 3; i++ )
				for ( Int32 j = 0; j < 5; j++ )
					nums[i, j] = ( i + 1 ) * ( j + 1 );

			// Использовать цикл foreach для вывода значений
			// элементов массива и подсчета их суммы.

			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(new string('*', 29));

			foreach (Int32 x in nums )
				{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine(" Значение элемента равно = " + x);
				sum += x;
				}
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine( new string( '*', 29));
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine(new string('*', 17));

			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(" Сумма равна = " + sum );			

			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine( new string( '*', 17 ));
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine( new string( '*', 7 ));
			Console.WriteLine( " Done ! " );
			Console.WriteLine( new string( '*', 7 ));
			Console.ReadLine();
			Console.Beep();
			}
		}
	}
*/
// Поиск в массиве с помощью оператора цикла foreach.
/*
using System;

namespace Test
	{
	class Search
		{
		static void Main()
			{
			Int32[] nums = new Int32[10];
			Int32 val;
			Boolean found = false;

			// Задать первоначальные значения элементов массива nums.

			for(Int32 i = 0; i < 10; i++)
				nums[i] = i;
			val = 5;

			// Использовать цикл foreach для поиска заданного
			// значения в массиве nums.

			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine(new string('*', 19));

			foreach(Int32 x in nums)
				{
				if(x == val)
					found = true;
					break;
				}
			if(found)

			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(" Значение найдено ! ");

			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine(new string('*', 19));
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(new string('*', 7));
			Console.WriteLine(" Done ! ");
			Console.WriteLine(new string('*', 7));
			Console.ReadLine();
			Console.Beep();
			}
		}
		
	}
*/
//  Создать и вывести символьную строку.
/*
using System;

namespace Test
	{
	class StringDemo
		{
		static void Main()
			{

			char[] charray = { 'S', 'T', 'R', 'I', 'N', 'G' };

			string str1 = new string(charray);
			string str2 = " Еще одна строка ";

			Console.WriteLine(str1);
			Console.WriteLine(str2);
			}
		}
	}
*/
// Некоторые операции со строками.
/*
using System;
using System.Globalization;

namespace Test
	{
	class StrOps
		{
		static void Main()
			{
			String str1 = "Программировать в .NET лучше всего на С#.";
			String str2 = "Программировать в .NET лучше всего на С#.";
			String str3 = "Строки в C# весьма эффективны.";
			String strUp, strLow;
			Int32 result, idx;

			Console.WriteLine("str1 = " + str1);
			Console.WriteLine("Длина строки str1 = " + str1.Length);

			// Создать варианты строки str1, набранные
			// прописными и строчными буквами.

			strLow = str1.ToLower(CultureInfo.CurrentCulture);
			strUp = str1.ToUpper(CultureInfo.CurrentCulture);

			Console.WriteLine("Вариант строки str1, набранный строчными буквами" + strLow);
			Console.WriteLine("Вариант строки str1,набранный прописными буквами" + strUp);

			Console.WriteLine();

			// Вывести строку str1 посимвольно.

			Console.WriteLine("Вывод строки str1 посимвольно.");
			for(int i = 0; i < str1.Length; i++)
				Console.Write(str1[i]);

			Console.WriteLine("\n");

			// Сравнить строки способом порядкового сравнения.

			if(str1 == str2)
				Console.WriteLine("str1 == str2");
			else
				Console.WriteLine("str1 != str2");
			if(str1 == str3)
				Console.WriteLine("str1 == str3");
			else
				Console.WriteLine("str1 != str3");

			// Сравнить строки с учетом культурной среды.

			result = string.Compare(str3, str1, StringComparison.CurrentCulture);

			if(result == 0)
				Console.WriteLine("Строки str1 и str3 равны");
			else if(result < 0)
				Console.WriteLine("Строка str1 меньше строки str3");
			else
				Console.WriteLine("Строка str1 больше строки str3");

			Console.WriteLine();

			// Присвоить новую строку переменной str2.

			str2 = "Один Два Три Один";

			// Поиск подстроки.

			idx = str2.IndexOf("Один", StringComparison.Ordinal);
			Console.WriteLine("Индекс первого вхождения подстроки <Один> = " + idx);

			idx = str2.LastIndexOf("Один", StringComparison.Ordinal);
			Console.WriteLine("Индекс последнего вхождения подстроки <Один> = " + idx);

			Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('*', 7));
            Console.WriteLine(" Done ! ");
            Console.WriteLine(new string('*', 7));
            Console.ReadLine();
            Console.Beep();
			}
		}
	}
*/
// Продемонстрировать массивы строк.
/*
using System;

namespace Test
	{
	class StringArrays
		{
		static void Main()
			{
			string[] str = { "This", "is", "very", "plain", "test" };

			Console.WriteLine("Source array");

			for(Int32 i = 0; i < str.Length; i++)
				Console.Write(str[i] + " ");
			Console.WriteLine();

			// Change row

			str[1] = "too";
			str[2] = "to limit the test";

			Console.WriteLine("Modified array = ");
			for(Int32 i = 0; i < str.Length; i++)
				Console.Write(str[i] + " ");
			
			}
		}
	}
*/
// Вывести отдельные цифры целого числа словами.
/*
using System;

namespace Test
	{
	class ConvertDigitsToWords
		{
		static void Main()
			{
			Int32 num;
			Int32 nextdigit;
			Int32 numdigits;

			Int32[] n = new Int32[20];
			String[] digits = { "нуль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

			num = 1908;

			Console.WriteLine(" Число = " + num);
			Console.Write(" Число словами = ");

			nextdigit = 0;
			numdigits = 0;

			// Получить отдельные цифры и сохранить их в массиве n.

			do
				{
				nextdigit = num % 10;
				n[numdigits] = nextdigit;
				numdigits++;
				num = num / 10;
				}
			while(num > 0);
			numdigits--;

			// Вывести полученные слова.

			for(; numdigits >= 0; numdigits--)
				Console.Write(digits[n[numdigits]] + " ");
			Console.WriteLine();
			}
		}
	}
*/
// Применить метод Substring().
/*
using System;

namespace Test
	{
	class SubStr
		{
		static void Main()
			{
			string orgstr = " В C# упрощается обращение со строками ";

			// сформировать подстроку

			string substr = orgstr.Substring(5, 20);

			Console.WriteLine("orgstr = " + orgstr);
			Console.WriteLine("substr = " + substr);
			}
		}
	}
*/
// Продемонстрировать управление оператором switch посредством строк.

using System;

namespace Test
	{
	class StringSwitch
		{
		static void Main()
			{
			string[] strs = { "один", "два", "три", "два", "один" };

			foreach(string s in strs)

				switch(s)
					{
					case "один":
						Console.Write(1);
						break;
					case "два":
						Console.Write(2);
						break;
					case "три":
						Console.Write(3);
						break;						
					}
			Console.WriteLine();
			}
		}		
	}
