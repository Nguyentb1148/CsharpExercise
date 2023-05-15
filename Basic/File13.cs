using System;

namespace BasicCSharp.Basic
{
    public class File13
    {
        public static string chuoi;

        public static void File13Main()
        { 
            Console.Write("Nhap chuoi ki tu: ");
            chuoi = Console.ReadLine();
            Console.WriteLine("Chuoi vua nhap: "+chuoi);
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
            while (i<chuoi.Length)
            {
                Console.Write(chuoi[i]+" ");
                i++;
            }
            Console.WriteLine();
        }
        static void DaoNguocChuoiRiengLe()
        {
            Console.Write("Chuoi sau khi tach va dao nguoc: ");
            int i = chuoi.Length-1;
            while (i>=0)
            {
                Console.Write(chuoi[i] + " ");
                i--;
            }
            Console.WriteLine();
        }
        static void SoKiTu()
        {
            int dem = 1;
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == ' ')
                {
                    dem++;
                }
            }
            Console.WriteLine("So tu trong chuoi: " + dem);
        }
        static void DemSoChuKiTuDacBiet()
        {
            int so = 0, chu = 0, kiTuDacBiet = 0,i=0;
            while (i < chuoi.Length)
            {
                if ((chuoi[i] >= 'a' && chuoi[i] <= 'z') || (chuoi[i] >= 'A' && chuoi[i] <= 'Z'))
                {
                    chu++;
                }
                else if (chuoi[i] >= '0' && chuoi[i] <= '9')
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
            for (int i = 0; i < chuoi.Length; i++)
            {
                if(chuoi[i]=='a'|| chuoi[i] == 'o'|| chuoi[i] == 'u'|| chuoi[i] == 'i'|| chuoi[i] == 'e'|| chuoi[i] == 'A' || chuoi[i] == 'O' || chuoi[i] == 'U' || chuoi[i] == 'I' || chuoi[i] == 'E')
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
            int[] NhieuNhat = new int[chuoi.Length];
            int kiTu=0,nhieuNhat=0,a=0;
            for (int i = 0; i < chuoi.Length-1; i++)
            {
                for (int j = i + 1; j < chuoi.Length; j++)
                    if (chuoi[i] != ' ' && chuoi[j] != ' ')
                    {
                        if (chuoi[i] == chuoi[j])
                        {
                            kiTu++;
                        }
                    }
                if (kiTu > nhieuNhat)
                {
                    nhieuNhat = kiTu;
                    a = i;
                }
                kiTu = 1;
            }
            Console.WriteLine("Ki tu xuat hien nhieu nhat la "+chuoi[a]+" xuat hien "+(nhieuNhat));
        }
    }
}