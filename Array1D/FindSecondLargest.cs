using System;

namespace BasicCSharp.Array1D
{
    public class FindSecondLargest
    {
        public static void FindSecondLargestMain()
        {
            int[] arr = new int [10];
            int max = 0,j=0,lon_thu_hai=0;
            Console.Write(" Input number of elements: ");

            int num = int.Parse(Console.ReadLine());
                for (int i = 0; i<num; i++)
            {
                Console.Write($"Elements {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                    j = i;
                }
            }
            Console.WriteLine(max);

            for (int i = 0; i < num; i++)
            {
                if (i==j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (lon_thu_hai < arr[i])
                    {
                        lon_thu_hai = arr[i];
                    }
                }
            }
            Console.WriteLine("Elements of  array: ");
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine(lon_thu_hai);
        }
    }
}
