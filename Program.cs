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

/*
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
*/

/*
int[][] array = new int[3][];

array[0] = new int[2] { 1, 2 };
array[1] = new int[3] { 1, 2, 3 };
array[2] = new int[5] { 1, 2, 3, 4, 5 };


foreach (var i in array)
{
    foreach (var j in i)
    {
        Console.Write(j + " ");
    }
}
*/

/*
int[] arr = new int[] { -1, 15, 0 , 9, -33, 6};

var num = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) num++;
}

Console.WriteLine(num);
*/

/*
using System;

int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

var num = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{

    for (int k = 0; k < arr.GetLength(1); k++)
    {
        if (arr[i, k] > 0) num++;
    }
        
}
    Console.WriteLine(num);
*/

/*
using System;


int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

int temp;

for (int i = 0; i <= arr.GetUpperBound(0); i++)
{
    for(int j = 0; j <= arr.GetUpperBound(1); j++)
    {
        for (int a = j + 1; a <= arr.GetUpperBound(1); a++)
        {
            if (arr[i, j] > arr[i, a])
            {
                temp = arr[i, a];
                arr[i, a] = arr[i, j];
                arr[i, j] = temp;
            }
        }
        Console.Write(arr[i, j] + " ");
    }

    Console.WriteLine();
}
*/

/* Задание 4.4.2
(string name, int age) anketa;

Console.WriteLine("Введите свое имя: ");
anketa.Item1 =  Console.ReadLine();
Console.WriteLine("Введите свой возраст: ");
anketa.Item2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваше имя: {0}", anketa.Item1);
Console.WriteLine("Ваш возраст: {0}", anketa.Item2);
*/

/* Задание 4.4.3
var (name, age) = ("Тамер", 25);
Console.WriteLine("Моё имя: {0}", name);
Console.WriteLine("Мой возраст: {0}", age);


Console.Write("Введите имя: "); 
name = Console.ReadLine();
Console.Write("Введите возраст с цифрами: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваше имя: {0}", name);
Console.WriteLine("Ваш возраст: {0}", age);
*/

/* Задание 4.4.5
(string name, string type, double age, int nameCount) Pet;

Console.Write("Введите имя питомца: ");
Pet.name = Console.ReadLine();

Pet.nameCount = Pet.name.Length;

Console.Write("Введите тип питомца: ");
Pet.type = Console.ReadLine();

Console.Write("Введите возраст питомца: ");
Pet.age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Длина имени: {Pet.name} {Pet.nameCount} символа.");
*/
using System;
using System.Reflection.Metadata;

class MainClass
{
    static void Main(string[] args)
    {
        (string name, string lastName, string login, int loginCount, bool pet, int age, string[] color) Anketa;

        for (int k = 0; k < 3;  k++)
        {
            Console.WriteLine("Введите имя");
            Anketa.name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            Anketa.lastName = Console.ReadLine();

            Console.WriteLine("введите логин");
            Anketa.login = Console.ReadLine();

            //Вычисление длины логина

            Anketa.loginCount = Anketa.login.Length;

            //Наличие/отсутствие животных

            Console.WriteLine("Есть ли у вас животные? Да или Нет");

            var result = Console.ReadLine();

            if (result == "Да")
            {
                Anketa.pet = true;
            }

            else if (result == "да")
            {
                Anketa.pet = true;
            }

            else
            {
                Anketa.pet = false;
            }

            //Ввод возраста пользователя и трех его любимых цветов

            Console.WriteLine("Введите свой возраст");
            Anketa.age = Convert.ToInt32(Console.ReadLine());

            Anketa.color = new string[3];

            Console.WriteLine("Введите три своих любимыхцвета");
            for (int i = 0; i < Anketa.color.Length; i++)
            {
                Anketa.color[i] = Console.ReadLine();
            }
        }
    }
}