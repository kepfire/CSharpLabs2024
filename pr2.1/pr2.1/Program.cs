using System;

class Pr2
{
    static void Main()
    {
        Console.WriteLine("Введіть три цілих числа:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        if (num1 >= 1 && num1 <= 12)
            Console.WriteLine($"Число {num1} належить інтервалу [1, 12].");

        if (num2 >= 1 && num2 <= 12)
            Console.WriteLine($"Число {num2} належить інтервалу [1, 12].");

        if (num3 >= 1 && num3 <= 12)
            Console.WriteLine($"Число {num3} належить інтервалу [1, 12].");

        Console.ReadLine();
    }
}
