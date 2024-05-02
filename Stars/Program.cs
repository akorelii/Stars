using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Edge Number: ");
        int square = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < square; i++)
        {
            for (int j = 0; j < square; j++)
            {
                if (i == 0 || i == square - 1 || j == 0 || j == square - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }

        Console.Read();
    }
}
