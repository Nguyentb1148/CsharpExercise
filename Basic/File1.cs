using System;

namespace BasicCSharp.Basic
{
    public  class File1
    {
        public static void File1Main()
        {
            Console.Write("Nhap so tu 1 den 7:");
            string so = Console.ReadLine();
            int socannhap = int.Parse(so);
            
            switch (socannhap)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}