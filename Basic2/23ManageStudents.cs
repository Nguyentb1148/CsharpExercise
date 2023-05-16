using System;

namespace BasicCSharp.Basic2
{
    public class ManageStudents
    {
        struct SinhVien//Khởi tạo struct SinhVien để gọi hết những thông tin cần xử lí thành một kiểu dữ liệu duy nhất
        { 
            public string TenTruong, Hoten, GioiTinh;
            public int Tuoi;
            public float DiemLy, DiemHoa, DiemToan,DiemTb;
        }
        public static void ManageStudentsMain()
        {
            int choice;
            Console.Write("Nhap so luong hoc sinh: ");
            int num = int.Parse(Console.ReadLine());
            SinhVien[] students = new SinhVien[num];
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
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        NhapTTKhanghang(students);
                        break;
                    case 2:
                        if (num == 0)
                        {
                            Console.WriteLine("Khong co sinh vien trong danh sach.");
                        }
                        else
                        {
                            InThongTinSinhVien(students);
                        }
                        break;
                    case 3:
                        if (num == 0)
                        {
                            Console.WriteLine("Khong co sinh vien trong danh sach.");
                        }
                        else
                        {
                            InRaDiemTrungBinh(students);
                        }
                        break;
                    case 4:
                        if (num == 0)
                        {
                            Console.WriteLine("Khong co sinh vien trong danh sach.");
                        }
                        else
                        {
                            SapXepTheoDiemTrungBinh(students);
                        }
                        break;
                    case 5:
                        if (num == 0)
                        {
                            Console.WriteLine("Khong co sinh vien trong danh sach.");
                        }
                        else
                        {
                            SepXepLoaiSinhVien(students);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Ban da thoat chuong trinh.");
                        Console.ReadLine();
                        break;
                }
            } while (choice!=6);
        }
        static void NhapTTKhanghang(SinhVien[] student)//Lấy thông tin và gán giá trị
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"Sinh vien thu {i+1}");
                Console.Write($"Nhap ho va ten: ");
                student[i].Hoten = Console.ReadLine();//Gán giá trị cho từng biến
                Console.Write($"Nhap tuoi khach hang {i + 1}: ");
                student[i].Tuoi = int.Parse(Console.ReadLine());
                Console.Write($"Nhap gioi tinh cua {student[i].Hoten}:");
                student[i].GioiTinh = Console.ReadLine();
                Console.Write($"Nhap ten truong: ");
                student[i].TenTruong =Console.ReadLine();
                Console.Write($"Nhap diem toan cua {student[i].Hoten}: ");
                student[i].DiemToan = int.Parse(Console.ReadLine());
                Console.Write($"Nhap diem ly cua {student[i].Hoten}: ");
                student[i].DiemLy = int.Parse(Console.ReadLine());
                Console.Write($"Nhap diem hoa cua {student[i].Hoten}: ");
                student[i].DiemHoa = int.Parse(Console.ReadLine());
                student[i].DiemTb = (student[i].DiemToan + student[i].DiemLy + student[i].DiemHoa) / 3;
                Console.WriteLine();
            }
        }
        static void InThongTinSinhVien(SinhVien[]student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"Sinh vien thu {i + 1}");
                Console.WriteLine("Ho va ten: "+student[i].Hoten+" Gioi tinh: "+student[i].GioiTinh);
                Console.WriteLine("Tuoi: " + student[i].Tuoi);
                Console.WriteLine("Ten truong: " + student[i].TenTruong);
                Console.WriteLine("Diem toan: " + student[i].DiemToan);
                Console.WriteLine("Diem ly: " + student[i].DiemLy);
                Console.WriteLine("Diem hoa: " + student[i].DiemHoa);
                Console.WriteLine();
            }
        }
        static void InRaDiemTrungBinh(SinhVien[]student)
        {
            Console.WriteLine("Danh sach Diem trung binh.");
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Ho va ten: " + student[i].Hoten);
                Console.WriteLine($"Diem trung binh cua {student[i].Hoten}: " + student[i].DiemTb);
            }
        }
        static void SapXepTheoDiemTrungBinh(SinhVien[]student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                for (int j = i+1; j < student.Length; j++)
                {
                    if(student[i].DiemTb>student[j].DiemTb)
                    {
                        (student[i].DiemTb, student[j].DiemTb) = (student[j].DiemTb, student[i].DiemTb);//Swap giải cấu trúc của C#
                    }
                }
            }
            Console.WriteLine("Danh sach sinh vien sap xep tang dan theo diem: ");
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Ho va ten: "+student[i].Hoten+" Diem trung binh: "+student[i].DiemTb);
            }
            Console.WriteLine();
        }
        static void SepXepLoaiSinhVien(SinhVien[]student)//Phân loại học lực dựa vào điểm trung bình
        {
            for (int i = 0; i < student.Length; i++)
            {
                if(student[i].DiemTb>=8)
                {
                    Console.WriteLine($"{student[i].Hoten}: Gioi ({student[i].DiemTb})." );
                }
                else if(student[i].DiemTb>=5&&student[i].DiemTb<8)
                {
                    Console.WriteLine($"{student[i].Hoten}: Kha ({student[i].DiemTb}).");
                }
                else
                {
                    Console.WriteLine($"{student[i].Hoten}: Trung binh ({student[i].DiemTb}).");
                }
            }
        }
    }
    
}