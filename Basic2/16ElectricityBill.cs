using System;

namespace BasicCSharp.Basic2
{
    public class ElectricityBill
    {
        /*
         * Calculate electricity bill. Enter the customer's id, name, number of letters
         * used and then print the amount to be paid on the screen.
         * Electricity price according to electricity: below 199 is $ 1.2, 200-399 is $ 1.5,
         * 400-599 is $ 1.8, above 600 is $ 2 if the number of electricity letters is greater than 400,
         * there will be an surcharge of 15 %
         */
        public static void ElectricityBillMain()
        {
             string name;
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
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
                Console.WriteLine("tong so tien ban phai tra la: " +Math.Ceiling(dien *2.07));//1,8+1,8*15%=2.07
            }
            else if ( dien > 600)
            {
                Console.WriteLine($"so dien ban da dung la {dien}");
                Console.WriteLine("so tien ban phai tra la:" + dien * 2);
                Console.WriteLine("so tien phu phi ban phai tra la:" + dien * 2 * 0.15);
                Console.WriteLine("tong so tien ban phai tra la: " +Math.Ceiling(dien * 2.3) );//2+2*15%==2.3
            }
            Console.ReadLine();
        
        }
    }
}