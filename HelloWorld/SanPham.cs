using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class SanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        public SanPham()
        {
            
        }

        public SanPham(int maSanPham, string tenSanPham, double donGia, int soLuong)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public double ThanhTien()
        {
            var thanhTien = this.DonGia * this.SoLuong;
            return thanhTien;
        }

        public void In()
        {
            Console.WriteLine("Ma San Pham: " + this.MaSanPham);
            Console.WriteLine("Ten San Pham: " + this.TenSanPham);
            Console.WriteLine("Don Gia: " + this.DonGia);
            Console.WriteLine("So Luong: " + this.SoLuong);
            Console.WriteLine("Thanh Tien: " + ThanhTien());
        }
    }
}
