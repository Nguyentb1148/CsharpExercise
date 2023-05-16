using System;

namespace BasicCSharp.Basic
{
    public class CheckNumber
    {
      //Enter an integer and print to the screen whether the number is even or odd.
        public static void CheckNumberMain()
        {
            int i;
            Console.WriteLine("Nhap mot so: ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)//If the remainder when divided by 2 is 0, then the number is even
            {
                Console.WriteLine($"So ban nhap la so chan {i}");
            }
            else
            {
                Console.WriteLine("So ban nhap la so le ");
            }
        }
    }
}