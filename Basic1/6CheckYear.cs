using System;

namespace BasicCSharp.Basic
{
    public class CheckYear
    {
        /*
         * Enter the number of years and then print out the screen whether that year is a leap year or not,
         * Calculation of a leap year is as follows: you take the number of years to divide by 4,
         * if the result is divisible by 4, the year it is a leap year.
         * For the full years of the century with 2 00s at the end,
         * the number of years is divided by 400, if the result is divisible by 400,
         * the year is a leap year.
         */
        public static void CheckYearMain()
        {
            bool Choice = true;
            do
            {
                Console.Write("Nhap nam: ");
                var nam = int.Parse(Console.ReadLine());
                if (nam < 0)//Check year is smaller than 0 
                {
                    Console.WriteLine("Nhap lai nam");
                    break;// it will break the do while loop and go back to do because while condition is true(choice==true)
                }
                else
                {
                    if (nam % 4 == 0)// leap year
                    {
                        if (nam % 100 == 0)
                        {
                            if (nam % 400 == 0)//leap year
                            {
                                Console.WriteLine($"{nam} la nam nhuan.");
                            }
                            else
                            {
                                Console.WriteLine($"{nam} khong phai nam nhuan.");
                            }
                        }
                        else// leap year 
                        {
                            Console.WriteLine($"{nam} la nam nhuan.");
                        }
                    }
                    else
                        Console.WriteLine($"{nam} khong phai nam nhuan.");
                }
                Console.WriteLine("True de quay lai, false de thoat.");
                Choice = Boolean.Parse(Console.ReadLine());
                if (Choice == false)// break do while loop
                {
                    Console.WriteLine("Ban da thoat.");
                }
            } while (Choice == true);
        }
    }
}