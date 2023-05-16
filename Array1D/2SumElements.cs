using System;

namespace BasicCSharp.Array1D
{
    public class SumElements
    {
        /*
         * Input an array of integers and print to the screen the total value of the numbers in the array.
         */
        public static void SumElementsMain()
        {
            int sum = 0;
            Console.Write("Input numbers of elements: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write($" Element {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < num; i++)
            {
                sum += arr[i];
            }
            Console.Write("Sum of elements in array: "+sum);
        }
    }
}