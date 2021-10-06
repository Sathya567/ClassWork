using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    class BizzNumber
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 7 == 0)
                Console.WriteLine("Buzz Number");
            else
                Console.WriteLine("Not a Buzz Number");
        }
    }
}

   
