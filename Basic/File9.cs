using System;

namespace BasicCSharp.Basic
{
    public class File9
    {
        public static void File9Main()
        {
            float a, b, c;
            bool chon = false;
            do
            {
                Console.WriteLine("Giải phương trình bậc 2: aX^2 + bX + C =0");
                Console.Write("Nhap a: ");
                a = float.Parse(Console.ReadLine());
                Console.Write("Nhap b: ");
                b = float.Parse(Console.ReadLine());
                Console.Write("Nhap c: ");
                c = float.Parse(Console.ReadLine());
                
                float delta = b * b - 4 * a * c;
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("phuong trinh vo nghiem.");
                }
                else if (a == 0)
                {
                    Console.WriteLine("phuong trinh co 1 nghiem.");
                    Console.WriteLine("X: " + -c / b);
                }
                else
                {
                    if (delta > 0)
                    {
                        Console.WriteLine("phuong trinh co hai nghiem phan biet.");
                        Console.WriteLine("X1: " + (-(b - Math.Sqrt(delta)) / (a * 2)));
                        Console.WriteLine("X2: " + (-(b + Math.Sqrt(delta)) / (a * 2)));
                    }
                    else if (delta == 0)
                    {
                        Console.WriteLine("phuong trinh co nghiem kep.");
                        Console.WriteLine("X: " + (-b / 2 * a));
                    }
                    else
                    {
                        Console.WriteLine("phuong trinh vo nghiem.");
                    }
                }
                
                Console.Write("Nhap true de quay lai,false de thoat: ");
                chon =Boolean.Parse(Console.ReadLine());
            } while (chon==true);
        }
    }
}