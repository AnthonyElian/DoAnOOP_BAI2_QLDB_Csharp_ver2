using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class DoiBong
    {
        private string sTenDoiBong;
        private string sTenNhaTaiTro;
        private List<CaNhan> lDoiBong;
        private List<BacSi> lBacsi;
        private List<HLVChienThuat> lHLVChienThuat;
        private List<HLVTheLuc> lHLVTheLuc;
        private San sanDoiBong;
        private QuanLyCauThu lCauThu;

        public string NhaTaiTro
        {
            get { return this.sTenNhaTaiTro; }
            set { this.sTenNhaTaiTro = value; }
        }
        public string TenDoiBong
        {
            get { return this.sTenDoiBong; }
            set { this.sTenDoiBong = value; }
        }
        public List<CaNhan> listDoiBong
        {
            get { return this.lDoiBong; }
            set { this.lDoiBong = value; }
        }

        public San SanDoiBong
        {
            get { return this.sanDoiBong; }
            set { this.sanDoiBong = value; }
        }

        public QuanLyCauThu listCauThu
        {
            get { return this.lCauThu; }
            set { this.lCauThu = value; }
        }

        internal List<BacSi> LBacsi { get => this.lBacsi; set => this.lBacsi = value; }
        internal List<HLVChienThuat> LHLVChienThuat { get => this.lHLVChienThuat; set => this.lHLVChienThuat = value; }
        internal List<HLVTheLuc> LHLVTheLuc { get => this.lHLVTheLuc; set => this.lHLVTheLuc = value; }

        public DoiBong()
        {
            this.lDoiBong = new List<CaNhan>();
            this.sanDoiBong = new San();
            this.lCauThu = new QuanLyCauThu();
        }

        public DoiBong(string tendoibong, string nhataitro, List<CaNhan> listdoibong, San sandoibong)
        {
            this.lDoiBong = listdoibong;
            this.sTenNhaTaiTro = nhataitro;
            this.lDoiBong = listdoibong;
            this.sanDoiBong = sandoibong;
        }

        public void Xuat()
        {
            Console.WriteLine("Ten Doi Bong la: " + this.sTenDoiBong);
            Console.WriteLine("Ten Nha Tai Tro cua Doi Bong la: " + this.sTenNhaTaiTro);
        }

        public void Nhap()
        {
            Console.Write("Moi nhap Ten Doi Bong: ");
            this.sTenDoiBong = Console.ReadLine();
            Console.Write("Ten Nha Tai Tro cua Doi Bong: ");
            this.sTenNhaTaiTro = Console.ReadLine();

        }

        public void MenuQLCT()
        {
            QuanLyCauThu a = new QuanLyCauThu();
            a.Nhap();
            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
                Console.WriteLine("\t\t\t***      1. Sap xep Cau Thu                      ***\t\t\t");
                Console.WriteLine("\t\t\t***      2. Loc Cau Thu                          ***\t\t\t");
                Console.WriteLine("\t\t\t***      3. Tim Kiem Cau Thu                     ***\t\t\t");
                Console.WriteLine("\t\t\t***      4. Xem Tinh Trang The Luc cua Cau Thu   ***\t\t\t");
                Console.WriteLine("\t\t\t***      5. Xem Tinh Trang Suc Khoe cua Cau Thu  ***\t\t\t");
                Console.WriteLine("\t\t\t***      6. Cau Thu co The Luc Tot Nhat          ***\t\t\t");
                Console.WriteLine("\t\t\t***      7. Cau Thu co Suc Khoe Yeu Nhat         ***\t\t\t");
                Console.WriteLine("\t\t\t***      8. Tong Luong Cau Thu                   ***\t\t\t");
                Console.WriteLine("\t\t\t***      9. Thoat                                ***\t\t\t");
                Console.WriteLine("\t\t\t****************************************************\t\t\t");
                Console.Write("Moi nhap lua chon cua ba => Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        {
                            a.Sort();
                            a.Xuat();
                            break;
                        }
                    case 2:
                        {
                            List<CauThu> temp = a.Loc();
                            foreach (var item in temp)
                            {
                                item.Xuat();
                            }
                            break;
                        }
                    case 3:
                        {
                            a.Search().Xuat();
                            break;
                        }
                    case 4:
                        {
                            a.XemtinhTrangtheLuc();
                            break;
                        }
                    case 5:
                        {
                            a.XemtinhTrangSucKhoe();
                            break;
                        }
                    case 6:
                        {
                            a.CauThuCoTheLucTotNhat().Xuat();
                            break;
                        }
                    case 7:
                        {
                            a.CauThuCoTheSucKhoeYeuNhat().Xuat();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Tong luong phai tra cho cac Cau  Thu la: " + a.TongLuongToanCauThu());
                            break;
                        }
                    case 9:
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

        public void MenuQLNV()
        {
            QuanLyNhanVien a = new QuanLyNhanVien();
            a.Nhap();
            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
                Console.WriteLine("\t\t\t***      1. Sap xep Nhan Vien theo Luong         ***\t\t\t");
                Console.WriteLine("\t\t\t***      2. Loc Nhan Vien theo Luong lon         ***\t\t\t");
                Console.WriteLine("\t\t\t***      3. Loc Nhan Vien theo Luong be          ***\t\t\t");
                Console.WriteLine("\t\t\t***      4. Xem Danh Sach Bac Si                 ***\t\t\t");
                Console.WriteLine("\t\t\t***      5. Xem Danh Sach HLV Chien Thuat        ***\t\t\t");
                Console.WriteLine("\t\t\t***      6. Xem Danh Sach HLV The Luc            ***\t\t\t");
                Console.WriteLine("\t\t\t***      7. Xem Danh Sach Nhan Vien Bao Ve       ***\t\t\t");
                Console.WriteLine("\t\t\t***      8. Xem Danh Sach Nhan Vien Ve Sinh      ***\t\t\t");
                Console.WriteLine("\t\t\t***      9. Tong Luong Nhan Vien                 ***\t\t\t");
                Console.WriteLine("\t\t\t***     10. Thoat                                ***\t\t\t");
                Console.WriteLine("\t\t\t****************************************************\t\t\t");
                Console.Write("Moi nhap lua chon cua ba => Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            a.SapxepTheoLuong();
                            a.XuatDsNhanVien();
                            break;
                        }
                    case 2:
                        {
                            List<CaNhan> temp = a.LocTheoLuongLon();
                            Console.WriteLine("Danh sach Nhan Vien co Luong lon hon x da nhap: ");
                            foreach (var item in temp)
                            {
                                item.Xuat();
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 3:
                        {
                            List<CaNhan> temp = a.LocTheoLuongBe();
                            Console.WriteLine("Danh sach Nhan Vien co Luong be hon x da nhap: ");
                            foreach (var item in temp)
                            {
                                item.Xuat();
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 4:
                        {
                            a.XuatDsBacSi();
                            break;
                        }
                    case 5:
                        {
                            a.XuatDsHLVCT();
                            break;
                        }
                    case 6:
                        {
                            a.XuatDsHLVTL();
                            break;
                        }
                    case 7:
                        {
                            a.XuatDsNVBV();
                            break;
                        }
                    case 8:
                        {
                            a.XuatDsNVVS();
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Tong luong toan nhan vien la: " + a.TinhLuongToanBoNV());
                            break;
                        }
                    case 10:
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

        public void MenuHoatDong()
        {
            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
                Console.WriteLine("\t\t\t***      1. Kham Suc Khoe Toan Doi               ***\t\t\t");
                Console.WriteLine("\t\t\t***      2. Kham Suc Khoe Cau Thu                ***\t\t\t");
                Console.WriteLine("\t\t\t***      3. Chon Doi 11 Nguoi                    ***\t\t\t");
                Console.WriteLine("\t\t\t***      4. Huan Luyen The Luc Ca Doi            ***\t\t\t");
                Console.WriteLine("\t\t\t***      5. Huan Luyen The Luc Cau Thu           ***\t\t\t");
                Console.WriteLine("\t\t\t***      6. Thoat                                ***\t\t\t");
                Console.WriteLine("\t\t\t****************************************************\t\t\t");
                Console.Write("Moi nhap lua chon cua ba => Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {

                            break;
                        }
                }
            }
        }
    }
}
