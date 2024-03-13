using System;

class Program
{
    static void Main(string[] args)
    {
        int[] X = new int[12];
        Random rand = new Random();

        for (int i = 0; i < X.Length; i++)
        {
            X[i] = rand.Next(-10, 11);
        }

        Console.WriteLine("Масив Х:");
        PrintArray(X);

        Console.Write("Введіть число М: ");
        int M;
        while (!int.TryParse(Console.ReadLine(), out M))
        {
            Console.WriteLine("Некоректне значення. Введіть ціле число для M:");
            Console.Write("Введіть число М: ");
        }

        int[] Y = GetElementsAboveModulus(X, M);

        Console.WriteLine($"Число М: {M}");
        Console.WriteLine("Масив Y (елементи з X більші за М за модулем):");
        PrintArray(Y);
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int[] GetElementsAboveModulus(int[] array, int M)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (Math.Abs(num) > M)
                count++;
        }

        int[] result = new int[count];
        int index = 0;
        foreach (int num in array)
        {
            if (Math.Abs(num) > M)
            {
                result[index] = num;
                index++;
            }
        }

        return result;
    }
}
