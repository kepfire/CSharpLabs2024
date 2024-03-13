using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть довжини сторін трикутника:");

        double a, b, c;
        Console.Write("a = ");
        while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
        {
            Console.WriteLine("Некоректне значення. Введіть додатне число для сторони a:");
            Console.Write("a = ");
        }

        Console.Write("b = ");
        while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
        {
            Console.WriteLine("Некоректне значення. Введіть додатне число для сторони b:");
            Console.Write("b = ");
        }

        Console.Write("c = ");
        while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
        {
            Console.WriteLine("Некоректне значення. Введіть додатне число для сторони c:");
            Console.Write("c = ");
        }

        if (a + b > c && a + c > b && b + c > a)
        {
            double perimeter = a + b + c;
            double semiPerimeter = perimeter / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

            Console.WriteLine($"Периметр трикутника: {perimeter}");
            Console.WriteLine($"Площа трикутника: {area}");

            if (a == b && b == c)
                Console.WriteLine("Трикутник є рівностороннім.");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Трикутник є рівнобедреним.");
            else
                Console.WriteLine("Трикутник є різностороннім.");
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
        }
    }
}
