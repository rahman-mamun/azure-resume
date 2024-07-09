using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            int result = Square(number);
            Console.WriteLine($"The square of {number} is {result}");
        }

        static int Square(int num)
        {
            return num * num;
        }
    }
}
