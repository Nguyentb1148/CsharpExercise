using System;

namespace BasicCSharp.Basic2
{
    public class Method
    {
        private static string _str;

        public static void MethodMain()
        { 
            Console.Write("Nhap chuoi ki tu: ");
            _str = Console.ReadLine();
            Console.WriteLine("Chuoi vua nhap: "+_str);
            KiTuRiengLe();
            DaoNguocChuoiRiengLe();
            SoKiTu();
            DemSoChuKiTuDacBiet();
            NguyenAmPhuAm();
            XuatHienNhieuNhat();
            Console.ReadLine();
        }
       static void KiTuRiengLe()
        {
            Console.Write("Chuoi sau khi tach: ");
            int i = 0;
            while (i<_str.Length)// Tách chuỗi
            {
                Console.Write(_str[i]+" ");
                i++;
            }
            Console.WriteLine();
        }
        static void DaoNguocChuoiRiengLe()
        {
            Console.Write("Chuoi sau khi tach va dao nguoc: ");
            int i = _str.Length-1;
            while (i>=0)//In ngược chuỗi và tách chuỗi thành từng kí tự riêng lẻ
            {
                Console.Write(_str[i] + " ");
                i--;
            }
            Console.WriteLine();
        }
        static void SoKiTu()
        {
            int dem = 1;
            for (int i = 0; i < _str.Length; i++)
            {
                if (_str[i] == ' ')//Kiểm tra nếu có dấu cách thì trước đó là 1 từ
                {
                    dem++;
                }
            }
            Console.WriteLine("So tu trong chuoi: " + dem);
        }
        static void DemSoChuKiTuDacBiet()
        {
            int so = 0, chu = 0, kiTuDacBiet = 0,i=0;
            while (i < _str.Length)
            {
                if ((_str[i] >= 'a' && _str[i] <= 'z') || (_str[i] >= 'A' && _str[i] <= 'Z'))
                {
                    chu++;
                }
                else if (_str[i] >= '0' && _str[i] <= '9')
                {
                    so++;
                }
                else
                {
                    kiTuDacBiet++;
                }

                i++;
            }
            Console.WriteLine("So chu cai trong chuoi: " + chu);
            Console.WriteLine("So chu so trong chuoi: " + so);
            Console.WriteLine("So ki tu dac biet trong chuoi: " + kiTuDacBiet);
        }
        static void NguyenAmPhuAm()
        {
            int ngAm = 0, phuAm = 0;
            for (int i = 0; i < _str.Length; i++)
            {
                if(_str[i]=='a'|| _str[i] == 'o'|| _str[i] == 'u'|| _str[i] == 'i'|| _str[i] == 'e'|| _str[i] == 'A' || _str[i] == 'O' || _str[i] == 'U' || _str[i] == 'I' || _str[i] == 'E')
                {
                    ngAm++;
                }
                else
                {
                    phuAm++;
                }
            }
            Console.WriteLine("So nguyen am trong chuoi: "+ ngAm );
            Console.WriteLine("So phu am trong chuoi: " + phuAm );
        }
        static void XuatHienNhieuNhat()
        {
            // int[] NhieuNhat = new int[_str.Length];
            int kiTu=0,nhieuNhat=0,a=0;
            for (int i = 0; i < _str.Length-1; i++)
            {
                for (int j = i + 1; j < _str.Length; j++)
                    if (_str[i] != ' ' && _str[j] != ' ')
                    {
                        if (_str[i] == _str[j])// kiểm tra 2 kí tự có giống nhau ko
                        {
                            kiTu++;
                        }
                    }
                if (kiTu > nhieuNhat)
                {
                    nhieuNhat = kiTu;
                    a = i;// vị trí của kí tụ xuất hiện nhiều nhất
                }
                kiTu = 1;
            }
            Console.WriteLine("Ki tu xuat hien nhieu nhat la "+_str[a]+" xuat hien "+(nhieuNhat));
        }
    }
}