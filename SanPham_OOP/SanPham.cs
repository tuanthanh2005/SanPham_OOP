using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham_OOP
{
    class SanPham
    {
        private string _ten;
        private double _giaMua;




        public SanPham()
        {

        }
        public SanPham(string _ten, double _giaMua)
        {
            this._ten = _ten;
            this._giaMua = _giaMua;
        }
        public string Ten
        {
            set { _ten = value; }
            get { return _ten; }
        }
        public double GiaMua
        {
            set { _giaMua = value; }
            get { return _giaMua; }
        }
        public virtual double TinhGiaban()
        {
            return 0;
        }
        public virtual string InChiTiet()
        {
            return _ten + "-";
        }
        public virtual void Nhap()
        {
            Console.WriteLine("Nhap ten SP");
         _ten = Console.ReadLine();
            Console.WriteLine("nhap Gia Mua");
            _giaMua = double.Parse(Console.ReadLine());
        }

    }
}
