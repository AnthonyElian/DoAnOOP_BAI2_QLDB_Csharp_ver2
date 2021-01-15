using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class QuanLyCauThu : IQuanLy<CauThu>
    {
        private List<CauThu> lDsCauThu;
        public List<CauThu> LDsCauThu { get => lDsCauThu; set => lDsCauThu = value; }

        public QuanLyCauThu()
        {
            this.LDsCauThu = new List<CauThu>();
        }

        public QuanLyCauThu(List<CauThu> DsCauThu)
        {
            this.lDsCauThu = DsCauThu;
        }

        public void Nhap()
        {
            Console.Write("Moi nhap so luong cau thu trong doi bong: ");
            int cauthu = int.Parse(Console.ReadLine());
            for (int i = 0; i < cauthu; i++)
            {
                CauThu a = new CauThu();
                a.Nhap();
                this.lDsCauThu.Add(a);
            }
        }

        public void Xuat()
        {
            Console.WriteLine("So luong cau thu trong doi bong la: " + this.lDsCauThu.Count);
            foreach (var item in this.lDsCauThu)
            {
                item.Xuat();
            }
        }

        public void Sort()
        {
            Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
            Console.WriteLine("\t\t\t***              1. Ho ten                       ***\t\t\t");
            Console.WriteLine("\t\t\t***              2. Tuoi                         ***\t\t\t");
            Console.WriteLine("\t\t\t***              3. Ngay gia nhap                ***\t\t\t");
            Console.WriteLine("\t\t\t***              4. Thoi han hop dong con lai    ***\t\t\t");
            Console.WriteLine("\t\t\t***              5. So ao                        ***\t\t\t");
            Console.WriteLine("\t\t\t***              6. TT the luc                   ***\t\t\t");
            Console.WriteLine("\t\t\t***              7. TT Suc Khoe                  ***\t\t\t");
            Console.WriteLine("\t\t\t****************************************************\t\t\t");
            Console.Write("Moi nhap lua chon cua ban => Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    lDsCauThu.Sort((x, y) => x.sHoTen.CompareTo(y.sHoTen));
                    break;
                }
                case 2:
                {
                    lDsCauThu.Sort((x, y) => x.TinhTuoi().CompareTo(y.TinhTuoi()));
                    break;
                }
                case 3:
                {
                    lDsCauThu.Sort((x, y) => x.dNgayGiaNhap.CompareTo(y.dNgayGiaNhap));   
                    break;
                }
                case 4:
                {
                    lDsCauThu.Sort((x, y) => x.ThoiGianHopDongConLai().CompareTo(y.ThoiGianHopDongConLai()));
                    break;
                }
                case 5:
                {
                    lDsCauThu.Sort((x, y) => x.SoAo.CompareTo(y.SoAo));
                    break;
                }
                case 6:
                {
                    lDsCauThu.Sort((x, y) => x.TinhTrangTheLuc.CompareTo(y.TinhTrangTheLuc));
                    break;
                }
                case 7:
                {
                    lDsCauThu.Sort((x, y) => x.TinhTrangSucKhoe.CompareTo(y.TinhTrangSucKhoe));
                    break;
                }
                case 8:
                {
                    break;
                }
                default:
                {
                        Console.WriteLine("Nhap sai, moi nhap lai!!  ");
                        break;
                }
            }    

        }
        public List<CauThu> Loc()
        {
            List<CauThu> temp = new List<CauThu>();
            Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
            Console.WriteLine("\t\t\t***       1. Danh sach cau thu thuan chan trai   ***\t\t\t");
            Console.WriteLine("\t\t\t***       2. Danh sach cau thu thuan chan phai   ***\t\t\t");
            Console.WriteLine("\t\t\t***       3. Danh sach cau thu co the da tien dao***\t\t\t");
            Console.WriteLine("\t\t\t***       4. Danh sach cau thu co the da tien ve ***\t\t\t");
            Console.WriteLine("\t\t\t***       5. Danh sach cau thu co the da hau ve  ***\t\t\t");
            Console.WriteLine("\t\t\t***       6. Thoat                               ***\t\t\t");
            Console.WriteLine("\t\t\t****************************************************\t\t\t");
            Console.Write("Moi nhap lua chon cua ban => Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    foreach (var item in LDsCauThu)
                        if (item.ChanThuan == "trai")
                            temp.Add(item);
                    break;
                }
                case 2:
                {
                    foreach (var item in LDsCauThu)
                        if (item.ChanThuan == "phai")
                            temp.Add(item);
                    break;
                }
                case 3:
                {
                    foreach (var item in LDsCauThu)
                        if (item.ViTriDaChinh == "tiendao")
                            temp.Add(item);
                    break;
                }
                case 4:
                {
                    foreach (var item in LDsCauThu)
                        if (item.ViTriDaChinh == "tienve")
                            temp.Add(item);
                    break;
                }
                case 5:
                {
                    foreach (var item in LDsCauThu)
                        if (item.ViTriDaChinh == "hauve")
                                temp.Add(item);
                    break;
                }
                case 6:
                {
                    break;
                }
                default:
                {
                        Console.WriteLine("Nhap sai, moi nhap lai!!  ");
                    break;
                }             
            }
            return temp;
        }

        public bool ICompare<MuoiDiem>(CauThu a, string key)
        {
            return a.sHoTen.ToLower() == key.ToLower();
        }
        
        public CauThu Search()
        {
            Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
            Console.WriteLine("\t\t\t***            1. Ho ten                         ***\t\t\t");
            Console.WriteLine("\t\t\t***            2. So ao                          ***\t\t\t");
            Console.WriteLine("\t\t\t***            3. Thoat                          ***\t\t\t");
            Console.WriteLine("\t\t\t****************************************************\t\t\t");
            Console.Write("Moi nhap lua chon cua ban => Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            CauThu temp = null;
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Nhap ten cau thu tim kiem : ");
                        string key = Console.ReadLine();
                        for (int i = 0; i < this.lDsCauThu.Count; i++)
                        {
                            if (this.ICompare<bool>(this.lDsCauThu[i],key))
                            {
                                temp = this.lDsCauThu[i];
                                break;
                            }    
                        }
                        return temp;
                    }
                case 2:
                    {
                        Console.Write("Nhap so ao cau thu tim kiem : ");
                        string key = Console.ReadLine();
                        temp = this.lDsCauThu.Find(x => (x.SoAo == int.Parse(key)));
                        return temp;
                    }
                case 3:
                    {
                        return null;
                    }
                default:
                    {
                        Console.WriteLine("Nhap sai, moi nhap lai!! ");
                        return temp;
                    }
            }          
        }
        public void XemtinhTrangtheLuc()
        {
            foreach(var item in LDsCauThu)
            {
                Console.WriteLine("Cau thu " + item.sHoTen + " chi so TL la: " + item.TinhTrangTheLuc);
            }    
        }
        public void XemtinhTrangSucKhoe()
        {
            foreach (var item in this.lDsCauThu)
            {
                Console.WriteLine("Cau thu " + item.sHoTen + " chi so SK la: " + item.TinhTrangSucKhoe);
            }    
        }
        public CauThu CauThuCoTheLucTotNhat()
        {
            if (this.lDsCauThu.Count == 0)
                return null;
            else
            {
                CauThu temp = lDsCauThu[0];
                foreach (var item in LDsCauThu)
                {
                    if (item > temp)
                        temp = item;
                }
                return temp;
            }    
            
           
        }
        public CauThu CauThuCoTheSucKhoeYeuNhat()
        {
            if (this.lDsCauThu.Count == 0)
                return null;
            else
            {
                CauThu temp = lDsCauThu[0];
                foreach (var item in LDsCauThu)
                {
                    if (item < temp)
                        temp = item;
                }
                return temp;
            }
        }

        public double TongLuongToanCauThu()
        {
            double temp = 0;
            foreach (var item in this.lDsCauThu)
            {
                temp = item + temp;
            }
            return temp;
        }

        public void xoaCT()
        {
            Console.WriteLine("So luong cau thu hien tai la: " + this.lDsCauThu.Count());
            Console.Write("Ban muon xoa bao nhieu Cau thu: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Danh sach cau thu: ");
                foreach (var item in this.lDsCauThu)
                {
                    Console.WriteLine("Ten Cau Thu: " + item.sHoTen);
                }
                Console.Write("Nhap thu tu Cau thu muon xoa: ");
                int x = int.Parse(Console.ReadLine());
                this.xoa1CT(x);
            }
        }

        public void xoa1CT(int x)
        {
            this.lDsCauThu.RemoveAt(x);
        }
    }
}
