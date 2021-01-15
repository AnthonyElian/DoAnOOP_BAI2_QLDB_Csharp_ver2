using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{

    public class CauThu : CaNhan
    {
        private const double hesoluong= 1.3;
        private int iSoAo;
        private int iTinhTrangTheLuc;
        private int iTinhTrangSucKhoe;
        private string sChanThuan;
        private string sViTriDaChinh;

        public int SoAo
        {
            get { return this.iSoAo; }
            set { this.iSoAo = value; }
        }

        public int TinhTrangTheLuc
        {
            get { return this.iTinhTrangTheLuc; }
            set { this.iTinhTrangTheLuc = value; }
        }

        public int TinhTrangSucKhoe
        {
            get { return this.iTinhTrangSucKhoe; }
            set { this.iTinhTrangSucKhoe = value; }
        }
        
        public string ChanThuan 
        {
            get { return this.sChanThuan; }
            set { this.sChanThuan = value; }
        }

        public string ViTriDaChinh 
        {
            get { return this.sViTriDaChinh; }
            set { this.sViTriDaChinh = value; }
        }

        public CauThu(string hoten, DateTime NgayGiaNhap ,int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int soao, int tinhtrangsuckhoe, int tinhtrangtheluc,  string chanthuan, string vitridachinh) : base(hoten, NgayGiaNhap, thoigianhopdong
            , luongcoban, cmnd, namsinh)
        {
            this.iSoAo = soao;
            this.iTinhTrangSucKhoe = tinhtrangsuckhoe;
            this.iTinhTrangTheLuc = tinhtrangtheluc;
            this.sChanThuan = chanthuan;
            this.sViTriDaChinh = vitridachinh;
        }
        public CauThu(string hoten, double luongcoban, string cmnd, int namsinh, int soao, int tinhtrangsuckhoe, int tinhtrangtheluc, string chanthuan, string vitridachinh) : base(hoten, luongcoban, cmnd, namsinh)
        {
            this.iSoAo = soao;
            this.iTinhTrangSucKhoe = tinhtrangsuckhoe;
            this.iTinhTrangTheLuc = tinhtrangtheluc;
            this.sChanThuan = chanthuan;
            this.sViTriDaChinh = vitridachinh;
        }
        public CauThu() : base()
        {
            this.sNghe = "CauThu";
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap Thong Tin Cau Thu ~~");
            base.Nhap();
            Console.Write("So ao cua Cau Thu la: ");
            this.iSoAo = int.Parse(Console.ReadLine());

            Console.Write("Tinh Trang The Luc cua Cau Thu: ");
            this.iTinhTrangTheLuc = int.Parse(Console.ReadLine());

            Console.Write("Tinh Trang Suc Khoe cua Cau Thu: ");
            this.iTinhTrangSucKhoe = int.Parse(Console.ReadLine());

            Console.Write("Chan thuan cua Cau Thu la: ");
            this.sChanThuan = Console.ReadLine();

            Console.Write("Vi tri Da Chinh trong doi hinh cua Cau Thu la: ");
            this.sViTriDaChinh = Console.ReadLine();
        }
        public override double TinhLuong()
        {
            return dLuongCoBan *hesoluong - this.TinhThue(hesoluong);
        }
        public override void Xuat()
        {
            Console.WriteLine("Thong Tin Cau Thu ~~ ");
            base.Xuat();

            Console.WriteLine("So Ao co dinh cua Cau Thu la: " + this.iSoAo);
            Console.WriteLine("Chan Thuan cua Cau Thu la: " + this.sChanThuan);
            Console.WriteLine("Vi tri Da Chinh trong doi hinh la: " + this.sViTriDaChinh);
            Console.WriteLine("Luong cua Cau Thu la: " + this.TinhLuong() + " VND");

            if (this.dLuongCoBan > 11000000)
                Console.WriteLine("Thue thu nhap ca nhan cua Cau Thu la: " + this.TinhThue(hesoluong) + " VND");
            else
                Console.WriteLine("Doi tuong khong nam trong danh sach dong thue!! ");
        }

        public static bool operator >(CauThu a, CauThu b)
        {
            int value1 = a.TinhTrangTheLuc;
            int value2 = b.TinhTrangTheLuc;
            return value1 > value2;
        }

        public static bool operator <(CauThu a, CauThu b)
        {
            double value1 = a.TinhTrangSucKhoe;
            double value2 = b.TinhTrangSucKhoe;
            return value1 < value2;
        }

        public static double operator +(CauThu a, double num)
        {
            return a.TinhLuong() + num;
        }
    }
}
