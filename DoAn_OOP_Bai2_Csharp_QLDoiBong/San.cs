using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    public class San
    {
        public List<NVBaoVe> lNVBaoVe;
        public List<NVVeSinh> lNVVeSinh;
        public int SoLuongKhanGia;
        public double GiaVe;

        public San()
        {
            this.lNVBaoVe = new List<NVBaoVe>();
            this.lNVVeSinh = new List<NVVeSinh>();
        }

        public San(List<NVBaoVe> ListBv, List<NVVeSinh> ListVs, int soluong, double giave)
        {
            this.lNVBaoVe = ListBv;
            this.lNVVeSinh = ListVs;
            this.SoLuongKhanGia = soluong;
            this.GiaVe = giave;
        }

        public virtual void Nhap()
        {
            Console.Write("Moi nhap so luong Nhan Vien Bao Ve trong San: ");
            int nvbv = int.Parse(Console.ReadLine());
            //int temp = 0;
            for (int i = 0; i < nvbv; i++)
            {
                NVBaoVe a = new NVBaoVe();
                a.Nhap();
                this.lNVBaoVe.Add(a);
            }

            Console.Write("Moi nhap so luong Nhan Vien Ve Sinh trong San: ");
            int nvvs = int.Parse(Console.ReadLine());
            for (int i = 0; i < nvvs; i++)
            {
                NVVeSinh a = new NVVeSinh();
                a.Nhap();
                this.lNVVeSinh.Add(a);
            }

            Console.Write("Moi nhap Gia ve vao san: ");
            this.GiaVe = double.Parse(Console.ReadLine());

            Console.Write("Moi nhap So Luong Khan Gia ma San chua duoc toi da: ");
            this.SoLuongKhanGia = int.Parse(Console.ReadLine());
        }

        public void Nhap(List<NVBaoVe> ListBv, List<NVVeSinh> ListVs, int Soluong, double giave)
        {
            this.lNVBaoVe = ListBv;
            this.lNVVeSinh = ListVs;
            this.SoLuongKhanGia = Soluong;
            this.GiaVe = giave;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Gia ve vao san la: " + this.GiaVe);
            Console.WriteLine("So luong Khan Gia khan dai co the chua duoc la: " + this.SoLuongKhanGia);
            Console.WriteLine("So luong Nhan Vien Ve Sinh la: " + this.lNVVeSinh.Count);
            for (int i = 0; i < this.lNVVeSinh.Count; i++)
            {
                this.lNVVeSinh[i].Xuat();
            }

            Console.WriteLine("So luong Nhan Vien Bao Ve la: " + this.lNVBaoVe.Count);
            for (int i = 0; i < this.lNVBaoVe.Count; i++)
            {
                this.lNVBaoVe[i].Xuat();
            }
        }
    }
}
