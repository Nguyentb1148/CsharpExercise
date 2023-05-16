using System;

namespace BasicCSharp.Array1D
{
    public class FindSecondLargest
    {
        /*
         * Input an array of integers and then print the second largest number.
         */
        public static void FindSecondLargestMain()
        {
            int[] arr = new int [10];
            int j=0,max2=0;
            Console.Write(" Input number of elements: ");
            int num = int.Parse(Console.ReadLine());
                for (int i = 0; i<num; i++)
            {
                Console.Write($"Elements {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            for (int i = 0; i < num; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                    j = i;
                }
            }
            for (int i = 0; i < num; i++)
            {
                if (i==j)
                {
                    i++;// Ignore the position of the largest number
                    i--;
                }
                else
                {
                    if (max2 < arr[i])
                    {
                        max2 = arr[i];
                    }
                }
            }
            Console.WriteLine("Elements of  array: ");
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine(max2);
        }
    }
}
