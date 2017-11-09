using System;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int count = 0;count < 10; count++)
            {
                //Console.WriteLine(count);
                if(count == 7)
                {
                    Console.WriteLine("Found 6");
                    break;
                }
            }
            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine("--> {0} <--",myValue);

            }
            Console.ReadLine();
        }
    }
}
