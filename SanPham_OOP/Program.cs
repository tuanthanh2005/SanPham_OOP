﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLySanPham ql = new QuanLySanPham();
            ql.Nhap();
            ql.InChiTiet();
            Console.ReadLine();
        }
    }
}
