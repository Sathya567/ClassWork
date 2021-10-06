using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    //Wap to find an automorphic number whose squares ends in the
    //same digits as the number itself

    class AutomorphicNumber
    {
        public static bool CheckAutomorphicNumber(int num)
        {
            int square = num * num;

            Console.Write(num + " square = " + square + " ");

            while (num > 0)
            {
                if (num % 10 != square % 10)
                {
                    return false;
                }
                num = num / 10;
                square = square / 10;
            }
            return true;
        }

        static void Main()
        {
            int n = 25; // 25*25=625

            Console.WriteLine(CheckAutomorphicNumber(n));


        }
    }
}