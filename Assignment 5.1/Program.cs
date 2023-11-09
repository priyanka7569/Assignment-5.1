using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment 5.1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 natural numbers are");
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine(i);
            }
            int j = 1;
            Console.WriteLine("First 10 even natural numbers");
            while (j <= 20)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);

                }
                j++;

            }

            int k = 1;
            Console.WriteLine("First 10 odd natural numbers");
            while (k <= 20)
            {
                if (k % 2 != 0)
                {
                    Console.WriteLine(k);

                }
                k++;

            }


            Console.ReadKey();


        }

    }
}
       
