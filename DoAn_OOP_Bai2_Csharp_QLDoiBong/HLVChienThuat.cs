using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class HLVChienThuat : CaNhan
    {
        private const double hesoluong = 1.3;
        private string sRank;
        private string sQuocGia;
        private int iKinhNghiem;

        public string Rank
        {
            get { return this.sRank; }
            set { this.sRank = value; }
        }

        public string QuocGia
        {
            get { return this.sQuocGia; }
            set { this.sQuocGia = value; }
        }

        public int KinhNghiem
        {
            get { return this.iKinhNghiem; }
            set { this.iKinhNghiem = value; }
        }

        public HLVChienThuat() : base() 
        {
            this.sNghe = "HLVCT";
        }

        public HLVChienThuat(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, string rank, string quocgia, int kinhnghiem) : base(hoten, thoigianhopdong, luongcoban, cmnd, namsinh) 
        {
            this.sRank = rank;
            this.sQuocGia = quocgia;
            this.iKinhNghiem = kinhnghiem;
        }

        public HLVChienThuat(string hoten, double luongcoban, string cmnd,int namsinh, string rank) : base(hoten, luongcoban, cmnd, namsinh)
        {
            this.iNamSinh = namsinh;
            this.sRank = rank;
        }
        public override void Nhap()
        {
            Console.WriteLine("Moi nhap thong tin HLV Chien Thuat ~~ ");
            base.Nhap();

            Console.Write("Moi nhap hang cua HLV //Hang: C_B_A_Pro : ");
            this.sRank = Console.ReadLine();

            Console.Write("Moi nhap Quoc Gia cua HLV: ");
            this.sQuocGia = Console.ReadLine();

            Console.Write("Moi nhap so doi ma HLV da tung cong tac: ");
            this.iKinhNghiem = int.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return this.dLuongCoBan* hesoluong - TinhThue(hesoluong);
        }
        public override void Xuat()
        {
            base.Xuat();

            Console.WriteLine("Hang cua HLV Chien Thuat la: " + this.sRank);

            Console.WriteLine("HLV Chien Thuat den tu: " + this.sQuocGia);

            Console.WriteLine("So doi bong HLV nay tung dan dat: " + this.iKinhNghiem);

            Console.WriteLine("Luong cua HLV Chien Thuat: " + this.TinhLuong() + " VND");

            if (this.dLuongCoBan > 11000000)
                Console.WriteLine("Thue thu nhap ca nhan cua HLV Chien Thuat la: " + this.TinhThue(hesoluong) + " VND");
            else
                Console.WriteLine("Doi tuong khong nam trong danh sach dong thue!! ");
        }
        public string ChonChienThuat()
        {
            Console.Write("Ban Muon chon chien thuat nao: ");
            string temp=Console.ReadLine();
            return temp;
        }

        public static double operator +(HLVChienThuat a, double num)
        {
            return a.TinhLuong() + num;
        }
    }
}
