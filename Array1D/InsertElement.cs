using System;

namespace BasicCSharp.Array1D
{
    public class InsertElement
    {
        public static void InsertElementMain()
        {
            int[] arr = new int[10];
            int index,j=0;
            Console.Write("Numbers of elements: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Element {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Input number: ");
            index = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if (index<arr[i])
                {
                    j = i;
                    break;
                }
            }
            for (int i = num; i >=j; i--)
            {
                arr[i] = arr[i - 1];// di chuyen vi tri tat ca phan tu ben phai cua arr[j]
            }
            arr[j] = index;
            Console.WriteLine(" After insert");
            for (int i = 0; i <= num; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}