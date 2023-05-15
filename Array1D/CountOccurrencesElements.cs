using System;

namespace BasicCSharp.Array1D
{
    public class CountOccurrencesElements
    {
        public static void CountOccurrencesElementsMain()
        {
            Console.Write("Input numbers of elements: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int[] arrElements = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write($" Element {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
                arrElements[i] = -1;//Set elements default is -1
            }

            for (int i = 0; i < num; i++)
            {
                int index = 1;
                for (int j = i+1; j < num ; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        index++;
                        arrElements[j] = 0;//Two elements are the same, so set one is 0
                    }
                }
                if (arrElements[i]!=0)
                {
                    arrElements[i] = index;
                }
            }
            Console.WriteLine("The frequency of occurrence of each element in the array is: ");
            for (int i = 0; i < num; i++)
            {
                if (arrElements[i]!=0)
                {
                    Console.WriteLine(" Elements {0} occurrence {1} times.",arr[i],arrElements[i]);
                }
            }

        }
    }
}