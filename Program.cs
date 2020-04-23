using System;

namespace Chuong3P1Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSach httta = new DanhSach();
            httta.nhap();
            httta.xuat();
            httta.SapXep();
            httta.XuatDS();
            httta.LocDiem();
            Console.ReadLine();
        }
    }
}
