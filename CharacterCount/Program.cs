using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string longString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. " +
                "Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, " +
                "non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget " +
                "massa. Donec nec velit non ligula efficitur luctus.";

            //var charArray = longString.ToCharArray();
            var charcountDict = new Dictionary<char, int>();

            foreach (char item in longString)
            {
                if (!charcountDict.ContainsKey(item))
                   {
                    charcountDict.Add(item, 1);
                }
                else
                {
                  
                    charcountDict[item]++ ;
                }
               
 
            }
            foreach ( KeyValuePair<char,int> j in charcountDict)
            {
                
                Console.WriteLine(j.Key + " : "+j.Value);

            }
            Console.ReadLine();
        }
    }
}
