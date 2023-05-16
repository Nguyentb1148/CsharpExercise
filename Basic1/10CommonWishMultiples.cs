using System;

namespace BasicCSharp.Basic
{
    public class CommonWishMultiples
    {
        /*
         * Enter 2 integers a and b and print the greatest common divisor
         * and the least common multiple of those two numbers
         */
        public static void CommonWishMultiplesMain()
        {
            bool choice = false;
            do
            {
                Console.Write("Nhap a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Nhap b: ");
                int b = int.Parse(Console.ReadLine());
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("Khong co UCNN,BCLN");
                }
                else if (a == 0 || b == 0)
                {
                    Console.WriteLine("Khong co BCLN");
                    if (a == 0)
                    {
                        Console.WriteLine($"UCNN cua{a} va {b} la" + b);
                    }
                    else
                    {
                        Console.WriteLine($"UCNN cua{a} va {b} la" + a);
                    }
                }
                else
                {
                    int uCLN = 1;
                    for(int i = 1; i <= a && i <= b; i++)//the condition of the divisor is to be less than one of the two numbers
                    {
                        if(a % i == 0 && b % i == 0)//Gradually increase the value of the variable to find the greatest common divisor
                        {
                            uCLN = i;
                        }
                    }
                    Console.WriteLine("UCLN cua {a} va {b} la: " + uCLN);
                    Console.WriteLine("BCNN cua {a} va {b} la: " + (a*b) / uCLN);//The formula for finding the least common multiple is the product of two numbers divided by the greatest common divisor
                }
                Console.Write("Nhap true de quay lai:");
                choice = Boolean.Parse(Console.ReadLine());
            } while (choice == true);
            Console.ReadLine();
        }
    }
}