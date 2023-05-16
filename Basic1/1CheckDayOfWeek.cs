using System;

namespace BasicCSharp.Basic
{
    public  class CheckDayOfWeek
    {
        // Enter the number from 1 to 7 and then print the equivalent day of the week,
        // if you enter another number, print the screen "Invalid day"
        public static void CheckDayOfWeekMain()
        {
            Console.Write("Nhap so tu 1 den 7:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
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