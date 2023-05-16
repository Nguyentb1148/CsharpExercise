using System;

namespace BasicCSharp.Basic
{
    public class CheckTriangle
    {
        /*For triangle ABC, enter 3 sides of the triangle in turn and
         then print on the screen what triangle it is (isosceles, equilateral, normal)*/
        public static void CheckTriangleMain()
        {
            a:
            Console.WriteLine("Nhap canh BC:");
            int a = int.Parse(Console.ReadLine());

            if (a <= 0)
            {
                Console.WriteLine("Nhap lai");
                goto a;// Can use goto to go back, but don't abuse it
            }
            else
            {
                b:
                Console.WriteLine("Nhap canh AC:");
                int b = int.Parse(Console.ReadLine());
                if (b <= 0)
                {
                    Console.WriteLine("Nhap lai");
                    goto b;
                }
                else
                {
                    c:
                    Console.WriteLine("Nhap canh AB:");
                    int c = int.Parse(Console.ReadLine());
                    if (c <= 0)
                    {
                        Console.WriteLine("Nhap lai");
                        goto c;
                    }
                    else
                    {
                        int hieua = b - c;
                        int tonga = b + c;
                        if (hieua < a && a < tonga )// triangle inequality
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