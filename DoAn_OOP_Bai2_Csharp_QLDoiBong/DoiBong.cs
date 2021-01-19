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
        public List<CaNhan> expired;
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
            this.expired = new List<CaNhan>();
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

        public void DanhSachHetHanHopDong()
        {
            for (int i = 0; i < this.listCauThu.LDsCauThu.Count; i++)
            {
                if (this.listCauThu.LDsCauThu[i].ThoiGianHopDongConLai() <= 0)
                {
                    this.expired.Add(this.lCauThu.LDsCauThu[i]);
                }
            }
            for (int i = 0; i < this.listNhanVien.LcaNhans.Count; i++)
            {
                if (this.listNhanVien.LcaNhans[i].ThoiGianHopDongConLai() <= 0)
                {
                    this.expired.Add(this.lNhanvien.LcaNhans[i]);
                }
            }
        }

        public void ThaoTacHopDong()
        {
            this.DanhSachHetHanHopDong();
            if (this.expired.Count <= 0)
            {
                Console.WriteLine("Khong co nhan vien nao het han hop dong !!");
            }
            else
            {
                int flag = 1;
                while (flag == 1)
                {
                    if (this.expired.Count == 0)
                    {
                        flag = 0;
                    }
                    else
                    {
                        int dem = 0;
                        Console.WriteLine("Danh sach het han hop dong la: ");
                        foreach (var item in expired)
                        {
                            Console.WriteLine("STT: " + dem++ + "Ho ten: " + item.sHoTen + " Luong: " + item.TinhLuong());
                        }
                        Console.Write("1_Gia Han || 2_Kick => Your choice: ");
                        int n = int.Parse(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                {
                                    Console.Write("Ban muon gia han nhan vien thu may: ");
                                    int x = int.Parse(Console.ReadLine());
                                    if (this.expired[x].sNghe == "CauThu")
                                    {
                                        for (int i = 0; i < this.lCauThu.LDsCauThu.Count; i++)
                                        {
                                            if (this.lCauThu.LDsCauThu[i].sHoTen == this.expired[x].sHoTen)
                                            {
                                                Console.Write("Gia han hop dong bao nhieu nam?: ");
                                                this.lCauThu.LDsCauThu[i].iThoiGianHopDong = int.Parse(Console.ReadLine());
                                                this.lCauThu.LDsCauThu[i].dNgayGiaNhap = DateTime.Now;
                                                this.expired.RemoveAt(x);
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        for (int i = 0; i < this.lNhanvien.LcaNhans.Count; i++)
                                        {
                                            if (this.lNhanvien.LcaNhans[i].sHoTen == this.expired[x].sHoTen)
                                            {
                                                Console.Write("Gia han hop dong bao nhieu nam?: ");
                                                int temp = int.Parse(Console.ReadLine());
                                                this.lNhanvien.LcaNhans[i].iThoiGianHopDong = temp;
                                                this.lNhanvien.LcaNhans[i].dNgayGiaNhap = DateTime.Now;
                                                if (this.expired[x].sNghe == "bacsi")
                                                {
                                                    BacSi temp1 = this.lNhanvien.Lbacsi.Find(a => a.sHoTen == this.expired[x].sHoTen);
                                                    temp1.iThoiGianHopDong = temp;
                                                    temp1.dNgayGiaNhap = DateTime.Now;
                                                }
                                                else if (this.expired[x].sNghe == "HLVCT")
                                                {
                                                    HLVChienThuat temp1 = this.lNhanvien.LHLVCT.Find(a => a.sHoTen == this.expired[x].sHoTen);
                                                    temp1.iThoiGianHopDong = temp;
                                                    temp1.dNgayGiaNhap = DateTime.Now;
                                                }
                                                else if (this.expired[x].sNghe == "HLVTL")
                                                {
                                                    HLVTheLuc temp1 = this.lNhanvien.LHLVTL.Find(a => a.sHoTen == this.expired[x].sHoTen);
                                                    temp1.iThoiGianHopDong = temp;
                                                    temp1.dNgayGiaNhap = DateTime.Now;
                                                }
                                                else if (this.expired[x].sNghe == "NVVeSinh")
                                                {
                                                    NVVeSinh temp1 = this.lNhanvien.LNVVS.Find(a => a.sHoTen == this.expired[x].sHoTen);
                                                    temp1.iThoiGianHopDong = temp;
                                                    temp1.dNgayGiaNhap = DateTime.Now;
                                                }
                                                else if (this.expired[x].sNghe == "NVBaoVe")
                                                {
                                                    NVBaoVe temp1 = this.lNhanvien.LNVBV.Find(a => a.sHoTen == this.expired[x].sHoTen);
                                                    temp1.iThoiGianHopDong = temp;
                                                    temp1.dNgayGiaNhap = DateTime.Now;
                                                }
                                                this.expired.RemoveAt(x);
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    Console.Write("Ban muon kick nhan vien thu may: ");
                                    int x = int.Parse(Console.ReadLine());
                                    if (expired[x].sNghe != "CauThu")
                                    {
                                        int temp = 0;
                                        for (int i = 0; i < this.lNhanvien.LcaNhans.Count; i++)
                                        {
                                            if (this.lNhanvien.LcaNhans[i].sHoTen == expired[x].sHoTen)
                                            {
                                                temp = i;
                                                break;
                                            }
                                        }
                                        this.listNhanVien.xoa1NV(temp);
                                        expired.RemoveAt(x);
                                    }
                                    else
                                    {
                                        int temp = 0;
                                        for (int i = 0; i < this.lCauThu.LDsCauThu.Count; i++)
                                        {
                                            if (this.lCauThu.LDsCauThu[i].sHoTen == expired[x].sHoTen)
                                            {
                                                temp = i;
                                                break;
                                            }
                                        }
                                        this.lCauThu.xoa1CT(temp);
                                        expired.RemoveAt(x);
                                    }
                                    break;
                                }
                        }
                        Console.Write("1_ De tiep tuc !! => Your choice: ");
                        flag = int.Parse(Console.ReadLine());
                    }
                }
            }
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
                Console.WriteLine("\t\t\t***      9. Xoa Cau Thu                          ***\t\t\t");
                Console.WriteLine("\t\t\t***     10. Thoat                                ***\t\t\t");
                Console.WriteLine("\t\t\t****************************************************\t\t\t");
                Console.Write("Moi nhap lua chon cua ban => Your choice: ");
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
                            CauThu temp = listCauThu.Search();
                            if (temp == null)
                                Console.WriteLine("Khong tim thay cau thu");
                            else
                                temp.Xuat();
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
                            CauThu temp=listCauThu.CauThuCoTheLucTotNhat();
                            if (temp == null)
                                Console.WriteLine("Khong tim thay cau thu");
                            else
                                temp.Xuat();
                                break;
                        }
                    case 7:
                        {
                            CauThu temp = listCauThu.CauThuCoTheSucKhoeYeuNhat();
                            if (temp == null)
                                Console.WriteLine("Khong tim thay cau thu");
                            else
                                temp.Xuat();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Tong luong phai tra cho cac Cau  Thu la: " + this.lCauThu.TongLuongToanCauThu());
                            break;
                        }
                    case 9:
                        {
                            if (this.lCauThu.LDsCauThu.Count <= 0)
                                Console.WriteLine("Vui long nhap it nhat mot cau thu !! ");
                            else
                            {
                                this.lCauThu.xoaCT();
                                Console.WriteLine("Danh sach cau thu sau khi xoa: ");
                                foreach (var item in this.lCauThu.LDsCauThu)
                                {
                                    Console.WriteLine("Ten cau thu: " + item.sHoTen);
                                }
                            }                         
                            break;
                        }
                    case 10:
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
                Console.WriteLine("\t\t\t***      2. Loc Nhan Vien                        ***\t\t\t");
                Console.WriteLine("\t\t\t***      3. Xem Danh Sach Bac Si                 ***\t\t\t");
                Console.WriteLine("\t\t\t***      4. Xem Danh Sach HLV Chien Thuat        ***\t\t\t");
                Console.WriteLine("\t\t\t***      5. Xem Danh Sach HLV The Luc            ***\t\t\t");
                Console.WriteLine("\t\t\t***      6. Xem Danh Sach Nhan Vien Bao Ve       ***\t\t\t");
                Console.WriteLine("\t\t\t***      7. Xem Danh Sach Nhan Vien Ve Sinh      ***\t\t\t");
                Console.WriteLine("\t\t\t***      8. Tong Luong Nhan Vien                 ***\t\t\t");
                Console.WriteLine("\t\t\t***      9. Tim kiem nhan vien theo ten          ***\t\t\t");
                Console.WriteLine("\t\t\t***     10. Xem Ca Nhan                          ***\t\t\t");
                Console.WriteLine("\t\t\t***     11. Xoa Nhan Vien                        ***\t\t\t");
                Console.WriteLine("\t\t\t***     12. Thoat                                ***\t\t\t");
                Console.WriteLine("\t\t\t****************************************************\t\t\t");
                Console.Write("Moi nhap lua chon cua ban => Your choice: ");
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
                            listNhanVien.Sort();
                            listNhanVien.Xuat();
                            break;
                        }
                    case 2:
                        {
                            List<CaNhan> temp = listNhanVien.Loc();
                            if (temp.Count == 0)
                            {
                                Console.WriteLine("Khong co nhan vien thoa dieu kien loc!!");
                            }
                            else
                            {
                                foreach (var item in temp)
                                {
                                    item.Xuat();
                                    Console.WriteLine();
                                }
                            }                            
                            break;
                        }
                    case 3:
                        {
                            listNhanVien.XuatDsBacSi();
                            break;
                        }
                    case 4:
                        {
                            listNhanVien.XuatDsHLVCT();
                            break;
                        }
                    case 5:
                        {
                            listNhanVien.XuatDsHLVTL();
                            break;
                        }
                    case 6:
                        {
                            listNhanVien.XuatDsNVBV();
                            break;
                        }
                    case 7:
                        {
                            listNhanVien.XuatDsNVVS();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Tong luong toan nhan vien la: " + listNhanVien.TinhLuongToanBoNV());
                            break;
                        }
                    case 9:
                        {
                            CaNhan temp = this.listNhanVien.Search();
                            if (temp == null)
                            {
                                Console.WriteLine("Khong ton tai nhan vien nay!!");
                            }
                            else
                            { temp.Xuat(); }
                            break;
                        }
                    case 10:
                        {
                            this.listNhanVien.XemcaNhan();
                            break;
                        }
                    case 11:
                        {
                            if (this.lNhanvien.LcaNhans.Count <= 0)
                                Console.WriteLine("Vui long nhap it nhat mot nhan vien !!");
                            else
                            {
                                this.lNhanvien.xoaNV();
                                foreach (var item in this.lNhanvien.LcaNhans)
                                {
                                    Console.WriteLine("Ten nhan vien: " + item.sHoTen + " Chuc vu: " + item.sNghe);
                                }
                            }                
                            break;
                        }
                    case 12:
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

        public void MenuHoatDong(San san)
        {
            int flag = 1;
            List<CauThu> tmp = new List<CauThu>();
            HoatDong.createCauThu(ref tmp);
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
                Console.WriteLine("\t\t\t***      1. Kham Suc Khoe Toan Doi               ***\t\t\t");
                Console.WriteLine("\t\t\t***      2. Kham Suc Khoe Cau Thu                ***\t\t\t");
                Console.WriteLine("\t\t\t***      3. Chon Doi 11 Nguoi                    ***\t\t\t");
                Console.WriteLine("\t\t\t***      4. Huan Luyen The Luc Ca Doi            ***\t\t\t");
                Console.WriteLine("\t\t\t***      5. Huan Luyen The Luc Cau Thu           ***\t\t\t");
                Console.WriteLine("\t\t\t***      6. Da thu                               ***\t\t\t");
                Console.WriteLine("\t\t\t***      7. Thao tac hop dong                    ***\t\t\t");
                Console.WriteLine("\t\t\t***      8. Chuyen nhuong                        ***\t\t\t");
                Console.WriteLine("\t\t\t***      9. Thoat                                ***\t\t\t");
                Console.WriteLine("\t\t\t****************************************************\t\t\t");
                Console.Write("Moi nhap lua chon cua ban => Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            BacSi BsKham = this.lNhanvien.chonBacsi();
                            if (BsKham != null)
                            {
                                HoatDong.KhamSucKhoeToanDoi(this.lCauThu.LDsCauThu, BsKham);
                                this.lCauThu.XemtinhTrangSucKhoe();
                            }
                            break;
                        }
                    case 2:
                        {
                            BacSi BsKham = this.lNhanvien.chonBacsi();
                            if (BsKham != null)
                            {
                                foreach (var item in this.lCauThu.LDsCauThu)
                                {
                                    Console.WriteLine("Ten: " + item.sHoTen + " So Ao: " + item.SoAo);
                                }
                                Console.Write("Muon Kham Suc Khoe Cau Thu thu: ");
                                int i = int.Parse(Console.ReadLine());
                                CauThu temp =  this.lCauThu.LDsCauThu[i];
                            
                                HoatDong.KhamSucKhoeCauThu(ref temp, BsKham);
                                this.lCauThu.LDsCauThu[i] = temp;
                                this.lCauThu.XemtinhTrangSucKhoe();
                            }
                            break;
                        }
                    case 3:
                        {
                            List<CauThu> temp = HoatDong.TuyenChon11CT(this.lCauThu.LDsCauThu);
                            if (temp.Count != 0) 
                            { 
                                Console.WriteLine("Doi Hinh da lua chon: ");
                                foreach (var item in temp)
                                {
                                    Console.WriteLine("Ten: " + item.sHoTen + " Vi Tri: " + item.ViTriDaChinh);
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            HLVTheLuc HLV = this.listNhanVien.chonhLVTheLuc();
                            if (HLV != null)
                            {
                                HoatDong.HuanLuyenTLCaDoi(this.lCauThu.LDsCauThu, this.lNhanvien.LHLVTL[0]);
                                this.lCauThu.XemtinhTrangtheLuc();
                            }
                            break;
                        }
                    case 5:
                        {
                            HLVTheLuc HLV = this.listNhanVien.chonhLVTheLuc();
                            if (HLV != null)
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

                            }
                            break;
                        }
                    case 6:
                        {
                            if (this.lCauThu.LDsCauThu.Count < 11)
                            {
                                Console.WriteLine("Khong du cau thu de tham gia thi dau");
                                break;
                            }
                            if (this.listNhanVien.LHLVCT.Count == 0)
                            {
                                Console.WriteLine("Khong co HLV");
                                break;
                            }
                            HLVChienThuat hlv = this.listNhanVien.chonHLVCT();
                            HoatDong.DaGiaoLuu(this.listCauThu.LDsCauThu, hlv, san);
                            break;
                        }
                    case 7:
                        {
                            this.ThaoTacHopDong();
                            this.expired.Clear();
                            break;
                        }
                    case 8:
                        {
                            HoatDong.ChuyenNhuong(ref this.lCauThu, ref tmp);
                            break;
                        }
                    case 9:
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
