using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("gina");
            names.Add("Tina");
            if (names.Contains("gina"))
            {
                Console.Write("Found gina");
            }
            Console.WriteLine("++++++++++");
            var students = new Dictionary<string, int>();
            students.Add("Matilda", 12);
            students.Add("Ana", 50);
            students.Add("Bagya", 62);
            students.Add("Mette",53);
            foreach(var keyValue in students)
            {
                Console.WriteLine(keyValue.Key + " " + keyValue.Value);
            }
            Console.ReadLine();
        }
    }
}
