using System;

namespace BasicCSharp.Array1D
{
    public class FindUniqueNumbers
    {
        public static void FindUniqueNumbersMain()
        {
            Console.Write("Input numbers of elements: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write($" Element {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(" unique numbers in array: ");
            for (int i = 0; i < num; i++)
            {
                int index = 0;
                for (int j = 0; j < i-1; j++)// check  elements before i
                {
                    if (arr[i]==arr[j])
                    {
                        index++;
                    }
                }
                for (int j = i+1; j < num; j++)//check elements after i
                {
                    if (arr[i]==arr[j])
                    {
                        index++;
                    }
                }
                if (index==0)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
    }
}