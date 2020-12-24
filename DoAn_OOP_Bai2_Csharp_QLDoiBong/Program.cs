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

            San san = new San();
            a.Nhap();
            int co = 1, co2 = 1;
            while(flag == 1)
            {
                Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
                Console.WriteLine("\t\t\t***            1. Quan Ly Cau Thu                ***\t\t\t");
                Console.WriteLine("\t\t\t***            2. Quan Ly Nhan Vien              ***\t\t\t");
                Console.WriteLine("\t\t\t***            3. Quan Ly San                    ***\t\t\t");
                Console.WriteLine("\t\t\t***            4. Thoat                          ***\t\t\t");
                Console.WriteLine("\t\t\t****************************************************\t\t\t");
                Console.Write("Moi nhap lua chon cua ba => Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            a.MenuQLCT();
                            break;
                        }
                    case 2:
                        {
                            a.MenuQLNV();
                            break;
                        }
                    case 3:
                        {
                            //int co = 1;
                        
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
