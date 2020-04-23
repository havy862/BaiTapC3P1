using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3P1Bai6
{
    class DanhSach
    {
        private int n;
        private SinhVien[] ds;
        public void nhap ()
        {
            Console.WriteLine("Nhap vao so sinh vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            ds = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao thong tin sinh vien thu {0}", i + 1);
                ds[i] = new SinhVien();
                ds[i].Nhap();
            }
        }
        public void xuat()
        {
            if (ds != null && n != 0)
            {
                Console.WriteLine("Danh sach sinh vien: ");
                for (int i = 0; i < n; i++)
                {
                    ds[i].Xuat();
                }
            }
        }
        public void SapXep()
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(ds[i].MaSV, ds[j].MaSV, true) > 0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tg;
                    }
                }
            }
        }
        public void XuatDS()
        {
            Console.WriteLine("Danh sach sau khi sap xep: ");
            for (int i=0; i<n; i++)
                ds[i].Xuat();
        }
        public void LocDiem()
        {
            for (int i = 0; 9 < n; i++)
            {
                if (ds[i].DiemTB >= 8)
                {
                    Console.WriteLine("Danh sach sinh vien co diem TB tren 8 la: ");
                    ds[i].Xuat();
                }
            }
        }
    }
}