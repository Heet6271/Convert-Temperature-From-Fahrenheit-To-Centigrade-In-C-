using System;

namespace Prac2
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit = 100;
            Console.WriteLine("Fahrenheit:" + fahrenheit);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius:" + celsius);
            Console.ReadLine();
        }
    }
}
