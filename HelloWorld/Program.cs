using System;
using System.Collections;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 1; i <= 3; i++)
            {
                SanPham sanPham = new SanPham();
                Console.Write("Nhap ma san pham " + i + ": ");
                sanPham.MaSanPham = int.Parse(Console.ReadLine());
                Console.Write("Nhap ten san pham " + i + ": ");
                sanPham.TenSanPham = Console.ReadLine();
                Console.Write("Nhap don gia san pham " + i + ": ");
                sanPham.DonGia = double.Parse(Console.ReadLine());
                Console.Write("Nhap so luong san pham " + i + ": ");
                sanPham.SoLuong = int.Parse(Console.ReadLine());

                arrayList.Add(sanPham);
            }

            foreach (SanPham sp in arrayList)
            {
                sp.In();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

