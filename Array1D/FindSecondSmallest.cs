using System;

namespace BasicCSharp.Array1D
{
    public class FindSecondSmallest
    {
        public static void FindSecondSmallestMain()
        {
            int[] arr = new int [10];
            int j=0,min2=0;
            Console.Write(" Input number of elements: ");

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i<num; i++)
            {
                Console.Write($"Elements {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min = arr[0];
            for (int i = 0; i < num; i++)
            {
                if (arr[i]>min)
                {
                    min = arr[i];
                    j = i;
                }
            }

            min2 = arr[0];
            for (int i = 0; i < num; i++)
            {
                if (i==j)
                {
                    i++; // Ignore the position of the smallest number
                    i--;
                }
                else
                {
                    if (min2 > arr[i])
                    {
                        min2 = arr[i];
                    }
                }
            }
            Console.WriteLine("Elements of  array: ");
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine(min2);
        }
    }
}