using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    public abstract class CaNhan
    {
        public string sHoTen;
        public DateTime dNgayGiaNhap;
        public int iThoiGianHopDong;
        public double dLuongCoBan;
        public string sCMND;
        public int iNamSinh;
        public string sNghe;
        public CaNhan() { }
        enum Bac
        {
            Bac0 = 0,
            Bac1 = 1,
            Bac2,
            Bac3,
            Bac4,
            Bac5,
            Bac6,
            Bac7
        }
        public CaNhan(string hoten,DateTime NgayGiaNhap, int thoigianhopdong, double luongcoban, string cmnd, int namsinh)
        {
            this.sHoTen = hoten;
            this.dNgayGiaNhap = NgayGiaNhap;
            this.iThoiGianHopDong = thoigianhopdong;
            this.dLuongCoBan = luongcoban;
            this.sCMND = cmnd;
            this.iNamSinh = namsinh;
        }

        public  CaNhan(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh)
        {
            this.sHoTen = hoten;
            this.iThoiGianHopDong = thoigianhopdong;
            this.dLuongCoBan = luongcoban;
            this.sCMND = cmnd;
            this.iNamSinh = namsinh;
        }

        public CaNhan(string hoten, double luongcoban, string cmnd)
        {
            this.sHoTen = hoten;
            this.dLuongCoBan = luongcoban;
            this.sCMND = cmnd;
        }
        public abstract double TinhLuong();
        public virtual void Nhap()
        {
            Console.Write("Moi nhap Ho Ten thanh vien: ");
            this.sHoTen = Console.ReadLine();

            Console.Write("Nhap ngay gia nhap dinh dang dd/mm/yyyy: ");
            this.dNgayGiaNhap = DateTime.Parse(Console.ReadLine());

            Console.Write("Moi nhap Thoi Gian Hop Dong: ");
            this.iThoiGianHopDong = int.Parse(Console.ReadLine());

            
            Console.Write("Moi nhap Luong Co Ban cua thanh vien: ");
            this.dLuongCoBan = double.Parse(Console.ReadLine());

            Console.Write("Moi nhap so CMND cua thanh vien: ");
            this.sCMND = Console.ReadLine();

            Console.Write("Moi nhap Nam Sinh cua thanh vien: ");
            this.iNamSinh = int.Parse(Console.ReadLine());
        }


        public virtual void Xuat()
        {
            Console.WriteLine("Ho Ten thanh vien la: " + this.sHoTen);
            Console.WriteLine("Ngay Gia Nhap: {0:d}",this.dNgayGiaNhap);
            Console.WriteLine("Thoi gian Hop Dong cua thanh vien la: " + this.iThoiGianHopDong + " nam");
            Console.WriteLine("Luong co ban cua thanh vien la: " + this.dLuongCoBan + " VND");
            Console.WriteLine("So CMND cua thanh vien la: " + this.sCMND);
            Console.WriteLine("Nam sinh cua thanh vien la: " + this.iNamSinh);
            Console.WriteLine("Tuoi cua thanh vien la: " + this.TinhTuoi());
        }
        public double GiamTru(double heso)
        {
            double GiamTruGiaCanhBanThan = 11000000;
            //8% BHXH, 1.5% BHYT, 1% BHTN
            double BaoHiem = this.dLuongCoBan*heso * (0.08 + 0.015 + 0.01);
            double GiamTru = GiamTruGiaCanhBanThan + BaoHiem;
            return GiamTru;
        }

        public int XacDinhBacThue(double heso)
        {
            double ThuNhapTinhThue = this.dLuongCoBan * heso - this.GiamTru(heso);
            if (ThuNhapTinhThue <= 0)
                return (int)Bac.Bac0;

            if (ThuNhapTinhThue <= 500  )
                return (int)Bac.Bac1;
            else
            {
                if (ThuNhapTinhThue <= 10000000)
                {
                    return (int)Bac.Bac2;
                }
                else
                {
                    if (ThuNhapTinhThue <= 18000000)
                    {
                        return (int)Bac.Bac3;
                    }
                    else
                    {
                        if (ThuNhapTinhThue <= 32000000)
                        {
                            return (int)Bac.Bac4;
                        }
                        else
                        {
                            if (ThuNhapTinhThue <= 52000000)
                            {
                                return (int)Bac.Bac5;
                            }
                            else
                            {
                                if (ThuNhapTinhThue <= 80000000)
                                {
                                    return (int)Bac.Bac6;
                                }
                                else
                                    return (int)Bac.Bac7;
                            }
                        }
                    }
                }
            }
        }

        public virtual double TinhThue(double heso)
        {
            double ThuNhapTinhThue = this.dLuongCoBan * heso - this.GiamTru(heso);
            int Bac = XacDinhBacThue(heso);
            double SoThuePhaiNop = 0;
            switch (Bac)
            {
                case 0:
                    {
                        return 0;
                    }
                case 1:
                    {
                        SoThuePhaiNop = ThuNhapTinhThue * 0.05;
                        break;
                    }
                case 2:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.1) - 250000;
                        break;
                    }
                case 3:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.15) - 750000;
                        break;
                    }
                case 4:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.2) - 1650000;
                        break;
                    }
                case 5:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.25) - 3250000;
                        break;
                    }
                case 6:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.3) - 5850000;
                        break;
                    }
                default:
                    {
                        SoThuePhaiNop = (ThuNhapTinhThue * 0.35) - 9850000;
                        break;
                    }
            }
            return SoThuePhaiNop;
        }

        public int TinhTuoi()
        {
            return 2020 - this.iNamSinh;
        }
        public int ThoiGianHopDongConLai()
        {
            DateTime temp = new DateTime(this.iThoiGianHopDong+this.dNgayGiaNhap.Year, this.dNgayGiaNhap.Month, this.dNgayGiaNhap.Day);
            DateTime now = DateTime.Now;
            TimeSpan res = temp - now;
            Console.WriteLine(res.TotalDays);
            return (int)res.TotalDays;
        }
    }
}
