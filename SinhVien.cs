using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3P1Bai6
{
    class SinhVien
    {
        public string MaSV;
        public string HoTen;
        public int NamSinh;
        public float DiemLapTrinh;
        public float DiemCSDL;
        public float DiemTB;
        public SinhVien()
        {
            MaSV = "";
            HoTen = "";
            NamSinh = 1900;
            DiemLapTrinh = DiemCSDL = DiemTB = 0;
        }
        public SinhVien(string MaSV, string HoTen, int NamSinh, float DiemLapTrinh, float DiemCSDL)
        {
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLapTrinh = DiemLapTrinh;
            this.DiemCSDL = DiemCSDL;
            this.DiemTB = (DiemLapTrinh + DiemCSDL) / 2;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine();
            Console.WriteLine("Nhap ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh cua sinh vien: ");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap diem lap trinh: ");
            DiemLapTrinh = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem CSDL: ");
            DiemCSDL = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Thong tin cua sinh vien: \n Ma sinh vien: {0} \n Ten sinh vien: {1}" +
                "\n Nam sinh: {2} \n Diem lap trinh: {3} \t Diem CSDL: {4}" +
                "\t Diem TB: {5}", MaSV, HoTen, NamSinh, DiemLapTrinh, DiemCSDL, DiemTB);
        }
    }
}




