using System;

class Program
{
    static void Main(string[] args)
    {
        int row = int.Parse(Console.ReadLine());

        if (row < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number.");
            return;
        }

        for (int i = 0; i <= row; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                int coefficient = CalculateCoefficient(i, j);
                Console.Write(coefficient + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculateCoefficient(int n, int k)
    {
        if (k == 0 || k == n)
            return 1;

        int numerator = Factorial(n);
        int denominator = Factorial(k) * Factorial(n - k);

        return numerator / denominator;
    }

    static int Factorial(int number)
    {
        if (number <= 1)
            return 1;

        return number * Factorial(number - 1);
    }
}
