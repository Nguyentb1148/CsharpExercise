using System;

namespace BasicCSharp.Basic
{
    public class File8
    {
        public static void File8Main()
        {
            int a, b, c;
        a:
            Console.WriteLine("Nhap canh BC:");
            a = int.Parse(Console.ReadLine());

            if (a <= 0)
            {
                Console.WriteLine("Nhap lai");
                goto a;
            }
            else
            {
            b:
                Console.WriteLine("Nhap canh AC:");
                b = int.Parse(Console.ReadLine());
                if (b <= 0)
                {
                    Console.WriteLine("Nhap lai");
                    goto b;
                }
                else
                {
                c:
                    Console.WriteLine("Nhap canh AB:");
                    c = int.Parse(Console.ReadLine());
                    if (c <= 0)
                    {
                        Console.WriteLine("Nhap lai");
                        goto c;
                    }
                    else
                    {
                        int hieua = b - c;
                        int hieub = a - c;
                        int hieuc = a - b;

                        int tonga = b + c;
                        int tongb = a + c;
                        int tongc = a + b;
                        if (hieua < a && a < tonga && hieub < b && b < tongb && hieuc < c && c < tongc)
                        {
                            if (a == b && b == c)
                            {
                                Console.WriteLine("tam giac deu.");
                            }
                            else if (a == b && b != c)
                            {
                                Console.WriteLine(" tam giac can tai C.");
                            }
                            else if (a == c && b != c)
                            {
                                Console.WriteLine(" tam giac can tai B.");
                            }
                            else if (c == b && b != a)
                            {
                                Console.WriteLine(" tam giac can tai A.");
                            }
                            else
                            {
                                Console.WriteLine("tam giac thuong.");
                            }
                        }

                        else
                        {
                            Console.WriteLine("khong phai tam giac.");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}