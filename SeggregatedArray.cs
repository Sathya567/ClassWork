using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    class SeggregatedArray
    {
        static void segregate0and1(int[] arr, int n)
        {
            Console.WriteLine("Enter the size of an array");
            int count = 0;  //counts no of zeros in array
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                    count++;
            }
            //loop fills arr with 0 until count
            for (int i = 0; i < count; i++)
                arr[i] = 0;
            //fills remaing arr with space 1
            for (int i = count; i < n; i++)
                arr[i] = 1;

        }
        //function to print segre array
        static void print(int[] arr, int n)
        {
            Console.WriteLine("array after seggregation is ");
            for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i] + " ");
        }
        public static void Main()
        {
            int[] arr = new int[] { 1, 1, 0, 1, 0, 0, 1 };
            int n = arr.Length;

            segregate0and1(arr, n);
            print(arr, n);
        }






    }
}

