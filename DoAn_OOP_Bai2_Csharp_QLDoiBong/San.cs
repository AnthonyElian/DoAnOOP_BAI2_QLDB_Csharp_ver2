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

        public string STenSan { get => sTenSan; set => sTenSan = value; }
        public double GiaVe { get => dGiaVe; set => dGiaVe = value; }
        public int SoLuongKhanGia { get => iSoLuongKhanGia; set => iSoLuongKhanGia = value; }

        public San()
        {
        }

        public San(int soluong, double giave)
        {
            this.SoLuongKhanGia = soluong;
            this.GiaVe = giave;
        }

        public virtual void Nhap()
        {
            Console.Write("Moi nhap Ten San ma Doi Bong so huu: ");
            this.sTenSan = Console.ReadLine();

            Console.Write("Moi nhap Gia ve vao san: ");
            this.GiaVe = double.Parse(Console.ReadLine());

            Console.Write("Moi nhap So Luong Khan Gia ma San chua duoc toi da: ");
            this.SoLuongKhanGia = int.Parse(Console.ReadLine());
        }

        public void Nhap(string tensan, int Soluong, double giave)
        {
            this.sTenSan = tensan;
            this.SoLuongKhanGia = Soluong;
            this.GiaVe = giave;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ten San Bong la: " + this.sTenSan);
            Console.WriteLine("San co suc chua: " + this.iSoLuongKhanGia + " Nguoi");
            Console.WriteLine("Gia ve vao san: " + this.dGiaVe + " VND");
        }
    }
}
