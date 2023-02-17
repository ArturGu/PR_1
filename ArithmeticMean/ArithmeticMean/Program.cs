using System;

namespace ArithmeticMean
{
    class Program
    {
        static void AerageValue(int a, int b, int c)
        {
            Console.WriteLine($"Вiдповiдь: " + ((a + b + c) / 3));
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть перше число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введiть друге число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введiть третє число: ");
            int c = int.Parse(Console.ReadLine());

            AerageValue(a, b, c);
            Console.ReadKey();
        }
    }
}