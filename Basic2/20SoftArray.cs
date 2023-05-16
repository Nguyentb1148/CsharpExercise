using System;

namespace BasicCSharp.Basic2
{
    public class SoftArray
    {
        /*
         * Enter any array of integers and then print the array of numbers
         * before and after sorting ascending and descending
         */
        public static void SoftArrayMain()
        {
            Console.Write("Nhap kich thuoc mang: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Nhap phan tu");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i+1}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang so truoc khi sap xep");
            for (int i = 0; i < num; i++)
            {
                Console.Write(arr[i]+" ");
            }
            for (int i = 0; i < num; i++)//Sắp xếp  theo thứ tự tăng dần
            {
                for (int j = i+1; j < num; j++)
                {
                    if(arr[i]>arr[j])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);//Swap của C# 
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("sau khi sap xep theo thu tu tang dan");
            for (int i = 0; i < num; i++)
            {
                Console.Write(arr[i]+" ");
            }
            
            
            for (int i = 0; i < num; i++)//Thứ tụ giảm dần
            {
                for (int j = i + 1; j < num; j++)
                {
                    if (arr[i] < arr[j])//cách truyền thống
                    {
                        int bien = arr[i];
                        arr[i] = arr[j];
                        arr[j] = bien;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("sau khi sap xep theo thu tu giam dan");
            for (int i = 0; i < num; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine(); 
        }
    }
}