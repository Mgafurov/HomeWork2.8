using System;

class HomeWork
{
    static void Main()
    {
        Console.WriteLine("Введите значение x : ");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение переменной y : ");
        float y = float.Parse(Console.ReadLine());
        float result = (x + y) / (y + 1) - ((x * y - 12) / (34 + x));
        Console.WriteLine("Результат : " + result);
        Console.ReadKey();
    }
}