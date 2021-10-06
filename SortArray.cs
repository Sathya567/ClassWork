using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    class SortArray
    {
        
            static void Main(String[] args)
            {
                Console.WriteLine("numeric array and string array without using sort function");
                Console.WriteLine("Enter the size of array: ");
                int length_arr = Convert.ToInt32(Console.ReadLine());
                int i;
                int temp = 0;
                int[] arr = new int[length_arr];
                for (i = 0; i < length_arr; i++)
                {
                    Console.WriteLine("Enter your number: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n");
                for (i = 0; i < length_arr; i++)
                {
                    Console.WriteLine("Array values {0}", arr[i]);
                }
                Console.ReadLine();
                for (i = 0; i <= arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                Console.WriteLine("Array sort in ascending order");
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        
    }
}
