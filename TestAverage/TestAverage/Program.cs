using System;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first score.");
            var answer1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second score.");
            var answer2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your third score.");
            var answer3 = int.Parse(Console.ReadLine());

            int testAverage;
            testAverage = (answer1 + answer2 + answer3) / 3;

            Console.WriteLine($"Your average is {testAverage}");
        }
    }
}
