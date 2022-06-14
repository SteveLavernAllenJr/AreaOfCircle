using System;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double areaOfCircle = (Math.PI * radius * radius);
            Console.WriteLine($"The Area of a Circle with radius of {radius} is {areaOfCircle}");
        }
    }
}
