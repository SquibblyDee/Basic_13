using System;

namespace Basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Print all the numbers from 1 to 255.
            // Console.WriteLine("Print 1-255:");
            // for(int i=1; i<=255; i++)
            // {
                // Console.WriteLine(i);
            // }

            ////Print all the odd numbers from 1 to 255.
            // Console.WriteLine("Print odd numbers between 1-255:");
            // for(int i=1; i<=255; i++)
            // {
                // if(i%2==1)
                // {
                    // Console.WriteLine(i);
                // }
            // }

            ////Print the numbers from 0 to 255, but this time, 
            ////also print the sum of the numbers that have been printed so far.
            Console.WriteLine("Print Sum:");
            int sum = 0;
            for(int i=1; i<=255; i++)
            {
                sum+=i;
                Console.WriteLine("New Number: {0} Sum: {1}", i, sum);
            }
        }
    }
}
