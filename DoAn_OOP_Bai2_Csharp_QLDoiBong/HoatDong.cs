using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    static class HoatDong
    {
        static public void KhamSucKhoeToanDoi(List<CauThu> list, BacSi BS)
        {
            //int a = 0;
            for(int i=0;i<list.Count;i++)
            {
                CauThu temp = list[i];
                HoatDong.KhamSucKhoeCauThu(ref temp, BS);
                list[i] = temp;
            }
               
        }
        static public void KhamSucKhoeCauThu(ref CauThu CT, BacSi BS)
        {
            //int a = 0;
            Console.WriteLine("Cau thu: " + CT.sHoTen);
            BS.Kham(ref CT);
            //CT.TinhTrangSucKhoe = a;
        }
        static public List<CauThu> TuyenChon11CT(List<CauThu> list)
        {
            List<CauThu> temp= new List<CauThu>();
            Console.WriteLine("=============================");
            Console.WriteLine(" 1: Chon 11 Cau thu co TL tot nhat");
            Console.WriteLine(" 2: Tu ban chon");
            Console.Write("Ban muon chon theo cai gi: ");
            int choose = int.Parse(Console.ReadLine());
            if(list.Count<=11)
            {
                Console.WriteLine("Doi <=11 nguoi => Khong the chon Doi !!");
                return list;
            }
            switch (choose)
            {
                case 1:
                    {
                        list.Sort((y, x) => x.TinhTrangTheLuc.CompareTo(y.TinhTrangTheLuc));
                        for (int i = 0; i < 11; i++)
                            temp.Add(list[i]);
                        return temp;
                    }
                case 2:
                    {
                        Console.WriteLine("Day la DS cau thu");
                        foreach(var item in list)
                        {
                            Console.WriteLine(" " + item.sHoTen);
                        }
                        for(int i=0;i<11;i++)
                        {
                            Console.Write("Moi chon cau thu thu " + (i + 1) + ": ");
                            int x= int.Parse(Console.ReadLine());
                            temp.Add(list[x]);
                        }
                        return temp;
                    }
                default:
                    {
                        return temp;
                    }
            }
        }
        static public void HuanLuyenTLCaDoi(List<CauThu> list, HLVTheLuc HLV)
        {
            for(int i=0;i<list.Count;i++)
            {
                list[i].TinhTrangTheLuc = list[i].TinhTrangTheLuc + HLV.ChiSoNangCaoTL;
            }
        }
        static public void HuanLuyenTL(ref CauThu CT, HLVTheLuc HLV)
        {

            CT.TinhTrangTheLuc += HLV.ChiSoNangCaoTL;
        }
        static public void DaGiaoLuu(List<CauThu> listCT, HLVChienThuat HLV)
        {

            Console.WriteLine("Chon cau thu tham gia thi dau");
            List<CauThu> listCT2=HoatDong.TuyenChon11CT(listCT);
            Console.WriteLine("Chon chien thuat");
            string chienthuat =HLV.ChonChienThuat();
            Console.Write("Nhap doi thu: ");
            string dt = Console.ReadLine();
            Console.WriteLine("\t\t\t************************************************\t\t\t");
            Console.WriteLine("Doi nha VS " + dt);
            Console.WriteLine("Danh sach cau thu tham du!");
            foreach (var item in listCT2)
            {
                Console.WriteLine("Cau thu " + item.sHoTen + " so ao: " + item.SoAo);
            }
            Console.Write("Huan luyen vien: "+HLV.sHoTen);
            Console.Write(" + Chien thuat: " + chienthuat);
            Console.WriteLine("\n\t\t\t************************************************\t\t\t\n");
        }

        static public void createCauThu(ref List<CauThu> chuyennhuong)
        {
            CauThu a = new CauThu("nguyen van a", 30000000, "56893457", 1998, 1, 56, 72, "trai", "tienve");
            CauThu b = new CauThu("nguyen van b", 20000000, "56630787", 2000, 90, 88, 12, "phai", "hauve");
            CauThu c = new CauThu("nguyen van c", 67000000, "99637457", 1995, 57, 26, 82, "trai", "tiendao");
            CauThu d = new CauThu("nguyen van d", 100000000, "63019457", 1998, 420, 100, 100, "phai", "tiendao");
            CauThu e = new CauThu("nguyen van e", 12000000, "56891234", 2005, 1, 36, 22, "phai", "tiendao");
            CauThu f = new CauThu("nguyen van f", 10000000, "12343457", 2004, 1, 46, 52, "phai", "tienve");
            //List<CauThu> chuyennhuong = new List<CauThu>();
            chuyennhuong.Add(a);chuyennhuong.Add(b);chuyennhuong.Add(c);chuyennhuong.Add(d);chuyennhuong.Add(e);chuyennhuong.Add(f);
            //return chuyennhuong;
        }

        static public void ChuyenNhuong(ref QuanLyCauThu ct, ref List<CauThu> temp)
        {
            Console.WriteLine("Da den ki chuyen nhuong mua Dong, ban co muon mua them hay ban di cau thu ko? 1_Yes || 2_No");
            Console.Write("=> Your choice: "); int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                int flag = 1;
                while (flag == 1)
                {
                    Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
                    Console.WriteLine("\t\t\t***            1. Mua                            ***\t\t\t");
                    Console.WriteLine("\t\t\t***            2. Ban                            ***\t\t\t");
                    Console.WriteLine("\t\t\t***            3. Thoat                          ***\t\t\t");
                    Console.WriteLine("\t\t\t****************************************************\t\t\t");
                    Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                    int choice1 = int.Parse(Console.ReadLine());
                    switch (choice1)
                    {
                        case 1:
                            {
                                int i = 0;
                                foreach (var item in temp)
                                {
                                    Console.WriteLine("STT: " + i++ + " Ho ten: " + item.sHoTen + " Luong: " + item.TinhLuong());
                                }
                                Console.Write("Moi nhap STT cau thu muon mua: ");
                                int n = int.Parse(Console.ReadLine());
                                temp[n].dNgayGiaNhap = DateTime.Now;
                                Console.Write("Ban muon ki hop dong thoi han bao lau: "); int thoihan = int.Parse(Console.ReadLine());
                                temp[n].iThoiGianHopDong = thoihan;
                                temp[n].sNghe = "CauThu";
                                ct.LDsCauThu.Add(temp[n]);
                                temp.RemoveAt(n);
                                Console.WriteLine("Successfully ~~ ");
                                break;
                            }
                        case 2:
                            {
                                int i = 0;
                                foreach (var item in ct.LDsCauThu)
                                {
                                    Console.WriteLine("STT: " + i++ + " Ho ten: " + item.sHoTen + " Luong: " + item.TinhLuong());
                                }
                                Console.Write("Ban muon ban cau thu so may: "); int stt = int.Parse(Console.ReadLine());
                                ct.xoa1CT(stt);
                                Console.WriteLine("Successfully ~~ ");
                                break;
                            }
                        case 3:
                            {
                                flag = 0;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Nhap sai, moi nhap lai!! ");
                                break;
                            }
                    }
                }
            }
        }
    }
}
