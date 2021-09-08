using System;
using System.Numerics;

namespace HW_2_TA_FIB
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger  t1 = 1, t2 = 1, t3 = 0; ;
            int desired_fibo_number = 1000;

            for (int i = 3; i <= desired_fibo_number; i++)
            {
                t3 = t1 + t2;
                t1 = t2; t2 = t3;
            }
            Console.WriteLine($"{desired_fibo_number}-e число фибоначчи= \n{t3}");
        }
    }
}
