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
            int a = 0;
            Console.WriteLine("Cau thu: " + CT.sHoTen);
            BS.Kham(ref a);
            CT.TinhTrangSucKhoe = a;
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
                Console.WriteLine("Doi <=11 nguoi");
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
        static public void HuanLuyenTLCaDoi( List<CauThu> list, HLVTheLuc HLV)
        {
            for(int i=0;i<list.Count;i++)
            {
                list[i].TinhTrangTheLuc += HLV.ChiSoNangCaoTL; 
            }
        }
        static public void HuanLuyenTL(ref CauThu CT, HLVTheLuc HLV)
        {

            CT.TinhTrangTheLuc += HLV.ChiSoNangCaoTL;
        }
    }
}
