using System;

namespace Logical
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------Print fizz,buzz and fizzbuzz");
            //Print Divisible by 3 fizz, Divisible by 5 buzz, if divisible by 3&5 fizzbuzz
            for(int i=1; i<= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
            }
            

            Console.WriteLine("--------------Print Reverse----------------");
            string input = "abcdef";
            char[] inputChar = input.ToCharArray(); 
            for(int i = inputChar.Length - 1; i >= 0; i--)
            {
                Console.Write(inputChar[i]);
            }

            Console.ReadLine();



        }
    }
}
