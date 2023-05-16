using System;

namespace BasicCSharp.Array1D
{
    /*
     * Input an array of integers and then print the largest and smallest number to the screen.
     */
    public class FindLargestSmallest
    {
        public static void FindLargestSmallestMain()
        {
            Console.Write("Input numbers of elements: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write($" Element {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];
            int min =arr[0];

            for (int i = 0; i < num; i++)
            {

                if (arr[i] > max) {
                    max = arr[i];
                }
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Largest element in array: "+max);
            Console.WriteLine("Largest element in array: "+min);
        }
    }
}