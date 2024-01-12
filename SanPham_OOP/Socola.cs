using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham_OOP
{
    class Socola :SanPham
    {
        private double loiNhuan;




        public Socola() { }
        public Socola(string ten, double giaMua) : base(ten, giaMua)
        {
            loiNhuan = GiaMua * 0.2;
        }
        public override double TinhGiaban()
        {
            return GiaMua + loiNhuan;
        }
        public override string InChiTiet()
        {
            return Ten + " " + TinhGiaban();
        }
        public override void Nhap()
        {
            base.Nhap();
            loiNhuan = GiaMua * 0.2;
        }


    }
}
