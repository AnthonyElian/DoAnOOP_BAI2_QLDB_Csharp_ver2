using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
   public interface IQuanLy<T>
    {
        void Nhap();
        void Sort();
        void Xuat();
        T Search();
        List<T> Loc();
    }
}
