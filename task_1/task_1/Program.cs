using System;
using System.Text;


class Program
{
    static void Main()
    {
        Console.Write("Перше число: ");
        string input1 = Console.ReadLine();

        Console.Write("Друге число: ");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
        {
            double sum = number1 + number2;
            Console.WriteLine($"Сума двох чисел: {sum}");
        }
        else
        {
            Console.WriteLine("Некоректні вхідні дані. Введіть дійсні числа.");
        }

        Console.ReadLine();
    }
}

