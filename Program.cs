using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" program to Print numbers from 1 to 100");
            for (int i=1; i<=100; i++)
            {
                
                Console.WriteLine(i);
                
            }
            Console.WriteLine("Print even numbers between 1 to 100");
            for (int i = 1; i <= 100; i++)
            {
                
                if (i%2 ==0)
                {
                    
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine("Print odd numbers between 1 to 100");
            for (int i = 1; i <= 100; i++)
            {

                if (i % 2 != 0)
                {

                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();
        }

    }
}
