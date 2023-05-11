using System;

namespace BasicCSharp.Array1D
{
    public class SplitArray
    {
        public static void SplitArrayMain()
        {
            int[] arr = new int [10];
            int[] arrOdd = new int[10];
            int[] arrEven = new int[10];
            int j=0,k=0;
            Console.Write(" Input number of elements: ");

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i<num; i++)
            {
                Console.Write($"Elements {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                if (arr[i]%2==0)
                {
                    arrEven[j] = arr[i];
                    j++;
                }
                else
                {
                    arrOdd[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("Elements of odd array: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write($"{arrOdd[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Elements of even array: ");
            for (int i = 0; i < j; i++)
            {
                Console.Write($"{arrEven[i]} ");
            }
        }
    }
}