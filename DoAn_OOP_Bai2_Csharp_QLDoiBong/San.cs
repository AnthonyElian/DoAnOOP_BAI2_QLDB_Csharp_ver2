using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    public class San
    {
        private string sTenSan;
        private int iSoLuongKhanGia;
        private double dGiaVe;

        public San()
        {
        }

        public San(int soluong, double GiaVe)
        {
            this.iSoLuongKhanGia = soluong;
            this.dGiaVe = GiaVe;
        }

        public string STenSan { get => sTenSan; set => sTenSan = value; }
        public int ISoLuongKhanGia { get => iSoLuongKhanGia; set => iSoLuongKhanGia = value; }
        public double IGiaVe { get => dGiaVe; set => dGiaVe = value; }

        public void Nhap()
        {
            Console.Write("Moi nhap Ten San: ");
            this.sTenSan = Console.ReadLine();

            Console.Write("Moi nhap Gia ve vao san: ");
            this.dGiaVe = double.Parse(Console.ReadLine());

            Console.Write("Moi nhap So Luong Khan Gia ma San chua duoc toi da: ");
            this.iSoLuongKhanGia = int.Parse(Console.ReadLine());
        }

        public void Nhap(int Soluong, double iGiaVe)
        {
            this.iSoLuongKhanGia = Soluong;
            this.dGiaVe = iGiaVe;
        }

        public void Xuat()
        {
            Console.WriteLine("Ten San Van Dong cua Doi Bong la: " + this.sTenSan);
            Console.WriteLine("Gia ve vao san la: " + this.dGiaVe);
            Console.WriteLine("So luong Khan Gia khan dai co the chua duoc la: " + this.iSoLuongKhanGia);
        }
    }
}
