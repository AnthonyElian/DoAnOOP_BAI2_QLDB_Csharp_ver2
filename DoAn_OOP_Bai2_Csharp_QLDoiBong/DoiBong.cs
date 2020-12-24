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
        private San sanDoiBong;
        private QuanLyCauThu lCauThu;
        private QuanLyNhanVien lNhanvien;
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
        public QuanLyNhanVien listNhanVien
        {
            get { return this.lNhanvien; }
            set { this.lNhanvien = value; }
        }

        public DoiBong()
        {
            this.sanDoiBong = new San();
            this.lCauThu = new QuanLyCauThu();
            this.lNhanvien = new QuanLyNhanVien();
        }

        public DoiBong(string tendoibong, string nhataitro, San sandoibong)
        {
            this.sTenNhaTaiTro = nhataitro;
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
           
            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
                Console.WriteLine("\t\t\t***      0. Nhap cau thu                         ***\t\t\t");
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
                    case 0:
                        {
                            listCauThu.Nhap();
                            break;
                        }
                    case 1:
                        {
                            listCauThu.Sort();
                            listCauThu.Xuat();
                            break;
                        }
                    case 2:
                        {
                            List<CauThu> temp = listCauThu.Loc();
                            foreach (var item in temp)
                            {
                                item.Xuat();
                            }
                            break;
                        }
                    case 3:
                        {
                            listCauThu.Search().Xuat();
                            break;
                        }
                    case 4:
                        {
                            listCauThu.XemtinhTrangtheLuc();
                            break;
                        }
                    case 5:
                        {
                            listCauThu.XemtinhTrangSucKhoe();
                            break;
                        }
                    case 6:
                        {
                            listCauThu.CauThuCoTheLucTotNhat().Xuat();
                            break;
                        }
                    case 7:
                        {
                            listCauThu.CauThuCoTheSucKhoeYeuNhat().Xuat();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Tong luong phai tra cho cac Cau  Thu la: " + this.lCauThu.TongLuongToanCauThu());
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
            
            
            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
                Console.WriteLine("\t\t\t***      0. Nhap NV                              ***\t\t\t");
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
                    case 0:
                        {
                            listNhanVien.Nhap();
                            break;
                        }
                    case 1:
                        {
                            listNhanVien.SapxepTheoLuong();
                            listNhanVien.XuatDsNhanVien();
                            break;
                        }
                    case 2:
                        {
                            List<CaNhan> temp = listNhanVien.LocTheoLuongLon();
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
                            List<CaNhan> temp = listNhanVien.LocTheoLuongBe();
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
                            listNhanVien.XuatDsBacSi();
                            break;
                        }
                    case 5:
                        {
                            listNhanVien.XuatDsHLVCT();
                            break;
                        }
                    case 6:
                        {
                            listNhanVien.XuatDsHLVTL();
                            break;
                        }
                    case 7:
                        {
                            listNhanVien.XuatDsNVBV();
                            break;
                        }
                    case 8:
                        {
                            listNhanVien.XuatDsNVVS();
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Tong luong toan nhan vien la: " + listNhanVien.TinhLuongToanBoNV());
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
                            HoatDong.KhamSucKhoeToanDoi(this.lCauThu.LDsCauThu, this.lNhanvien.Lbacsi[0]);
                            this.lCauThu.XemtinhTrangSucKhoe();
                            break;
                        }
                    case 2:
                        {
                            foreach (var item in this.lCauThu.LDsCauThu)
                            {
                                Console.WriteLine("Ten: " + item.sHoTen + " So Ao: " + item.SoAo);
                            }
                            Console.Write("Muon Kham Suc Khoe Cau Thu thu: ");
                            int i = int.Parse(Console.ReadLine());
                            CauThu temp =  this.lCauThu.LDsCauThu[i];
                            HoatDong.KhamSucKhoeCauThu(ref temp, this.lNhanvien.Lbacsi[0]);
                            this.lCauThu.LDsCauThu[i] = temp;
                            this.lCauThu.XemtinhTrangSucKhoe();
                            break;
                        }
                    case 3:
                        {
                            List<CauThu> temp = HoatDong.TuyenChon11CT(this.lCauThu.LDsCauThu);
                            Console.WriteLine("Doi Hinh da lua chon: ");
                            foreach (var item in temp)
                            {
                                Console.WriteLine("Ten: " + item.sHoTen + " Vi Tri: " + item.ViTriDaChinh);
                            }
                            break;
                        }
                    case 4:
                        {
                            HoatDong.HuanLuyenTLCaDoi(this.lCauThu.LDsCauThu, this.lNhanvien.LHLVTL[0]);
                            this.lCauThu.XemtinhTrangtheLuc();
                            break;
                        }
                    case 5:
                        {
                            foreach (var item in this.lCauThu.LDsCauThu)
                            {
                                Console.WriteLine("Ten: " + item.sHoTen + " CMND: " + item.sCMND);
                            }
                            Console.Write("Muon Cai Thien The Luc Cau Thu thu: ");
                            int i = int.Parse(Console.ReadLine());
                            CauThu temp = this.lCauThu.LDsCauThu[i];
                            HoatDong.HuanLuyenTL(ref temp, this.lNhanvien.LHLVTL[0]);
                            this.lCauThu.LDsCauThu[i] = temp;
                            this.lCauThu.XemtinhTrangtheLuc();
                            break;
                        }
                    case 6:
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
