using System;

namespace BasicCSharp.Basic
{
    public class File16
    {
        public static void File16Main()
        {
            int day, month, year;
            Console.WriteLine("Nhap ngay");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam");
            year = int.Parse(Console.ReadLine());
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