using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class HLVTheLuc : CaNhan
    {
        private const double hesoluong = 1.3;
        private int iChiSoNangCaoTL;
        private string sNoiSinh;


        public string NoiSinh
        {
            get { return this.sNoiSinh; }
            set { this.sNoiSinh = value; }
        }
        public int ChiSoNangCaoTL
        {
            get { return this.iChiSoNangCaoTL; }
            set { this.iChiSoNangCaoTL = value; }
        }
        public HLVTheLuc() : base() 
        {
            this.sNghe = "HLVTL";
        }

        public HLVTheLuc(string hoten, int thoigianhopdong, double luongcoban,int NangCaoTL, string cmnd, int namsinh, string noisinh) : base(hoten, thoigianhopdong, luongcoban, cmnd , namsinh)
        {
            this.ChiSoNangCaoTL = NangCaoTL;
            this.sNoiSinh = noisinh;
        }

        public HLVTheLuc(string hoten, double luongcoban, int namsinh, int NangCaoTL, string cmnd, string noisinh) : base(hoten, luongcoban, cmnd, namsinh)
        {
            this.iNamSinh = namsinh;
            this.ChiSoNangCaoTL = NangCaoTL;
            this.sNoiSinh = noisinh;
        }
        public override void Nhap()
        {
            Console.WriteLine("Moi nhap thong tin HLV The Luc ~~ ");
            base.Nhap();

            Console.Write("Moi nhap chi so nang Cao TL: ");
            this.ChiSoNangCaoTL = int.Parse(Console.ReadLine());

            Console.Write("Moi nhap Quoc Gia cua HLV The Luc: ");
            this.sNoiSinh = Console.ReadLine();
        }
        public override double TinhLuong()
        {
            return this.dLuongCoBan * hesoluong - this.TinhThue(hesoluong);
        }

        public override void Xuat()
        {
            
            base.Xuat();
            Console.WriteLine("Tuoi cua HVL The Luc la: " + this.TinhTuoi());

            Console.WriteLine("HLV the luc den tu: " + this.sNoiSinh);

            Console.WriteLine("chi so nang cao the luc : " + this.ChiSoNangCaoTL);

            Console.WriteLine("Luong cua HLV The Luc la: " + this.TinhLuong() + " VND");

            if (this.dLuongCoBan > 11000000)
                Console.WriteLine("Thue thu nhap ca nhan cua HLV The Luc la: " + this.TinhThue(hesoluong) + " VND");
            else
                Console.WriteLine("Doi tuong khong nam trong danh sach dong thue!! ");
        }

        public static double operator +(HLVTheLuc a, double num)
        {
            return a.TinhLuong() + num;
        }
    }  
}
