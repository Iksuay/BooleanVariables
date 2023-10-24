/*
Задание 4.1.4
string a, b;
bool c = a != b;

Задание 4.1.5
int a, b;
double x, y;
bool c = (a < b) || (x > y);
*/

/*
Задание 4.1.12
var a = 6;
var b = 7;

if (a < b)
{
    Console.WriteLine("Условие истинно");
}
else
{
    Console.WriteLine("Условие ложно");
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

        for (;;)
        {
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        }
    }
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

        while (true)
        {
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        }
    }
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Цикл for");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        }
        
        Console.WriteLine("Цикл white");
        int k = 0;

        while (k < 3)
        {
            Console.WriteLine(k);
            k++;
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        }
    }
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Цикл for");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        }

        Console.WriteLine("Цикл white");
        int k = 0;

        while (k < 3)
        {
            Console.WriteLine(k);
            k++;
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        }

        Console.WriteLine("Цикл do");
        int t = 0;

        do
        {
            Console.WriteLine(t);
            t++;
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
        } while (true);
    }
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int k = 0;

        while (true)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            Console.WriteLine(k);

            var text = Console.ReadLine();

            if (text == "stop")
            {
                Console.WriteLine("Цикл остановлен");
                break;
            }

            switch (text)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    continue;
            }

            k++;

        }
    }
}
*/

/*
using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Введите число");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }

                sum += number;
            }

            Console.WriteLine("Итоговая сумма: {0}", sum);
        }
    }
}
*/

/*
using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] favcolors = new string[3];

            for(int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Введите любимый цвет {0}", i + 1);
                favcolors[i] = Console.ReadLine();
            }

            foreach(var color in favcolors)
            {
                switch (color)
                {
                    case "red":
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;
                    }
                    case "green":
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    }
                    case "cyan":
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    }
                    default:
                        continue;
                }
            }
        }
    }
}
*/

/*
using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя:");

            var name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }
        }
    }
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
        
        foreach (int i in array)
        {
            Console.WriteLine(i + " ");
        }
    }
}
*/

/*
using System;


class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

        int num;

        for (int a = 0; a < arr.Length; a++)
        {
            for (int b = a + 1; b < arr.Length; b++)
            {
                if (arr[a] > arr[b])
                {
                    num = arr[a];
                    arr[a] = arr[b];
                    arr[b] = num;
                }
            }
        }
            
        foreach (var i in arr)
        {
            Console.Write(i);
        }
        
    }
}
*/


using System;
class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

        int num = 0;

        foreach (var i in arr)
        {
            num += i;
        }
        Console.WriteLine(num);
    }
}
