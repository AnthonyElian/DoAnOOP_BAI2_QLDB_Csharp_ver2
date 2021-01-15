using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    //hello ban thang minh la dan
    class BacSi : CaNhan
    {
        private const double hesoluong = 1.15;
        private string sRank;
        private string sTruongDaoTao;
        
        public string Rank
        {
            get { return this.sRank; }
            set { this.sRank = value; }
        }

        public string TruongDaoTao
        {
            get { return this.sTruongDaoTao; }
            set { this.sTruongDaoTao = value; }
        }

        public string Nghe { get => this.sNghe; set => this.sNghe = value; }

        public BacSi() : base() {
            this.sNghe = "bacsi";
        }

        public BacSi(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, string rank, string tentruong) : base(hoten, thoigianhopdong, luongcoban, cmnd, namsinh) 
        {
            this.sRank = rank;
            this.sTruongDaoTao = tentruong;
            this.sNghe = "bacsi";
        }

        public BacSi(string hoten, double luongcoban,int namsinh, string cmnd, string tentruong) : base(hoten, luongcoban, cmnd, namsinh) 
        {
            this.sTruongDaoTao = tentruong;
            this.iNamSinh = namsinh;
            this.sNghe = "bacsi";
        }

        public override void Nhap()
        {
            Console.WriteLine("Moi nhap thong tin Bac Si ~~ ");
            base.Nhap();

            Console.Write("Moi nhap loai bang cua Bac Si: ");
            this.sRank = Console.ReadLine();

            Console.Write("Moi nhap truong dao tao Bac Si: ");
            this.sTruongDaoTao = Console.ReadLine();
        }


        public void Kham(ref CauThu ct)
        {
            Console.Write("Moi nhap Tinh Trang suc khoe Cau Thu: ");
            ct.TinhTrangSucKhoe = int.Parse(Console.ReadLine());
            if (ct.TinhTrangSucKhoe < 50)
            {
                Console.WriteLine("Cau thu bi chan thuong !!");
                Console.Write("1_chua tri || 2_khong chua => Your choice: ");
                int temp = int.Parse(Console.ReadLine());
                if (temp == 1)
                {
                    int a = ct.TinhTrangSucKhoe;
                    this.ChuaBenh(ref a);
                    ct.TinhTrangSucKhoe = a;
                    Console.WriteLine("Cau thu da duoc chua tri !! ");
                }
                else
                    Console.WriteLine("Cau thu dang chan thuong dau lam ne !! ");
            }     
            else
                Console.WriteLine("Cau thu dang o tinh trang the luc tot !!");
        }
        public void ChuaBenh(ref int a)
        {
            a = 100;
            Console.WriteLine("Cau thu dang o tinh trang the luc tot nhat !!");
        }
        public override double TinhLuong()
        {
            return dLuongCoBan * hesoluong - this.TinhThue(hesoluong);
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Bang cua Bac Si hang: " + this.sRank);
            Console.WriteLine("Truong dao tao cua Bac Si la: " + this.sTruongDaoTao);
            Console.WriteLine("Luong cua Bac Si la: " + this.TinhLuong() + " VND");
            if (this.dLuongCoBan > 11000000)
                Console.WriteLine("Thue thu nhap ca nhan cua Cau Thu la: " + this.TinhThue(hesoluong) + " VND");
            else
                Console.WriteLine("Doi tuong khong nam trong danh sach dong thue!! ");
        }

        public static double operator +(BacSi a, double num)
        {
            return a.TinhLuong() + num;
        }
        
    }
}
