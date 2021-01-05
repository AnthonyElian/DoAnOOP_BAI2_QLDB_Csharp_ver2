using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 1;
            DoiBong a = new DoiBong();
            a.Nhap();
            San san = new San();
            int co = 1, co2 = 1, co3 = 0, co4 = 0;
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
                Console.WriteLine("\t\t\t***            1. Quan Ly Cau Thu                ***\t\t\t");
                Console.WriteLine("\t\t\t***            2. Quan Ly Nhan Vien              ***\t\t\t");
                Console.WriteLine("\t\t\t***            3. Quan Ly San                    ***\t\t\t");
                Console.WriteLine("\t\t\t***            4. Hoat Dong                      ***\t\t\t");
                Console.WriteLine("\t\t\t***            5. Thoat                          ***\t\t\t");
                Console.WriteLine("\t\t\t****************************************************\t\t\t");
                Console.Write("Moi nhap lua chon cua ba => Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            a.MenuQLCT();
                            co3 = 1;
                            break;
                        }
                    case 2:
                        {
                            a.MenuQLNV();
                            co4 = 1;
                            break;
                        }
                    case 3:
                        {
                            if (co == 1)
                            {
                                Console.Write("Doi Bong co san co khong? 1_Co || 2_Khong : ");
                                int temp = int.Parse(Console.ReadLine());
                                if (temp == 1)
                                {
                                    san.Nhap();
                                    Console.WriteLine("//////////////////////////////////////////////////////////////////////");
                                    san.Xuat();
                                }
                                else
                                {
                                    co2 = 0;
                                    san = null;
                                    Console.WriteLine("Doi bong khong co San!! ");
                                }
                                co = 0;
                            }
                            else
                            {
                                if (co2 == 1)
                                    san.Xuat();
                                else 
                                    Console.WriteLine("Doi bong khong co San!! ");
                            }
                            break;
                        }
                    case 4:
                        {
                            a.MenuHoatDong();
                            break; 
                        }
                    case 5:
                        {
                            flag = 0;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Nhap sai, moi nhap lai!!  ");
                            break;
                        }
                }
            }
        }
    }
}
