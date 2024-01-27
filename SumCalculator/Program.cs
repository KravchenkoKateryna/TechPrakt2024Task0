using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число:");
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Введіть друге число:");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                double sum = num1 + num2;
                Console.WriteLine($"Сума двох чисел: {sum}");
            }
            else
            {
                Console.WriteLine("Некоректне друге число.");
            }
        }
        else
        {
            Console.WriteLine("Некоректне перше число.");
        }
    }
}
