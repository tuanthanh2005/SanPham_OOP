using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham_OOP
{
    class QuanLySanPham
    {
        private string ten;
        private SanPham[] dsSP;
        private int n;


        public QuanLySanPham()
        {
            dsSP = new SanPham[100];
            ten = "cua hang ban le ";
            n = 0;

        }
        public QuanLySanPham(int max)
        {
            dsSP = new SanPham[max];
            ten = "cua hang ban le ";
            n = 0;

        }

       
        public void Nhap()
        {
            int chon;
            SanPham sp;
            do
            {
                Console.WriteLine("Nhap Loai");
                Console.WriteLine("chon San Pham : {1.Socola}/{2.NuocUong}");

                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        sp = new Socola();
                        dsSP[n++] = sp;
                        sp.Nhap();
                        break;
                    case 2:
                        sp = new NuocUong();
                        dsSP[n++] = sp;
                        sp.Nhap();
                        break;
                }
            } while (chon != 0);

            }

        public void InChiTiet()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dsSP[i].InChiTiet());
            }
        }

    }
}





