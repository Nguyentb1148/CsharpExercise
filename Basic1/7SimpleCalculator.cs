using System;

namespace BasicCSharp.Basic
{
    public class SimpleCalculator
    {
        /*Enter the number a and then print to the screen each case of addition,
         subtraction, multiplication, division, division with remainder (ex: 1:/,2:*,3:+,4:-,..) 
         for calculation and then enter the number b and print the calculation to the screen*/
        public static void SimpleCalculatorMain()
        {
            int b;
            Console.Write("nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap phep tinh(1:/,2:*,3:+,4:-,5:%): ");
            int chon = int.Parse( Console.ReadLine());
            switch(chon)
            {
                case 1:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    double hieu = a / (double)b;//change to double or float because if you leave the data type int, the result will be incorrect
                    hieu = Math.Round(hieu, 2);// rounding decimals
                    Console.Write($"phep chia cua {a} va {b} la {hieu}");
                    break;
                case 2:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep nhan cua {a} va {b} la {a*b}");
                    break;
                case 3:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep cong cua {a} va {b} la {a + b}");
                    break;
                case 4:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep tru cua {a} va {b} la {a - b}");
                    break;
                case 5:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep chia lay du cua {a} va {b} la {a % b}");
                    break;
            }
            Console.ReadLine();
        }
    }
}