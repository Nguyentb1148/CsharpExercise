using System;

namespace BasicCSharp.Basic
{
    public class File6
    {
        public static void File6Main()
        {
            int nam;
            bool chon = true;
            do
            {
                Console.Write("Nhap nam: ");
                nam = int.Parse(Console.ReadLine());
                if (nam < 0)
                {
                    Console.WriteLine("Nhap lai nam");
                    continue;
                }
                else
                {
                    if (nam % 4 == 0)
                    {
                        if (nam % 100 == 0)
                        {
                            if (nam % 400 == 0)
                            {
                                Console.WriteLine($"{nam} la nam nhuan.");
                            }
                            else
                            {
                                Console.WriteLine($"{nam} khong phai nam nhuan.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{nam} la nam nhuan.");
                        }
                    }
                    else
                        Console.WriteLine($"{nam} khong phai nam nhuan.");
                }
                Console.WriteLine("True de quay lai, false de thoat.");
                chon = Boolean.Parse(Console.ReadLine());
                if (chon == false)
                {
                    Console.WriteLine("Ban da thoat.");
                }
            } while (chon == true);
        }
    }
}