using System;
using System.Collections.Generic;

namespace Basic_13
{
    class Program
    {
        //Given an array X, say [1,3,5,7,9,13], write a function that would iterate 
        //through each member of the array and print each value on the screen.
        public static void IterateArray(int[] arr)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Iterating through an Array");
            // int[] arr = {1,3,5,7,9,13};
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        ////Write a function that takes any array and prints the maximum value in the array. 
        public static void FindMax(int[] arr)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Find Max:");
            int max = arr[0];
            for(int i=1; i<arr.Length; i++)
            {
                if(arr[i]>max)
                {
                    max=arr[i];
                }
            }
            Console.WriteLine("Max Number: "+max);
        }

        ////Write a function that takes an array and prints the AVERAGE of the values in the array.
        public static void GetAverage(int[] arr)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Get Average:");
            int arrLength = arr.Length;
            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum+=arr[i];
            }
            Console.WriteLine("Average: "+sum/arrLength);
        }
        
        ////Write a function that creates an array 'y' that contains all the odd numbers between 1 to 255.
        public static void ArrayWithOddNums()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Array With Odd Numbers:");
            List<int> values = new List<int>();
            ////build a list of all our odd values so we can get it's length for the arr
            for(int i=1; i<=255; i++)
            {
                if(i%2!=0)
                {
                    values.Add(i);
                }
            }
            ////Declare our array now that it's length is known
            int[] numArray = new int[values.Count];
            int count = 0;
            ////Push each list entry into the array
            foreach(int value in values)
            {
                numArray[count] = value;
                count++;
            }
            ////Write the array
            Console.Write("[");
            foreach(int value in numArray)
            {
                Console.Write(value+",");
            }
            Console.Write("]");
        }

        ////Write a function that takes an array and returns the number of values in that array whose value is greater than a given value y.
        public static int GreaterThanY(int[] arr, int y)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Greater Than Y:");
            int count=0;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]>y)
                {
                    count++;
                }
            }
            return count;
        }

        ////Given any array x, say [1, 5, 10, -2], create a function that multiplies each value in the array by itself.
        public static void SquareTheValues(int[] arr)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Square The Values:");
            for(var i=0; i<arr.Length; i++)
            {
                arr[i]*=arr[i];
            }
            Console.Write("[");
            foreach(int value in arr)
            {
                Console.Write(value+",");
            }
            Console.Write("]");
        }

        ////Given any array x, say [1, 5, 10, -2], create a function that
        ////replaces any negative number with the value of 0.
        public static void EliminateNegativeNumbers(int[] arr)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Eliminate Negative Numbers:");
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]<0)
                {
                    arr[i]=0;
                }
            }
            Console.Write("[");
            foreach(int value in arr)
            {
                Console.Write(value+",");
            }
            Console.Write("]");
        }

        ////Given any array x, say [1, 5, 10, -2], create a function that prints the maximum number in the array,
        //// the minimum value in the array, and the average of the values in the array.
        public static void MinMaxAverage(int[] arr)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Min, Max, and Average:");
            int arrLength = arr.Length;
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            for(int i=0; i<arrLength; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                else if(arr[i] < min)
                {
                    min = arr[i];
                }
                sum+=arr[i];
            }
            Console.WriteLine("Min Value: {0} - Max Value: {1} - Avg Value: {2}", min, max, sum/arrLength);
        }

        ////Given any array x, say [1, 5, 10, 7, -2], create a function that shifts each number by one to the front and adds '0' to the end. 
        public static void ShiftArrayValues(int[] arr)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Shifting the values in an array:");
            for(int i=0; i<arr.Length; i++)
            {
                if(i==arr.Length-1)
                {
                    arr[i] = 0;
                }
                else
                {
                    arr[i] = arr[i+1];
                }
            }
            Console.Write("[");
            foreach(int value in arr)
            {
                Console.Write(value+",");
            }
            Console.Write("]");
        }

        ////Write a function that takes an array of numbers and replaces any negative number with the string 'Dojo'.
        public static void NumberToString(int[] arr)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Number To String:");
            ////Make a new string array since we need to substitute strings in
            String[] NumArray = new String[arr.Length];
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]<0)
                {
                    NumArray[i] = "Dojo";
                }
                ////If i isn't < 0 we convert arr[i] to a string and push it to the string array
                else
                {
                    NumArray[i] = arr[i].ToString();
                }
            }
            Console.Write("[");
            foreach(string value in NumArray)
            {
                Console.Write(value+",");
            }
            Console.Write("]");
        }

        static void Main(string[] args)
        {
            // Print all the numbers from 1 to 255.
            Console.WriteLine("\n");
            Console.WriteLine("Print 1-255:");
            for(int i=1; i<=255; i++)
            {
                Console.WriteLine(i);
            }
// 
            //Print all the odd numbers from 1 to 255.
            Console.WriteLine("\n");
            Console.WriteLine("Print odd numbers between 1-255:");
            for(int i=1; i<=255; i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }
            }

            //Print the numbers from 0 to 255, but this time, 
            //also print the sum of the numbers that have been printed so far.
            Console.WriteLine("\n");
            Console.WriteLine("Print Sum:");
            int sum = 0;
            for(int i=1; i<=255; i++)
            {
                sum+=i;
                Console.WriteLine("New Number: {0} Sum: {1}", i, sum);
            }

            ////FUNCTION CALLS LIVE BELOW HERE
            ////Iterate Array
            int[] arr = {1,3,5,7,9,13};
            IterateArray(arr);

            ////Find Max
            int[] arr2 = {-3,1,-5,0,-7};
            FindMax(arr2);

            ////Get Average
            int[] arr3 = {2,10,3};
            GetAverage(arr3);

            ////Array With Odd Numbers
            ArrayWithOddNums();

            ////Greater Than Y
            int[] arr4 = {1,3,5,7};
            int y = 3;
            Console.WriteLine(GreaterThanY(arr4, y));

            ////Square The Values
            int[] arr5 = {1,5,10,-2};
            SquareTheValues(arr5);

            ////Eliminate Negative Numbers
            int[] arr6 = {1,5,10,-2};
            EliminateNegativeNumbers(arr6);

            ////Min, Max, Average
            int[] arr7 = {1,5,10,-2};
            MinMaxAverage(arr7);

            ////Shifting the values on an array
            int[] arr8 = {1,5,10,7,-2};
            ShiftArrayValues(arr8);
            
            ////Number To String
            int[] arr9 = {-1,-3,2};
            NumberToString(arr9);
        }
    }
}
