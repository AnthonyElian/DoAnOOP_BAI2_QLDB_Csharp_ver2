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
        static public void DaGiaoLuu(List<CauThu> listCT, HLVChienThuat HLV, San san)
        {

            Console.WriteLine("Chon cau thu tham gia thi dau");
            List<CauThu> listCT2 = HoatDong.TuyenChon11CT(listCT);
            Console.WriteLine("Chon chien thuat");
            string chienthuat = HLV.ChonChienThuat();
            Console.Write("Nhap doi thu: ");
            string dt = Console.ReadLine();
            Console.Write("Ban muon da tren san nha:1 hay san khach:2 => Your choice: ");
            int key = int.Parse(Console.ReadLine()); int flag;
            string tensan = "";
            if (key == 1)
            {
                if (san != null)
                {
                    flag = 1;
                }
                else
                {
                    flag = 2;
                    Console.Write("Doi tuyen khong co san, Moi nhap ten san khach: "); tensan = Console.ReadLine();
                }
            }
            else
            {
                flag = 2;
                Console.Write("Moi nhap ten san khach: ");tensan = Console.ReadLine();
            }
            int soLuong = 0;
            if (flag == 1)
            {
                do
                {
                    Console.Write("Moi nhap so luong khan gia da mua ve: ");
                    soLuong = int.Parse(Console.ReadLine());

                } while (san.ISoLuongKhanGia < soLuong);
            }
            Console.WriteLine("\t\t\t************************************************\t\t\t");
            Console.WriteLine("Doi nha VS " + dt);
            if (flag == 1)
            {
                Console.WriteLine("Cuoc so tai duoc dien ra tren san van dong: " + san.STenSan);
            }
            else
            {
                Console.WriteLine("Cuoc so tai duoc dien ra tren san van dong: " + tensan);
            }
            Console.WriteLine("Danh sach cau thu tham du!");
            foreach (var item in listCT2)
            {
                Console.WriteLine("Cau thu " + item.sHoTen + " so ao: " + item.SoAo);
            }
            Console.Write("Huan luyen vien: "+HLV.sHoTen);
            Console.Write(" + Chien thuat: " + chienthuat);
            Console.WriteLine("\n\t\t\t************************************************\t\t\t");
            Console.Write("1_Thang || 2_Thua => Your choice: ");
            int temp = int.Parse(Console.ReadLine());
            if (temp == 1)
            {
                for (int i=0;i<listCT2.Count;i++)
                {
                    for (int j=0;j<listCT.Count;j++)
                    {
                        if (listCT2[i].sHoTen == listCT[j].sHoTen)
                        {
                            listCT[j].dLuongCoBan = listCT[j].dLuongCoBan + 500000;
                            listCT[j].TinhTrangSucKhoe = listCT[j].TinhTrangSucKhoe - 2;
                            listCT[j].TinhTrangTheLuc = listCT[j].TinhTrangTheLuc - 3;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < listCT2.Count; i++)
                {
                    for (int j = 0; j < listCT.Count; j++)
                    {
                        if (listCT2[i].sHoTen == listCT[j].sHoTen)
                        {
                            listCT[j].TinhTrangSucKhoe = listCT[j].TinhTrangSucKhoe - 5;
                            listCT[j].TinhTrangTheLuc = listCT[j].TinhTrangTheLuc - 7;
                        }
                    }
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Thu nhap cua san bong la: " + san.IGiaVe * soLuong);
            }
        }

        static public void createCauThu(ref List<CauThu> chuyennhuong)
        {
            Random rd = new Random();
            int soLuong = rd.Next(minValue: 5, maxValue: 11);
            for (int i = 0; i < soLuong; i++)
            {
                CauThu a = new CauThu();
                int aphlab = rd.Next(minValue: 65, maxValue: 123);
                a.sHoTen = "Nguyen Van " + ((char)aphlab).ToString();
                int luongcoban = rd.Next(minValue: 1000000, maxValue: 1000000000);
                a.dLuongCoBan = luongcoban;
                int cmnd = rd.Next(minValue: 10000000, maxValue: 100000000);
                a.sCMND = Convert.ToString(cmnd);
                int namsinh = rd.Next(minValue: 1890, maxValue: 2009);
                a.iNamSinh = namsinh;
                int soao = rd.Next(minValue: 1, maxValue: 101);
                a.SoAo = soao;
                int theluc = rd.Next(minValue: 10, maxValue: 101);
                a.TinhTrangTheLuc = theluc;
                int suckhoe = rd.Next(minValue: 10, maxValue: 101);
                a.TinhTrangSucKhoe = suckhoe;
                int chanthuan = rd.Next(minValue: 1, maxValue: 3);
                if (chanthuan == 1)
                    a.ChanThuan = "trai";
                else
                    a.ChanThuan = "phai";
                int vitridachinh = rd.Next(minValue: 1, maxValue: 4);
                if (vitridachinh == 1)
                {
                    a.ViTriDaChinh = "tiendao";
                }
                else if (vitridachinh == 2)
                {
                    a.ViTriDaChinh = "tienve";
                }
                else
                    a.ViTriDaChinh = "hauve";
                chuyennhuong.Add(a);
            }
        }

        static public void ChuyenNhuong(ref QuanLyCauThu ct, ref List<CauThu> temp)
        {
            Random rd = new Random();
            int key = rd.Next(minValue: 1, maxValue: 5);
            string tmp = "";
            if (key == 1)
            {
                tmp = "Xuan";
            }
            else if (key == 2)
            {
                tmp = "Ha";
            }
            else if (key == 3)
            {
                tmp = "Thu";
            }
            else if (key == 4)
            {
                tmp = "Dong";
            }

            Console.WriteLine("Da den ki chuyen nhuong mua " + tmp + ", ban co muon mua them hay ban di cau thu ko? 1_Yes || 2_No");
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
