using System;

namespace ConsoleApplication1
{
    class Program
    {
        static double a;
        static double b;
        static char d;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Доступные операции:");
            Console.ResetColor();
            Console.WriteLine("Сумма -- (+)");
            Console.WriteLine("Разность -- (-)");
            Console.WriteLine("Произведение -- (*)");
            Console.WriteLine("Частное -- (/)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите первое число:");
            Console.ResetColor();
            a = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите нужное действие:");
            Console.ResetColor();
            d = Convert.ToChar(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите второе число:");
            Console.ResetColor();
            b = Convert.ToDouble(Console.ReadLine());
            if (d == '+')
            {
                plus();
            }
            else if (d == '-')
            {
                minus();
            }
            else if (d == '*')
            {
                umnojit();
            }
            else if (d == '/')
            {
                delit();
            }
            Console.ReadKey();
        }

        static void plus()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Cумма чисел = " + (a + b));
            Console.ResetColor();
        }
        static void minus()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Разность чисел = " + (a - b));
            Console.ResetColor();
        }
        static void umnojit()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Произведение чисел = " + (a * b));
            Console.ResetColor();
        }
        static void delit()
        {
            if (b == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Ошбика! Деление на ноль невозможно!)");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Частное чисел = " + (a / b));
                Console.ResetColor();
            }
        }

    }
}