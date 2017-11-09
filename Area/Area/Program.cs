using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            double radius;



            Console.WriteLine("Enter a radius");
            input = Console.ReadLine();
            radius = double.Parse(input);
            if (radius > 0)
                {
                Double Area = Math.PI * radius * radius;
                Console.WriteLine(Area);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Error Please enter a non negaive number");
                Console.ReadLine();
            }
            
        }
    }
}
