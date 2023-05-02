using System;

namespace BasicCSharp.Basic
{
    public class File22
    {
        struct SinhVien
        {
            public string tenTruong, hoten, gioiTinh;
            public int tuoi;
            public float diemLy, diemHoa, diemToan,diemTB;
        }
        static void File22Main(string[] args)
        {
            int soLuong,chon;
            Console.Write("Nhap so luong hoc sinh: ");
            soLuong = int.Parse(Console.ReadLine());
            SinhVien[] KhachHang = new SinhVien[soLuong];
            do
            {
                Console.WriteLine("-----------------------------MENU------------------------------");
                Console.WriteLine("|1, Nhap vao danh sach sinh vien.                             |");
                Console.WriteLine("|2, In ra danh sach sinh vien.                                |");
                Console.WriteLine("|3, In ra danh sach diem trung binh sinh vien.                |");
                Console.WriteLine("|4, Sap xep sinh vien(thu tu tang dan theo diem trung binh).  |");
                Console.WriteLine("|5, Xep loai sinh vien(Theo diem trun binh).                  |");
                Console.WriteLine("|6, Thoat.                                                    |");
                Console.WriteLine("---------------------------------------------------------------");
                Console.Write("Nhap lua chon(1-6): ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        NhapTTKhanghang(KhachHang);
                        break;
                    case 2:
                        if (soLuong == 0)
                        {
                            Console.WriteLine("Khong co sinh vien trong danh sach.");
                        }
                        else
                        {
                            InThongTinSinhVien(KhachHang);
                        }
                        break;
                    case 3:
                        if (soLuong == 0)
                        {
                            Console.WriteLine("Khong co sinh vien trong danh sach.");
                        }
                        else
                        {
                            InRaDiemTrungBinh(KhachHang);
                        }
                        break;
                    case 4:
                        if (soLuong == 0)
                        {
                            Console.WriteLine("Khong co sinh vien trong danh sach.");
                        }
                        else
                        {
                            SapXepTheoDiemTrungBinh(KhachHang);
                        }
                        break;
                    case 5:
                        if (soLuong == 0)
                        {
                            Console.WriteLine("Khong co sinh vien trong danh sach.");
                        }
                        else
                        {
                            SepXepLoaiSinhVien(KhachHang);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Ban da thoat chuong trinh.");
                        Console.ReadLine();
                        break;
                }
            } while (chon!=6);
        }
        static void NhapTTKhanghang(SinhVien[] KhachHang)
        {
            for (int i = 0; i < KhachHang.Length; i++)
            {
                Console.WriteLine($"Sinh vien thu {i+1}");
                Console.Write($"Nhap ho va ten: ");
                KhachHang[i].hoten = Console.ReadLine();
                Console.Write($"Nhap tuoi khach hang {i + 1}: ");
                KhachHang[i].tuoi = int.Parse(Console.ReadLine());
                Console.Write($"Nhap gioi tinh cua {KhachHang[i].hoten}:");
                KhachHang[i].gioiTinh = Console.ReadLine();
                Console.Write($"Nhap ten truong: ");
                KhachHang[i].tenTruong =Console.ReadLine();
                Console.Write($"Nhap diem toan cua {KhachHang[i].hoten}: ");
                KhachHang[i].diemToan = int.Parse(Console.ReadLine());
                Console.Write($"Nhap diem ly cua {KhachHang[i].hoten}: ");
                KhachHang[i].diemLy = int.Parse(Console.ReadLine());
                Console.Write($"Nhap diem hoa cua {KhachHang[i].hoten}: ");
                KhachHang[i].diemHoa = int.Parse(Console.ReadLine());
                KhachHang[i].diemTB = (KhachHang[i].diemToan + KhachHang[i].diemLy + KhachHang[i].diemHoa) / 3;
                Console.WriteLine();
            }
        }
        static void InThongTinSinhVien(SinhVien[]KhachHang)
        {
            for (int i = 0; i < KhachHang.Length; i++)
            {
                Console.WriteLine($"Sinh vien thu {i + 1}");
                Console.WriteLine("Ho va ten: "+KhachHang[i].hoten+" Gioi tinh: "+KhachHang[i].gioiTinh);
                Console.WriteLine("Tuoi: " + KhachHang[i].tuoi);
                Console.WriteLine("Ten truong: " + KhachHang[i].tenTruong);
                Console.WriteLine("Diem toan: " + KhachHang[i].diemToan);
                Console.WriteLine("Diem ly: " + KhachHang[i].diemLy);
                Console.WriteLine("Diem hoa: " + KhachHang[i].diemHoa);
                Console.WriteLine();
            }
        }
        static void InRaDiemTrungBinh(SinhVien[]KhachHang)
        {
            Console.WriteLine("Danh sach Diem trung binh.");
            for (int i = 0; i < KhachHang.Length; i++)
            {
                Console.WriteLine("Ho va ten: " + KhachHang[i].hoten);
                Console.WriteLine($"Diem trung binh cua {KhachHang[i].hoten}: " + KhachHang[i].diemTB);
            }
        }
        static void SapXepTheoDiemTrungBinh(SinhVien[]KhachHang)
        {
            float bien;
            for (int i = 0; i < KhachHang.Length; i++)
            {
                for (int j = i+1; j < KhachHang.Length; j++)
                {
                    if(KhachHang[i].diemTB>KhachHang[j].diemTB)
                    {
                        bien = KhachHang[i].diemTB;
                        KhachHang[i].diemTB = KhachHang[j].diemTB;
                        KhachHang[j].diemTB = bien;
                    }
                }
            }
            Console.WriteLine("Danh sach sinh vien sap xep tang dan theo diem: ");
            for (int i = 0; i < KhachHang.Length; i++)
            {
                Console.WriteLine("Ho va ten: "+KhachHang[i].hoten+" Diem trung binh: "+KhachHang[i].diemTB);
            }
            Console.WriteLine();
        }
        static void SepXepLoaiSinhVien(SinhVien[]KhachHang)
        {
            for (int i = 0; i < KhachHang.Length; i++)
            {
                if(KhachHang[i].diemTB>=8)
                {
                    Console.WriteLine($"{KhachHang[i].hoten}: Gioi ({KhachHang[i].diemTB})." );
                }
                else if(KhachHang[i].diemTB>=5&&KhachHang[i].diemTB<8)
                {
                    Console.WriteLine($"{KhachHang[i].hoten}: Kha ({KhachHang[i].diemTB}).");
                }
                else
                {
                    Console.WriteLine($"{KhachHang[i].hoten}: Trung binh ({KhachHang[i].diemTB}).");
                }
            }
        }
    }
    
}