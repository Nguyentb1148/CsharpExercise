using System;

namespace BasicCSharp.Basic2
{
    public class Method2
    {
        /*
         * Enter a given string of characters “Greenwich’s Club of Developers” and then perform the following methods:
           - Reverse the given string
           - Prints the given string to lowercase and uppercase
           - Cut the string and print out “Club” prints the given string
           - Count occurrences of 'e' and screen print
         */
        public static void Method2Main()
        {
            string chuoi = "Greenwich's Club of Developers";
            
            //đảo ngược chuỗi 
            string daochuoi = Reserve(chuoi);
            
            //In thường chuỗi
             Console.WriteLine("In thuong: " +chuoi.ToLower());
             //In hoa chuỗi
             Console.WriteLine("In hoa: "+chuoi.ToUpper());
            
             Console.WriteLine("\nDao nguoc chuoi: " +daochuoi);
            //Cắt chuỗi mới bằng Substring(vị trí cắt, độ dài)
            Console.WriteLine("chuoi moi:" + chuoi.Substring(12, 4));

            int dem = 0;
            int lan = -1;
            int idx = -1;
            char solan = 'e';
            while (dem != -1)
            {
                dem =chuoi.IndexOf(solan, idx + 1);//Sử dụng IndexOf để tìm vị trí cụ thể của e
                lan += 1;
                idx = dem;
            }
            Console.Write("e da xuat hien:" + lan + " lan.");  

            Console.ReadLine();
        }
        
        public static string Reserve(string index)
        {
            char[] arr = index.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}