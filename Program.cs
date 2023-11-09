using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFibonacciSequence(10);
        }

        static void PrintFibonacciSequence(int count)
        {
            int i1 = 0, i2 = 1, next;

            Console.WriteLine("The first 10 numbers in the Fibonacci sequence:");
            Console.Write(i1 + " " + i2 + " ");

            for (int i = 2; i < count; i++)
            {
                next = i1 + i2;
                Console.Write(next + " ");
                i1 = i2;
                i2 = next;

            }
            Console.ReadKey();
        }
    }
}
