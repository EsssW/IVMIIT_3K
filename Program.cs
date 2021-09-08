using System;
using System.IO;

namespace HW_1_TA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MoveCountArr = new int[100]; //массив для записи количества перстановок в каждом эксперемне
            StreamWriter sw = new StreamWriter(@"C:\Users\mukht\source\repos\HW_1_TA\f.txt");
            for (int i = 0; i < MoveCountArr.Length; i++)
            {
                MoveCountArr[i] = MakeExp();
                sw.WriteLine(MoveCountArr[i]);
            }
            sw.WriteLine($"Среднее число перестановок={ (double)Arithmetic_Mean(MoveCountArr)}");
            Console.WriteLine($"Среднее число перестановок={ (double)Arithmetic_Mean(MoveCountArr)}");
            sw.Close();
        }
        public static int MakeExp()
        {
            int count = 1; // переменная для подсчета числа перестановок
            var arr = CreateArr();
            var max = arr[0]; 

            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    count++;
                }
            }

            return count;
        }

        public static double[] CreateArr()
        {
            Random rand = new Random();
            int arr_length = 10000000; // переменая для задания длинны массива 
            double[] arr = new double[arr_length];
            

            for (int i = 0; i < arr_length; i++)
            {
                arr[i] = (double)rand.NextDouble();
            }

            return arr;

        }
        public static double Arithmetic_Mean(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
    }
}
