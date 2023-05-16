using System;

namespace BasicCSharp.Basic2
{
    public class Datetime
    {
        /*
         * Enter the day, month, year and then print to the screen format {dddd}:
            -Print to the screen the day 1000 days after the date entered
            -Print to the screen the 100th day of the year after the input date
            -Print to the screen “Too difficult”
         */
        public static void DatetimeMain()
        {
            Console.WriteLine("Nhap ngay");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam");
            int year = int.Parse(Console.ReadLine());
            DateTime dateTime = new DateTime(year, month,day) ;
            DateTime newday = dateTime.AddDays(1000);
            Console.WriteLine("{0}",dateTime);
            Console.WriteLine(" 1000 days later {0}", newday);
            Console.WriteLine("{0:dddd}", newday);
            DateTime newYear = dateTime.AddYears(100);
            Console.WriteLine(" 1000 years later : {0}", newYear);
            Console.Write("khó quá");
            Console.ReadLine();
        }
    }
}