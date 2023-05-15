using System;

namespace BasicCSharp.Array1D
{
    public class DeleteElement
    {
        public static void DeleteElementMain()
        {
            int[] arr = new int[10];
            Console.Write("Numbers of elements: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Element {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Input place want delete: ");
            int index = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Array before delete: ");
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            for (int i = index-1; i <= num; i++)//Find place want to delete and replace it with its right position
            {
                arr[i] = arr[i+1];
            }
            
            Console.WriteLine("Array after delete: ");
            for (int i = 0; i < num-1; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}