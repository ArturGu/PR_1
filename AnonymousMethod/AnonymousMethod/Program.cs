using System;

namespace AnonymousMethod
{
    class Program
    {
        delegate int RandomDelegate();

        static void Main(string[] args)
        {
            RandomDelegate[] delegates = new RandomDelegate[5];
           
            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = () => new Random().Next(1, 100);
            }

            double average = CalculateAverage(delegates);

            Console.WriteLine("Середнє арифметичне: " + average);

            Console.ReadKey();
        }

        static double CalculateAverage(RandomDelegate[] delegates)
        {
            int sum = 0;

            foreach (var del in delegates)
            {
                sum += del();
            }
           
            double average = (double)sum / delegates.Length;

            return average;
        }
    }
}
