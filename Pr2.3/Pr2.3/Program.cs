using System;

class Program
{
    static void Main(string[] args)
    {
        int[] X = new int[12];

        Random rand = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = rand.Next(1, 100);
        }

        Console.WriteLine("Масив Х:");
        foreach (int num in X)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int min = X[0];
        int max = X[0];
        foreach (int num in X)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }

        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
    }
}
