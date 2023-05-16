using System;

namespace BasicCSharp.Array1D
{
    public class SoftArray
    {
        /*
         * Input an array of integers, sort them in ascending order,
         * and print to the screen.
         */
        public static void SoftArrayMain()
        {
            int[] arr = new int[10];
            int index;
            Console.Write("Numbers of elements: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Element {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                for (int j = i+1; j < num; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        index = arr[j];
                        arr[j] = arr[i];
                        arr[i] = index;
                    }
                }
            }
            Console.WriteLine(" After soft");
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}