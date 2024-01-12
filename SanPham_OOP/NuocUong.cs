using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham_OOP
{
    class NuocUong:SanPham
    {
        private double loiNhuan;
        private double chiPhiLuuHanh;




        public NuocUong() { }
        public NuocUong(string ten, double giaMua) : base(ten, giaMua)
        {
            loiNhuan = giaMua * 0.15;
            chiPhiLuuHanh = giaMua * 0.1;
        }
        public override double TinhGiaban()
        {
            return GiaMua = loiNhuan + chiPhiLuuHanh;
        }
        public override string InChiTiet()
        {
            return Ten + " " + TinhGiaban();
        }
        public override void Nhap()
        {
            base.Nhap();
            loiNhuan = GiaMua * 0.15;
            chiPhiLuuHanh =GiaMua * 0.1;
        }
    }
}
