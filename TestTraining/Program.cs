/*
Это простая программа на С#.
Назовем ее Example.cs.

using System; 

class Example
{
    // Любая программа на C# начинается с вызова метода Main(). 
    static void Main() {
    System.Console.WriteLine("1");
}
} 

// Эта программа демонстрирует применение переменных

using System;

class Example2
{
    static void Main()
    {
        int x; // здесь объявляется переменная
        int y; // здесь объявляется еще одна переменая
        x = 100; // здесь x  присваивается значение 100
        Console.WriteLine("x содержит" + x);
        y = x / 2;
        Console.Write("y содержит x/2 = ");
        Console.WriteLine(y);
    }
}



// Эта программа демонстрирует отличия между типами данных int и double.

using System;
    
 class Example3
{
    static void Main()
    {
        int ivar; // объявить целочисленную переменную 
        double dvar; // объявить переменную с плавающей точкой 
        ivar = 100; // присвоить переменной ivar значение 100
        dvar = 100.0; // присвоить переменной значение 100.0

        Console.WriteLine("Иходное значение ivar = " + ivar);
        Console.WriteLine("Исходное значение dvar = " + dvar);
        Console.WriteLine(); // Вывести пустую строку

        // Разделить значения обеих переменных на 3

        ivar = ivar / 3;
        dvar = dvar / 3.0;

        Console.WriteLine("Значение ivar после деления = " + ivar);
        Console.WriteLine("Значение dvar после деления = " + dvar);
    }

}



// Вычислитьплощадь круга

using System;

class Circle
{
    static void Main()
    {
        double radius;
        double area;
        radius = 10.0;
        area = radius * radius * 3.1416;

        Console.WriteLine(" Площадь равна " + area);
    }
}




// Продемонстрировать применение условного оператора if.
using System;
class IfDemo
{
    private static int а;

    static void Main()
    {
        int a, b, v;
        a = 2; b = 3;
        if (a < b) Console.WriteLine("а меньше b");
        // He подлежит выводу.
        if (a == b) Console.WriteLine("этого никто не увидит");
        Console.WriteLine();
        v = a - b; //с содержит -1
        Console.WriteLine("v содержит - 1");
    if (v >= 0) Console.WriteLine("значение v неотрицательно");
        if (v < 0) Console.WriteLine("значение v отрицательно");
        Console.WriteLine();
        v= b - а; // теперь с содержит 1 Console.WriteLine("с содержит 1");
        if (v >= 0) Console.WriteLine("значение v неотрицательно");
        if (v < 0) Console.WriteLine("значение v отрицательно ");
    }
}




// Демонстрация оператора цикла for
using System;

class ForDemo
{
    static void Main()
    {
        int count;
        // for (count = 0; count < 5; count = count + 1);
        for (count = 0; count < 5; count++); // count++ опрератор инкремента count-- оперератор декремента 
        Console.WriteLine("Это подсчет = " + count);
        Console.WriteLine("Готово !!!");

    }
}



// Применение кодового блока
using System;

class BlockDemo
{
    static void Main()
    {
        int i, j, d;
        i = 5;
        j = 10;
        // Адресатом этого оператора if служит кодовый блок
        if (i != 0)
        {
            Console.WriteLine("i не равно нулю");
            d = j / i;
            Console.WriteLine("j / i = " + d);

        }
    }
}




// Вычислить сумму и произведение чисел от 1 до 10.

using System;

class ProdSum
{
    static void Main()
    {
        int prod;
        int sum;
        int i;
        sum = 0;
        prod = 1;

        for (i = 1; i <= 10; i++)
        {
            sum = sum + i; prod = prod * i;
        }
        Console.WriteLine("Сумма = " + sum);
        Console.WriteLine("Произведение = " + prod);
    }
}



// Продемонстрировать применение идентификатора со знаком

using System;

class IdTest
{
    static void Main()
    {
        int @if; // применение ключевого слова if
                 //в качестве идентификатора
        for (@if = 0; @if < 10; @if++)
            Console.WriteLine("@if равно " + @if);
    }
}


// Вычислить расстояние от Земли до Солнца в дюймах.

using System;

namespace ConsoleApplication1
{
    class Inches
    {
        static void Main()
        {
            long inches;
            long miles;
            
            miles = 93000000;  // 93 000 000 миль до Солнца // 5 280 футов в миле, 12 дюймов в футе
            inches = miles * 5280 * 12;
            
            Console.WriteLine("Расстояние до солнца = " + inches + " дюймов ");

        }
    }
}


using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            long result;
            const long km = 149800000; // расстояние в км.

            result = km * 1000 * 100;

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}


// Использовать тип byte.

using System;

namespace ConsoleApplications
{
    class Use_Byte
    {
        static void Main()
        {
            byte x;
            int sum;
            sum = 0;

            for (x = 1; x <= 100; x++) sum = sum + x;
            Console.WriteLine(" Сумма чисел от 1 до 100 = " + sum);

        }
    }
}


// Определить радиус окружности по площади круга.

using System;

namespace ConsoleApplications1
{
    class FindRadius
    {
        static void Main()
        {
            double r;
            double area;
            area = 10.0;

            r = Math.Sqrt(area / 3.1416);

            Console.WriteLine(" Радиус = " + r);

        }
    }
}


// Продемонстрировать применение тригонометрических функций.

using System;

namespace ConsoleApplication1
{
    class Trigonometry
    {
        static void Main()
        {
            double theta; // угол в радианах
            for (theta = 0.1; theta <= 1.0; theta = theta + 0.1)
            {
                Console.WriteLine(" Синус угла ABC " + theta + " = " + Math.Sin(theta));
                Console.WriteLine();
                Console.WriteLine(" Косинуc угла ABC " + theta + " = " + Math.Cos(theta));
                Console.WriteLine();
                Console.WriteLine(" Тангенс угла ABC " + theta + " = " + Math.Tan(theta));
                Console.WriteLine();
                
            }

        }
    }
}


// Использовать тип decimal для расчета скидки.

using System;

namespace ConsoleApplication1
{
    class UseDecimal
    {
        static void Main()
        {
            decimal price;
            decimal discount;
            decimal discounted_price;

            // Рассчитать цену со скидкой

            price = 19.95m;
            discount = 0.15m;

            // норма скидки составляет 15%

            discounted_price = price - (price * discount);
            //Console.WriteLine(" Цена со скидкой =  " + discounted_price + " $ ");
            //Console.WriteLine("Цена со скидкой: {0:C}", discounted_price);

        }
    }
}


// Применить тип decimal для расчета будущей стоимости капиталовложений.

using System;

namespace ConsoleApplication1
{
    class FutVal
    {
        static void Main()
        {
            decimal amount;
            decimal rate_of_return;
            int years;
            int i;
            amount = 1000.0m;
            rate_of_return = 0.07m;
            years = 10;

            Console.WriteLine(" Первоначальное капиталовложение " + amount + " $ ");
            Console.WriteLine(" Норма прибыли " + rate_of_return + " % ");
            Console.WriteLine(" В течение " + years + " лет ");

            for (i = 0; i < years; i++)
            {
                amount = amount + (amount * rate_of_return);
                Console.WriteLine(" Будущая стоимость = " + amount + " $ ");
                Console.WriteLine();
            }
        }
    }
}

// Продемонстрировать применение типа bool.

using System;

namespace ConsoleApplication1
{
    class BoolDemo
    {
        static void Main()
        {
            bool b;

            b = false;
            Console.WriteLine(" b = " + b);

            b = true;
            Console.WriteLine(" b = " + b);

            // Логическое значение может управлять оператором if.

            if (b) Console.WriteLine(" Выполняется ! ");
            b = false;

            if (b) Console.WriteLine(" Не выполняется! ");

            // Результатом выполнения оператора отношения // является логическое значение.

            Console.WriteLine(" 10 > 9 =" + (10 > 9));

        }
    }
}


// Применить команды форматирования.

using System;

namespace ConsoleApplication1
{
    class DisplayOptions
    {
        static void Main()
        {
            int i;
            Console.WriteLine(" Число Квадрат Куб");
            for (i = 1; i < 10; i++)
            {
                Console.WriteLine(" {0}\t{1}\t{2}", i, i * i, i * i * i);
                
        }
    }
}


// Использовать спецификатор формата С для вывода // результата в местной валюте.

using System;

class UseDecimal
{
    static void Main()
    {
        decimal price;
        decimal discount;
        decimal discounted_price;

        // рассчитать цену со скидкой 

        price = 19.95m;
        discount = 0.15m;

        // норма скидки составляет 15% 

        discounted_price = price - ( price * discount);
        Console.WriteLine("Цена со скидкой = {0:C}", discounted_price);
    }
}


         // Продемонстрировать применение управляющих и  последовательностей символов в строковых литералах.

using System;

namespace ConsoleApplication1
{
    class StrDemo
    {
        static void Main()
        {
            Console.WriteLine(" Первая строка\t Вторая строка\t Третья строка ");
            Console.WriteLine(" Один         \t Два          \t Три ");
            Console.WriteLine(" Четыре       \t Пять         \t Шесть ");

            // Вставить кавычки

            Console.WriteLine();
            Console.WriteLine(" \" Зачем ? \" - спросил он. ");
        }
    }
}

//  Применение буквальных строковых литералов

using System;

namespace ConsoleApplication1
{
    class Verbatium
    {
        static void Main()
        {
            Console.WriteLine(@"Это буквальный строковый литерал, занимающий несколько строк.");
            Console.WriteLine(@"А это вывод с табуляцией: 1 2 3 4
                          5 6 7 8");
            Console.WriteLine();
            Console.WriteLine(@"Отзыв программиста: "" Мне нравиться C#. """);
        }
    }
}


// Продемонстрировать динамическую инициализацию.

using System;

namespace ConsoleApplication1
{
    class Dynlnit
    {
        static void Main()
        {
            // Длина сторонпрямоугольноготреугольника

            double s1 = 4.0;
            double s2 = 5.0;

            // Инициализировать переменную hypot динамически

            double hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.Write(" Гипотенуза треугольника со сторонами " + s1 + " и " + s2 + " = ");
            Console.WriteLine("{0:#.###}", hypot);
        }
    }
}


// Продемонстрировать применение неявно типизированных переменных

using System;

namespace ConsileApplication1
{
    class ImpliSitlyTypedVar
    {
        static void Main()
        {
            // Эти переменные типизированы неявно.Они отнесены 
            // к типу double, поскольку инициализирующие их 
            // выражения сами относятся к типу double

            var s1 = 4.0;
            var s2 = 5.0;

            // Итак, переменная hypot типизирована неявно и 
            // относится к типу double, поскольку результат,
            // возвращаемый методом Sqrt(), имеет тип double, 

            var hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.Write("Гипотенуза треугольника со сторонами " + s1 + " и " + s2 + " = ");
            Console.WriteLine("{0:#.###}", hypot);

        }
    }
}

// Продемонстрировать область действия кодового блока

using System;


class ScopeDemo
{
    private static int х;
    private static int y;

    static void Main()
    {
        int x; // Эта переменная доступна для всего кода внутри метода Main().
        х = 10;
        if (х == 10)
        {
                            // начать новую область действия

                int у = 20; // Эта переменная доступна только в данном кодовом блоке.
                            // Здесь доступны обе переменные, х и у.

                Console.WriteLine("х и у =  " + х + " и " + у);
                х = у * 2;
        }

        // у = 100; // Ошибка! Переменна у здесь недоступна.
        //А переменная х здесь по-прежнему доступна.

        Console.WriteLine("х равно " + х);
    }
}


// Продемонстрировать время существования переменной.

using System;

namespace ConsoleApplication1
{
    class VarlnitDemo
    {
        private static int у;

        static void Main()
        {
            int x;
            for(x = 0; x < 3; x++)
            {
                int y = -1;
                Console.WriteLine("y = " + y); // Здесь всегда выводится -1
                у = 100;
                Console.WriteLine("у теперь = " + у);
            }
        }
    }
}


// Эта программа не может быть скомпилирована

using System;

class NestVar
{
    static void Main()
    {
        int count;
        for (count = 0; count < 10; count = count + 1)
        {
            Console.WriteLine("Это подсчет: " + count);

            int count; // Недопустимо!!!
            for (count = 0; count < 2; count++)
            Console.WriteLine("В этой программе есть ошибка!");
        }
    }
}

// Продемонстрировать неявное преобразование типа long в тип double.

using System;

namespace ConsoleApplication1
{
    class LtoD
    {
        static void Main()
        {
            long L;
            double D;
            L = 100123285L;
            D = L;
            Console.WriteLine(" L  = " + L + " и " + " D = " + D);
            Console.WriteLine();
            Console.WriteLine(@" Поскольку значение D присвоено значение L. Значения одиаковы. ");
        }
    }
}

// *** Эта программа не может быть скомпилирована. ***
using System;

class LtoD
{
    static void Main()
    {
        long L; double D;
        D = 100123285.0;
        L = D; // Недопустимо!!!
        Console.WriteLine("L и D = " + L + " " + D);
    }
}

// Продемонстрировать приведение типов.


using System;

namespace ConsoleApplication1
{
    class CastDemo
    {
        static void Main()
        {
            double x;
            double y;
            byte b;
            int i;
            char ch;
            uint u;
            short s;
            long l;
            decimal d;
            x = 10.0;
            y = 3.0;


            // Приведение типа double к типу int, дробная часть числа теряется

            i = (int)(x / y);
            Console.WriteLine(" Целочисленный результат деления х / у = " + i);
            Console.WriteLine();

            // Приведение типа int к типу byte без потери данных

            i = 255;
            b = (byte)i;
            Console.WriteLine(" b после присваивания 255 =  " + b + " -- без потери данных.");
            Console.WriteLine();

            // Приведение типа int к типу byte с потерей данных

            i = 257;
            b = (byte)i;
            Console.WriteLine(" b после присваивания 257 =  " + b + " -- с потерей данных.");
            Console.WriteLine();

            // Приведение типа uint к типу short без потери данных

            u = 32000;
            s = (short)u;
            Console.WriteLine(" s после присваивания 32000 =  " + s + " -- без потери данных.");
            Console.WriteLine();

            // Приведение типа uint к типу short с потерей данных

            u = 64000;
            s = (short)u;
            Console.WriteLine(" s после присваивания 64000 =  " + s + " -- с потерей данных. ");
            Console.WriteLine();

            // Приведение типа long к типу uint без потери данных.

            l = 64000;
            u = (uint)l;
            Console.WriteLine(" u после присваивания 64000 = " + u + " -- без потери данных.");
            Console.WriteLine();

            // Приведение типа long к типу uint с потерей данных.

            l = -12;
            u = (uint)l;
            Console.WriteLine(" u после присваивания -12 = " + u + " -- с потерей данных.");
            Console.WriteLine();

            // Приведение типа int к типу char

            b = 88;

            // код ASCII символа X

            ch = (char)b;
            Console.WriteLine(" ch после присваивания 88 = " + ch);
            Console.WriteLine();

            // Приведение точного дробного результата деления x / y

            d = (decimal)(x / y);
            Console.WriteLine("Дробный результат деления с тремя знакаи после запятой = " + "{0:#.###}", d);
            Console.WriteLine();
        }
    }
}



// Пример неожиданного результата продвижения типов!

using System;

namespace TestTraining
{
    class PromDemo
    {
        static void Main()
        {
            byte b;
            b = 10;
            b = (byte)(b * b); // Необходимо приведение типов!!
            char ch1 = 'a';
            char ch2 = 'b';
            ch1 = (char)(ch1 * ch2);

            Console.WriteLine(" ch1 = " + ch1); // ?
            Console.WriteLine();

            Console.WriteLine(" b = " + b);
            Console.WriteLine();

        }
    }
}


// Пример приведения типов в выражениях.

using System;

namespace TesTraining
{
    class CastExpr
    {
        static void Main()
        {
            double n;

            for (n = 1.0; n <= 10; n++)
            {
                Console.WriteLine(" Квадратный корень из {0} = {1}", n, Math.Sqrt(n));
                Console.WriteLine();
                Console.WriteLine(" Целая часть числа = {0}", (int) Math.Sqrt(n));
                Console.WriteLine();
                Console.WriteLine(" Дробная часть числа = {0}", Math.Sqrt(n) - (int) Math.Sqrt(n));
                Console.WriteLine();
            } 

        }
    }
}


// Продемонстрировать применение оператора %.

using System;

namespace TestTraining
{
    class ModDemo
    {
        static void Main()
        {
            int iresult;
            int irem;
            double dresult;
            double drem;

            iresult = 10 / 3;
            irem = 10 % 3;
            dresult = 10.0 / 3.0;
            drem = 10.0 % 3.0;

            Console.WriteLine(" Результат и остаток деления 10 / 3 = " + iresult + " и " + irem);
            Console.WriteLine();
            Console.WriteLine(" Результат и остаток деления 10.0 / 3.0 = " + dresult + " и " + drem);
            Console.WriteLine();
        }
    }
}


// Продемонстрировать отличие между префиксной
// и постфиксной формами оператора инкремента (++).

using System;

namespace TestTraining
{
    class PrePostDemo
    {
      

        static void Main()
        {
            int x;
            int i;
            int y;
            int f;

            x = 1;
            f = 0;

            Console.WriteLine(" Ряд чисел, полученных с помощью оператора f = f + x++;");
            Console.WriteLine();

            for(i = 0; i < 10; i++)
            {
                f = f + x++; // постфиксная форма оператора ++
                Console.WriteLine(f + " ");
               }
            Console.WriteLine();

            x = 1;
            y = 0;

            Console.WriteLine(" Ряд чисел, полученных с помощью оператора y = y+ ++x;");
            Console.WriteLine();

            for(i = 0; i < 10; ++i)
            {
                y = y + ++x; // префиксная форма оператора ++
                Console.WriteLine(y + " ");
                }
            Console.WriteLine();

        }
    }
}


// Продемонстрировать применение операторов
// отношения и логических операторов.

using System;

namespace TestTraining
{
    class RelLogOps
    {
        static void Main()
        {
            int i, j;
            bool b1, b2;

            i = 10;
            j = 11;

            if (i < j) Console.WriteLine(" i < j ");
            Console.WriteLine();
            if (i <= j) Console.WriteLine(" i <= j ");
            Console.WriteLine();
            if (i != j) Console.WriteLine(" i != j ");
            Console.WriteLine();
            if (i == j) Console.WriteLine(" Нельзя выполнить ");
            Console.WriteLine();
            if (i >= j) Console.WriteLine(" Нельзя выполнить ");
            Console.WriteLine();
            if (i > j) Console.WriteLine(" Нельзя выполнить ");
            Console.WriteLine();

            b1 = true;
            b2 = false;

            if (b1 & b2) Console.WriteLine(" Нельзя выполнить ");
            Console.WriteLine();
            if (!(b1 & b2)) Console.WriteLine(" !(b1 & b2) — true ");
            Console.WriteLine();
            if (b1 | b2) Console.WriteLine(" b1 | b2 - true ");
            Console.WriteLine();
            if (b1 ^ b2) Console.WriteLine(" bl ^ b2 — true ");
            Console.WriteLine();
        }
    }
}


// Построение операции импликации в С#.

using System;

namespace TestTraining
{
    class Test
    {
        static void Main()
        {
            bool p = false, q = false;
            int i, j;

            for(i = 0; i < 2; i++)
            {
                for(j = 0; j < 2; j++)
                {
                    if (i == 0) p = true;
                    if (i == 1) p = false;
                    if (j == 0) q = true;
                    if (j == 1) q = false;

                    Console.WriteLine(" p = " + p + " q = " + q);

                    if (!p | q)

                    Console.WriteLine(" Результат импликации " + p + " и " + q + " = " + true);
                    Console.WriteLine();

                }
            }

        }
    }
}


//  Применение укороченных логических операторов.

using System;

namespace TestTraining
{
    class SCops
    {
        static void Main()
        {
            int n;
            int d;

            n = 10;
            d = 2;

            if (d != 0 && (n % d) == 0)
                Console.WriteLine(n + " делиться нацело на " + d);
            Console.WriteLine();

            d = 0; // задать нулевое значение переменной d

            // d равно нулю, поэтому второй операнд не вычисляется

            if (d != 0 && (n % d) == 0)
                Console.WriteLine(n + " делиться нацело на " + d);
            Console.WriteLine();

            // Если теперь попытаться сделать то же самое без укороченного
            // логического оператора, то возникнет ошибка из-за деления на нуль.

            // if (d != 0 & (n % d) == 0)
            //    Console.WriteLine(n + " делится нацело на " + d);
            // Console.WriteLine();
        }
    }
}


//  Значение побочных эффектов.

using System;

namespace TestTraining
{
    class SideEffects
    {
        static void Main()
        {
            int i;
            bool someCondition = false;

            i = 0;

            // Значение переменной i инкрементируется,
            // несмотря на то, что оператор if не выполняется.

            if(someCondition & ( ++i < 100))
                Console.WriteLine(" He выводится ");
            Console.WriteLine(" Оператор if выполняется и = " + i); // выводится 1
            Console.WriteLine();

            // В данном случае значение переменной i не инкрементируется,
            // поскольку инкремент в укороченном логическом операторе опускается.

            if (someCondition && (++i < 100))
                Console.WriteLine(" Не выводиться ");
            Console.WriteLine(" Оператор if выполняестя и = " + i); // по-прежнему 1 !!
            Console.WriteLine();
            
            System.Console.ReadKey();
        }
    }
}
 
// NULL

using System;

namespace TestTraining
{
    class Program
    {
        class MyClass
        {
            public void MyMethod() { }
        }

        static void Main(string[] args)
        {
            // Set a breakpoint here to see that mc = null.
            // However, the compiler considers it "unassigned."
            // and generates a compiler error if you try to
            // use the variable.
            MyClass mc;

            // Now the variable can be used, but...
            mc = null;

            // ... a method call on a null object raises 
            // a run-time NullReferenceException.
            // Uncomment the following line to see for yourself.
            // mc.MyMethod();

            // Now mc has a value.
            mc = new MyClass();

            // You can call its method.
            mc.MyMethod();

            // Set mc to null again. The object it referenced
            // is no longer accessible and can now be garbage-collected.
            mc = null;

            // A null string is not the same as an empty string.
            string s = null;
            string t = String.Empty; // Logically the same as ""

            // Equals applied to any null object returns false.
            bool b = (t.Equals(s));
            Console.WriteLine(b);

            // Equality operator also returns false when one
            // operand is null.
            Console.WriteLine("Empty string {0} null string", s == t ? "equals" : "does not equal");

            // Returns true.
            Console.WriteLine("null == null is {0}", null == null);


            // A value type cannot be null
            // int i = null; // Compiler error!

            // Use a nullable value type instead:
            //int i = null;

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}


// Поразрядный оператор И

using System;

namespace TestTraining
{
    class MakeEvan
    {
        static void Main()
        {
            ushort num;
            ushort i;

            for(i = 0; i <= 10; i++)
            {
                num = i;

                Console.WriteLine(" num = " + num);

                num = (ushort)(num & 0xFFFE);

                Console.WriteLine(" num после сброса младшего разряда = " + num + " \n ");
                Console.WriteLine();
                Console.ReadKey();
            }
                // Console.ReadKey();
        }
    }
}


// Применить поразрядный оператор И, чтобы определить,
// является ли число нечетным.

using System;

namespace TestTraining
{
    class IsOdd
    {
        static void Main()
        {
            ushort num;

            num = 10;

            if ((num & 1) == 1)
            Console.WriteLine("He выводится.");

            num = 11;

            if ((num & 1) == 1)
            Console.WriteLine(num + " — нечетное число.");

        }
    }
}


// Показать биты, составляющие байт.

using System;

namespace TestTraining
{
    class ShowBits
    {
        static void Main()
        {
            int t;
            byte val;

            val = 123;

            for(t = 128; t > 0; t = t / 2)
            {
                if ((val & t) != 0) Console.Write(" 1 ");
                if ((val & t) == 0) Console.Write(" 0 ");
            }
            // Console.WriteLine();
            Console.ReadKey();
        }
    }
}
*/

// Применить поразрядный оператор ИЛИ, чтобы сделать число нечетным.

using System;

namespace TestTraining
{
    class MakeOdd
    {
        static void Main()
        {
            ushort num;
            ushort i;

            for(i = 1; i <= 10; i++)
            {
                num = i;
                Console.WriteLine(" num = " + num);

                num = (ushort)(num | 1);
                Console.WriteLine(" num после установки младшего разряда = " + num + " \n ");
                Console.WriteLine();
                }
            Console.ReadKey();
        }
    }
}