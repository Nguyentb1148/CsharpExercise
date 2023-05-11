using System;

namespace BasicCSharp.Array1D
{
    public class CopyArray
    {
        public static void CopyArrayMain()
        {
            int [] arr = new int[10];
            int [] copyArr = new int[10];
            Console.Write(" Input number of elements: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Elements {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                copyArr[i] = arr[i];
            }
            Console.WriteLine("Elements of copy array: ");
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{copyArr[i]} ");
            }
        }
    }
}