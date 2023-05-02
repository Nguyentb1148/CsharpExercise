using System;

namespace BasicCSharp.Basic
{
    public class File15
    {
        public static void File15Main()
        {
             string name;
            Console.Write("ID: ");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("ten khach hang: ");
            name = Console.ReadLine();
            Console.Write("so dien da tieu thu: ");
            int dien = int.Parse(Console.ReadLine());
            Console.WriteLine("--------menu tien dien----------");
            Console.WriteLine("|unit             Charge/unit  |");
            Console.WriteLine("|upto 199         $1.2         |");
            Console.WriteLine("|200-400          $1.5         |");
            Console.WriteLine("|400-600          $1.8         |");
            Console.WriteLine("|600 and above    $2           |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("neu dung qua 400 chu dien thi them 15% phu phi");
            if (dien<100)
            {
                Console.WriteLine(" ban da su dung 100 chu diem");
                Console.WriteLine("so tien dien cua ban la 120 $.");
            }
            else if(100 <dien &&dien <200)
            {
                Console.WriteLine($"so dien ban da dung la {dien}");
                Console.WriteLine("so tien ban phai tra la:"+ dien*1.2);
            }
            else if (200 < dien && dien < 400)
            {
                Console.WriteLine($"so dien ban da dung la {dien}");
                Console.WriteLine("so tien ban phai tra la:" + dien * 1.5);
            }
            else if(400 <dien &&dien<600)
            {
                Console.WriteLine($"so dien ban da dung la {dien}");
                Console.WriteLine("so tien ban phai tra la:" + dien * 1.8);
                Console.WriteLine("so tien phu phi ban phai tra la:" + dien * 1.8 * 0.15);
                double tien400 = dien *2.07;
                double ceiling = Math.Ceiling(tien400);
                Console.WriteLine("tong so tien ban phai tra la: " +ceiling);
            }
            else if ( dien > 600)
            {
                Console.WriteLine($"so dien ban da dung la {dien}");
                Console.WriteLine("so tien ban phai tra la:" + dien * 2);
                Console.WriteLine("so tien phu phi ban phai tra la:" + dien * 2 * 0.15);
                double tien600 = dien * 2.3;
                double ceiling2 = Math.Ceiling(tien600);
                Console.WriteLine("tong so tien ban phai tra la: " +ceiling2 );
            }
            Console.ReadLine();
        
        }
    }
}